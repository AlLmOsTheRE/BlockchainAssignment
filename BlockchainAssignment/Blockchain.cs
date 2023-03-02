using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    internal class Blockchain
    {
        public List<Block> blocks = new List<Block>();
        public List<Transaction> transactions = new List<Transaction>();
        int transactionsPerBlock = 5;

        public Blockchain()
        {
            blocks.Add(new Block());
        }

        public string getBlockAsString(int index)
        {
            if (index >= 0 && index < blocks.Count)
                return blocks[index].ToString();
            else return "Block doesn't exist!";
        }

        public Block getLastBlock()
        {
            return blocks[blocks.Count - 1];
        }

        public List<Transaction> getPendingTransactions()
        {
            int n = Math.Min(transactionsPerBlock, transactions.Count);
            List<Transaction> pendingTransactions = transactions.GetRange(0, n);

            transactions.RemoveRange(0, n);

            return pendingTransactions;
        }

        public Transaction createTransaction(string from, string to, double amount, double fees, string priv)
        {
            Transaction newTransaction = new Transaction(from, to, amount, fees, priv);
            transactions.Add(newTransaction);

            return newTransaction;
        }

        public double getBalance(string address)
        {
            double balance = 0;

            foreach (Block b in blocks)
                foreach (Transaction t in b.transactions)
                {
                    if (t.recipientAddress == address)
                    {
                        balance += t.amount;
                    }
                    if (t.senderAddress == address)
                    {
                        balance -= t.amount + t.fees;
                    }
                }

            return balance;
        }

        public bool validateMerkleRoot(Block b)
        {
            string reMerkle = Block.getMerkleRoot(b.transactions);

            return reMerkle == b.merkleRoot;
        }

        public override string ToString()
        {
            string output = string.Empty;

            blocks.ForEach(b => output += b.ToString() + "\n");

            return output;
        }
    }
}
