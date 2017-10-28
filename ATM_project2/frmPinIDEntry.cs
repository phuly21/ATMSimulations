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
    public partial class frmPinIdEntry : Form
    {
        public frmPinIdEntry()
        {
            InitializeComponent();
        }
        //int hiddentries = GlobalData.ATMBank.getHiddenMax();
        private void btnOK_Click(object sender, EventArgs e)
        {
            int hiddentries = GlobalData.ATMBank.getHiddenMax();
            string pin = txtPinNumber.Text;
            string name = txtName.Text;
            if (!string.IsNullOrWhiteSpace(pin) || !string.IsNullOrWhiteSpace(name))
            {
                if (GlobalData.customer.verifyNameAndPin(name, pin))
                {
                    this.Hide();
                    frmTransactionEntry thirdForm = new frmTransactionEntry();
                    thirdForm.Show();
                }

                else
                {
                     
                MessageBox.Show(String.Format("The Name or Pin entered is invalid or does not Exist.\n You have {0} tries left", hiddentries - 1));
                    hiddentries--;

                    GlobalData.ATMBank.setHiddenMax(hiddentries);
                    if (hiddentries==0)
                    {
                        MessageBox.Show("YOU HAVE REACH THREE TRIES, ACCOUNT IS LOCKED", "SHUTDOWN");
                        Close();
                    }
                    //MessageBox.Show("not Valid");

                }
            }
            else
            {
                MessageBox.Show("blank data");
            }
        }

        private void TextChange(object sender, EventArgs e)
        {
            txtPinNumber.Text = "";
            btnOK.Enabled = true;
            btnReset.Enabled = true;
        }

        //event for  btnReset_Click
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPinNumber.Text = "";
            txtName.Text = "";
            btnOK.Enabled = false;

        }
    }
}
