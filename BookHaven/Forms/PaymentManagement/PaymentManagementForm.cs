using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven.Classes.DataAccess;
using BookHaven.Classes.Models;
using BookHaven.Forms.Admin;

namespace BookHaven.Forms.PaymentManagement
{
    public partial class PaymentManagementForm : Form
    {
        public PaymentManagementForm()
        {
            InitializeComponent();
            LoadPayments();
        }

        private void PaymentManagementForm_Load(object sender, EventArgs e)
        {
            // Load combo box data
            LoadComboBoxes();

            // Load payments into DataGridView
            LoadPayments();
        }

        private void LoadComboBoxes()
        {
            // These can be fetched from the database or predefined
            cmbPaymentMethod.Items.Clear();
            cmbPaymentMethod.Items.Add("Credit Card");
            cmbPaymentMethod.Items.Add("Cash");
            cmbPaymentMethod.Items.Add("Bank Transfer");

            cmbPaymentStatus.Items.Clear();
            cmbPaymentStatus.Items.Add("Completed");
            cmbPaymentStatus.Items.Add("Pending");
            cmbPaymentStatus.Items.Add("Failed");
        }

        // Load Payments into DataGridView
        private void LoadPayments()
        {
            dgvPayments.AutoGenerateColumns = true;
            dgvPayments.DataSource = PaymentDataAccess.GetAllPayments();
        }


        // Clear Form Fields
        private void ClearFields()
        {
            txtPaymentID.Clear();
            txtSaleID.Clear();
            txtCustomerID.Clear();
            dtpPaymentDate.Value = DateTime.Now;
            cmbPaymentMethod.SelectedIndex = -1;
            txtAmount.Clear();
            cmbPaymentStatus.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                DataTable searchResults = PaymentDataAccess.SearchPayments(searchTerm);

                if (searchResults.Rows.Count > 0)
                {
                    dgvPayments.DataSource = searchResults;
                }
                else
                {
                    MessageBox.Show("No matching records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPayments(); // Reload full data if no results found
                }
            }
            else
            {
                MessageBox.Show("Please enter a search term.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // Select Row from DataGridView
        private void dgvPayments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPayments.Rows[e.RowIndex].Cells["PaymentID"].Value != null)
            {
                DataGridViewRow row = dgvPayments.Rows[e.RowIndex];

                // Populate text fields
                txtPaymentID.Text = row.Cells["PaymentID"].Value?.ToString() ?? string.Empty;
                txtSaleID.Text = row.Cells["SaleID"].Value?.ToString() ?? string.Empty;
                txtCustomerID.Text = row.Cells["CustomerID"].Value?.ToString() ?? string.Empty;

                // Set date picker value
                DateTime.TryParse(row.Cells["PaymentDate"].Value?.ToString(), out DateTime paymentDate);
                dtpPaymentDate.Value = paymentDate != DateTime.MinValue ? paymentDate : DateTime.Now;

                // Set combo box values
                cmbPaymentMethod.Text = row.Cells["PaymentMethod"].Value?.ToString() ?? string.Empty;
                cmbPaymentStatus.Text = row.Cells["PaymentStatus"].Value?.ToString() ?? string.Empty;

                // Set amount text box
                txtAmount.Text = row.Cells["Amount"].Value?.ToString() ?? string.Empty;
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadPayments();
        }

        // Add Payment
        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var payment = new PaymentModel
                {
                    SaleID = int.Parse(txtSaleID.Text),
                    CustomerID = int.Parse(txtCustomerID.Text),
                    PaymentDate = dtpPaymentDate.Value,
                    PaymentMethod = cmbPaymentMethod.Text,
                    Amount = decimal.Parse(txtAmount.Text),
                    PaymentStatus = cmbPaymentStatus.Text
                };

                if (PaymentDataAccess.AddPayment(payment))
                {
                    MessageBox.Show("Payment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPayments();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to add payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditPayment_Click(object sender, EventArgs e)
        {
            if (ValidateInput() && !string.IsNullOrEmpty(txtPaymentID.Text))
            {
                var payment = new PaymentModel
                {
                    PaymentID = int.Parse(txtPaymentID.Text),
                    SaleID = int.Parse(txtSaleID.Text),
                    CustomerID = int.Parse(txtCustomerID.Text),
                    PaymentDate = dtpPaymentDate.Value,
                    PaymentMethod = cmbPaymentMethod.Text,
                    Amount = decimal.Parse(txtAmount.Text),
                    PaymentStatus = cmbPaymentStatus.Text
                };

                if (PaymentDataAccess.UpdatePayment(payment))
                {
                    MessageBox.Show("Payment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPayments();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to update payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeletePayment_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPaymentID.Text))
            {
                int paymentID = int.Parse(txtPaymentID.Text);

                if (PaymentDataAccess.DeletePayment(paymentID))
                {
                    MessageBox.Show("Payment deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPayments();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to delete payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Payment ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Input Validation
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtSaleID.Text) ||
                string.IsNullOrWhiteSpace(txtCustomerID.Text) ||
                string.IsNullOrWhiteSpace(txtAmount.Text) ||
                cmbPaymentMethod.SelectedIndex == -1 ||
                cmbPaymentStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtSaleID.Text, out _) || !int.TryParse(txtCustomerID.Text, out _))
            {
                MessageBox.Show("Sale ID and Customer ID must be valid integers.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtAmount.Text, out _))
            {
                MessageBox.Show("Amount must be a valid number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboardForm sup = new AdminDashboardForm();
            sup.Show();
            this.Hide();
        }
    }
}
