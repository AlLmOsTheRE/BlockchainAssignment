using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockchainAssignment
{
    public partial class BlockchainApp : Form
    {
        static public char assignmentCoin = 'ඞ';
        Blockchain blockchain;

        public BlockchainApp()
        {
            InitializeComponent();
            blockchain = new Blockchain();
            MainInterface.Text = "New blockchain initialised!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void PrintBlock_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(BlockID.Text, out int index))
            {
                MainInterface.Text = blockchain.getBlockAsString(index);
            }
        }

        private void MainInterface_TextChanged(object sender, EventArgs e)
        {
        }

        private void CreateWallet_Click(object sender, EventArgs e)
        {
            string privKey;
            Wallet.Wallet newWallet = new Wallet.Wallet(out privKey);

            PublicKey.Text = newWallet.publicID;
            PrivateKey.Text = privKey;
        }

        private void ValidateKeys_Click(object sender, EventArgs e)
        {
            string isValidString = Wallet.Wallet.ValidatePrivateKey(PrivateKey.Text, PublicKey.Text) ? "valid" : "invalid";

            MainInterface.Text = "Keys are " + isValidString;
        }

        private void CreateTransaction_Click(object sender, EventArgs e)
        {
            Transaction transaction = blockchain.createTransaction(PublicKey.Text, ReceiverKey.Text, double.Parse(Amount.Text), double.Parse(Fees.Text), PrivateKey.Text);

            MainInterface.Text = transaction.ToString();
        }

        private void CreateBlock_Click(object sender, EventArgs e)
        {
            List<Transaction> transactions = blockchain.getPendingTransactions();
            Block newBlock = new Block(blockchain.getLastBlock(), transactions, PublicKey.Text);
            blockchain.blocks.Add(newBlock);

            MainInterface.Text = blockchain.getLastBlock().ToString();
        }

        private void ReadAllBlocks_Click(object sender, EventArgs e)
        {
            MainInterface.Text = blockchain.ToString();
        }

        private void PrintPending_Click(object sender, EventArgs e)
        {
            string pendingString = blockchain.transactions.Count == 0 ? "No pending transactions!"
                : blockchain.transactions.Aggregate("Pending transactions:\n", (acc, t) => acc + t.ToString());

            MainInterface.Text = pendingString;
        }

        private void ValidateChain_Click(object sender, EventArgs e)
        {
            // Contiguity checks
            bool isValid = true;

            if (blockchain.blocks.Count == 1)
                isValid = !blockchain.validateMerkleRoot(blockchain.blocks[0]);

            else
                for (int i = 1; i < blockchain.blocks.Count - 1; i++)
                    // Compare neighbouring hashes for all the blocks in the blockchain and
                    // validate transactions via merkle root
                    if (blockchain.blocks[i].prevHash != blockchain.blocks[i - 1].hash
                        || !blockchain.validateMerkleRoot(blockchain.blocks[i]))
                    {
                        isValid = false;
                        break;
                    }

            MainInterface.Text = "Blockchain is " + (isValid ? "valid" : "invalid");
        }

        private void CheckBalance_Click(object sender, EventArgs e)
        {
            MainInterface.Text = "Balance: " + blockchain.getBalance(PublicKey.Text).ToString() + " " + assignmentCoin;
        }
    }
}
