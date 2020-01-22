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
    public partial class frmAdmin : Form
    {

        string[] customers = File.ReadAllLines("OrderInfo.txt");
        public frmAdmin()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            int LowerTotal = 0;
            int ClubTotal = 0;
            int UpperTotal = 0;
            double TotalSales = 0;

            //gets each string from the OrderInfo text file, places them into array
            var DataGridQuery = from name in customers
                                let getdata = name.Split(',')
                                let getname = getdata[0]
                                let useremail = getdata[1]
                                let gettotalcost = getdata[6]
                                let lower = getdata[7]
                                let club = getdata[8]
                                let upper = getdata[9]
                                let sales = getdata[6]
                                let confirm = getdata[10]
                                select new { getname, useremail, gettotalcost, confirm, lower, club, upper, sales };
            foreach (var name in DataGridQuery)
            {
                //load data into data grid
                dataGridView1.Rows.Add(name.getname, name.useremail, name.gettotalcost, name.confirm, name.lower, name.club, name.upper, name.sales);

                LowerTotal += int.Parse(name.lower);
                ClubTotal += int.Parse(name.club);
                UpperTotal += int.Parse(name.upper);
                TotalSales += double.Parse(name.sales);
            }
                //display total seats remaining and total sales
                lblLowerCount.Text = (200 - LowerTotal).ToString();
                lblClubCount.Text = (75 - ClubTotal).ToString();
                lblUpperCount.Text = (200 - UpperTotal).ToString();
                lblTotalSales.Text = TotalSales.ToString("c2");
        }

        private void BtnFindGuest_Click(object sender, EventArgs e)
        {
            string confirmNum = txtConfirmNum.Text;

            var searchNameQ = from name in customers
                              let seatTotal = name.Split(',')
                              let searchName = seatTotal[0]
                              let amtCharged = seatTotal[6]
                              let ll = seatTotal[7]
                              let cl = seatTotal[8]
                              let ud = seatTotal[9]
                              let confirm = seatTotal[10]
                              select new { searchName, confirm, amtCharged, ll, cl, ud, };
            foreach (var result in searchNameQ)
            {
                if (confirmNum == result.confirm)
                {
                    MessageBox.Show("Found Confirmation number: " + result.confirm + "\n" +
                        "Name: " + result.searchName + "\n" + "Total Charge: $" + result.amtCharged + "\n" + "Confirmation found");
                }
            }
            //highlights row
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[3].Value.ToString().Equals(confirmNum))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Confirmation number does not exist!", "number now found");
            }
        }
    }
}
