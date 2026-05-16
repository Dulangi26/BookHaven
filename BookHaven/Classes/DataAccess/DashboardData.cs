using System;
using Microsoft.Data.SqlClient;
using BookHaven.Database;
using System.Data;
using System.Windows.Forms;

namespace BookHaven.Classes.DataAccess
{
    public class DashboardData
    {
        // Remove the dbConnection field as we no longer need an instance
        public DashboardData()
        {
            // No need to instantiate DBConnection
        }

        // Get Total Books
        public int GetTotalBooks()
        {
            using (SqlConnection conn = DBConnection.GetConnection())  // Static call
            {
                string query = "SELECT COUNT(*) FROM Books";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                var result = cmd.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToInt32(result) : 0;  // Safe handling of DBNull
            }
        }

        // Get Total Customers
        public int GetTotalCustomers()
        {
            using (SqlConnection conn = DBConnection.GetConnection())  // Static call
            {
                string query = "SELECT COUNT(*) FROM Customers";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                var result = cmd.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToInt32(result) : 0;  // Safe handling of DBNull
            }
        }

        // Get Total Sales Revenue
        public decimal GetTotalSalesRevenue()
        {
            using (SqlConnection conn = DBConnection.GetConnection())  // Static call
            {
                string query = "SELECT ISNULL(SUM(TotalAmount), 0) FROM Sales";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                var result = cmd.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToDecimal(result) : 0m;  // Safe handling of DBNull
            }
        }

        // Get Low Stock Alert Count
        public int GetLowStockCount(int threshold = 5)
        {
            using (SqlConnection conn = DBConnection.GetConnection())  // Static call
            {
                string query = "SELECT COUNT(*) FROM Books WHERE StockQuantity < @Threshold";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Threshold", threshold);
                conn.Open();
                var result = cmd.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToInt32(result) : 0;  // Safe handling of DBNull
            }
        }
    }
}
