using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* *************THINGS NEEDED TO BE FIX****************
--PIN/NAME VALIDATION        ---- Done
--MULTIPLE TRANSACTION     ---- Done
--TRIES COUNTER--IMPLEMENTATION BY USING SETTER----  DONE
--SETTING A LIMITS OF $300 A DAY        ----Done
--COMMENT CODE
--Withdraw cannot make balance negative
--Name caseSensitive      --- Done
--AND THATS IT FOR NOW :D
 */

// PHU LY AND SANDRA YU PROJECT 2
//  10/24/2017
namespace ATM_project2
{
    public partial class frmTransactionEntry : Form
    {
        public frmTransactionEntry()
        {
            InitializeComponent();
        }
        int buttonCode;
        private void Form3_Load(object sender, EventArgs e)
        {
            hidesControl();
            btnSelectAmountOK.Enabled = false;
        }

        //Yes Process selected Click events
        private void btnCorrectProcess_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTransactionComplete fourthForm = new frmTransactionComplete();
            fourthForm.Show();
           //decimal amount = 0;

            if (!(string.IsNullOrEmpty(txtSelectAmount.Text)))
            {
                decimal amount = Convert.ToDecimal(txtSelectAmount.Text);
                GlobalData.ATMBank.writeOut(GlobalData.customer.modifyCustomerRecord(buttonCode, amount));
            }
            else
            {
                decimal amount = 0;
                GlobalData.ATMBank.writeOut(GlobalData.customer.modifyCustomerRecord(buttonCode, amount));
            }
        }

        //Select amount OK click event
        private void btnSelectAmountOK_Click(object sender, EventArgs e)
        {
            if (GlobalData.customer.IsDigitOnly(txtSelectAmount.Text))
            {
                btnSelectAmountOK.Enabled = false;
                unHideLayer2Control();
                decimal amountInDec = Convert.ToDecimal(txtSelectAmount.Text);
                string amount = string.Format("{0:n0}", amountInDec);
                MessageBox.Show("You Have Select This amount: " + "$" + amount);
                txtYouSelectedAmount.Text = "$" + amount.ToString();
                decimal hiddenLimit = GlobalData.ATMBank.getHiddenWithdrawnmax();
                decimal chkBalance = GlobalData.customer.getCheckbalance();
                decimal savBalance = GlobalData.customer.getSavingBalance();

                if ((buttonCode == 3 || buttonCode == 6) && amountInDec > hiddenLimit)
                {
                    MessageBox.Show(string.Format("Daily Withdrawl is limited $300.00 a day, Please enter below this limit {0}",hiddenLimit),"OverLimit");
                    txtSelectAmount.Text = "";
                    txtYouSelectedAmount.Text = "";
                }
                else
                {
                    GlobalData.ATMBank.setHiddenWithdrawnMax(amountInDec);
                }
               
            }
            else
            {
                MessageBox.Show("Please No Symbol or Letter","Input Error");
            }
        }

        //Select select again click event
        private void btnNoSelectAgain_Click(object sender, EventArgs e)
        {
            enableButton();
            changecolor();
            txtSelectAmount.Text = "";
            txtYouSelectedAmount.Text = "";
            hidesControl();
        }

        //Checking Deposit Click events
        private void btnCheckingsDeposit_Click(object sender, EventArgs e)
        {
            buttonCode = 1;
            btnCheckingsDeposit.BackColor = System.Drawing.Color.Green;
            CaseSwitch(buttonCode);
            unhidehidesLayer1Control();
            txtSelectAmount.Focus();
            btnSelectAmountOK.Enabled = false;
        }

        //SavingsDeposit Click events
        private void btnSavingsDeposit_Click(object sender, EventArgs e)
        {

            buttonCode = 7;
             btnSavingsDeposit.BackColor = System.Drawing.Color.Green;
            CaseSwitch(buttonCode);
            unhidehidesLayer1Control();
            txtSelectAmount.Focus();
            btnSelectAmountOK.Enabled = false;
        }

        //Checking Withdrawal Click events
        private void btnCheckingsWithdrawal_Click(object sender, EventArgs e)
        {
            buttonCode = 3;
            btnCheckingsWithdrawal.BackColor = System.Drawing.Color.Green;
            CaseSwitch(buttonCode);
            unhidehidesLayer1Control();
            txtSelectAmount.Focus();
            btnSelectAmountOK.Enabled = false;
        }

        //Saving withdawal Click events
        private void btnSavingsWithdrawal_Click(object sender, EventArgs e)
        {
            buttonCode = 6;
            btnSavingsWithdrawal.BackColor = System.Drawing.Color.Green;
            CaseSwitch(buttonCode);
            unhidehidesLayer1Control();
            txtSelectAmount.Focus();
            btnSelectAmountOK.Enabled = false;
        }

        //Checking Balance Click events
        private void btnCheckingsBalanace_Click(object sender, EventArgs e)
        {
            buttonCode = 2;
            btnCheckingsBalanace.BackColor = System.Drawing.Color.Green;
            CaseSwitch(buttonCode);
            unHideLayer3Control();
            
        }

        //Savings Balance Click events
        private void btnSavingsBalance_Click(object sender, EventArgs e)
        {
            buttonCode = 8;
            btnSavingsBalance.BackColor = System.Drawing.Color.Green;
            CaseSwitch(buttonCode);
            unHideLayer3Control();
        }

        //Transfer checking to Savings Click events
        private void btnTransferCheckingsToSavings_Click(object sender, EventArgs e)
        {
            buttonCode = 5;
             btnTransferCheckingsToSavings.BackColor = System.Drawing.Color.Green;
            CaseSwitch(buttonCode);
            unhidehidesLayer1Control();
            txtSelectAmount.Focus();
            btnSelectAmountOK.Enabled = false;
        }

        //Transfer savings to checkings Click events
        private void btnTransferSavingsToCheckings_Click(object sender, EventArgs e)
        {
            buttonCode = 4;
             btnTransferSavingsToCheckings.BackColor = System.Drawing.Color.Green;
            CaseSwitch(buttonCode);
            unhidehidesLayer1Control();
            txtSelectAmount.Focus();
            btnSelectAmountOK.Enabled = false;
        }
        //caseswitch to determine what button were press and to diable stuff
        public void CaseSwitch(int caseNumber)
        {
            
            switch (caseNumber)
            {
                case 1:
                    disableButtons();
                    btnCheckingsDeposit.Enabled = true;
                    break;
                case 2:
                    disableButtons();
                    btnCheckingsBalanace.Enabled = true;
                    break;
                case 3:
                    disableButtons();
                    btnCheckingsWithdrawal.Enabled = true;
                    
                    break;
                case 4:
                    disableButtons();
                    btnTransferSavingsToCheckings.Enabled = true;
                    
                    break;
                case 5:
                    disableButtons();
                    btnTransferCheckingsToSavings.Enabled = true;
                    
                    break;
                case 6:
                    disableButtons();
                    btnSavingsWithdrawal.Enabled = true;
                    
                    break;
                case 7:
                    disableButtons();
                    btnSavingsDeposit.Enabled = true;
                   
                    break;
                case 8:
                    disableButtons();
                    btnSavingsBalance.Enabled = true;
                    break;

            }
        }
        //disable all button
        public void disableButtons()
        {
            btnCheckingsDeposit.Enabled = false;
            btnCheckingsBalanace.Enabled = false;
            btnCheckingsWithdrawal.Enabled = false;
            btnTransferSavingsToCheckings.Enabled = false;
            btnTransferCheckingsToSavings.Enabled = false;
            btnSavingsWithdrawal.Enabled = false;
            btnSavingsDeposit.Enabled = false;
            btnSavingsBalance.Enabled = false;

        }
        //enable all button
         public void enableButton()
        {

            btnCheckingsDeposit.Enabled = true;
            btnCheckingsBalanace.Enabled = true;
            btnCheckingsWithdrawal.Enabled = true;
            btnTransferSavingsToCheckings.Enabled = true;
            btnTransferCheckingsToSavings.Enabled = true;
            btnSavingsWithdrawal.Enabled = true;
            btnSavingsDeposit.Enabled = true;
            btnSavingsBalance.Enabled = true;

        }
        //change the color when the button is click
        public void changecolor()
        {
            btnCheckingsDeposit.BackColor = System.Drawing.Color.AliceBlue;
            btnSavingsDeposit.BackColor = System.Drawing.Color.AliceBlue;
            btnCheckingsWithdrawal.BackColor = System.Drawing.Color.AliceBlue;
            btnSavingsWithdrawal.BackColor = System.Drawing.Color.AliceBlue;
            btnCheckingsBalanace.BackColor = System.Drawing.Color.AliceBlue;
            btnSavingsBalance.BackColor = System.Drawing.Color.AliceBlue;
            btnTransferCheckingsToSavings.BackColor = System.Drawing.Color.AliceBlue;
            btnTransferSavingsToCheckings.BackColor = System.Drawing.Color.AliceBlue;

        }
        //hide some of the control
        public void hidesControl()
        {
            lblSelectAmount.Visible = false;
            txtSelectAmount. Visible = false;
            btnSelectAmountOK.Visible = false;
            lblYouSelectedAmount.Visible = false;
            txtYouSelectedAmount.Visible = false;
            lblYouSelectedContinued.Visible = false;
            btnCorrectProcess.Visible = false;
            btnNoSelectAgain.Visible = false;
        }
       //Make some of the control visible.
        public void unhidehidesLayer1Control()
        {
            lblSelectAmount.Visible = true;
            txtSelectAmount.Visible = true;
            btnSelectAmountOK.Visible = true;
        }
        //make some of the control visable
        public void unHideLayer2Control()
        {
            lblYouSelectedAmount.Visible = true;
            txtYouSelectedAmount.Visible = true;
            lblYouSelectedContinued.Visible = true;
            btnCorrectProcess.Visible = true;
            btnNoSelectAgain.Visible = true;
        }
        //unhidelayer3control
        public void unHideLayer3Control()
        {
            btnCorrectProcess.Visible = true;
            btnNoSelectAgain.Visible = true;
        }
        //textchange
        private void txtamountTextchange(object sender, EventArgs e)
        {
            btnSelectAmountOK.Enabled = true;
        }
        
    };
}

