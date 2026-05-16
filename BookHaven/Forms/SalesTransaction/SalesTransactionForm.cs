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
using BookHaven.Forms.Admin;

namespace BookHaven.Forms.SalesTransaction
{
    public partial class SalesTransactionForm : Form
    {
        private string connectionString = @"Server=DULANGI;Database=BookHavenDB;Trusted_Connection=True;TrustServerCertificate=true;";
        public SalesTransactionForm()
        {
            InitializeComponent();
        }

        public class SalesTransaction
        {
            public int TransactionID { get; set; }
            public int CustomerID { get; set; }
            public DateTime TransactionDate { get; set; }
            public decimal TotalAmount { get; set; }
            public string PaymentDetails { get; set; }
        }

        private void SalesTransactionForm_Load(object sender, EventArgs e)
        {
            PopulateCustomerComboBox();
            PopulatePaymentComboBox();
            PopulateDataGridView();
        }

        // Populate Customer ComboBox with customer names from the database
        private void PopulateCustomerComboBox()
        {
            var customers = GetCustomersFromDatabase();
            comboBoxCustomers.DisplayMember = "Name";  // Show customer names in the ComboBox
            comboBoxCustomers.ValueMember = "CustomerID";  // Store CustomerID behind the scenes
            comboBoxCustomers.DataSource = customers;
        }

        // Get list of customers from the database
        private List<CustomerModel> GetCustomersFromDatabase()
        {
            var customers = new List<CustomerModel>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT CustomerID, Name FROM Customers";  // Select CustomerID and Name
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    customers.Add(new CustomerModel
                    {
                        CustomerID = (int)reader["CustomerID"],
                        Name = reader["Name"].ToString()
                    });
                }
            }
            return customers;
        }

        // Populate Payment ComboBox with 'Cash' and 'Credit Card'
        private void PopulatePaymentComboBox()
        {
            cmbPayment.Items.Add("Cash");
            cmbPayment.Items.Add("Credit Card");
            cmbPayment.SelectedIndex = 0; // Default to "Cash"
        }

        // Populate Customer ComboBox with customers from the database
        private void PopulateComboBoxCustomers()
        {
            var customers = GetCustomers();
            comboBoxCustomers.DataSource = customers;
            comboBoxCustomers.DisplayMember = "CustomerName"; // The property to display in ComboBox
            comboBoxCustomers.ValueMember = "CustomerID";    // The value associated with the selected item
            comboBoxCustomers.SelectedIndex = -1; // Optionally reset the selection to default
        }

        // Get Customers from the database
        private List<CustomerModel> GetCustomers()
        {
            var customers = new List<CustomerModel>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT CustomerID, CustomerName FROM Customers";  // Assuming "Customers" table has "CustomerID" and "CustomerName"
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    customers.Add(new CustomerModel
                    {
                        CustomerID = (int)reader["CustomerID"],
                    });
                }
            }
            return customers;
        }

        // Populate DataGridView with transactions from database
        private void PopulateDataGridView()
        {
            var transactions = GetSalesTransactions();
            dataGridViewTransactions.DataSource = transactions;
        }

        // Get Sales Transactions from the database
        private List<SalesTransaction> GetSalesTransactions()
        {
            var transactions = new List<SalesTransaction>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM SalesTransactions";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    transactions.Add(new SalesTransaction
                    {
                        TransactionID = (int)reader["TransactionID"],
                        CustomerID = (int)reader["CustomerID"],
                        TransactionDate = (DateTime)reader["TransactionDate"],
                        TotalAmount = (decimal)reader["TotalAmount"],
                        PaymentDetails = reader["PaymentDetails"].ToString()
                    });
                }
            }
            return transactions;
        }

        // Save Button Click Event: Save a new sales transaction to the database
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTotalAmount.Text))
            {
                MessageBox.Show("Please enter the total amount.");
                return;
            }

            var transaction = new SalesTransaction
            {
                CustomerID = (int)comboBoxCustomers.SelectedValue, // Get CustomerID from ComboBox selection
                TransactionDate = dateTimePickerTransactionDate.Value,
                TotalAmount = Convert.ToDecimal(txtTotalAmount.Text),
                PaymentDetails = cmbPayment.SelectedItem.ToString()
            };

            InsertSalesTransaction(transaction);
            MessageBox.Show("Transaction saved successfully.");
            PopulateDataGridView(); // Refresh DataGridView
        }

        // Insert Sales Transaction into the database
        private void InsertSalesTransaction(SalesTransaction transaction)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO SalesTransactions (CustomerID, TransactionDate, TotalAmount, PaymentDetails) " +
                               "VALUES (@CustomerID, @TransactionDate, @TotalAmount, @PaymentDetails)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", transaction.CustomerID);
                command.Parameters.AddWithValue("@TransactionDate", transaction.TransactionDate);
                command.Parameters.AddWithValue("@TotalAmount", transaction.TotalAmount);
                command.Parameters.AddWithValue("@PaymentDetails", transaction.PaymentDetails);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        //Clears all form fields
        private void btnCancel_Click(object sender, EventArgs e)
        {
            comboBoxCustomers.SelectedIndex = -1; // Clear ComboBox selection
            dateTimePickerTransactionDate.Value = DateTime.Now;
            txtTotalAmount.Clear();
            cmbPayment.SelectedIndex = 0; // Reset to Cash
        }

        // Search for transactions based on customer name or customer ID
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.Trim();  // Get the search query from the TextBox

            if (string.IsNullOrEmpty(searchQuery))
            {
                MessageBox.Show("Please enter a customer name or ID to search.");
                return;
            }

            // Search for transactions by CustomerID or CustomerName
            var filteredTransactions = SearchSalesTransactions(searchQuery);

            if (filteredTransactions.Count == 0)
            {
                MessageBox.Show("No transactions found for the given customer.");
            }

            dataGridViewTransactions.DataSource = filteredTransactions;  // Display the filtered transactions in DataGridView
        }

        // Search for Sales Transactions based on customer name or customer ID
        private List<SalesTransaction> SearchSalesTransactions(string query)
        {
            var transactions = new List<SalesTransaction>();

            // Query to search for Customer by CustomerID or Customer Name
            string searchQuery = "SELECT st.TransactionID, st.CustomerID, st.TransactionDate, st.TotalAmount, st.PaymentDetails " +
                                 "FROM SalesTransactions st " +
                                 "JOIN Customers c ON st.CustomerID = c.CustomerID " +
                                 "WHERE c.CustomerID LIKE @Query OR c.Name LIKE @Query";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(searchQuery, connection);
                command.Parameters.AddWithValue("@Query", "%" + query + "%");

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    transactions.Add(new SalesTransaction
                    {
                        TransactionID = (int)reader["TransactionID"],
                        CustomerID = (int)reader["CustomerID"],
                        TransactionDate = (DateTime)reader["TransactionDate"],
                        TotalAmount = (decimal)reader["TotalAmount"],
                        PaymentDetails = reader["PaymentDetails"].ToString()
                    });
                }
            }

            return transactions;
        }

        //Clears the search filter
        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            PopulateDataGridView(); // Refresh DataGridView
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
            AdminDashboardForm sup = new AdminDashboardForm();
            sup.Show();
            this.Hide();
        }
    }
}
