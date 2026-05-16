using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven.Classes.BusinessLogic;
using BookHaven.Classes.Models;
using Microsoft.Data.SqlClient;
using BookHaven.Database;
using BookHaven.Forms.Admin;

namespace BookHaven.Forms.Security
{
    public partial class SecurityForm : Form
    {
        private int selectedUserID; // Store selected UserID from DataGridView

        public SecurityForm()
        {
            InitializeComponent();
            LoadUserData();
        }

        // Load user data into DataGridView
        private void LoadUserData()
        {
            try
            {
                DataTable users = UserManager.GetAllUsers();
                dgvUsers.DataSource = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message);
            }
        }
        private void SecurityForm_Load(object sender, EventArgs e)
        {
            LoadUserData();
            LoadRoles();
        }

        // Load roles into cmbRole
        private void LoadRoles()
        {
            cmbRole.Items.Clear();  // Clear any existing items to avoid duplicates
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("SalesClerk");
            cmbRole.SelectedIndex = -1; // No item selected by default
        }


        // Add User
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var user = new UserModel
                {
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    Role = cmbRole.SelectedItem?.ToString()
                };

                try
                {
                    UserManager.AddUser(user);
                    MessageBox.Show("User added successfully!");
                    LoadUserData();  // Refresh the user list
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding user: " + ex.Message);
                }
            }
        }

        // Edit User
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (selectedUserID > 0 && ValidateInput())
            {
                var user = new UserModel
                {
                    UserID = selectedUserID,
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    Role = cmbRole.SelectedItem?.ToString()
                };

                try
                {
                    UserManager.UpdateUser(user);
                    MessageBox.Show("User updated successfully!");
                    LoadUserData();
                    ClearFields(); // Reset selectedUserID after editing
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid user to edit.");
            }
        }




        // Delete User
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (selectedUserID > 0)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this user?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        UserManager.DeleteUser(selectedUserID);
                        MessageBox.Show("User deleted successfully!");
                        LoadUserData();
                        ClearFields(); // Reset selectedUserID after deletion
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting user: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a valid user to delete.");
            }
        }

        // DataGridView Row Click - Populate Data in Textboxes
        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

                // Ensure column names match DataGridView column names
                if (row.Cells["UserID"].Value != null)
                {
                    selectedUserID = Convert.ToInt32(row.Cells["UserID"].Value);
                }
                txtUsername.Text = row.Cells["Username"].Value?.ToString();
                cmbRole.SelectedItem = row.Cells["Role"].Value?.ToString();
            }
        }


        // Clear input fields
        private void ClearFields()
        {
            selectedUserID = 0;
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
        }

        // Input Validation
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter a username.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter a password.");
                return false;
            }
            if (cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a user role.");
                return false;
            }
            return true;
        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRole.SelectedIndex != -1)
            {
                MessageBox.Show($"Selected Role: {cmbRole.SelectedItem.ToString()}");
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboardForm sup = new AdminDashboardForm();
            sup.Show();
            this.Hide();
        }
    }
}

    

