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

namespace BookHaven.Forms.Reports
{
    public partial class SalesReportForm : Form
    {
        private readonly ReportManager reportManager;

        public SalesReportForm()
        {
            InitializeComponent();
            reportManager = new ReportManager();
        }

        // Display column names for debugging
        private void DisplayColumnNames(DataTable dataTable)
        {
            string columnNames = string.Join(", ", dataTable.Columns
                .Cast<DataColumn>()
                .Select(col => col.ColumnName));
            MessageBox.Show("Columns: " + columnNames, "Column Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // Load sales report data
        private void LoadSalesReport()
        {
            try
            {
                DataTable salesData = reportManager.GetSalesReport();

                // Check if data is not null and contains rows
                if (salesData != null && salesData.Rows.Count > 0)
                {
                    DisplayColumnNames(salesData);
                    dgvSalesReport.DataSource = salesData;
                }
                else
                {
                    MessageBox.Show("No sales data available.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvSalesReport.DataSource = null; // Clear DataGridView if no data is available
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the sales report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void SalesReportForm_Load(object sender, EventArgs e)
        {
            // Fetch the sales report data
            ReportManager reportManager = new ReportManager();
            DataTable salesData = reportManager.GetSalesReport();
            dgvSalesReport.DataSource = salesData;
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSalesReport();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                try
                {
                    DataTable salesData = reportManager.GetSalesReport();

                    if (salesData.Rows.Count > 0)
                    {
                        DataView dataView = salesData.DefaultView;

                        // Search Logic - ensure that column names match the DataTable
                        dataView.RowFilter =
                            $"CONVERT(SaleID, 'System.String') LIKE '%{searchText}%' " +
                            $"OR CustomerName LIKE '%{searchText}%' " +
                            $"OR BookTitle LIKE '%{searchText}%' " +
                            $"OR Author LIKE '%{searchText}%'";

                        // Display filtered data or show message
                        if (dataView.Count > 0)
                        {
                            dgvSalesReport.DataSource = dataView.ToTable();
                        }
                        else
                        {
                            MessageBox.Show("No matching records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadSalesReport();  // Reloads original data if no results are found
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data available to search.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a search term.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadSalesReport(); // Reload all data
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            // Clear the search textbox
            txtSearch.Clear();

            // Reload all books (no search term)
            LoadSalesReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Open the report Dashboard form
            Reportdashboard rep = new Reportdashboard();
            rep.Show();  // Show the report Dashboard form
            this.Hide();  // Hide the current report form
        }
    }
}
