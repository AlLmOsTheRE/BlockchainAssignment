using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace BlockchainAssignment
{
    internal class Block
    {
        static int ThreadCount = 4;
        public double miningTime;

        int index;
        DateTime timestamp;
        public string hashKey;
        static string[] hashes = new string[ThreadCount];
        public string hash = string.Empty;
        public string prevHash;

        public List<Transaction> transactions = new List<Transaction>();
        public string merkleRoot;

        // Proof of work
        static long[] nonces = new long[ThreadCount];
        public long nonce = 0;
        static public int difficulty = 4; // The difficulty's default value is 4 but may be overriden by the blockchain

        // Rewards and fees
        public double reward = 1.0; // fixed logic
        public double fees = 0.0;

        public string minerAddress = string.Empty;

        // Genesis Block
        public Block()
        {
            this.timestamp = DateTime.Now;
            this.index = 0;
            this.prevHash = string.Empty;
            this.hashKey = index.ToString() + timestamp.ToString() + prevHash + reward.ToString() + merkleRoot;
            Mine();
        }

        public Block(string prevHash, int index)
        {
            this.timestamp = DateTime.Now;
            this.index = index + 1;
            this.prevHash = prevHash;
            this.reward = 0;
            this.hashKey = index.ToString() + timestamp.ToString() + prevHash + reward.ToString() + merkleRoot;
            Mine();
        }

        public Block(Block lastBlock, List<Transaction> transactions, string address = "")
        {
            this.timestamp = DateTime.Now;
            this.prevHash = lastBlock.hash;
            this.index = lastBlock.index + 1;
            this.minerAddress = address;

            transactions.Add(CreateRewardTransaction(transactions));
            this.transactions = transactions;

            merkleRoot = getMerkleRoot(transactions);

            this.hashKey = index.ToString() + timestamp.ToString() + prevHash + reward.ToString() + merkleRoot;
            Mine();
        }

        public Transaction CreateRewardTransaction(List<Transaction> transactions)
        {
            this.fees = transactions.Aggregate(0.0, (acc, t) => acc + t.fees);

            // Create the reward transaction, it being the sum of the fees and the reward passed
            // from the coin base ("Mine rewards") to the miner
            return new Transaction("Mine Rewards", minerAddress, this.reward + this.fees, 0, "");
        }

        public static string CreateHash(string input)
        {
            SHA256 hasher = SHA256.Create();

            // Concatenate all the block's properties to hash
            //string input = index.ToString() + timestamp.ToString() + prevHash + nonce.ToString() + reward.ToString() + merkleRoot;
            byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Convert Hash from Byte array to String
            string hash = hashByte.Aggregate(string.Empty, (acc, x) => acc + string.Format("{0:x2}", x));

            return hash;
        }

        public void Mine()
        {
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = tokenSource.Token;
            List<Task> tasks = new List<Task>();

            // Starts timer to assess performance
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < ThreadCount; i++)
            {
                Task t = Task.Factory.StartNew((index) =>
                {
                    try
                    {
                        Hasher(hashKey, difficulty, (int)index, cancellationToken);
                    }
                    catch (OperationCanceledException)
                    {
                        Console.WriteLine("A task has been cancelled.");
                    }
                }, i, cancellationToken);
                tasks.Add(t);
            }

            // Gets winning thread and stops timer
            int winner = Task.WaitAny(tasks.ToArray());
            sw.Stop();
            miningTime = Math.Round(sw.Elapsed.TotalSeconds, 2);

            tokenSource.Cancel();

            hash = hashes[winner];
            nonce = nonces[winner];

            // reset the list of nonces
            nonces = new long[ThreadCount];
        }

        public static void Hasher(string hashKey, int difficulty, int index, CancellationToken cancellationToken)
        {
            string hash = CreateHash(hashKey + nonces[index].ToString());

            // Difficulty criteria definition
            string re = new string('0', difficulty); // creates a regex string of N (difficulty) number of 0s

            // Re-Hash until criteria is met
            while (hash == string.Empty || !hash.StartsWith(re))
            {
                if (cancellationToken.IsCancellationRequested)
                    cancellationToken.ThrowIfCancellationRequested();
                nonces[index]++;
                hash = CreateHash(hashKey + nonces[index].ToString());
            }

            hashes[index] = hash;
        }

        public static string getMerkleRoot(List<Transaction> transactions)
        {
            List<string> hashes = transactions.Select(t => t.hash).ToList();

            if (hashes.Count == 0)
                return string.Empty;

            else if (hashes.Count == 1)
                return HashCode.HashTools.CombineHash(hashes[0], hashes[0]);

            while (hashes.Count != 1)
            {
                List<string> merkleLeaves = new List<string>();

                for (int i = 0; i < hashes.Count; i += 2)
                {
                    if (i == hashes.Count - 1)
                        merkleLeaves.Add(HashCode.HashTools.CombineHash(hashes[i], hashes[i]));

                    else
                        merkleLeaves.Add(HashCode.HashTools.CombineHash(hashes[i], hashes[i + 1]));
                }

                hashes = merkleLeaves;
            }

            return hashes[0];
        }

        public override string ToString()
        {
            string transactionsString = transactions.Count == 0 ? string.Empty
                : transactions.Aggregate(string.Empty, (acc, t) => acc + t.ToString());

            return "Index: " + index.ToString() +
                "\nTime to mine: " + miningTime.ToString() + " seconds" +
                "\nTimestamp: " + timestamp.ToString() +
                "\nHash: " + hash.ToString() +
                "\nPrevious Hash: " + (prevHash == string.Empty ? "N/A" : prevHash.ToString()) +
                "\nNonce: " + nonce.ToString() +
                "\nDifficulty: " + difficulty.ToString() +
                "\nReward: " + reward.ToString() +
                "\nFees: " + fees.ToString() +
                "\nMiner's address: " + (minerAddress == string.Empty ? "N/A" : minerAddress.ToString()) +
                "\nTransactions: " + transactions.Count +
                "\n" + transactionsString +
                "------------------------------------------------------------------------------------------------------------" +
                "------------------------------------------------------------------------------------------------------------\n";
        }
    }

}
