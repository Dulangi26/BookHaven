using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BookHaven.Utils.Extensions
{
    public static class DBExtensions
    {
        // Connection string for MS SQL Database
        private static readonly string connectionString =
            @"Server=DULANGI;Database=BookHavenDB;Trusted_Connection=True;TrustServerCertificate=true;";

        // Method to get SQL Connection
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Method to test the database connection
        public static void TestConnection()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Database connection successful!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database connection failed:\n{ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}