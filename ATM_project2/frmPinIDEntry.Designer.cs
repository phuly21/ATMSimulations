﻿namespace ATM_project2
{
    partial class frmPinIdEntry
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
            this.lblNameAndPinInstructions = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPinNumber = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPinNumber = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblNameAndPinEntry = new System.Windows.Forms.Label();
            this.lblForm2BankName = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNameAndPinInstructions
            // 
            this.lblNameAndPinInstructions.AutoSize = true;
            this.lblNameAndPinInstructions.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblNameAndPinInstructions.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameAndPinInstructions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNameAndPinInstructions.Location = new System.Drawing.Point(81, 197);
            this.lblNameAndPinInstructions.Name = "lblNameAndPinInstructions";
            this.lblNameAndPinInstructions.Size = new System.Drawing.Size(456, 56);
            this.lblNameAndPinInstructions.TabIndex = 0;
            this.lblNameAndPinInstructions.Text = "Enter your name and your 4 digit pin number below \r\nand click ok when finished. ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(214, 280);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblPinNumber
            // 
            this.lblPinNumber.AutoSize = true;
            this.lblPinNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPinNumber.Location = new System.Drawing.Point(214, 323);
            this.lblPinNumber.Name = "lblPinNumber";
            this.lblPinNumber.Size = new System.Drawing.Size(81, 16);
            this.lblPinNumber.TabIndex = 2;
            this.lblPinNumber.Text = "Pin Number:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(301, 275);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // txtPinNumber
            // 
            this.txtPinNumber.Location = new System.Drawing.Point(301, 318);
            this.txtPinNumber.MaxLength = 4;
            this.txtPinNumber.Name = "txtPinNumber";
            this.txtPinNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPinNumber.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOK.Enabled = false;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(330, 388);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 39);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblNameAndPinEntry
            // 
            this.lblNameAndPinEntry.AutoSize = true;
            this.lblNameAndPinEntry.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblNameAndPinEntry.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameAndPinEntry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNameAndPinEntry.Location = new System.Drawing.Point(199, 109);
            this.lblNameAndPinEntry.Name = "lblNameAndPinEntry";
            this.lblNameAndPinEntry.Size = new System.Drawing.Size(208, 28);
            this.lblNameAndPinEntry.TabIndex = 6;
            this.lblNameAndPinEntry.Text = "Name and Pin Entry";
            // 
            // lblForm2BankName
            // 
            this.lblForm2BankName.AutoSize = true;
            this.lblForm2BankName.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblForm2BankName.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForm2BankName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForm2BankName.Location = new System.Drawing.Point(99, 29);
            this.lblForm2BankName.Name = "lblForm2BankName";
            this.lblForm2BankName.Size = new System.Drawing.Size(415, 57);
            this.lblForm2BankName.TabIndex = 7;
            this.lblForm2BankName.Text = "Phu And Sandy ATM";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReset.Enabled = false;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(171, 388);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 39);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Clear ";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmPinIdEntry
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(627, 471);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblForm2BankName);
            this.Controls.Add(this.lblNameAndPinEntry);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPinNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPinNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNameAndPinInstructions);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmPinIdEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pin And Name Verification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameAndPinInstructions;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPinNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPinNumber;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblNameAndPinEntry;
        private System.Windows.Forms.Label lblForm2BankName;
        private System.Windows.Forms.Button btnReset;
    }
}