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
using System.Text.RegularExpressions;

namespace Project7
{
    public partial class frmAcctCreation : Form
    {
        string[] customers = File.ReadAllLines("CustomerInfo.txt");

        bool emailformat = true;
        bool emaildup = false;
        bool agecheck = false;
        public frmAcctCreation()
        {
            InitializeComponent();
        }

        public void checkage()
        {
            int custage = int.Parse(txtAge.Text);
            if (custage >= 16)
            {
                agecheck = true;
            }
            else
            {
                MessageBox.Show("You must be 16 or older to purchase tickets.");
            }
        }
        public void emailregex()
        {
            //get email from textbox
            string email = txtEmail.Text;

            //create regex match astatement for email address
            Regex regex = new Regex ((@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"));
            Match match = regex.Match(email);

            if (match.Success)
            {
                emailformat = true;
            }
            else
            {
                emailformat = false;
                MessageBox.Show("invalid e-mail address entered", "Invalid e-mail");
            }
        }

        public void duplicateemail()
        {
            string CreateEmail = txtEmail.Text;

            var duplicateQ = from n in customers
                             let emails = n.Split(',')
                             let email = emails[2]
                             select new { email };
            foreach (var i in duplicateQ)
            {
                if (CreateEmail == i.email.ToString())
                {
                    emaildup = true;
                    MessageBox.Show(txtEmail.Text + " already has an account. Please use another email.");
                    break;
                }
            }
        }

        private void BtnCreatAcct_Click(object sender, EventArgs e)
        {
            try
            {
            duplicateemail();
            checkage();
            emailregex();
                if (emailformat == true && agecheck == true && emaildup == false)
                {
                            //Customer is a class for all user information and ticket types
                            this.Hide();
                            Customer.name = txtName.Text;
                            Customer.age = int.Parse(txtAge.Text);
                            Customer.email = txtEmail.Text;
                            Customer.password = txtPassword.Text;

                            string CustomerRecord = Customer.name + "," + Customer.age + "," + Customer.email + "," + Customer.password;

                            File.AppendAllText("CustomerInfo.txt", CustomerRecord + "\r\n");

                            frmOrder OrderForm = new frmOrder();
                            OrderForm.ShowDialog();
                            this.Close();
                }
            }
            catch
            {
                MessageBox.Show("All fields are required");
            }
        }
    }
}
