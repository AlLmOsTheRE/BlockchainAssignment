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
            Transaction transaction = new Transaction(PublicKey.Text, ReceiverKey.Text, double.Parse(Amount.Text), double.Parse(Fee.Text), PrivateKey.Text);
            blockchain.transactions.Add(transaction);
            MainInterface.Text = transaction.ToString();
        }

        private void CreateBlock_Click(object sender, EventArgs e)
        {
            List<Transaction> transactions = blockchain.getPendingTransactions();
            Block newBlock = new Block(blockchain.getLastBlock(), transactions);
            blockchain.blocks.Add(newBlock);

            MainInterface.Text = blockchain.ToString();
        }
    }
}
