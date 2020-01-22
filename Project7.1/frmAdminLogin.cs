using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project7
{
    public partial class frmAdminLogin : Form
    {
        //keeps user from accessing next page unless credentials match
        bool validauth = false;
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void BtnAdminLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //only one username and password for admin login
                if (txtUsername.Text == "admin" && txtAdminPassword.Text == "BACS287")
                {
                    this.Hide();
                    validauth = true;
                    frmAdmin Admin = new frmAdmin();
                    Admin.ShowDialog();
                    this.Close();
                }
                if (validauth == false)
                {
                    MessageBox.Show("Invalid Credentials");
                }
            }
            catch
            {
                MessageBox.Show("All fields are required");
            }
        }
    }
}
