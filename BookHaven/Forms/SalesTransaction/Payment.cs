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
using BookHaven.Forms.Reports;
using BookHaven.Forms.Admin;

namespace BookHaven.Forms.SalesTransaction
{
    public partial class PaymentForm : Form
    {
        // Properties to store SaleID, CustomerID, and TotalAmount
        public int SaleID { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalAmount { get; set; }

        // Constructor to initialize the PaymentForm with SaleID, CustomerID, and TotalAmount
        public PaymentForm(int saleID, int customerId, decimal totalAmount)
        {
            InitializeComponent();
            this.SaleID = saleID;
            this.CustomerId = customerId;
            this.TotalAmount = totalAmount;
        }

        // This method will run when the PaymentForm is loaded
        private void PaymentForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine($"SaleID: {SaleID}, CustomerId: {CustomerId}, TotalAmount: {TotalAmount}");

            // Display SaleID, CustomerID, TotalAmount, and PaymentDate in labels
            lblSaleID.Text = "Sale ID: " + SaleID.ToString(); // Show SaleID
            lblCustomerID.Text = "Customer ID: " + CustomerId.ToString(); // Show CustomerID
            lblTotalAmount.Text = "Total Amount: Rs. " + TotalAmount.ToString("0.00"); // Show the TotalAmount
            lblPaymentDate.Text = "Payment Date: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm"); // Show current payment date

            PopulatePaymentMethods();  // Populate the available payment methods
            PopulatePaymentStatus();   // Populate the payment status ComboBox
        }


        // Method to populate the payment methods in the ComboBox
        private void PopulatePaymentMethods()
        {
            cmbPaymentMethod.Items.Clear(); // Clear any existing items
            cmbPaymentMethod.Items.Add("Cash"); // Add payment methods
            cmbPaymentMethod.Items.Add("Card");
            cmbPaymentMethod.Items.Add("Online Payment");
            cmbPaymentMethod.SelectedIndex = 0; // Default to the first payment method (Cash)
        }

        private void PopulatePaymentStatus()
        {
            cmbPaymentStatus.Items.Clear(); // Clear any existing items
            cmbPaymentStatus.Items.Add("Pending"); // Add payment status options
            cmbPaymentStatus.Items.Add("Completed");
            cmbPaymentStatus.Items.Add("Failed");
            cmbPaymentStatus.SelectedIndex = 0; // Default to "Pending" payment status
        }


        // This method is called when the "Confirm Payment" button is clicked
        // This method is called when the "Confirm Payment" button is clicked
        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            try
            {
                // Connect to the database and insert the payment details
                using (var connection = DBConnection.GetConnection())
                {
                    string insertQuery = @"INSERT INTO Payment (SaleID, CustomerID, Amount, PaymentMethod, PaymentDate, PaymentStatus)
                                  VALUES (@SaleID, @CustomerID, @Amount, @PaymentMethod, GETDATE(), @PaymentStatus)";

                    using (var cmd = new SqlCommand(insertQuery, connection))
                    {
                        // Adding parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@SaleID", SaleID);
                        cmd.Parameters.AddWithValue("@CustomerID", CustomerId);
                        cmd.Parameters.AddWithValue("@Amount", TotalAmount);
                        cmd.Parameters.AddWithValue("@PaymentMethod", cmbPaymentMethod.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@PaymentStatus", cmbPaymentStatus.SelectedItem.ToString()); // Adding PaymentStatus

                        // Open the connection and execute the insert command
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                // Notify the user that the payment was successful
                MessageBox.Show("Payment Successful. Thank you for your purchase!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Open the report Dashboard form
                AdminDashboardForm rep = new AdminDashboardForm();
                rep.Show();  // Show the report Dashboard form
                this.Hide();  // Hide the current report form
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show($"Error processing payment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        // Cancel Payment and go back to the previous form
        private void btnCancelPayment_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the PaymentForm
        }

        private void lblPaymentID_Click(object sender, EventArgs e)
        {

        }

        private void lblSaleID_Click(object sender, EventArgs e)
        {

        }

        private void lblCustomerID_Click(object sender, EventArgs e)
        {

        }

        private void lblPaymentDate_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalAmount_Click(object sender, EventArgs e)
        {

        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPaymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
