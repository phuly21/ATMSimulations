namespace ATM_project2
{
    partial class frmTransactionEntry
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
            this.lblSelectTransaction = new System.Windows.Forms.Label();
            this.btnSavingsDeposit = new System.Windows.Forms.Button();
            this.btnSavingsWithdrawal = new System.Windows.Forms.Button();
            this.btnSavingsBalance = new System.Windows.Forms.Button();
            this.btnTransferSavingsToCheckings = new System.Windows.Forms.Button();
            this.btnCheckingsDeposit = new System.Windows.Forms.Button();
            this.btnCheckingsWithdrawal = new System.Windows.Forms.Button();
            this.btnCheckingsBalanace = new System.Windows.Forms.Button();
            this.btnTransferCheckingsToSavings = new System.Windows.Forms.Button();
            this.lblTransactionPage = new System.Windows.Forms.Label();
            this.btnSelectAmountOK = new System.Windows.Forms.Button();
            this.txtSelectAmount = new System.Windows.Forms.TextBox();
            this.txtYouSelectedAmount = new System.Windows.Forms.TextBox();
            this.btnCorrectProcess = new System.Windows.Forms.Button();
            this.btnNoSelectAgain = new System.Windows.Forms.Button();
            this.lblForm3BankName = new System.Windows.Forms.Label();
            this.lblSelectAmount = new System.Windows.Forms.Label();
            this.lblYouSelectedAmount = new System.Windows.Forms.Label();
            this.lblYouSelectedContinued = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSelectTransaction
            // 
            this.lblSelectTransaction.AutoSize = true;
            this.lblSelectTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTransaction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSelectTransaction.Location = new System.Drawing.Point(104, 173);
            this.lblSelectTransaction.Name = "lblSelectTransaction";
            this.lblSelectTransaction.Size = new System.Drawing.Size(220, 25);
            this.lblSelectTransaction.TabIndex = 0;
            this.lblSelectTransaction.Text = "Select a transaction...";
            // 
            // btnSavingsDeposit
            // 
            this.btnSavingsDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavingsDeposit.Location = new System.Drawing.Point(440, 222);
            this.btnSavingsDeposit.Name = "btnSavingsDeposit";
            this.btnSavingsDeposit.Size = new System.Drawing.Size(263, 41);
            this.btnSavingsDeposit.TabIndex = 1;
            this.btnSavingsDeposit.Text = "Savings Deposit";
            this.btnSavingsDeposit.UseVisualStyleBackColor = true;
            this.btnSavingsDeposit.Click += new System.EventHandler(this.btnSavingsDeposit_Click);
            // 
            // btnSavingsWithdrawal
            // 
            this.btnSavingsWithdrawal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavingsWithdrawal.Location = new System.Drawing.Point(440, 278);
            this.btnSavingsWithdrawal.Name = "btnSavingsWithdrawal";
            this.btnSavingsWithdrawal.Size = new System.Drawing.Size(263, 41);
            this.btnSavingsWithdrawal.TabIndex = 2;
            this.btnSavingsWithdrawal.Text = "Savings Withdrawal";
            this.btnSavingsWithdrawal.UseVisualStyleBackColor = true;
            this.btnSavingsWithdrawal.Click += new System.EventHandler(this.btnSavingsWithdrawal_Click);
            // 
            // btnSavingsBalance
            // 
            this.btnSavingsBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavingsBalance.Location = new System.Drawing.Point(440, 339);
            this.btnSavingsBalance.Name = "btnSavingsBalance";
            this.btnSavingsBalance.Size = new System.Drawing.Size(263, 41);
            this.btnSavingsBalance.TabIndex = 3;
            this.btnSavingsBalance.Text = "Savings Balance";
            this.btnSavingsBalance.UseVisualStyleBackColor = true;
            this.btnSavingsBalance.Click += new System.EventHandler(this.btnSavingsBalance_Click);
            // 
            // btnTransferSavingsToCheckings
            // 
            this.btnTransferSavingsToCheckings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferSavingsToCheckings.Location = new System.Drawing.Point(440, 398);
            this.btnTransferSavingsToCheckings.Name = "btnTransferSavingsToCheckings";
            this.btnTransferSavingsToCheckings.Size = new System.Drawing.Size(263, 41);
            this.btnTransferSavingsToCheckings.TabIndex = 4;
            this.btnTransferSavingsToCheckings.Text = "Transfer Savings to Checkings";
            this.btnTransferSavingsToCheckings.UseVisualStyleBackColor = true;
            this.btnTransferSavingsToCheckings.Click += new System.EventHandler(this.btnTransferSavingsToCheckings_Click);
            // 
            // btnCheckingsDeposit
            // 
            this.btnCheckingsDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckingsDeposit.Location = new System.Drawing.Point(126, 222);
            this.btnCheckingsDeposit.Name = "btnCheckingsDeposit";
            this.btnCheckingsDeposit.Size = new System.Drawing.Size(263, 41);
            this.btnCheckingsDeposit.TabIndex = 5;
            this.btnCheckingsDeposit.Text = "Checkings Deposit";
            this.btnCheckingsDeposit.UseVisualStyleBackColor = true;
            this.btnCheckingsDeposit.Click += new System.EventHandler(this.btnCheckingsDeposit_Click);
            // 
            // btnCheckingsWithdrawal
            // 
            this.btnCheckingsWithdrawal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckingsWithdrawal.Location = new System.Drawing.Point(126, 278);
            this.btnCheckingsWithdrawal.Name = "btnCheckingsWithdrawal";
            this.btnCheckingsWithdrawal.Size = new System.Drawing.Size(263, 41);
            this.btnCheckingsWithdrawal.TabIndex = 6;
            this.btnCheckingsWithdrawal.Text = "Checkings Withdrawal";
            this.btnCheckingsWithdrawal.UseVisualStyleBackColor = true;
            this.btnCheckingsWithdrawal.Click += new System.EventHandler(this.btnCheckingsWithdrawal_Click);
            // 
            // btnCheckingsBalanace
            // 
            this.btnCheckingsBalanace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckingsBalanace.Location = new System.Drawing.Point(126, 339);
            this.btnCheckingsBalanace.Name = "btnCheckingsBalanace";
            this.btnCheckingsBalanace.Size = new System.Drawing.Size(263, 41);
            this.btnCheckingsBalanace.TabIndex = 7;
            this.btnCheckingsBalanace.Text = "Checkings Balance";
            this.btnCheckingsBalanace.UseVisualStyleBackColor = true;
            this.btnCheckingsBalanace.Click += new System.EventHandler(this.btnCheckingsBalanace_Click);
            // 
            // btnTransferCheckingsToSavings
            // 
            this.btnTransferCheckingsToSavings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferCheckingsToSavings.Location = new System.Drawing.Point(126, 398);
            this.btnTransferCheckingsToSavings.Name = "btnTransferCheckingsToSavings";
            this.btnTransferCheckingsToSavings.Size = new System.Drawing.Size(263, 41);
            this.btnTransferCheckingsToSavings.TabIndex = 8;
            this.btnTransferCheckingsToSavings.Text = "Transfer Checkings to Savings";
            this.btnTransferCheckingsToSavings.UseVisualStyleBackColor = true;
            this.btnTransferCheckingsToSavings.Click += new System.EventHandler(this.btnTransferCheckingsToSavings_Click);
            // 
            // lblTransactionPage
            // 
            this.lblTransactionPage.AutoSize = true;
            this.lblTransactionPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTransactionPage.Location = new System.Drawing.Point(329, 108);
            this.lblTransactionPage.Name = "lblTransactionPage";
            this.lblTransactionPage.Size = new System.Drawing.Size(131, 16);
            this.lblTransactionPage.TabIndex = 9;
            this.lblTransactionPage.Text = "Transaction Page";
            // 
            // btnSelectAmountOK
            // 
            this.btnSelectAmountOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSelectAmountOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAmountOK.Location = new System.Drawing.Point(592, 480);
            this.btnSelectAmountOK.Name = "btnSelectAmountOK";
            this.btnSelectAmountOK.Size = new System.Drawing.Size(79, 34);
            this.btnSelectAmountOK.TabIndex = 11;
            this.btnSelectAmountOK.Text = "OK";
            this.btnSelectAmountOK.UseVisualStyleBackColor = false;
            this.btnSelectAmountOK.Click += new System.EventHandler(this.btnSelectAmountOK_Click);
            // 
            // txtSelectAmount
            // 
            this.txtSelectAmount.Location = new System.Drawing.Point(475, 488);
            this.txtSelectAmount.Name = "txtSelectAmount";
            this.txtSelectAmount.Size = new System.Drawing.Size(100, 20);
            this.txtSelectAmount.TabIndex = 12;
            this.txtSelectAmount.TextChanged += new System.EventHandler(this.txtamountTextchange);
            // 
            // txtYouSelectedAmount
            // 
            this.txtYouSelectedAmount.Location = new System.Drawing.Point(344, 523);
            this.txtYouSelectedAmount.Name = "txtYouSelectedAmount";
            this.txtYouSelectedAmount.ReadOnly = true;
            this.txtYouSelectedAmount.Size = new System.Drawing.Size(100, 20);
            this.txtYouSelectedAmount.TabIndex = 14;
            // 
            // btnCorrectProcess
            // 
            this.btnCorrectProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCorrectProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrectProcess.Location = new System.Drawing.Point(239, 562);
            this.btnCorrectProcess.Name = "btnCorrectProcess";
            this.btnCorrectProcess.Size = new System.Drawing.Size(161, 49);
            this.btnCorrectProcess.TabIndex = 16;
            this.btnCorrectProcess.Text = "YES - Process Select";
            this.btnCorrectProcess.UseVisualStyleBackColor = false;
            this.btnCorrectProcess.Click += new System.EventHandler(this.btnCorrectProcess_Click);
            // 
            // btnNoSelectAgain
            // 
            this.btnNoSelectAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNoSelectAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoSelectAgain.Location = new System.Drawing.Point(440, 562);
            this.btnNoSelectAgain.Name = "btnNoSelectAgain";
            this.btnNoSelectAgain.Size = new System.Drawing.Size(169, 49);
            this.btnNoSelectAgain.TabIndex = 17;
            this.btnNoSelectAgain.Text = "NO - Select Again";
            this.btnNoSelectAgain.UseVisualStyleBackColor = false;
            this.btnNoSelectAgain.Click += new System.EventHandler(this.btnNoSelectAgain_Click);
            // 
            // lblForm3BankName
            // 
            this.lblForm3BankName.AutoSize = true;
            this.lblForm3BankName.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForm3BankName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForm3BankName.Location = new System.Drawing.Point(223, 30);
            this.lblForm3BankName.Name = "lblForm3BankName";
            this.lblForm3BankName.Size = new System.Drawing.Size(324, 45);
            this.lblForm3BankName.TabIndex = 18;
            this.lblForm3BankName.Text = "Phu And Sandy ATM";
            // 
            // lblSelectAmount
            // 
            this.lblSelectAmount.AutoSize = true;
            this.lblSelectAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSelectAmount.Location = new System.Drawing.Point(122, 489);
            this.lblSelectAmount.Name = "lblSelectAmount";
            this.lblSelectAmount.Size = new System.Drawing.Size(346, 20);
            this.lblSelectAmount.TabIndex = 19;
            this.lblSelectAmount.Text = "Select an amount (in dollars with no puncations)";
            // 
            // lblYouSelectedAmount
            // 
            this.lblYouSelectedAmount.AutoSize = true;
            this.lblYouSelectedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouSelectedAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYouSelectedAmount.Location = new System.Drawing.Point(197, 523);
            this.lblYouSelectedAmount.Name = "lblYouSelectedAmount";
            this.lblYouSelectedAmount.Size = new System.Drawing.Size(140, 20);
            this.lblYouSelectedAmount.TabIndex = 20;
            this.lblYouSelectedAmount.Text = "You have selected";
            // 
            // lblYouSelectedContinued
            // 
            this.lblYouSelectedContinued.AutoSize = true;
            this.lblYouSelectedContinued.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouSelectedContinued.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYouSelectedContinued.Location = new System.Drawing.Point(470, 523);
            this.lblYouSelectedContinued.Name = "lblYouSelectedContinued";
            this.lblYouSelectedContinued.Size = new System.Drawing.Size(223, 20);
            this.lblYouSelectedContinued.TabIndex = 21;
            this.lblYouSelectedContinued.Text = "and the transaction is correct?";
            // 
            // frmTransactionEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(830, 634);
            this.Controls.Add(this.lblYouSelectedContinued);
            this.Controls.Add(this.lblYouSelectedAmount);
            this.Controls.Add(this.lblSelectAmount);
            this.Controls.Add(this.lblForm3BankName);
            this.Controls.Add(this.btnNoSelectAgain);
            this.Controls.Add(this.btnCorrectProcess);
            this.Controls.Add(this.txtYouSelectedAmount);
            this.Controls.Add(this.txtSelectAmount);
            this.Controls.Add(this.btnSelectAmountOK);
            this.Controls.Add(this.lblTransactionPage);
            this.Controls.Add(this.btnTransferCheckingsToSavings);
            this.Controls.Add(this.btnCheckingsBalanace);
            this.Controls.Add(this.btnCheckingsWithdrawal);
            this.Controls.Add(this.btnCheckingsDeposit);
            this.Controls.Add(this.btnTransferSavingsToCheckings);
            this.Controls.Add(this.btnSavingsBalance);
            this.Controls.Add(this.btnSavingsWithdrawal);
            this.Controls.Add(this.btnSavingsDeposit);
            this.Controls.Add(this.lblSelectTransaction);
            this.Name = "frmTransactionEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Page";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectTransaction;
        private System.Windows.Forms.Button btnSavingsDeposit;
        private System.Windows.Forms.Button btnSavingsWithdrawal;
        private System.Windows.Forms.Button btnSavingsBalance;
        private System.Windows.Forms.Button btnTransferSavingsToCheckings;
        private System.Windows.Forms.Button btnCheckingsDeposit;
        private System.Windows.Forms.Button btnCheckingsWithdrawal;
        private System.Windows.Forms.Button btnCheckingsBalanace;
        private System.Windows.Forms.Button btnTransferCheckingsToSavings;
        private System.Windows.Forms.Label lblTransactionPage;
        private System.Windows.Forms.Button btnSelectAmountOK;
        private System.Windows.Forms.TextBox txtSelectAmount;
        private System.Windows.Forms.TextBox txtYouSelectedAmount;
        private System.Windows.Forms.Button btnCorrectProcess;
        private System.Windows.Forms.Button btnNoSelectAgain;
        private System.Windows.Forms.Label lblForm3BankName;
        private System.Windows.Forms.Label lblSelectAmount;
        private System.Windows.Forms.Label lblYouSelectedAmount;
        private System.Windows.Forms.Label lblYouSelectedContinued;
    }
}