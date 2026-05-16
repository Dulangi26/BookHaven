using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using BookHaven.Classes.Models;
using BookHaven.Database;

namespace BookHaven.Classes.DataAccess
{
    public static class PaymentDataAccess
    {
        // Get All Payments
        public static DataTable GetAllPayments()
        {
            using (var connection = DBConnection.GetConnection())
            {
                string query = "SELECT * FROM Payment";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dtPayment = new DataTable();
                adapter.Fill(dtPayment);
                return dtPayment;
            }
        }

        // Add Payment
        public static bool AddPayment(PaymentModel payment)
        {
            using (var connection = DBConnection.GetConnection())
            {
                string query = @"
                    INSERT INTO Payment
                    (SaleID, CustomerID, PaymentDate, PaymentMethod, Amount, PaymentStatus) 
                    VALUES (@SaleID, @CustomerID, @PaymentDate, @PaymentMethod, @Amount, @PaymentStatus)";

                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@SaleID", payment.SaleID);
                    cmd.Parameters.AddWithValue("@CustomerID", payment.CustomerID);
                    cmd.Parameters.AddWithValue("@PaymentDate", payment.PaymentDate);
                    cmd.Parameters.AddWithValue("@PaymentMethod", payment.PaymentMethod);
                    cmd.Parameters.AddWithValue("@Amount", payment.Amount);
                    cmd.Parameters.AddWithValue("@PaymentStatus", payment.PaymentStatus);

                    connection.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Update Payment
        public static bool UpdatePayment(PaymentModel payment)
        {
            using (var connection = DBConnection.GetConnection())
            {
                string query = @"
                    UPDATE Payment
                    SET SaleID = @SaleID, 
                        CustomerID = @CustomerID, 
                        PaymentDate = @PaymentDate, 
                        PaymentMethod = @PaymentMethod, 
                        Amount = @Amount, 
                        PaymentStatus = @PaymentStatus
                    WHERE PaymentID = @PaymentID";

                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@PaymentID", payment.PaymentID);
                    cmd.Parameters.AddWithValue("@SaleID", payment.SaleID);
                    cmd.Parameters.AddWithValue("@CustomerID", payment.CustomerID);
                    cmd.Parameters.AddWithValue("@PaymentDate", payment.PaymentDate);
                    cmd.Parameters.AddWithValue("@PaymentMethod", payment.PaymentMethod);
                    cmd.Parameters.AddWithValue("@Amount", payment.Amount);
                    cmd.Parameters.AddWithValue("@PaymentStatus", payment.PaymentStatus);

                    connection.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Delete Payment
        public static bool DeletePayment(int paymentID)
        {
            using (var connection = DBConnection.GetConnection())
            {
                string query = "DELETE FROM Payment WHERE PaymentID = @PaymentID";

                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@PaymentID", paymentID);
                    connection.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Search Payments by SaleID or CustomerID
        public static DataTable SearchPayments(string searchTerm)
        {
            using (var connection = DBConnection.GetConnection())
            {
                string query = @"
            SELECT * FROM Payment
            WHERE CONVERT(NVARCHAR, SaleID) LIKE @SearchTerm
            OR CONVERT(NVARCHAR, CustomerID) LIKE @SearchTerm";

                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dtSearchResults = new DataTable();
                    adapter.Fill(dtSearchResults);
                    return dtSearchResults;
                }
            }
        }

    }
}
