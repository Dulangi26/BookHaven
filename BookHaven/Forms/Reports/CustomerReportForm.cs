using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven.Classes.BusinessLogic;
using BookHaven.Forms.Admin;

namespace BookHaven.Forms.Reports
{
    public partial class CustomerReportForm : Form
    {
        public CustomerReportForm()
        {
            InitializeComponent();
        }

        private void LoadCustomerReport()
        {
            // Create a new instance of the ReportManager class
            ReportManager reportManager = new ReportManager();

            // Get the latest customer report data
            DataTable customerData = reportManager.GetCustomerReport();

            // Set the data to the DataGridView to refresh it
            dgvCustomerReport.DataSource = customerData;
        }


        private void CustomerReportForm_Load(object sender, EventArgs e)
        {
            ReportManager reportManager = new ReportManager();
            DataTable customerData = reportManager.GetCustomerReport();
            dgvCustomerReport.DataSource = customerData;
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Open the report Dashboard form
            Reportdashboard rep = new Reportdashboard();
            rep.Show();  // Show the report Dashboard form
            this.Hide();  // Hide the current report form
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Call LoadCustomerReport to refresh the data in the DataGridView
            LoadCustomerReport();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();  // Get the text entered by the user

            if (!string.IsNullOrEmpty(searchText))
            {
                // Create an instance of the ReportManager class
                ReportManager reportManager = new ReportManager();

                // Get the latest customer report data (use GetCustomerReport instead of GetInventoryReport)
                DataTable customerData = reportManager.GetCustomerReport();

                // Apply filter to the DataTable based on the search text
                DataView dataView = customerData.DefaultView;
                dataView.RowFilter = $"CustomerName LIKE '%{searchText}%' OR Email LIKE '%{searchText}%'";  // Filter by Customer Name or Email

                // Bind the filtered data to the DataGridView
                dgvCustomerReport.DataSource = dataView.ToTable();
            }
            else
            {
                // If the search text is empty, reload the full report
                LoadCustomerReport();
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            // Clear the search textbox
            txtSearch.Clear();

            // Reload all books (no search term)
            LoadCustomerReport();
        }
    }
}
