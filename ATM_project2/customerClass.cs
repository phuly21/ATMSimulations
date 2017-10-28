using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// PHU LY AND SANDRA YU PROJECT 2
//  10/24/2017
namespace ATM_project2
{
    class customerClass
    {
        private string[] Customer;
        private string recordAccountNumber;
        private string recordName;
        private string recordPin;
        private decimal recordChkBalance;
        private decimal recordSavBalance;

        //return true or false if the customer enter the right account number.
        public bool customerMatch(string accountNum, string nextRecord)
        {
            Customer = nextRecord.Split('*');
            int i = 0;
            while (i < Customer.Length)
            {
                Customer[i] = Customer[i].Trim();
                i++;
            }

            recordAccountNumber = Customer[0];

            if (accountNum == recordAccountNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //given a name and pin entered by customer,check to see if they math account numner entered.
        public bool verifyNameAndPin(string name, string pin)
        {
            recordName = Customer[1];
            recordPin = Customer[2];
            if (String.Equals(name, recordName, StringComparison.OrdinalIgnoreCase) && pin == recordPin)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //modify the customeRecord and return the customer record for it print out
        public string modifyCustomerRecord(int butonCode,decimal inputAmount)
        {
            string modCustRecord = "";
            //remove the $
            recordChkBalance =Convert.ToDecimal(Customer[3].Substring(1)) ;
            recordSavBalance = Convert.ToDecimal(Customer[4].Substring(1));
           

            //Saving deposit
            if (butonCode == 7)
            {
                recordSavBalance +=inputAmount;
            }
            //checking deposit
            else if (butonCode == 1)
            {
                recordChkBalance += inputAmount;
            }
            //saving withdrawn
            else if (butonCode == 6)
            {
                if (butonCode == 6 && (inputAmount <= recordSavBalance))
                {
                    //MessageBox.Show(string.Format("Amount Enter Exceed total amount in Saving Account \n Total amount in Saving account is {0}", recordSavBalance), "Amount Exceed");
                    recordSavBalance -= inputAmount;
                }
                else
                {
                    MessageBox.Show(string.Format("Amount Enter Exceed total amount in Saving Account \n Total amount in Saving account is {0}. NO change were made", recordSavBalance), "Amount Exceed");
                    //recordSavBalance -= inputAmount;
                }
            }
            //checking withdrawn
            else if (butonCode == 3)
            {
                if (butonCode == 3 && (inputAmount <= recordChkBalance))
                {
                    //MessageBox.Show(string.Format("Amount Enter Exceed total amount in Checking Account \n Total amount in Checking account is {0}", recordChkBalance), "Amount Exceed");
                    recordChkBalance -= inputAmount;
                }

                //recordChkBalance -= inputAmount;
                MessageBox.Show(string.Format("Amount Enter Exceed total amount in Checking Account \n Total amount in Checking account is {0}. NO change were made", recordChkBalance), "Amount Exceed");
            }
            //transfer saving to checking
            else if (butonCode == 4)
            {
             
                recordSavBalance -= inputAmount;
                recordChkBalance += inputAmount;
            }
            //transfer from checking to saving
            else if (butonCode ==5 )
            {
                recordSavBalance += inputAmount;
                recordChkBalance -= inputAmount;
            }
            //check chkbalance
            else if (butonCode == 2)
            {
                recordChkBalance -= inputAmount;

            }
            //check sav balnace
            else if (butonCode == 8)
            {
                recordSavBalance += inputAmount;
            }
            Customer[3] = recordChkBalance.ToString("c0");
            Customer[4] = recordSavBalance.ToString("c0");
            string Sav= string.Format("{0:n0}", recordSavBalance); 
            string chek= string.Format("{0:n0}", recordChkBalance);

            modCustRecord = recordAccountNumber + " * " + recordName + " * " + recordPin + " * $" + chek + " * $" + Sav;
           
            return modCustRecord;
        }
        //getter to get check balance
        public decimal getCheckbalance()
        {
            return recordChkBalance;
        }
        //getter to get saving balance
        public decimal getSavingBalance()
        {
            return recordSavBalance;
        }

        //check to see if it contained digit only
        public bool IsDigitOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }
            return true;
        }
    }
}

