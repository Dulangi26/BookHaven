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
using BookHaven.Forms.SalesTransaction;

namespace BookHaven.Forms.SalesTransaction
{
    public partial class SaleDetailsForm : Form
    {
        public int SaleID { get; set; }
        private int customerId;
        private int bookId;
        private int quantity;
        private decimal totalAmount;
        private string orderStatus;

        // Constructor
        public SaleDetailsForm(int customerId, int bookId, int quantity, decimal totalAmount, int orderID, string orderStatus)
        {
            InitializeComponent();
            this.customerId = customerId;
            this.bookId = bookId;
            this.quantity = quantity;
            this.totalAmount = totalAmount;
            this.SaleID = orderID; // Use the order ID from OrderConfirmationForm
            this.orderStatus = orderStatus;
        }
        private void SaleDetailsForm_Load(object sender, EventArgs e)
        {
            lblTotalAmount.Text = "Total Amount: Rs. " + totalAmount.ToString("0.00");

            // Populate Payment Method ComboBox
            cmbPaymentMethod.Items.Clear();
            cmbPaymentMethod.Items.Add("Cash");
            cmbPaymentMethod.Items.Add("Card");
            cmbPaymentMethod.Items.Add("Online Payment");
            cmbPaymentMethod.SelectedIndex = 0; // Default to 'Cash'

            // Load Sale details for the SaleID
            LoadSaleDetails(SaleID);
        }

        // Load Sale Details for the specific SaleID into DataGridView
        private void LoadSaleDetails(int saleID)
        {
            try
            {
                // Establish a database connection
                using (var connection = DBConnection.GetConnection())
                {
                    // Check if the connection opens successfully
                    try
                    {
                        connection.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting to the database: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Define the SQL query to fetch sale details based on SaleID
                    string query = @"SELECT SaleDetailID, SaleID, BookID, Quantity, TotalPrice
                                     FROM SaleDetails
                                     WHERE SaleID = @SaleID
                                     ORDER BY SaleDetailID";

                    // Use SqlCommand to execute the query
                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@SaleID", saleID); // Pass SaleID as a parameter

                        // Create a DataTable to hold the results
                        DataTable dt = new DataTable();

                        // Execute the query and load data into DataTable
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                                dgvSaleDetails.DataSource = dt; // Bind data to DataGridView
                            }
                            else
                            {
                                // If no records found, show an info message
                                MessageBox.Show("No sales details found for this Sale ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Catch any other exceptions and show an error message
                MessageBox.Show($"Error loading sale details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // DataGridView Cell Click event for viewing details
        private void dgvSaleDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSaleDetails.Rows[e.RowIndex];
                MessageBox.Show($"Sale Detail ID: {row.Cells["SaleDetailID"].Value}",
                                "Sale Detail Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        // Cancel Sale and go back to the previous form
        private void btnCancelSale_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form
        }

        private void btnConfirmSale_Click(object sender, EventArgs e)
        {
            try
            {
                // Insert the Sale record into the Sales table
                using (var connection = DBConnection.GetConnection())
                {
                    string insertSaleQuery = @"INSERT INTO Sales (CustomerID, TotalAmount, SaleDate)
                                               VALUES (@CustomerID, @TotalAmount, GETDATE());
                                               SELECT SCOPE_IDENTITY();";

                    using (var cmd = new SqlCommand(insertSaleQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);
                        cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);

                        connection.Open();
                        SaleID = Convert.ToInt32(cmd.ExecuteScalar()); // Get the newly inserted SaleID
                    }
                }

                // Insert SaleDetail record into SaleDetails table
                using (var connection = DBConnection.GetConnection())
                {
                    string insertSaleDetailQuery = @"INSERT INTO SaleDetails (SaleID, BookID, Quantity, TotalPrice)
                                                     VALUES (@SaleID, @BookID, @Quantity, @TotalPrice)";

                    using (var cmd = new SqlCommand(insertSaleDetailQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@SaleID", SaleID);
                        cmd.Parameters.AddWithValue("@BookID", bookId);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@TotalPrice", totalAmount);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                // Notify the user that the sale is confirmed
                MessageBox.Show("Sale Confirmed. Redirecting to Payment.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Redirect to PaymentForm with the SaleID, CustomerID, and TotalAmount
                PaymentForm paymentForm = new PaymentForm(SaleID, customerId, totalAmount);
                paymentForm.Show();
                this.Hide(); // Hide SaleDetailsForm
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error confirming the sale: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
