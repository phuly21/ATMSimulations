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
    public class ATMBankClass
    {
        // Bank parameters (Named constants defined by the bank)

        // The Files the Bank Owns
        private static string currentFilePath = "CurrentATMBankFile.txt";
        private static string updatedFilePath = "UpdatedATMBankFile.txt";
        //private static string updatedFilePath = @"C:\Users\PHU\Desktop\ATM PROJECT\ATM Project 2 v5\ATM Project 2\Updated.txt";



        private currentFileClass currentFile = new currentFileClass(currentFilePath);
        private updatedFileClass updatedFile = new updatedFileClass(updatedFilePath);

        // Exact length of legal accounts 
        //private int hiddenAccountLength = 5;

        // Number of attempts allows a user before terminating ATM Session
        private int hiddenTryCountMax = 3;

        // Maximum withdrawal amount bank allows per day
        private decimal hiddenWDAmount = Convert.ToDecimal(300.0);

        // Constructor for the ATM Bank Class ...
        public ATMBankClass()
        {

        }
        // Find customer record given the entered account
        public string findCustomerRecord(string account, ref Boolean found)
        {
           // hiddenTryCountMax--;
            string nextRecord;
            Boolean isEndOfFile = true;

            nextRecord = currentFile.getNextRecord(ref isEndOfFile);
            found = false;
            while (!isEndOfFile)
            {
                if (GlobalData.customer.customerMatch(account, nextRecord))
                {
                    found = true;
                   // CopyRemainingRecords();
                    return (nextRecord);
                }
                else
                {
                    updatedFile.putNextRecord(nextRecord);
                    nextRecord = currentFile.getNextRecord(ref isEndOfFile);
                } // end If
            } //end While

            return (nextRecord);
        } //end find Customer Record


        // Writes a single record (such as a modified record) to the updated file
        public void writeOut(string record)
        {
            updatedFile.putNextRecord(record);
        }  // end writeOut


        // Copies remaining records from currentFile to updatedFile.
        public void CopyRemainingRecords()
        {
            Boolean isEndOfFile = false;
            string nextRecord;

            nextRecord = currentFile.getNextRecord(ref isEndOfFile);
            while (!isEndOfFile)
            {
                updatedFile.putNextRecord(nextRecord);
                nextRecord = currentFile.getNextRecord(ref isEndOfFile);
            } // end While

            MessageBox.Show("End of program execution." + "\n"
                + "The number of records read is: " + currentFile.getRecordsReadCount().ToString() + "\n"
                + "The number of records written is: " + updatedFile.getRecordsWrittenCount().ToString());
        } // end CopyRemaingRecords


        public void rewindFiles()
        {
            currentFile.rewindFile();
            updatedFile.rewindFile();
        }  // end rewindFiles


        public void closeFiles()
        {
            currentFile.closeFile();
            updatedFile.closeFile();
        }  // end close files

        //getter
        public int getHiddenMax()
        {
            return this.hiddenTryCountMax;
        }
        public void setHiddenMax(int tries)
        {
            hiddenTryCountMax = tries;
        }
        //getter for calling hiddenWDAmount in other method
        public decimal getHiddenWithdrawnmax()
        {
            return hiddenWDAmount;
        }
        //setter for setting in other method hiddenWDAmount
        public void setHiddenWithdrawnMax(decimal max)
        {
           
            this.hiddenWDAmount-= max;
        }
    } // end ATMBankClass

}