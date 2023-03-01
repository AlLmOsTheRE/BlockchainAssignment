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

        public long nonce = 0;
        public int difficulty = 4;

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
            this.hash = Mine();
        }

        public Block(Block lastBlock, List<Transaction> transactions)
        {
            this.timestamp = DateTime.Now;
            this.prevHash = lastBlock.hash;
            this.index = lastBlock.index + 1;
            this.transactions = transactions;

            this.hash = Mine();
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
            string transactionsString = transactions.Aggregate(string.Empty, (a, b) => a.ToString() + "\n" + b.ToString());

            return "Index: " + index.ToString()
                    + "\nTimestamp: " + timestamp.ToString()
                    + "\nHash: " + hash.ToString()
                    + "\nPrevious Hash: " + prevHash.ToString()
                    + "\nNonce" + nonce.ToString()
                    + "\nTransactions:\n " + transactionsString
                    + "\n";
        }
    }

}
