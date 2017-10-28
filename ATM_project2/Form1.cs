using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// PHU LY AND SANDRA YU PROJECT 2
//  10/24/2017
namespace ATM_project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void btnFindMe_Click(object sender, EventArgs e)
        {
            txtAccountNumber.Focus();
            bool found = false;
            string accountNumber = txtAccountNumber.Text;
            int hiddentries = GlobalData.ATMBank.getHiddenMax();

            if (GlobalData.customer.IsDigitOnly(accountNumber) || string.IsNullOrWhiteSpace(accountNumber))
            {
                GlobalData.ATMBank.findCustomerRecord(accountNumber, ref found);
                if (found)
                {
                    this.Hide();
                    frmPinIdEntry secondform = new frmPinIdEntry();
                    secondform.Show();
                    GlobalData.ATMBank.setHiddenMax(3);
                }
                else
                {
                    MessageBox.Show(String.Format("The account number you enter is invalid or does not Exist.\n You have {0} tries left", hiddentries - 1));
                    //MessageBox.Show("not Valid");
                    txtAccountNumber.Text = "";
                    GlobalData.ATMBank.rewindFiles();
                    hiddentries--;
                    GlobalData.ATMBank.setHiddenMax(hiddentries);
                    

                    if (hiddentries == 0)
                    {
                        MessageBox.Show("YOU HAVE REACH THREE TRIES, ACCOUNT IS LOCKED", "SHUTDOWN");
                        Close();
                    }
                    txtAccountNumber.Focus();

                }
            }
            else
            {
                MessageBox.Show("Please Enter 5 digit ", "Non-Digit detected");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAccountNumber.Focus();
            btnFindMe.Enabled = false;
        }
        private void txtAccNumTextChange(object sender, EventArgs e)
        {
            bool flag = true;
            while(txtAccountNumber.Text.Length == 5 && flag)
            { 
                btnFindMe.Enabled = true;
                flag = false;
            }
        }
    }
}
