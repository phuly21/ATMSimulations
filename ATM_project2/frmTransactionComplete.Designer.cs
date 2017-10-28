namespace ATM_project2
{
    partial class frmTransactionComplete
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
            this.lblTransactionComplete = new System.Windows.Forms.Label();
            this.lblTransactionCompleteForm = new System.Windows.Forms.Label();
            this.lblSeeBalances = new System.Windows.Forms.Label();
            this.btnSeeBalancesYes = new System.Windows.Forms.Button();
            this.btnSeeBalancesNo = new System.Windows.Forms.Button();
            this.lblBalances = new System.Windows.Forms.Label();
            this.lblCheckingsBalance = new System.Windows.Forms.Label();
            this.lblSavingsBalance = new System.Windows.Forms.Label();
            this.txtCheckingsBalance = new System.Windows.Forms.TextBox();
            this.txtSavingsBalance = new System.Windows.Forms.TextBox();
            this.lblAnotherTransaction = new System.Windows.Forms.Label();
            this.btnAnotherTransactionYes = new System.Windows.Forms.Button();
            this.btnAnotherTransactionNo = new System.Windows.Forms.Button();
            this.lblForm4BankName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTransactionComplete
            // 
            this.lblTransactionComplete.AutoSize = true;
            this.lblTransactionComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionComplete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTransactionComplete.Location = new System.Drawing.Point(114, 167);
            this.lblTransactionComplete.Name = "lblTransactionComplete";
            this.lblTransactionComplete.Size = new System.Drawing.Size(291, 24);
            this.lblTransactionComplete.TabIndex = 0;
            this.lblTransactionComplete.Text = "Your Transaction Is Complete!";
            // 
            // lblTransactionCompleteForm
            // 
            this.lblTransactionCompleteForm.AutoSize = true;
            this.lblTransactionCompleteForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionCompleteForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTransactionCompleteForm.Location = new System.Drawing.Point(178, 96);
            this.lblTransactionCompleteForm.Name = "lblTransactionCompleteForm";
            this.lblTransactionCompleteForm.Size = new System.Drawing.Size(219, 18);
            this.lblTransactionCompleteForm.TabIndex = 1;
            this.lblTransactionCompleteForm.Text = "Transaction Complete form ";
            // 
            // lblSeeBalances
            // 
            this.lblSeeBalances.AutoSize = true;
            this.lblSeeBalances.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeeBalances.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSeeBalances.Location = new System.Drawing.Point(114, 213);
            this.lblSeeBalances.Name = "lblSeeBalances";
            this.lblSeeBalances.Size = new System.Drawing.Size(109, 20);
            this.lblSeeBalances.TabIndex = 2;
            this.lblSeeBalances.Text = "See Balance?";
            // 
            // btnSeeBalancesYes
            // 
            this.btnSeeBalancesYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSeeBalancesYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeBalancesYes.Location = new System.Drawing.Point(263, 210);
            this.btnSeeBalancesYes.Name = "btnSeeBalancesYes";
            this.btnSeeBalancesYes.Size = new System.Drawing.Size(53, 23);
            this.btnSeeBalancesYes.TabIndex = 3;
            this.btnSeeBalancesYes.Text = "YES";
            this.btnSeeBalancesYes.UseVisualStyleBackColor = false;
            this.btnSeeBalancesYes.Click += new System.EventHandler(this.btnSeeBalancesYes_Click);
            // 
            // btnSeeBalancesNo
            // 
            this.btnSeeBalancesNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSeeBalancesNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeBalancesNo.Location = new System.Drawing.Point(357, 210);
            this.btnSeeBalancesNo.Name = "btnSeeBalancesNo";
            this.btnSeeBalancesNo.Size = new System.Drawing.Size(50, 23);
            this.btnSeeBalancesNo.TabIndex = 4;
            this.btnSeeBalancesNo.Text = "NO";
            this.btnSeeBalancesNo.UseVisualStyleBackColor = false;
            this.btnSeeBalancesNo.Click += new System.EventHandler(this.btnSeeBalancesNo_Click);
            // 
            // lblBalances
            // 
            this.lblBalances.AutoSize = true;
            this.lblBalances.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalances.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBalances.Location = new System.Drawing.Point(134, 274);
            this.lblBalances.Name = "lblBalances";
            this.lblBalances.Size = new System.Drawing.Size(75, 20);
            this.lblBalances.TabIndex = 5;
            this.lblBalances.Text = "Balances";
            // 
            // lblCheckingsBalance
            // 
            this.lblCheckingsBalance.AutoSize = true;
            this.lblCheckingsBalance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCheckingsBalance.Location = new System.Drawing.Point(261, 258);
            this.lblCheckingsBalance.Name = "lblCheckingsBalance";
            this.lblCheckingsBalance.Size = new System.Drawing.Size(57, 13);
            this.lblCheckingsBalance.TabIndex = 6;
            this.lblCheckingsBalance.Text = "Checkings";
            // 
            // lblSavingsBalance
            // 
            this.lblSavingsBalance.AutoSize = true;
            this.lblSavingsBalance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSavingsBalance.Location = new System.Drawing.Point(364, 258);
            this.lblSavingsBalance.Name = "lblSavingsBalance";
            this.lblSavingsBalance.Size = new System.Drawing.Size(45, 13);
            this.lblSavingsBalance.TabIndex = 7;
            this.lblSavingsBalance.Text = "Savings";
            // 
            // txtCheckingsBalance
            // 
            this.txtCheckingsBalance.Location = new System.Drawing.Point(250, 274);
            this.txtCheckingsBalance.Name = "txtCheckingsBalance";
            this.txtCheckingsBalance.ReadOnly = true;
            this.txtCheckingsBalance.Size = new System.Drawing.Size(83, 20);
            this.txtCheckingsBalance.TabIndex = 8;
            // 
            // txtSavingsBalance
            // 
            this.txtSavingsBalance.Location = new System.Drawing.Point(348, 274);
            this.txtSavingsBalance.Name = "txtSavingsBalance";
            this.txtSavingsBalance.ReadOnly = true;
            this.txtSavingsBalance.Size = new System.Drawing.Size(86, 20);
            this.txtSavingsBalance.TabIndex = 9;
            // 
            // lblAnotherTransaction
            // 
            this.lblAnotherTransaction.AutoSize = true;
            this.lblAnotherTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnotherTransaction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAnotherTransaction.Location = new System.Drawing.Point(70, 323);
            this.lblAnotherTransaction.Name = "lblAnotherTransaction";
            this.lblAnotherTransaction.Size = new System.Drawing.Size(162, 20);
            this.lblAnotherTransaction.TabIndex = 10;
            this.lblAnotherTransaction.Text = "Another Transaction?";
            // 
            // btnAnotherTransactionYes
            // 
            this.btnAnotherTransactionYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAnotherTransactionYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnotherTransactionYes.Location = new System.Drawing.Point(250, 320);
            this.btnAnotherTransactionYes.Name = "btnAnotherTransactionYes";
            this.btnAnotherTransactionYes.Size = new System.Drawing.Size(75, 23);
            this.btnAnotherTransactionYes.TabIndex = 11;
            this.btnAnotherTransactionYes.Text = "YES";
            this.btnAnotherTransactionYes.UseVisualStyleBackColor = false;
            this.btnAnotherTransactionYes.Click += new System.EventHandler(this.btnAnotherTransactionYes_Click);
            // 
            // btnAnotherTransactionNo
            // 
            this.btnAnotherTransactionNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAnotherTransactionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnotherTransactionNo.Location = new System.Drawing.Point(348, 320);
            this.btnAnotherTransactionNo.Name = "btnAnotherTransactionNo";
            this.btnAnotherTransactionNo.Size = new System.Drawing.Size(75, 23);
            this.btnAnotherTransactionNo.TabIndex = 12;
            this.btnAnotherTransactionNo.Text = "NO";
            this.btnAnotherTransactionNo.UseVisualStyleBackColor = false;
            this.btnAnotherTransactionNo.Click += new System.EventHandler(this.btnAnotherTransactionNo_Click);
            // 
            // lblForm4BankName
            // 
            this.lblForm4BankName.AutoSize = true;
            this.lblForm4BankName.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForm4BankName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForm4BankName.Location = new System.Drawing.Point(143, 37);
            this.lblForm4BankName.Name = "lblForm4BankName";
            this.lblForm4BankName.Size = new System.Drawing.Size(254, 36);
            this.lblForm4BankName.TabIndex = 13;
            this.lblForm4BankName.Text = "Phu And Sandy ATM";
            // 
            // frmTransactionComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(575, 481);
            this.Controls.Add(this.lblForm4BankName);
            this.Controls.Add(this.btnAnotherTransactionNo);
            this.Controls.Add(this.btnAnotherTransactionYes);
            this.Controls.Add(this.lblAnotherTransaction);
            this.Controls.Add(this.txtSavingsBalance);
            this.Controls.Add(this.txtCheckingsBalance);
            this.Controls.Add(this.lblSavingsBalance);
            this.Controls.Add(this.lblCheckingsBalance);
            this.Controls.Add(this.lblBalances);
            this.Controls.Add(this.btnSeeBalancesNo);
            this.Controls.Add(this.btnSeeBalancesYes);
            this.Controls.Add(this.lblSeeBalances);
            this.Controls.Add(this.lblTransactionCompleteForm);
            this.Controls.Add(this.lblTransactionComplete);
            this.Name = "frmTransactionComplete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTransactionComplete;
        private System.Windows.Forms.Label lblTransactionCompleteForm;
        private System.Windows.Forms.Label lblSeeBalances;
        private System.Windows.Forms.Button btnSeeBalancesYes;
        private System.Windows.Forms.Button btnSeeBalancesNo;
        private System.Windows.Forms.Label lblBalances;
        private System.Windows.Forms.Label lblCheckingsBalance;
        private System.Windows.Forms.Label lblSavingsBalance;
        private System.Windows.Forms.TextBox txtCheckingsBalance;
        private System.Windows.Forms.TextBox txtSavingsBalance;
        private System.Windows.Forms.Label lblAnotherTransaction;
        private System.Windows.Forms.Button btnAnotherTransactionYes;
        private System.Windows.Forms.Button btnAnotherTransactionNo;
        private System.Windows.Forms.Label lblForm4BankName;
    }
}