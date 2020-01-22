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

namespace Project7
{
    public partial class frmLogin : Form
    {
        string[] CustomerInfo = File.ReadAllLines("CustomerInfo.txt");
        public frmLogin()
        {
            InitializeComponent();
        }

        private void LblPassword_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                string LoginEmail = txtEmail.Text;
                string Loginpassword = txtPassword.Text;
                bool valid = false;

                //CustomerLogin collect user info to be put in the Customer class
                var CustomerLogin = from customer in CustomerInfo
                                    let login = customer.Split(',')
                                    let name = login[0]
                                    let age = login[1]
                                    let email = login[2]
                                    let password = login[3]
                                    select new { name, age, email, password };

                foreach (var i in CustomerLogin)
                {
                    if (i.email == LoginEmail && i.password == Loginpassword)
                    {
                        Customer.email = i.email;
                        Customer.name = i.name;
                        Customer.age = int.Parse(i.age);
                        valid = true;
                        frmOrder OrderForm = new frmOrder();
                        OrderForm.ShowDialog();
                        this.Close();
                        break;
                    }
                }
                if (valid == false)
                {
                    MessageBox.Show("The email or password is incorrect.");
                }
            }
            catch
            {
                MessageBox.Show("All fields are required");
            }
        }

        private void LblCreateAcct_Click(object sender, EventArgs e)
        {
            //pulls up the account creation window
            this.Hide();
            frmAcctCreation Create = new frmAcctCreation();
            Create.ShowDialog();
        }
    }
}
