using System;
using System.Collections.Generic;
using System.Data;
using BookHaven.Classes.Models;
using Microsoft.Data.SqlClient;

namespace BookHaven.Database
{
    public static class CustomerDataAccess
    {
        // Retrieve all customers
        public static List<CustomerModel> GetAllCustomers()
        {
            List<CustomerModel> customers = new List<CustomerModel>();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "SELECT * FROM Customers";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customers.Add(new CustomerModel
                            {
                                CustomerID = Convert.ToInt32(reader["CustomerID"]),
                                Name = reader["Name"].ToString(),
                                Contact = reader["Contact"].ToString(),
                                Email = reader["Email"].ToString()
                            });
                        }
                    }
                }
            }

            return customers;
        }

        // Add a new customer
        public static void AddCustomer(CustomerModel customer)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "INSERT INTO Customers (Name, Contact, Email) VALUES (@Name, @Contact, @Email)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", customer.Name);
                    cmd.Parameters.AddWithValue("@Contact", customer.Contact);
                    cmd.Parameters.AddWithValue("@Email", customer.Email);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Edit customer details
        public static void EditCustomer(CustomerModel customer)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "UPDATE Customers SET Name = @Name, Contact = @Contact, Email = @Email WHERE CustomerID = @CustomerID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customer.CustomerID);
                    cmd.Parameters.AddWithValue("@Name", customer.Name);
                    cmd.Parameters.AddWithValue("@Contact", customer.Contact);
                    cmd.Parameters.AddWithValue("@Email", customer.Email);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Delete customer
        public static void DeleteCustomer(int customerId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Search customers based on name, contact, or email
        public static List<CustomerModel> SearchCustomers(string searchTerm)
        {
            List<CustomerModel> customers = new List<CustomerModel>();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"
            SELECT * FROM Customers
            WHERE Name LIKE @SearchTerm 
            OR Contact LIKE @SearchTerm 
            OR Email LIKE @SearchTerm";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customers.Add(new CustomerModel
                            {
                                CustomerID = Convert.ToInt32(reader["CustomerID"]),
                                Name = reader["Name"].ToString(),
                                Contact = reader["Contact"].ToString(),
                                Email = reader["Email"].ToString()
                            });
                        }
                    }
                }
            }

            return customers;
        }


    }
}
