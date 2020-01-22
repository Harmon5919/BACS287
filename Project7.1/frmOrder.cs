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
    public partial class frmOrder : Form
    {
        string[] customers = File.ReadAllLines("OrderInfo.txt");

        bool soldout = false;

        public frmOrder()
        {
            InitializeComponent();
        }

        private void soldoutcheck()
        {
           
            double llseats = 0;
            double clseats = 0;
            double udseats = 0;

            var getSeatsQ = from name in customers
                            let seatTotal = name.Split(',')
                            let ll = seatTotal[7]
                            let cl = seatTotal[8]
                            let ud = seatTotal[9]
                            let sales = seatTotal[6]
                            select new { ll, cl, ud, sales };
            foreach (var total in getSeatsQ)
            {
                llseats += double.Parse(total.ll);
                clseats += double.Parse(total.cl);
                udseats += double.Parse(total.ud);
            }

            double llTotal = 0;
            double clTotal = 0;
            double udTotal = 0;

            llTotal = 200 - llseats - double.Parse(cbxLower.Text);
            clTotal = 75 - clseats - double.Parse(cbxClub.Text);
            udTotal = 200 - udseats - double.Parse(cbxUpper.Text);

            if (llTotal < 0)
            {
                lblLower.Text = "Sold Out";
                lblLower.ForeColor = Color.Red;
                cbxLower.Visible = false;
                soldout = true;
            }

            if (clTotal < 0)
            {
                lblClub.Text = "Sold Out";
                lblClub.ForeColor = Color.Red;
                cbxClub.Visible = false;
                soldout = true;
            }

            if (udTotal < 0)
            {
                lblUpper.Text = "Sold Out";
                lblUpper.ForeColor = Color.Red;
                cbxUpper.Visible = false;
                soldout = true;
            }
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            soldoutcheck();
            if (soldout == false)
            {
                Customer.Lower = int.Parse(cbxLower.Text);
                Customer.Club = int.Parse(cbxClub.Text);
                Customer.Upper = int.Parse(cbxUpper.Text);
                Customer.TotalCost = (Customer.Lower * 125 + Customer.Club * 75 + Customer.Upper * 50);

                frmPurchase purchase = new frmPurchase();
                purchase.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("There are not enough remaining tickets. Please reduce the number of tickets to order.");
            }
        }
    }
}
