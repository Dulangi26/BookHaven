using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven.Forms.Admin;

namespace BookHaven.Forms.Reports
{
    public partial class Reportdashboard : Form
    {
        public Reportdashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var confirmExit = MessageBox.Show(
    "Are you sure you want to exit?",
    "Exit Confirmation",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question);

            if (confirmExit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboardForm sup = new AdminDashboardForm();
            sup.Show();
            this.Hide();
        }

        private void btnCusRep_Click(object sender, EventArgs e)
        {
            CustomerReportForm sup = new CustomerReportForm();
            sup.Show();
            this.Hide();
        }

        private void btnInRep_Click(object sender, EventArgs e)
        {
            InventoryReportForm sup = new InventoryReportForm();
            sup.Show();
            this.Hide();
        }

        private void btnSalRep_Click(object sender, EventArgs e)
        {
            SalesReportForm sup = new SalesReportForm();
            sup.Show();
            this.Hide();
        }
    }
}
