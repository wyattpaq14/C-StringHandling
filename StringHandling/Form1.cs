using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnParseName_Click(object sender, System.EventArgs e)
        {
            // TODO: Add code to parse name
            string messageBox = "";
            string fullName = txtFullName.Text;
            fullName = fullName.Trim();
            string[] names = fullName.Split(' ');
            string firstname = names[0];
            string middlename = names[1];
            string lastname = names[2];


            messageBox += "First name \t" + firstname + "\n";
            messageBox += "Middle name \t" + middlename + "\n";
            messageBox += "Last name \t" + lastname + "\n";
            MessageBox.Show(messageBox);
        }

        private void btnEditPhoneNumber_Click(object sender, System.EventArgs e)
        {
            // TODO: Add code to edit the phone number
            string messageBox = "";
            string phoneNumber = txtPhoneNumber.Text;
            phoneNumber = phoneNumber.Insert(3, "-");
            phoneNumber = phoneNumber.Insert(7, "-");

            messageBox += "Origional Number: \t" + txtPhoneNumber.Text + "\n";
            messageBox += "Formated Number: \t" + phoneNumber + "\n";
            MessageBox.Show(messageBox);



        }

        // TODO: Add ToInitialCap method here

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}