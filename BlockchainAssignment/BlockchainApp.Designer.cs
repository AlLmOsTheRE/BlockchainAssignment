namespace BlockchainAssignment
{
    partial class BlockchainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainInterface = new System.Windows.Forms.RichTextBox();
            this.PrintBlock = new System.Windows.Forms.Button();
            this.BlockID = new System.Windows.Forms.TextBox();
            this.CreateWallet = new System.Windows.Forms.Button();
            this.PublicKey = new System.Windows.Forms.TextBox();
            this.PrivateKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ValidateKeys = new System.Windows.Forms.Button();
            this.CreateTransaction = new System.Windows.Forms.Button();
            this.CreateBlockGreedy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.TextBox();
            this.Fees = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ReceiverKey = new System.Windows.Forms.TextBox();
            this.ReadAllBlocks = new System.Windows.Forms.Button();
            this.PrintPending = new System.Windows.Forms.Button();
            this.ValidateChain = new System.Windows.Forms.Button();
            this.CheckBalance = new System.Windows.Forms.Button();
            this.CreateInvalidBlock = new System.Windows.Forms.Button();
            this.InvalidateTransaction = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ResetBlockchain = new System.Windows.Forms.Button();
            this.InvalidateBlock = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.CreateBlockRandom = new System.Windows.Forms.Button();
            this.CreateBlockAltruistic = new System.Windows.Forms.Button();
            this.CreateBlockPreference = new System.Windows.Forms.Button();
            this.AddressPreference = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MainInterface
            // 
            this.MainInterface.BackColor = System.Drawing.SystemColors.InfoText;
            this.MainInterface.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainInterface.Location = new System.Drawing.Point(12, 12);
            this.MainInterface.Name = "MainInterface";
            this.MainInterface.Size = new System.Drawing.Size(706, 314);
            this.MainInterface.TabIndex = 0;
            this.MainInterface.Text = "";
            this.MainInterface.TextChanged += new System.EventHandler(this.MainInterface_TextChanged);
            // 
            // PrintBlock
            // 
            this.PrintBlock.Location = new System.Drawing.Point(12, 332);
            this.PrintBlock.Name = "PrintBlock";
            this.PrintBlock.Size = new System.Drawing.Size(78, 21);
            this.PrintBlock.TabIndex = 1;
            this.PrintBlock.Text = "Print Block";
            this.PrintBlock.UseVisualStyleBackColor = true;
            this.PrintBlock.Click += new System.EventHandler(this.PrintBlock_Click);
            // 
            // BlockID
            // 
            this.BlockID.Location = new System.Drawing.Point(96, 333);
            this.BlockID.Name = "BlockID";
            this.BlockID.Size = new System.Drawing.Size(27, 20);
            this.BlockID.TabIndex = 2;
            // 
            // CreateWallet
            // 
            this.CreateWallet.Location = new System.Drawing.Point(620, 331);
            this.CreateWallet.Name = "CreateWallet";
            this.CreateWallet.Size = new System.Drawing.Size(98, 47);
            this.CreateWallet.TabIndex = 3;
            this.CreateWallet.Text = "Generate Wallet";
            this.CreateWallet.UseVisualStyleBackColor = true;
            this.CreateWallet.Click += new System.EventHandler(this.CreateWallet_Click);
            // 
            // PublicKey
            // 
            this.PublicKey.Location = new System.Drawing.Point(291, 332);
            this.PublicKey.Name = "PublicKey";
            this.PublicKey.Size = new System.Drawing.Size(323, 20);
            this.PublicKey.TabIndex = 4;
            // 
            // PrivateKey
            // 
            this.PrivateKey.Location = new System.Drawing.Point(291, 358);
            this.PrivateKey.Name = "PrivateKey";
            this.PrivateKey.Size = new System.Drawing.Size(323, 20);
            this.PrivateKey.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Public Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Private Key";
            // 
            // ValidateKeys
            // 
            this.ValidateKeys.Location = new System.Drawing.Point(727, 404);
            this.ValidateKeys.Name = "ValidateKeys";
            this.ValidateKeys.Size = new System.Drawing.Size(97, 46);
            this.ValidateKeys.TabIndex = 8;
            this.ValidateKeys.Text = "Validate Keys";
            this.ValidateKeys.UseVisualStyleBackColor = true;
            this.ValidateKeys.Click += new System.EventHandler(this.ValidateKeys_Click);
            // 
            // CreateTransaction
            // 
            this.CreateTransaction.Location = new System.Drawing.Point(113, 453);
            this.CreateTransaction.Name = "CreateTransaction";
            this.CreateTransaction.Size = new System.Drawing.Size(94, 48);
            this.CreateTransaction.TabIndex = 9;
            this.CreateTransaction.Text = "Create Transaction";
            this.CreateTransaction.UseVisualStyleBackColor = true;
            this.CreateTransaction.Click += new System.EventHandler(this.CreateTransaction_Click);
            // 
            // CreateBlockGreedy
            // 
            this.CreateBlockGreedy.Location = new System.Drawing.Point(12, 400);
            this.CreateBlockGreedy.Name = "CreateBlockGreedy";
            this.CreateBlockGreedy.Size = new System.Drawing.Size(78, 36);
            this.CreateBlockGreedy.TabIndex = 10;
            this.CreateBlockGreedy.Text = "Greedy";
            this.CreateBlockGreedy.UseVisualStyleBackColor = true;
            this.CreateBlockGreedy.Click += new System.EventHandler(this.CreateBlockGreedy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fees";
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(274, 454);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(44, 20);
            this.Amount.TabIndex = 13;
            // 
            // Fees
            // 
            this.Fees.Location = new System.Drawing.Point(274, 480);
            this.Fees.Name = "Fees";
            this.Fees.Size = new System.Drawing.Size(44, 20);
            this.Fees.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Receiver Key";
            // 
            // ReceiverKey
            // 
            this.ReceiverKey.Location = new System.Drawing.Point(410, 480);
            this.ReceiverKey.Name = "ReceiverKey";
            this.ReceiverKey.Size = new System.Drawing.Size(308, 20);
            this.ReceiverKey.TabIndex = 16;
            // 
            // ReadAllBlocks
            // 
            this.ReadAllBlocks.Location = new System.Drawing.Point(129, 332);
            this.ReadAllBlocks.Name = "ReadAllBlocks";
            this.ReadAllBlocks.Size = new System.Drawing.Size(78, 21);
            this.ReadAllBlocks.TabIndex = 17;
            this.ReadAllBlocks.Text = "Read All";
            this.ReadAllBlocks.UseVisualStyleBackColor = true;
            this.ReadAllBlocks.Click += new System.EventHandler(this.ReadAllBlocks_Click);
            // 
            // PrintPending
            // 
            this.PrintPending.Location = new System.Drawing.Point(12, 454);
            this.PrintPending.Name = "PrintPending";
            this.PrintPending.Size = new System.Drawing.Size(95, 47);
            this.PrintPending.TabIndex = 18;
            this.PrintPending.Text = "Print Pending Transactions";
            this.PrintPending.UseVisualStyleBackColor = true;
            this.PrintPending.Click += new System.EventHandler(this.PrintPending_Click);
            // 
            // ValidateChain
            // 
            this.ValidateChain.Location = new System.Drawing.Point(727, 456);
            this.ValidateChain.Name = "ValidateChain";
            this.ValidateChain.Size = new System.Drawing.Size(97, 46);
            this.ValidateChain.TabIndex = 19;
            this.ValidateChain.Text = "Validate Chain";
            this.ValidateChain.UseVisualStyleBackColor = true;
            this.ValidateChain.Click += new System.EventHandler(this.ValidateChain_Click);
            // 
            // CheckBalance
            // 
            this.CheckBalance.Location = new System.Drawing.Point(620, 384);
            this.CheckBalance.Name = "CheckBalance";
            this.CheckBalance.Size = new System.Drawing.Size(98, 21);
            this.CheckBalance.TabIndex = 20;
            this.CheckBalance.Text = "Check Balance";
            this.CheckBalance.UseVisualStyleBackColor = true;
            this.CheckBalance.Click += new System.EventHandler(this.CheckBalance_Click);
            // 
            // CreateInvalidBlock
            // 
            this.CreateInvalidBlock.Location = new System.Drawing.Point(724, 140);
            this.CreateInvalidBlock.Name = "CreateInvalidBlock";
            this.CreateInvalidBlock.Size = new System.Drawing.Size(97, 46);
            this.CreateInvalidBlock.TabIndex = 21;
            this.CreateInvalidBlock.Text = "Generate Invalid Block";
            this.CreateInvalidBlock.UseVisualStyleBackColor = true;
            this.CreateInvalidBlock.Click += new System.EventHandler(this.CreateInvalidBlock_Click);
            // 
            // InvalidateTransaction
            // 
            this.InvalidateTransaction.Location = new System.Drawing.Point(724, 89);
            this.InvalidateTransaction.Name = "InvalidateTransaction";
            this.InvalidateTransaction.Size = new System.Drawing.Size(97, 45);
            this.InvalidateTransaction.TabIndex = 22;
            this.InvalidateTransaction.Text = "Invalidate Last Transaction";
            this.InvalidateTransaction.UseVisualStyleBackColor = true;
            this.InvalidateTransaction.Click += new System.EventHandler(this.InvalidateTransaction_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(724, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Validation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(721, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Testing / Debugging";
            // 
            // ResetBlockchain
            // 
            this.ResetBlockchain.Location = new System.Drawing.Point(724, 192);
            this.ResetBlockchain.Name = "ResetBlockchain";
            this.ResetBlockchain.Size = new System.Drawing.Size(97, 46);
            this.ResetBlockchain.TabIndex = 25;
            this.ResetBlockchain.Text = "Reset Blockchain";
            this.ResetBlockchain.UseVisualStyleBackColor = true;
            this.ResetBlockchain.Click += new System.EventHandler(this.ResetBlockchain_Click);
            // 
            // InvalidateBlock
            // 
            this.InvalidateBlock.Location = new System.Drawing.Point(724, 38);
            this.InvalidateBlock.Name = "InvalidateBlock";
            this.InvalidateBlock.Size = new System.Drawing.Size(97, 45);
            this.InvalidateBlock.TabIndex = 26;
            this.InvalidateBlock.Text = "Invalidate Last Block";
            this.InvalidateBlock.UseVisualStyleBackColor = true;
            this.InvalidateBlock.Click += new System.EventHandler(this.InvalidateBlock_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Generate New Block";
            // 
            // CreateBlockRandom
            // 
            this.CreateBlockRandom.Location = new System.Drawing.Point(179, 400);
            this.CreateBlockRandom.Name = "CreateBlockRandom";
            this.CreateBlockRandom.Size = new System.Drawing.Size(78, 36);
            this.CreateBlockRandom.TabIndex = 28;
            this.CreateBlockRandom.Text = "Random";
            this.CreateBlockRandom.UseVisualStyleBackColor = true;
            this.CreateBlockRandom.Click += new System.EventHandler(this.CreateBlockRandom_Click);
            // 
            // CreateBlockAltruistic
            // 
            this.CreateBlockAltruistic.Location = new System.Drawing.Point(96, 400);
            this.CreateBlockAltruistic.Name = "CreateBlockAltruistic";
            this.CreateBlockAltruistic.Size = new System.Drawing.Size(77, 36);
            this.CreateBlockAltruistic.TabIndex = 29;
            this.CreateBlockAltruistic.Text = "Altruistic";
            this.CreateBlockAltruistic.UseVisualStyleBackColor = true;
            this.CreateBlockAltruistic.Click += new System.EventHandler(this.CreateBlockAltruistic_Click);
            // 
            // CreateBlockPreference
            // 
            this.CreateBlockPreference.Location = new System.Drawing.Point(275, 401);
            this.CreateBlockPreference.Name = "CreateBlockPreference";
            this.CreateBlockPreference.Size = new System.Drawing.Size(77, 36);
            this.CreateBlockPreference.TabIndex = 30;
            this.CreateBlockPreference.Text = "Address preference";
            this.CreateBlockPreference.UseVisualStyleBackColor = true;
            this.CreateBlockPreference.Click += new System.EventHandler(this.CreateBlockPreference_Click);
            // 
            // AddressPreference
            // 
            this.AddressPreference.Location = new System.Drawing.Point(358, 417);
            this.AddressPreference.Name = "AddressPreference";
            this.AddressPreference.Size = new System.Drawing.Size(360, 20);
            this.AddressPreference.TabIndex = 31;
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(830, 513);
            this.Controls.Add(this.AddressPreference);
            this.Controls.Add(this.CreateBlockPreference);
            this.Controls.Add(this.CreateBlockAltruistic);
            this.Controls.Add(this.CreateBlockRandom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.InvalidateBlock);
            this.Controls.Add(this.ResetBlockchain);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.InvalidateTransaction);
            this.Controls.Add(this.CreateInvalidBlock);
            this.Controls.Add(this.CheckBalance);
            this.Controls.Add(this.ValidateChain);
            this.Controls.Add(this.PrintPending);
            this.Controls.Add(this.ReadAllBlocks);
            this.Controls.Add(this.ReceiverKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Fees);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CreateBlockGreedy);
            this.Controls.Add(this.CreateTransaction);
            this.Controls.Add(this.ValidateKeys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrivateKey);
            this.Controls.Add(this.PublicKey);
            this.Controls.Add(this.CreateWallet);
            this.Controls.Add(this.BlockID);
            this.Controls.Add(this.PrintBlock);
            this.Controls.Add(this.MainInterface);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "BlockchainApp";
            this.Text = "Blockchain App - ඞ // 29016289";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MainInterface;
        private System.Windows.Forms.Button PrintBlock;
        private System.Windows.Forms.TextBox BlockID;
        private System.Windows.Forms.Button CreateWallet;
        private System.Windows.Forms.TextBox PublicKey;
        private System.Windows.Forms.TextBox PrivateKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ValidateKeys;
        private System.Windows.Forms.Button CreateTransaction;
        private System.Windows.Forms.Button CreateBlockGreedy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.TextBox Fees;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ReceiverKey;
        private System.Windows.Forms.Button ReadAllBlocks;
        private System.Windows.Forms.Button PrintPending;
        private System.Windows.Forms.Button ValidateChain;
        private System.Windows.Forms.Button CheckBalance;
        private System.Windows.Forms.Button CreateInvalidBlock;
        private System.Windows.Forms.Button InvalidateTransaction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ResetBlockchain;
        private System.Windows.Forms.Button InvalidateBlock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CreateBlockRandom;
        private System.Windows.Forms.Button CreateBlockAltruistic;
        private System.Windows.Forms.Button CreateBlockPreference;
        private System.Windows.Forms.TextBox AddressPreference;
    }
}

