using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BlockchainAssignment
{
    internal class Block
    {
        int index;
        DateTime timestamp;
        string hash;
        string prevHash;

        List<Transaction> transactions = new List<Transaction>();

        // Proof of work
        public long nonce = 0;
        public int difficulty = 4;

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
            this.hash = Mine();
        }

        public Block(string prevHash, int index)
        {
            this.timestamp = DateTime.Now;
            this.index = index + 1;
            this.prevHash = prevHash;
            this.reward = 0;
            this.hash = Mine();
        }

        public Block(Block lastBlock, List<Transaction> transactions, string address = "")
        {
            this.timestamp = DateTime.Now;
            this.prevHash = lastBlock.hash;
            this.index = lastBlock.index + 1;
            this.minerAddress = address;

            transactions.Add(CreateRewardTransaction(transactions));
            this.transactions = transactions;

            this.hash = Mine();
        }

        public Transaction CreateRewardTransaction(List<Transaction> transactions)
        {
            this.fees = transactions.Aggregate(0.0, (acc, t) => acc + t.fees);

            // Create the reward transaction, it being the sum of the fees and the reward passed
            // from the coin base ("Mine rewards") to the miner
            return new Transaction("Mine rewards", minerAddress, this.reward + this.fees, 0, "");
        }

        public string CreateHash()
        {
            string hash = string.Empty;
            SHA256 hasher = SHA256.Create();

            // Concatenate all the block's properties to hash
            string input = index.ToString() + timestamp.ToString() + prevHash + nonce.ToString();
            byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Convert Hash from Byte array to String
            foreach (byte x in hashByte)
            {
                hash += string.Format("{0:x2}", x);
            }

            return hash;
        }

        public string Mine()
        {
            string hash = CreateHash();

            // Difficulty criteria definition
            string re = new string('0', difficulty); // creates a regex string of N (difficulty) number of 0s

            // Re-Hash until criteria is met
            while (!hash.StartsWith(re))
            {
                nonce++;
                hash = CreateHash();
            }

            return hash;
        }

        public override string ToString()
        {
            string transactionsString = transactions.Count == 0 ? " N/A\n"
                : transactions.Aggregate("\n", (acc, t) => acc + t.ToString());

            return "Index: " + index.ToString() +
                "\nTimestamp: " + timestamp.ToString() +
                "\nHash: " + hash.ToString() +
                "\nPrevious Hash: " + prevHash.ToString() +
                "\nNonce: " + nonce.ToString() +
                "\nDifficulty: " + difficulty.ToString() +
                "\nReward: " + reward.ToString() +
                "\nFees: " + fees.ToString() +
                "\nMiner's address: " + minerAddress.ToString() +
                "\nTransactions:" + transactionsString +
                "------------------------------------------------------------------------------------------------" +
                "------------------------------------------------------------------------------------------------\n";
        }
    }

}
