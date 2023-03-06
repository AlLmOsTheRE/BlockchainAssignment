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
        int difficulty = 2;

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
            try
            {
                if (ReceiverKey.Text == string.Empty)
                {
                    MainInterface.Text = "Unable to create transaction: Missing Receiver Key";
                    return;
                }

                if (!Wallet.Wallet.ValidatePrivateKey(PrivateKey.Text, PublicKey.Text))
                {
                    MainInterface.Text = "Unable to create transaction: Invalid/Missing Wallet";
                    return;
                }

                double transactionCost = (double.Parse(Amount.Text) + double.Parse(Fees.Text));
                double totalPendingTransactionsCost = blockchain.transactions.Aggregate(0.0, (acc, t) => acc + t.amount + t.fees);
                double walletBalance = blockchain.getBalance(PublicKey.Text);

                if ((transactionCost + totalPendingTransactionsCost) > walletBalance)
                {
                    MainInterface.Text = $"Unable to create transaction: Insufficient funds (Missing {(transactionCost + totalPendingTransactionsCost) - walletBalance} {assignmentCoin})";
                }
                else
                {
                    Transaction transaction = blockchain.createTransaction(PublicKey.Text, ReceiverKey.Text, double.Parse(Amount.Text), double.Parse(Fees.Text), PrivateKey.Text);
                    MainInterface.Text = transaction.ToString();
                }
            }
            catch (Exception)
            {
                MainInterface.Text = "Can't create transaction: Invalid/Missing values";
            }
        }

        private void createBlock(string strategy, string recipientAddress = "")
        {
            List<Transaction> transactions = blockchain.getPendingTransactions(strategy, recipientAddress);
            // Assign the blockchain's difficulty to the block
            Block.difficulty = difficulty;
            Block newBlock = new Block(blockchain.getLastBlock(), transactions, PublicKey.Text);
            blockchain.blocks.Add(newBlock);

            int n = 5; // After how many blocks should the difficulty be updated

            // Every N blocks - not counting the Genesis block
            if ((blockchain.blocks.Count - 1) % n == 0)
            {
                // Checks the average mining time of the last N blocks
                double timeTaken = blockchain.blocks
                    .Skip(Math.Max(0, blockchain.blocks.Count - n))
                    .Aggregate(0.0, (acc, b) => acc + b.miningTime) / n;
                // calculates the ratio between the expected and the actual times taken
                double expectedVsActual = ((n * 2) / timeTaken); // the expected time is N x 2 seconds

                // if the actual time is considerably lower than the expected one, raise the difficulty
                if (expectedVsActual > 1.25)
                    difficulty++;
                else if (expectedVsActual < .75)
                    difficulty--;
            }

            MainInterface.Text = blockchain.getLastBlock().ToString();
        }

        private void CreateBlockGreedy_Click(object sender, EventArgs e)
        {
            createBlock("Greedy");
        }

        private void CreateBlockAltruistic_Click(object sender, EventArgs e)
        {
            createBlock("Altruistic");
        }

        private void CreateBlockRandom_Click(object sender, EventArgs e)
        {
            createBlock("Random");
        }

        private void CreateBlockPreference_Click(object sender, EventArgs e)
        {
            if (AddressPreference.Text == string.Empty)
            {
                MainInterface.Text = "Unable to create Block with preferred Recipient Address: Missing value";
                return;
            }
            createBlock("Preference", AddressPreference.Text);
        }

        private void ReadAllBlocks_Click(object sender, EventArgs e)
        {
            MainInterface.Text = blockchain.ToString();
        }

        private void PrintPending_Click(object sender, EventArgs e)
        {
            string pendingString = blockchain.transactions.Count == 0 ? "No pending transactions"
                : blockchain.transactions.Aggregate("Pending transactions:\n", (acc, t) => acc + t.ToString());

            MainInterface.Text = pendingString;
        }

        private void ValidateChain_Click(object sender, EventArgs e)
        {
            // Contiguity checks
            bool isValid = true;

            if (blockchain.blocks.Count == 1)
                isValid = blockchain.validateHash(blockchain.blocks[0]);

            else
                for (int i = 1; i < blockchain.blocks.Count; i++)
                    // Compare neighbouring hashes for all the blocks in the blockchain and
                    // validate transactions via merkle root
                    if (
                        blockchain.blocks[i].prevHash != blockchain.blocks[i - 1].hash ||
                        !blockchain.validateHash(blockchain.blocks[i]) ||
                        !blockchain.validateMerkleRoot(blockchain.blocks[i])
                    )
                    {
                        isValid = false;
                        break;
                    }

            MainInterface.Text = "Blockchain is " + (isValid ? "valid" : "invalid");
        }

        private void CheckBalance_Click(object sender, EventArgs e)
        {
            MainInterface.Text = PublicKey.Text == string.Empty ? "No Wallet ID has been provided" :
                "Balance: " + blockchain.getBalance(PublicKey.Text).ToString() + " " + assignmentCoin;
        }

        private void CreateInvalidBlock_Click(object sender, EventArgs e)
        {
            List<Transaction> transactions = blockchain.getPendingTransactions("Altruistic");
            Block lastBlock = blockchain.getLastBlock();
            Block invalidBlock = new Block(lastBlock, transactions, PublicKey.Text);
            invalidBlock.prevHash = "InvalidHash_123";
            blockchain.blocks.Add(invalidBlock);

            MainInterface.Text = blockchain.getLastBlock().ToString();
        }

        private void InvalidateTransaction_Click(object sender, EventArgs e)
        {
            Block lastBlock = blockchain.getLastBlock();

            if (lastBlock.transactions.Count > 0)
            {
                Transaction lastTransaction = lastBlock.transactions[lastBlock.transactions.Count - 1];
                lastTransaction.hash = lastTransaction.CreateHash();

                MainInterface.Text = lastTransaction.ToString();
            }
            else
                MainInterface.Text = "No transactions to tinker with!";

        }

        private void ResetBlockchain_Click(object sender, EventArgs e)
        {
            BlockID.Text = string.Empty;
            PublicKey.Text = string.Empty;
            PrivateKey.Text = string.Empty;
            Amount.Text = string.Empty;
            Fees.Text = string.Empty;
            ReceiverKey.Text = string.Empty;
            AddressPreference.Text = string.Empty;
            difficulty = 2;
            Block.difficulty = 2;
            blockchain = new Blockchain();
            MainInterface.Text = "<New blockchain initialised>";
        }

        private void InvalidateBlock_Click(object sender, EventArgs e)
        {
            Block lastBlock = blockchain.getLastBlock();
            lastBlock.nonce = 0;
        }
    }
}
