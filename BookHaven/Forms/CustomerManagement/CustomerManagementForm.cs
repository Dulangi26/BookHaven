using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven.Classes.Models;
using BookHaven.Database;
using BookHaven.Forms.Admin;

namespace BookHaven.Forms.CustomerManagement
{
    public partial class CustomerManagementForm : Form
    {
        public CustomerManagementForm()
        {
            InitializeComponent();
        }

        private void CustomerManagementForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            dgvCustomers.DataSource = CustomerDataAccess.GetAllCustomers();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadCustomers();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }

            var searchResults = CustomerDataAccess.SearchCustomers(searchTerm);

            if (searchResults.Count == 0)
            {
                MessageBox.Show("No matching customers found.");
            }

            dgvCustomers.DataSource = searchResults;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];

                txtCustomerID.Text = row.Cells["CustomerID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtContact.Text = row.Cells["Contact"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }

        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtContact.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            CustomerModel customer = new CustomerModel
            {
                Name = txtName.Text,
                Contact = txtContact.Text,
                Email = txtEmail.Text
            };

            CustomerDataAccess.AddCustomer(customer);
            LoadCustomers();
            ClearFields();
            MessageBox.Show("Customer added successfully.");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerID.Text))
            {
                MessageBox.Show("Please select a customer to edit.");
                return;
            }

            CustomerModel customer = new CustomerModel
            {
                CustomerID = Convert.ToInt32(txtCustomerID.Text),
                Name = txtName.Text,
                Contact = txtContact.Text,
                Email = txtEmail.Text
            };

            CustomerDataAccess.EditCustomer(customer);
            LoadCustomers();
            ClearFields();
            MessageBox.Show("Customer updated successfully.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtCustomerID.Clear();
            txtName.Clear();
            txtContact.Clear();
            txtEmail.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerID.Text))
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }

            int customerId = Convert.ToInt32(txtCustomerID.Text);

            CustomerDataAccess.DeleteCustomer(customerId);
            LoadCustomers();
            ClearFields();
            MessageBox.Show("Customer deleted successfully.");
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
