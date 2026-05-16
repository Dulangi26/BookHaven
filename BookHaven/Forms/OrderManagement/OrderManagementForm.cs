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
using BookHaven.Forms.Admin;

namespace BookHaven.Forms.OrderManagement
{
    public partial class OrderManagementForm : Form
    {
        public OrderManagementForm()
        {
            InitializeComponent();
            LoadAllOrders();
        }

        private void LoadBooks()
        {
            var books = OrderDataAccess.LoadBooks();
            cmbBooks.DataSource = books;
            cmbBooks.DisplayMember = "Title";  // Title is displayed
            cmbBooks.ValueMember = "BookId";  // BookId is used as the actual value
        }

        private void LoadCustomers()
        {
            var customers = OrderDataAccess.LoadCustomers();
            cmbCustomer.DataSource = customers;
            cmbCustomer.DisplayMember = "Name";  // Name is displayed
            cmbCustomer.ValueMember = "CustomerID";  // CustomerID is used as the actual value
        }


        // Load all orders into the DataGridView
        private void LoadAllOrders()
        {
            string query = @"
        SELECT o.OrderId, c.Name AS CustomerName, c.CustomerId, b.Title AS BookTitle, b.BookId,
               o.Quantity, o.OrderStatus, o.OrderDate
        FROM Orders o
        JOIN Customers c ON o.CustomerId = c.CustomerId
        JOIN Books b ON o.BookId = b.BookId";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable ordersTable = new DataTable();
                    adapter.Fill(ordersTable);
                    dgvOrders.DataSource = ordersTable;
                }
            }
        }


        private void LoadOrderStatusOptions()
        {
            cmbOrderStatus.Items.Clear();
            cmbOrderStatus.Items.AddRange(new string[] { "Pending", "Processing", "Shipped", "Completed", "Cancelled" });
            cmbOrderStatus.SelectedIndex = 0; // Default selection
        }

        private void UpdateOrder(int orderId)
        {
            int customerId = (int)cmbCustomer.SelectedValue;
            int bookId = (int)cmbBooks.SelectedValue;
            int quantity = Convert.ToInt32(txtQuantity.Text);
            string orderStatus = cmbOrderStatus.Text;

            OrderDataAccess.UpdateOrder(orderId, customerId, bookId, quantity, orderStatus);
            MessageBox.Show("Order updated successfully!");
        }

        private void OrderManagementForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadCustomers();
            LoadOrderStatusOptions();
        }

        // Input Validation for Order Form
        private bool ValidateOrderInput()
        {
            if (cmbCustomer.SelectedIndex == -1 || cmbBooks.SelectedIndex == -1 ||
                string.IsNullOrEmpty(txtQuantity.Text) || cmbOrderStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        // Clear Form Fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbCustomer.SelectedIndex = -1;
            cmbBooks.SelectedIndex = -1;
            txtQuantity.Clear();
            cmbOrderStatus.SelectedIndex = -1;
            lblTotalAmount.Text = "Rs. 0.00"; // Reset total amount as well
        }


        // Add Order Button Click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateOrderInput())
            {
                int customerId = Convert.ToInt32(cmbCustomer.SelectedValue);
                int bookId = Convert.ToInt32(cmbBooks.SelectedValue);
                int quantity = Convert.ToInt32(txtQuantity.Text);
                string orderStatus = cmbOrderStatus.SelectedItem.ToString();
                DateTime orderDate = dtpOrderDate.Value;

                OrderDataAccess.AddOrder(customerId, bookId, quantity, orderStatus, orderDate);
                MessageBox.Show("Order added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllOrders();
            }
        }

        // Edit Order Button Click
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateOrderInput() && dgvOrders.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["OrderId"].Value);
                int customerId = Convert.ToInt32(cmbCustomer.SelectedValue);
                int bookId = Convert.ToInt32(cmbBooks.SelectedValue);
                int quantity = Convert.ToInt32(txtQuantity.Text);
                string orderStatus = cmbOrderStatus.SelectedItem.ToString();

                OrderDataAccess.UpdateOrder(orderId, customerId, bookId, quantity, orderStatus);
                MessageBox.Show("Order updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllOrders();
            }
        }

        // Delete Order Button Click
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["OrderId"].Value);
                var confirmDelete = MessageBox.Show($"Are you sure you want to delete Order ID: {orderId}?",
                    "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmDelete == DialogResult.Yes)
                {
                    OrderDataAccess.DeleteOrder(orderId);
                    MessageBox.Show("Order deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllOrders();
                }
            }
        }

        // Calculate Total Button Click
        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            if (cmbBooks.SelectedIndex != -1 && int.TryParse(txtQuantity.Text, out int quantity))
            {
                int bookId = Convert.ToInt32(cmbBooks.SelectedValue);
                decimal totalAmount = OrderDataAccess.CalculateTotalAmount(bookId, quantity);
                lblTotalAmount.Text = $"Rs. {totalAmount:F2}";
            }
            else
            {
                MessageBox.Show("Please select a book and enter a valid quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // DataGridView Cell Click Event
        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOrders.Rows[e.RowIndex];

                // Convert the displayed text (name/title) back to the corresponding ID (CustomerId/BookId)
                int customerId = (int)row.Cells["CustomerId"].Value;
                int bookId = (int)row.Cells["BookId"].Value;

                // Assign values to controls using the selected row values
                cmbCustomer.SelectedValue = customerId;  // Set the CustomerId as the selected value
                cmbBooks.SelectedValue = bookId;  // Set the BookId as the selected value
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                cmbOrderStatus.SelectedItem = row.Cells["OrderStatus"].Value.ToString();
            }
        }



        private void btnProceedToNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(lblTotalAmount.Text.Replace("Rs. ", ""), out decimal totalAmount))
                {
                    MessageBox.Show("Invalid total amount. Please calculate the total first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int customerId = Convert.ToInt32(cmbCustomer.SelectedValue);
                int bookId = Convert.ToInt32(cmbBooks.SelectedValue);
                int quantity = Convert.ToInt32(txtQuantity.Text);
                string orderStatus = "Pending"; // Default status

                OrderConfirmationForm confirmationForm = new OrderConfirmationForm(customerId, bookId, quantity, totalAmount, orderStatus);
                confirmationForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error proceeding to the confirmation form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var confirmExit = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                string query = @"
                    SELECT o.OrderId, c.Name AS CustomerName, b.Title AS BookTitle,
                           o.Quantity, o.OrderStatus, o.OrderDate
                    FROM Orders o
                    JOIN Customers c ON o.CustomerId = c.CustomerId
                    JOIN Books b ON o.BookId = b.BookId
                    WHERE c.Name LIKE @SearchText OR b.Title LIKE @SearchText";

                using (SqlConnection conn = DBConnection.GetConnection())
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchText", $"%{searchText}%");
                    DataTable searchResults = new DataTable();
                    adapter.Fill(searchResults);
                    dgvOrders.DataSource = searchResults;
                }
            }
            else
            {
                MessageBox.Show("Please enter text to search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadAllOrders();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboardForm sup = new AdminDashboardForm();
            sup.Show();
            this.Hide();
        }
    }
}
