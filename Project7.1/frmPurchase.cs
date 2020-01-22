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
    public partial class frmPurchase : Form
    {
        bool credit = true;
        bool csv = true;
        public frmPurchase()
        {
            InitializeComponent();
            lblTotalCost.Text = "$" + Customer.TotalCost.ToString();
        }

        public void CreditCheck()
        {
            string creditNum = txtCreditCardNum.Text;
            Regex numOnly = new Regex("\\d+");
            Match match = numOnly.Match(creditNum);
            if (match.Success && txtCreditCardNum.Text.Length == 16)
            {
                credit = true;
            }
            else
            {
                credit = false;
                MessageBox.Show("Invalid Credit Card Number.");
            }
        }
        public void csvCheck()
        {
            string csvNum = txtCSV.Text;
            Regex numOnly = new Regex("\\d+");
            Match match = numOnly.Match(csvNum);
            if (match.Success && txtCSV.Text.Length == 3)
            {
                csv = true;
            }
            else
            {
                csv = false;
                MessageBox.Show("Invalid CSV.");
            }
        }
        private void BtnPayment_Click(object sender, EventArgs e)
        {
            try
            {
                csvCheck();
                CreditCheck();
                if (csv == true && credit == true)
                {
                    //generates random number using class Random between 1000 and 9999
                    Random r = new Random();
                    int RandNum = r.Next(1000, 9999);

                    string[] CustomerArray = new string[11];
                    CustomerArray[0] = Customer.name;
                    CustomerArray[1] = Customer.email;
                    CustomerArray[2] = Customer.age.ToString();
                    CustomerArray[3] = txtNameOnCard.Text;
                    CustomerArray[4] = txtCreditCardNum.Text;
                    CustomerArray[5] = txtCSV.Text;
                    CustomerArray[6] = Customer.TotalCost.ToString();
                    CustomerArray[7] = Customer.Lower.ToString();
                    CustomerArray[8] = Customer.Club.ToString();
                    CustomerArray[9] = Customer.Upper.ToString();
                    CustomerArray[10] = RandNum.ToString();

                    DialogResult result = (MessageBox.Show("Hello: " + Customer.name + "\n"
                        + "Please confirm your purchase of: " + Customer.TotalCost + "\n" + "Contact Email: " + Customer.email + "\n" +
                        "Please click Yes to confirm your order", "Confirmation", MessageBoxButtons.YesNoCancel));

                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("Thank you for your order!" + "\n" + "Your confirmation number is: " + RandNum);
                        string PurchaseRecord = string.Join(",", CustomerArray);

                        File.AppendAllText("OrderInfo.txt", PurchaseRecord + "\r\n");

                        this.Close();
                    }
                    //if result is no or cancel, form will stay open, no data will be created
                }
            }
            catch
            {
                MessageBox.Show("All fields are required");
            }
        }
    }
}
