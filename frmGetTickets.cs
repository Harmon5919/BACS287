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
    public partial class frmGetTicket : Form
    {
        public frmGetTicket()
        {
            InitializeComponent();
        }

        private void BtnGetTicket_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            frmLogin Login = new frmLogin();
            Login.ShowDialog();
            this.Close();
        }

        private void LblAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminLogin AdminLogin = new frmAdminLogin();
            AdminLogin.ShowDialog();
            this.Close();
        }
    }
}
