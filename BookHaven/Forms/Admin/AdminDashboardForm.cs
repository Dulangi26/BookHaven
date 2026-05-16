using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven.Classes.DataAccess;
using BookHaven.Forms.BookManagement;
using BookHaven.Forms.CustomerManagement;
using BookHaven.Forms.Login;
using BookHaven.Forms.OrderManagement;
using BookHaven.Forms.PaymentManagement;
using BookHaven.Forms.Reports;
using BookHaven.Forms.SalesTransaction;
using BookHaven.Forms.Security;
using BookHaven.Forms.SupplierManagement;

namespace BookHaven.Forms.Admin
{
    public partial class AdminDashboardForm : Form
    {
        private readonly DashboardData dashboardData;

        public AdminDashboardForm()
        {
            InitializeComponent();
            dashboardData = new DashboardData();
            LoadDashboardData();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {

        }

        // Method to Load Data
        private void LoadDashboardData()
        {
            try
            {
                lblTotalBooks.Text = dashboardData.GetTotalBooks().ToString();
                lblTotalCustomers.Text = dashboardData.GetTotalCustomers().ToString();
                lblTotalSales.Text = "Rs. " + dashboardData.GetTotalSalesRevenue().ToString("N2");
                lblLowStock.Text = dashboardData.GetLowStockCount().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Button Hover Effects
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(0, 90, 158); // Darker Blue on Hover
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(0, 122, 204); // Original Blue
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            BookManagementForm book = new BookManagementForm();
            book.Show();
            this.Hide();
        }

        private void btnAdControl_Click(object sender, EventArgs e)
        {
            AdminControls adcontrol = new AdminControls();
            adcontrol.Show();
            this.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerManagementForm cus = new CustomerManagementForm();
            cus.Show();
            this.Hide();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            SalesTransactionForm sale = new SalesTransactionForm();
            sale.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reportdashboard rep = new Reportdashboard();
            rep.Show();
            this.Hide();
        }

        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            OrderManagementForm ord = new OrderManagementForm();
            ord.Show();
            this.Hide();
        }

        private void btnSupplierManagement_Click(object sender, EventArgs e)
        {
            SupplierManagementForm sup = new SupplierManagementForm();
            sup.Show();
            this.Hide();
        }

        private void btnpayment_Click(object sender, EventArgs e)
        {
            PaymentManagementForm sec = new PaymentManagementForm();
            sec.Show();
            this.Hide();
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            SecurityForm sec = new SecurityForm();
            sec.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin sec = new FrmLogin();
            sec.Show();
            this.Hide();
        }
    }
}
