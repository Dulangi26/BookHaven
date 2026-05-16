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
using BookHaven.Utils;
using BookHaven.Database;
using BookHaven.Forms.Admin;
using BookHaven.Forms.Login;

namespace BookHaven.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            // Populate the ComboBox with role options (Admin, User, etc.)
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Sales Clerk");
            cmbRole.SelectedIndex = 1; // Set default role to 'User'
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Collect user input
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            string role = cmbRole.SelectedItem.ToString(); // Get selected role

            // Validation checks
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password are required.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Ensure that username and password are not null or empty
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password cannot be empty.");
                return;
            }

            // Save to the database 
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password); // Directly store the password
                    cmd.Parameters.AddWithValue("@Role", role); // Store the selected role

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registration successful!");
                        FrmLogin log = new FrmLogin();
                        log.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the textboxes and reset the role selection
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            cmbRole.SelectedIndex = 1; // Reset role to 'User'
        }
    }
}
