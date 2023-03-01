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

        public override string ToString()
        {
            string output = string.Empty;

            blocks.ForEach(b => output += b.ToString() + "\n");

            return output;
        }
    }
}
