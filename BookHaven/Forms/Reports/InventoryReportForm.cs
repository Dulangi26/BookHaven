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
using OfficeOpenXml; 
using System.IO;

namespace BookHaven.Forms.Reports
{
    public partial class InventoryReportForm : Form
    {
        public InventoryReportForm()
        {
            InitializeComponent();
        }

        private void LoadInventoryReport()
        {
            // Create an instance of the ReportManager class
            ReportManager reportManager = new ReportManager();

            // Get the latest inventory report data
            DataTable inventoryData = reportManager.GetInventoryReport();

            // Bind data to the DataGridView
            dgvInventoryReport.DataSource = inventoryData;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InventoryReportForm_Load(object sender, EventArgs e)
        {
            LoadInventoryReport();
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

        private void btnback_Click(object sender, EventArgs e)
        {
            // Open the report Dashboard form
            Reportdashboard rep = new Reportdashboard();
            rep.Show();  // Show the report Dashboard form
            this.Hide();  // Hide the current report form
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Refresh the inventory report data
            LoadInventoryReport();
        }

        public void ExportToExcel(DataGridView dgv)
        {
            // Open a SaveFileDialog to let the user choose the file location and name
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "report.xlsx";  // Default file name
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Create a new Excel package using the selected file path
                using (var package = new ExcelPackage(new FileInfo(saveFileDialog.FileName)))
                {
                    var worksheet = package.Workbook.Worksheets.Add("Report"); // Create a new worksheet

                    // Writing headers to the first row
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = dgv.Columns[i].HeaderText;  // Set header name
                    }

                    // Writing data rows starting from row 2
                    for (int rowIndex = 0; rowIndex < dgv.Rows.Count; rowIndex++)
                    {
                        for (int colIndex = 0; colIndex < dgv.Columns.Count; colIndex++)
                        {
                            worksheet.Cells[rowIndex + 2, colIndex + 1].Value = dgv.Rows[rowIndex].Cells[colIndex].Value?.ToString() ?? string.Empty;
                        }
                    }

                    // Save the package to the chosen file
                    package.Save();
                    MessageBox.Show("Report exported successfully to Excel!");
                }
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgvInventoryReport);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                ReportManager reportManager = new ReportManager();
                DataTable inventoryData = reportManager.GetInventoryReport();

                // Debugging: Check if data is being retrieved
                if (inventoryData.Rows.Count == 0)
                {
                    MessageBox.Show("No data found in the inventory report.");
                    return;
                }

                DataView dataView = inventoryData.DefaultView;
                dataView.RowFilter = $"BookTitle LIKE '%{searchText}%' OR Author LIKE '%{searchText}%'";

                dgvInventoryReport.DataSource = dataView.ToTable();
            }
            else
            {
                LoadInventoryReport();
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            // Clear the search textbox
            txtSearch.Clear();

            // Reload all books (no search term)
            LoadInventoryReport();
        }
    }
}
