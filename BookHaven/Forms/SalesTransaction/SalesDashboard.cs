using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using BookHaven.Database;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using BookHaven.Forms.SalesTransaction;
using BookHaven.Forms.Reports;
using BookHaven.Forms.CustomerManagement;
using BookHaven.Forms.OrderManagement;
using BookHaven.Forms.BookManagement;
using BookHaven.Forms.Login;

namespace BookHaven.Forms
{
    public partial class SalesDashboardForm : Form
    {
        public SalesDashboardForm()
        {
            InitializeComponent();
            LoadSalesSummary();
            LoadSalesChart();
            LoadSalesSummaryGrid();
        }

        // Load Sales Summary Data
        private void LoadSalesSummary()
        {
            using (var connection = DBConnection.GetConnection())
            {
                // Query to calculate total sales
                string totalSalesQuery = @"SELECT SUM(TotalAmount) AS TotalSales FROM Sales;";
                using (var cmd = new SqlCommand(totalSalesQuery, connection))
                {
                    connection.Open();
                    var result = cmd.ExecuteScalar();
                    lblTotalSales.Text = $"Total Sales: Rs. {result ?? 0}";
                }

                // Query to calculate total transactions
                string totalTransactionsQuery = @"SELECT COUNT(TransactionID) AS TotalTransactions FROM SalesTransactions;";
                using (var cmd = new SqlCommand(totalTransactionsQuery, connection))
                {
                    var result = cmd.ExecuteScalar();
                    lblTotalTransactions.Text = $"Total Transactions: {result ?? 0}";
                }

                // Query to calculate total quantity sold
                string totalQuantityQuery = @"SELECT SUM(Quantity) AS TotalQuantitySold FROM SaleDetails;";
                using (var cmd = new SqlCommand(totalQuantityQuery, connection))
                {
                    var result = cmd.ExecuteScalar();
                    lblTotalQuantitySold.Text = $"Total Quantity Sold: {result ?? 0}";
                }

                // Query to calculate average sale amount
                string avgSaleAmountQuery = @"SELECT AVG(TotalAmount) AS AvgSaleAmount FROM Sales;";
                using (var cmd = new SqlCommand(avgSaleAmountQuery, connection))
                {
                    var result = cmd.ExecuteScalar();
                    lblAvgSaleAmount.Text = $"Average Sale Amount: Rs. {result ?? 0}";
                }
            }
        }


        // Load Sales Data into the Chart
        private void LoadSalesChart()
        {
            using (var connection = DBConnection.GetConnection())
            {
                string query = @"SELECT SaleDate, SUM(TotalAmount) AS DailyTotal FROM Sales GROUP BY SaleDate ORDER BY SaleDate;"; // Added ORDER BY for sorted data
                using (var cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        var salesData = new ChartValues<double>();
                        var dates = new List<string>();

                        while (reader.Read())
                        {
                            salesData.Add(Convert.ToDouble(reader["DailyTotal"]));
                            dates.Add(Convert.ToDateTime(reader["SaleDate"]).ToShortDateString());
                        }

                        salesChart.Series = new SeriesCollection
                        {
                            new LineSeries
                            {
                                Title = "Daily Sales",
                                Values = salesData
                            }
                        };

                        salesChart.AxisX.Clear();
                        salesChart.AxisX.Add(new Axis
                        {
                            Title = "Date",
                            Labels = dates
                        });

                        salesChart.AxisY.Clear();
                        salesChart.AxisY.Add(new Axis
                        {
                            Title = "Sales (Rs.)",
                            LabelFormatter = value => value.ToString("C") // Formatting Y axis as currency
                        });
                    }
                }
            }
        }

        // Load Sales Summary Data into DataGridView
        private void LoadSalesSummaryGrid()
        {
            using (var connection = DBConnection.GetConnection())
            {
                // SQL query to fetch data from Sales, SaleDetails, and SalesTransactions tables
                string query = @"
                    SELECT 
                        s.SaleID,                   -- From Sales table
                        s.CustomerID,               -- From Sales table
                        s.TotalAmount AS SaleTotal, -- From Sales table
                        s.SaleDate,                 -- From Sales table
                        sd.SaleDetailID,            -- From SaleDetails table
                        sd.BookID,                  -- From SaleDetails table
                        sd.Quantity,                -- From SaleDetails table
                        sd.TotalPrice,              -- From SaleDetails table
                        st.TransactionID,           -- From SalesTransactions table
                        st.TransactionDate,         -- From SalesTransactions table
                        st.TotalAmount AS TransactionTotal, -- From SalesTransactions table
                        st.PaymentDetails           -- From SalesTransactions table
                    FROM Sales s
                    JOIN SaleDetails sd ON s.SaleID = sd.SaleID  -- Join Sales with SaleDetails based on SaleID
                    JOIN SalesTransactions st ON s.CustomerID = st.CustomerID  -- Join Sales with SalesTransactions based on CustomerID
                    ORDER BY s.SaleDate;

        ";

                using (var cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        // Create a DataTable to hold the data
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        // Bind the DataTable to the DataGridView
                        dgvSalesDetails.DataSource = dt;
                    }
                }
            }
        }



        // Update Chart Button
        private void btnUpdateChart_Click(object sender, EventArgs e)
        {
            LoadSalesChart();
            MessageBox.Show("Sales Chart Updated Successfully.");
        }

        // View Detailed Sales Button
        private void btnViewDetailedSales_Click(object sender, EventArgs e)
        {
            var salesTransactionForm = new SalesTransactionForm();
            salesTransactionForm.Show();
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

        private void SalesDashboard_Load(object sender, EventArgs e)
        {

        }

        private void dgvSalesDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTotalSales_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalExpenses_Click(object sender, EventArgs e)
        {

        }

        private void lblProfit_Click(object sender, EventArgs e)
        {

        }

        private void salesChart_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerManagementForm sup = new CustomerManagementForm();
            sup.Show();
            this.Hide();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            SalesTransactionForm sup = new SalesTransactionForm();
            sup.Show();
            this.Hide();
        }

        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            OrderManagementForm sup = new OrderManagementForm();
            sup.Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Reportdashboard sup = new Reportdashboard();
            sup.Show();
            this.Hide();
        }

        private void btnBookManagement_Click(object sender, EventArgs e)
        {
            BookManagementForm sup = new BookManagementForm();
            sup.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin sup = new FrmLogin();
            sup.Show();
            this.Hide();
        }
    }
}
