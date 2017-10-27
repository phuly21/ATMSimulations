using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Project_2
{
    public class customerClass
    {
        private string[] Customer;
        private string recordAccountNumber;
        private string recordName;
        private string recordPin;
        private decimal recordChkBalance;
        private decimal recordSavBalance;

        //return true or false if the customer enter the right account number.
        public bool customerMatch(string accountNum,string nextRecord)
        {
            Customer=nextRecord.Split('*');
            for (int i = 0; i <= Customer.Length - 1; i++)
            {
                Customer[i] = Customer[i].Trim();
            }
            recordAccountNumber = Customer[0];
            //while (Customer.Length < 0)
            //{
            //    int i = 0;
            //    Customer[i] = Customer[i].Trim();
            //    i++;

            //}
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
        public bool verifyNameAndPin(string name,string pin)
        {
            recordName = Customer[1];
            recordPin = Customer[2];
            if (name==recordName && pin == recordPin)
            {
                return true;
            }
            else
            {
                return false;
            }
          
        }

        public string modifyCustomerRecord(decimal inputAmount)
        {
            string modCustRecord = "";
            
            
            return modCustRecord;
        }

        public decimal getCheckbalance()
        {
            recordChkBalance =  Convert.ToDecimal(Customer[3]);
            return recordChkBalance;
        }

        public decimal getSavingBalance()
        {
            recordSavBalance = Convert.ToDecimal(Customer[4]);
            return recordSavBalance;
        }
    }
}
