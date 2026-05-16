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
using BookHaven.Forms.SupplierManagement;


namespace BookHaven.Forms.Admin
{
    public partial class AdminControls : Form

    {
        private AdminData adminData;
        public AdminControls()
        {
            InitializeComponent();
            adminData = new AdminData(); // Initialize data access class
            LoadAdminData();            // Load data when form opens
        }

        // Load Admin Data into DataGridView
        private void LoadAdminData()
        {
            try
            {
                List<UserModel> adminList = adminData.GetAllAdmins();
                dgvAdmins.DataSource = adminList; // Bind data to DataGridView

                // Customize DataGridView column headers (Ensure correct column names)
                dgvAdmins.Columns["UserID"].HeaderText = "Admin ID";
                dgvAdmins.Columns["Username"].HeaderText = "Username";
                dgvAdmins.Columns["Role"].HeaderText = "Role";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading admin data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handle DataGridView Cell Click to populate TextBoxes and ComboBox
        private void dgvAdmins_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the user clicked on a valid row
            if (e.RowIndex >= 0)
            {
                txtUsername.Text = dgvAdmins.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                cmbRole.SelectedItem = dgvAdmins.Rows[e.RowIndex].Cells["Role"].Value.ToString(); // Set ComboBox role selection
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate form fields
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter a username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter a password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbRole.SelectedItem?.ToString()))
            {
                MessageBox.Show("Please select a role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (adminData.AddAdmin(username, password, role))
            {
                MessageBox.Show($"{role} added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAdminData();  // Refresh DataGridView
            }
            else
            {
                MessageBox.Show($"Failed to add {role}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected in DataGridView
            if (dgvAdmins.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an admin to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate form fields
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter a username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter a password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbRole.SelectedItem?.ToString()))
            {
                MessageBox.Show("Please select a role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = Convert.ToInt32(dgvAdmins.SelectedRows[0].Cells["UserID"].Value);
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (adminData.EditAdmin(userId, username, password, role))
            {
                MessageBox.Show($"{role} details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAdminData();  // Refresh DataGridView
            }
            else
            {
                MessageBox.Show($"Failed to update {role} details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAdmins.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an admin to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = Convert.ToInt32(dgvAdmins.SelectedRows[0].Cells["UserID"].Value);

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this admin?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                if (adminData.DeleteAdmin(userId))
                {
                    MessageBox.Show("Admin deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAdminData();  // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to delete admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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


        private void AdminControls_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboardForm sup = new AdminDashboardForm();
            sup.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear textboxes
            txtUsername.Clear();
            txtPassword.Clear();

            // Clear combo box
            cmbRole.SelectedIndex = -1;  
            dgvAdmins.ClearSelection();
        }
    }
}
