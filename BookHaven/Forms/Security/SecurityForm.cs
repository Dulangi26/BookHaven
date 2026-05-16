using System;
using System.Data;
using System.Windows.Forms;
using BookHaven.Classes.BusinessLogic;
using BookHaven.Classes.Models;
using BookHaven.Forms.Admin;

namespace BookHaven.Forms.Security
{
    public partial class SecurityForm : Form
    {
        private int selectedUserID = 0;

        public SecurityForm()
        {
            InitializeComponent();
        }

        private void SecurityForm_Load(object sender, EventArgs e)
        {
            LoadUserData();
            LoadRoles();
        }

        // Load users into DataGridView
        private void LoadUserData()
        {
            try
            {
                DataTable users = UserManager.GetAllUsers();
                dgvUsers.DataSource = users;

                dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvUsers.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message);
            }
        }

        // Load roles
        private void LoadRoles()
        {
            cmbRole.Items.Clear();
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("SalesClerk");
            cmbRole.SelectedIndex = -1;
        }

        // ADD USER
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                var user = new UserModel
                {
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    Role = cmbRole.SelectedItem?.ToString() ?? ""
                };

                UserManager.AddUser(user);

                MessageBox.Show("User added successfully!");
                LoadUserData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding user: " + ex.Message);
            }
        }

        // EDIT USER
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (selectedUserID <= 0)
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            if (!ValidateInput()) return;

            try
            {
                var user = new UserModel
                {
                    UserID = selectedUserID,
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    Role = cmbRole.SelectedItem?.ToString() ?? ""
                };

                UserManager.UpdateUser(user);

                MessageBox.Show("User updated successfully!");
                LoadUserData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message);
            }
        }

        // DELETE USER
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (selectedUserID <= 0)
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            var result = MessageBox.Show(
                "Are you sure you want to delete this user?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    UserManager.DeleteUser(selectedUserID);

                    MessageBox.Show("User deleted successfully!");
                    LoadUserData();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting user: " + ex.Message);
                }
            }
        }

        // DATA GRID CLICK
        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

            if (row.Cells["UserID"].Value != null)
            {
                selectedUserID = Convert.ToInt32(row.Cells["UserID"].Value);
            }

            txtUsername.Text = row.Cells["Username"].Value?.ToString();
            txtPassword.Text = row.Cells["Password"].Value?.ToString();
            cmbRole.SelectedItem = row.Cells["Role"].Value?.ToString();
        }

        // CLEAR FIELDS
        private void ClearFields()
        {
            selectedUserID = 0;
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
        }

        // VALIDATION
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Enter username.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Enter password.");
                return false;
            }

            if (cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Select a role.");
                return false;
            }

            return true;
        }

        // EXIT
        private void btnExit_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
                this.Close();
        }

        // BACK
        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboardForm form = new AdminDashboardForm();
            form.Show();
            this.Hide();
        }
    }
}