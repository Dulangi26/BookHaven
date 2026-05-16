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
using BookHaven.Classes.Models;
using BookHaven.Classes.DataAccess;
using BookHaven.Forms.SalesTransaction;


namespace BookHaven.Forms.OrderManagement
{
    public partial class OrderConfirmationForm : Form
    {
        private int customerId;
        private int bookId;
        private int quantity;
        private decimal totalAmount;
        private string orderStatus;

        // Constructor to pass data from previous form
        public OrderConfirmationForm(int customerId, int bookId, int quantity, decimal totalAmount, string orderStatus)
        {
            InitializeComponent();
            this.customerId = customerId;
            this.bookId = bookId;
            this.quantity = quantity;
            this.totalAmount = totalAmount;
            this.orderStatus = orderStatus;
        }


        private int GetLatestSaleID()
        {
            int saleID = 0;
            using (var connection = DBConnection.GetConnection())
            {
                string query = "SELECT TOP 1 SaleID FROM Sales ORDER BY SaleID DESC";
                using (var cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        saleID = Convert.ToInt32(result);
                    }
                }
            }
            return saleID;
        }


        private void OrderConfirmationForm_Load(object sender, EventArgs e)
        {
            // Display order details in the confirmation form
            lblCustomerName.Text = "Customer ID: " + customerId.ToString();
            lblBookTitle.Text = "Book ID: " + bookId.ToString();
            lblQuantity.Text = "Quantity: " + quantity.ToString();
            lblTotalAmount.Text = "Total Amount: Rs. " + totalAmount.ToString("0.00");
            lblOrderStatus.Text = "Order Status: " + orderStatus;
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            try
            {
                // Insert the order details into the Orders table
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    string insertQuery = @"INSERT INTO Orders (CustomerId, BookId, Quantity, OrderStatus, OrderDate) 
                                   VALUES (@CustomerId, @BookId, @Quantity, @OrderStatus, @OrderDate); 
                                   SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerId", customerId);
                        cmd.Parameters.AddWithValue("@BookId", bookId);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@OrderStatus", orderStatus);
                        cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);

                        conn.Open();
                        int orderID = Convert.ToInt32(cmd.ExecuteScalar());

                        // Call the GetLatestSaleID method to retrieve the latest SaleID
                        int latestSaleID = GetLatestSaleID();

                        // Now, pass the order ID and other details to SaleDetailsForm
                        SaleDetailsForm salesDetailsForm = new SaleDetailsForm(customerId, bookId, quantity, totalAmount, latestSaleID, orderStatus);
                        salesDetailsForm.Show();
                        this.Hide(); // Hide the current form
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error confirming the order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
