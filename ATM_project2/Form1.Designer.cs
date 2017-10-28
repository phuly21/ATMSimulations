namespace ATM_project2
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
            this.picATM = new System.Windows.Forms.PictureBox();
            this.lblAtmWelcome2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picATM)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblInstructions.Location = new System.Drawing.Point(11, 278);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(531, 28);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Enter 5 digit Account Number. Once finished, click Find Me.";
            // 
            // btnFindMe
            // 
            this.btnFindMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFindMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindMe.Location = new System.Drawing.Point(299, 364);
            this.btnFindMe.Name = "btnFindMe";
            this.btnFindMe.Size = new System.Drawing.Size(111, 50);
            this.btnFindMe.TabIndex = 1;
            this.btnFindMe.Text = "Find Me";
            this.btnFindMe.UseVisualStyleBackColor = false;
            this.btnFindMe.Click += new System.EventHandler(this.btnFindMe_Click);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(197, 379);
            this.txtAccountNumber.MaxLength = 5;
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(79, 20);
            this.txtAccountNumber.TabIndex = 0;
            this.txtAccountNumber.TextChanged += new System.EventHandler(this.txtAccNumTextChange);
            // 
            // lblAtmWelcome
            // 
            this.lblAtmWelcome.AutoSize = true;
            this.lblAtmWelcome.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtmWelcome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblAtmWelcome.Location = new System.Drawing.Point(24, 66);
            this.lblAtmWelcome.Name = "lblAtmWelcome";
            this.lblAtmWelcome.Size = new System.Drawing.Size(449, 57);
            this.lblAtmWelcome.TabIndex = 3;
            this.lblAtmWelcome.Text = "Welcome To Phu And Sandy";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblAccountNumber.Location = new System.Drawing.Point(81, 383);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(110, 16);
            this.lblAccountNumber.TabIndex = 4;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // picATM
            // 
            this.picATM.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.picATM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picATM.Image = global::ATM_project2.Properties.Resources.atm_automated_teller_machine_icon_90057;
            this.picATM.Location = new System.Drawing.Point(567, 66);
            this.picATM.Name = "picATM";
            this.picATM.Size = new System.Drawing.Size(420, 439);
            this.picATM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picATM.TabIndex = 5;
            this.picATM.TabStop = false;
            // 
            // lblAtmWelcome2
            // 
            this.lblAtmWelcome2.AutoSize = true;
            this.lblAtmWelcome2.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtmWelcome2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblAtmWelcome2.Location = new System.Drawing.Point(188, 123);
            this.lblAtmWelcome2.Name = "lblAtmWelcome2";
            this.lblAtmWelcome2.Size = new System.Drawing.Size(88, 57);
            this.lblAtmWelcome2.TabIndex = 6;
            this.lblAtmWelcome2.Text = "ATM";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnFindMe;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1044, 591);
            this.Controls.Add(this.lblAtmWelcome2);
            this.Controls.Add(this.picATM);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.lblAtmWelcome);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.btnFindMe);
            this.Controls.Add(this.lblInstructions);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome To ATM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picATM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnFindMe;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lblAtmWelcome;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.PictureBox picATM;
        private System.Windows.Forms.Label lblAtmWelcome2;
    }
}


