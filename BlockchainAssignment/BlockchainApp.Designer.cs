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
            this.CreateBlock = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // MainInterface
            // 
            this.MainInterface.BackColor = System.Drawing.SystemColors.InfoText;
            this.MainInterface.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainInterface.Location = new System.Drawing.Point(12, 12);
            this.MainInterface.Name = "MainInterface";
            this.MainInterface.Size = new System.Drawing.Size(673, 314);
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
            this.BlockID.Size = new System.Drawing.Size(34, 20);
            this.BlockID.TabIndex = 2;
            // 
            // CreateWallet
            // 
            this.CreateWallet.Location = new System.Drawing.Point(587, 331);
            this.CreateWallet.Name = "CreateWallet";
            this.CreateWallet.Size = new System.Drawing.Size(98, 47);
            this.CreateWallet.TabIndex = 3;
            this.CreateWallet.Text = "Generate Wallet";
            this.CreateWallet.UseVisualStyleBackColor = true;
            this.CreateWallet.Click += new System.EventHandler(this.CreateWallet_Click);
            // 
            // PublicKey
            // 
            this.PublicKey.Location = new System.Drawing.Point(310, 332);
            this.PublicKey.Name = "PublicKey";
            this.PublicKey.Size = new System.Drawing.Size(271, 20);
            this.PublicKey.TabIndex = 4;
            // 
            // PrivateKey
            // 
            this.PrivateKey.Location = new System.Drawing.Point(310, 358);
            this.PrivateKey.Name = "PrivateKey";
            this.PrivateKey.Size = new System.Drawing.Size(271, 20);
            this.PrivateKey.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Public Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Private Key";
            // 
            // ValidateKeys
            // 
            this.ValidateKeys.Location = new System.Drawing.Point(587, 384);
            this.ValidateKeys.Name = "ValidateKeys";
            this.ValidateKeys.Size = new System.Drawing.Size(98, 21);
            this.ValidateKeys.TabIndex = 8;
            this.ValidateKeys.Text = "Validate Keys";
            this.ValidateKeys.UseVisualStyleBackColor = true;
            this.ValidateKeys.Click += new System.EventHandler(this.ValidateKeys_Click);
            // 
            // CreateTransaction
            // 
            this.CreateTransaction.Location = new System.Drawing.Point(12, 423);
            this.CreateTransaction.Name = "CreateTransaction";
            this.CreateTransaction.Size = new System.Drawing.Size(98, 46);
            this.CreateTransaction.TabIndex = 9;
            this.CreateTransaction.Text = "Create Transaction";
            this.CreateTransaction.UseVisualStyleBackColor = true;
            this.CreateTransaction.Click += new System.EventHandler(this.CreateTransaction_Click);
            // 
            // CreateBlock
            // 
            this.CreateBlock.Location = new System.Drawing.Point(12, 371);
            this.CreateBlock.Name = "CreateBlock";
            this.CreateBlock.Size = new System.Drawing.Size(97, 46);
            this.CreateBlock.TabIndex = 10;
            this.CreateBlock.Text = "Generate New Block";
            this.CreateBlock.UseVisualStyleBackColor = true;
            this.CreateBlock.Click += new System.EventHandler(this.CreateBlock_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fees";
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(166, 423);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(48, 20);
            this.Amount.TabIndex = 13;
            // 
            // Fees
            // 
            this.Fees.Location = new System.Drawing.Point(166, 449);
            this.Fees.Name = "Fees";
            this.Fees.Size = new System.Drawing.Size(48, 20);
            this.Fees.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Receiver Key";
            // 
            // ReceiverKey
            // 
            this.ReceiverKey.Location = new System.Drawing.Point(310, 449);
            this.ReceiverKey.Name = "ReceiverKey";
            this.ReceiverKey.Size = new System.Drawing.Size(375, 20);
            this.ReceiverKey.TabIndex = 16;
            // 
            // ReadAllBlocks
            // 
            this.ReadAllBlocks.Location = new System.Drawing.Point(136, 332);
            this.ReadAllBlocks.Name = "ReadAllBlocks";
            this.ReadAllBlocks.Size = new System.Drawing.Size(78, 21);
            this.ReadAllBlocks.TabIndex = 17;
            this.ReadAllBlocks.Text = "Read All";
            this.ReadAllBlocks.UseVisualStyleBackColor = true;
            this.ReadAllBlocks.Click += new System.EventHandler(this.ReadAllBlocks_Click);
            // 
            // PrintPending
            // 
            this.PrintPending.Location = new System.Drawing.Point(119, 371);
            this.PrintPending.Name = "PrintPending";
            this.PrintPending.Size = new System.Drawing.Size(95, 46);
            this.PrintPending.TabIndex = 18;
            this.PrintPending.Text = "Print Pending Transactions";
            this.PrintPending.UseVisualStyleBackColor = true;
            this.PrintPending.Click += new System.EventHandler(this.PrintPending_Click);
            // 
            // ValidateChain
            // 
            this.ValidateChain.Location = new System.Drawing.Point(587, 411);
            this.ValidateChain.Name = "ValidateChain";
            this.ValidateChain.Size = new System.Drawing.Size(98, 20);
            this.ValidateChain.TabIndex = 19;
            this.ValidateChain.Text = "Validate Chain";
            this.ValidateChain.UseVisualStyleBackColor = true;
            this.ValidateChain.Click += new System.EventHandler(this.ValidateChain_Click);
            // 
            // CheckBalance
            // 
            this.CheckBalance.Location = new System.Drawing.Point(483, 384);
            this.CheckBalance.Name = "CheckBalance";
            this.CheckBalance.Size = new System.Drawing.Size(98, 21);
            this.CheckBalance.TabIndex = 20;
            this.CheckBalance.Text = "Check Balance";
            this.CheckBalance.UseVisualStyleBackColor = true;
            this.CheckBalance.Click += new System.EventHandler(this.CheckBalance_Click);
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(697, 481);
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
            this.Controls.Add(this.CreateBlock);
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
            this.Text = "Blockchain App";
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
        private System.Windows.Forms.Button CreateBlock;
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
    }
}

