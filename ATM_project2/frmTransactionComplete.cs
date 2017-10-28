using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_project2
{
    public partial class frmTransactionComplete : Form
    {
        public frmTransactionComplete()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        //event for btnAnotherTransactionNo_Click
        private void btnAnotherTransactionNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using this bank! Have a wonderful day!","Good Bye Message");
           
            GlobalData.ATMBank.CopyRemainingRecords();
            GlobalData.ATMBank.closeFiles();
            Application.Exit();

        }

        private void btnSeeBalancesNo_Click(object sender, EventArgs e)
        {
            btnAnotherTransactionYes.Visible = true;
            btnAnotherTransactionNo.Visible = true;
        }

        private void btnSeeBalancesYes_Click(object sender, EventArgs e)
        {
            visibleBalance();
            decimal chkBalance = GlobalData.customer.getCheckbalance();
            txtCheckingsBalance.Text = "" + chkBalance;

            decimal savBalance = GlobalData.customer.getSavingBalance();
            txtSavingsBalance.Text = "" + savBalance;

            btnAnotherTransactionYes.Visible = true;
            btnAnotherTransactionNo.Visible = true;

        }

        private void btnAnotherTransactionYes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTransactionEntry thirdForm = new frmTransactionEntry();
            thirdForm.Show();
        }

        public void invisibleBalance()
        {
            lblBalances.Visible = false;
            lblCheckingsBalance.Visible = false;
            lblSavingsBalance.Visible = false;
            txtCheckingsBalance.Visible = false;
            txtSavingsBalance.Visible = false;
        }

        public void visibleBalance()
        {
            lblBalances.Visible = true;
            lblCheckingsBalance.Visible = true;
            lblSavingsBalance.Visible = true;
            txtCheckingsBalance.Visible = true;
            txtSavingsBalance.Visible = true;
        }
    }
}
