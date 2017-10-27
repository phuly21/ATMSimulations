namespace ATM_Project_2
{
    partial class Form1
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnFindMe = new System.Windows.Forms.Button();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblAtmWelcome = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblInstructions.Location = new System.Drawing.Point(16, 326);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(524, 25);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Enter 5 digit Account Number. Once finished, click Find Me.";
            // 
            // btnFindMe
            // 
            this.btnFindMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFindMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindMe.Location = new System.Drawing.Point(345, 372);
            this.btnFindMe.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindMe.Name = "btnFindMe";
            this.btnFindMe.Size = new System.Drawing.Size(100, 28);
            this.btnFindMe.TabIndex = 1;
            this.btnFindMe.Text = "Find Me";
            this.btnFindMe.UseVisualStyleBackColor = false;
            this.btnFindMe.Click += new System.EventHandler(this.btnFindMe_Click);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(213, 375);
            this.txtAccountNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccountNumber.MaxLength = 5;
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(87, 22);
            this.txtAccountNumber.TabIndex = 2;
            this.txtAccountNumber.Focus();

            // 
            // lblAtmWelcome
            // 
            this.lblAtmWelcome.AutoSize = true;
            this.lblAtmWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtmWelcome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblAtmWelcome.Location = new System.Drawing.Point(140, 74);
            this.lblAtmWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAtmWelcome.Name = "lblAtmWelcome";
            this.lblAtmWelcome.Size = new System.Drawing.Size(340, 36);
            this.lblAtmWelcome.TabIndex = 3;
            this.lblAtmWelcome.Text = "Welcome to (Name)ATM";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblAccountNumber.Location = new System.Drawing.Point(59, 375);
            this.lblAccountNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(139, 20);
            this.lblAccountNumber.TabIndex = 4;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnFindMe;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(633, 485);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.lblAtmWelcome);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.btnFindMe);
            this.Controls.Add(this.lblInstructions);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnFindMe;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lblAtmWelcome;
        private System.Windows.Forms.Label lblAccountNumber;
    }
}

