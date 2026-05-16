using System;
using System.Windows.Forms;
using BookHaven.Classes.DataAccess;
using BookHaven.Classes.Models;
using BookHaven.Forms.Admin;
using BookHaven.Forms.SalesTransaction;
using BookHaven.Forms.Security; // make sure this exists

namespace BookHaven.Forms.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent(); // MUST be here
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // Optional settings
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.",
                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                UserModel? user = UserDataAccess.ValidateUser(username, password);

                if (user != null)
                {
                    if (user.Role != null &&
                        user.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                    {
                        AdminDashboardForm adminDashboard = new AdminDashboardForm();
                        adminDashboard.Show();
                        adminDashboard.FormClosed += (s, args) => this.Close();
                    }
                    else if (user.Role != null &&
                             user.Role.Equals("SalesClerk", StringComparison.OrdinalIgnoreCase))
                    {
                        SalesDashboardForm salesDashboard = new SalesDashboardForm();
                        salesDashboard.Show();
                        salesDashboard.FormClosed += (s, args) => this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid user role.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.",
                        "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}",
                    "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm register = new RegistrationForm();
            register.Show();
            this.Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Leave empty (required by designer)
        }
    }
}