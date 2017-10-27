using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ATM_Project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            txtAccountNumber.Focus();

        }
        
        private void btnFindMe_Click(object sender, EventArgs e)
        {
            txtAccountNumber.Focus();
            bool found = false;
            
            {
                string accountNumber = txtAccountNumber.Text;
                GlobalData.ATMBank.findCustomerRecord(accountNumber, ref found);
                // flag = GlobalData.customer.customerMatch(accountNumber, nextRecord);
                if (found)
                {
                    this.Hide();
                    Form2 secondform = new Form2();
                    secondform.Show();
                }
                else
                {
                    MessageBox.Show("The account you enter is invalid, please try again!!!");
                    txtAccountNumber.Text = "";
                    messagebox.Show("hello world");
                   
                    
                }

            }
           
        }
    }
}
