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
using BookHaven.Utils;
using BookHaven.Classes.Models;
using BookHaven.Classes.DataAccess;
using BookHaven.Utils.Validators;
using BookHaven.Forms.Admin;


namespace BookHaven.Forms.SupplierManagement
{
    public partial class SupplierManagementForm : Form
    {
        public SupplierManagementForm()
        {
            InitializeComponent();
            LoadSuppliers();
        }

        // Load suppliers into the DataGridView
        private void LoadSuppliers()
        {
            dgvSuppliers.DataSource = SupplierDataAccess.GetAllSuppliers();
        }

        // Load data on form load
        private void SupplierManagementForm_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }

            var searchResults = SupplierDataAccess.SearchSuppliers(searchTerm);

            if (searchResults.Count == 0)
            {
                MessageBox.Show("No matching suppliers found.");
            }

            dgvSuppliers.DataSource = searchResults;
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadSuppliers();
        }

        // Add Supplier
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            var supplier = new SupplierModel
            {
                Name = txtSupplierName.Text.Trim(),
                Contact = txtContact.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = txtAddress.Text.Trim()
            };
            if (SupplierDataAccess.AddSupplier(supplier))
            {
                MessageBox.Show("Supplier added successfully.");
                LoadSuppliers();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to add supplier.");
            }
        }

        // Edit Supplier
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            if (dgvSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a supplier to edit.");
                return;
            }

            var selectedSupplierID = Convert.ToInt32(dgvSuppliers.SelectedRows[0].Cells["SupplierID"].Value);

            var updatedSupplier = new SupplierModel
            {
                SupplierID = selectedSupplierID,
                Name = txtSupplierName.Text.Trim(),
                Contact = txtContact.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = txtAddress.Text.Trim()
            };

            if (SupplierDataAccess.UpdateSupplier(updatedSupplier))
            {
                MessageBox.Show("Supplier updated successfully.");
                LoadSuppliers();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to update supplier.");
            }
        }

        // Delete Supplier
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a supplier to delete.");
                return;
            }

            var confirmDelete = MessageBox.Show(
                "Are you sure you want to delete this supplier?",
                "Delete Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmDelete == DialogResult.Yes)
            {
                var supplierID = Convert.ToInt32(dgvSuppliers.SelectedRows[0].Cells["SupplierID"].Value);

                if (SupplierDataAccess.DeleteSupplier(supplierID))
                {
                    MessageBox.Show("Supplier deleted successfully.");
                    LoadSuppliers();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to delete supplier.");
                }
            }
        }

        // Clear Fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtSupplierName.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
        }

        // Exit
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

        // Validation Logic
        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtSupplierName.Text))
            {
                MessageBox.Show("Supplier Name is required.");
                return false;
            }

            if (!Validator.IsValidContactNumber(txtContact.Text))
            {
                MessageBox.Show("Invalid contact number. Please enter a valid 10-digit number.");
                return false;
            }

            if (!Validator.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Invalid email format.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address is required.");
                return false;
            }

            return true;
        }

        // DataGridView Selection
        private void dgvSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvSuppliers.Rows[e.RowIndex];

                txtSupplierName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtContact.Text = selectedRow.Cells["Contact"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txtAddress.Text = selectedRow.Cells["Address"].Value.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboardForm sup = new AdminDashboardForm();
            sup.Show();
            this.Hide();
        }
    }
}
