using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Project_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string pin = txtPinNumber.Text;
            string name = txtName.Text;
            if (GlobalData.customer.verifyNameAndPin(name, pin))
            {
                this.Hide();
                Form3 thirdForm = new Form3();
                thirdForm.Show();
            }
            else
            {
                MessageBox.Show("WRong data");
            }
        }
    }
}
