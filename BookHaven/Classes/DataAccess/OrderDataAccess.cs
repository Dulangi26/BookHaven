using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using BookHaven.Classes.Models;

namespace BookHaven.Database
{
    public static class OrderDataAccess
    {
        // Method to calculate the total amount based on BookId and Quantity
        public static decimal CalculateTotalAmount(int bookId, int quantity)
        {
            decimal price = 0;

            // Fetch the book's price using the bookId (you might have to retrieve it from the database)
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "SELECT Price FROM Books WHERE BookID = @BookId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BookId", bookId);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        price = Convert.ToDecimal(result);
                    }
                }
            }

            return price * quantity;
        }

        // Method to get the price of the book (Example)
        private static decimal GetBookPrice(int bookId)
        {
            // Assuming you have a method to get the price from the database or a static value for simplicity
            decimal price = 20.0m; // Placeholder price
            return price;
        }

        // Method to retrieve all orders
        public static List<OrderModel> GetAllOrders()
        {
            List<OrderModel> orders = new List<OrderModel>();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "SELECT OrderId, CustomerId, BookId, Quantity, OrderStatus, OrderDate FROM Orders";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrderModel order = new OrderModel
                            {
                                OrderId = reader.GetInt32(0),
                                CustomerId = reader.GetInt32(1),
                                BookId = reader.GetInt32(2),
                                Quantity = reader.GetInt32(3),
                                OrderStatus = reader.GetString(4),
                                OrderDate = reader.GetDateTime(5)
                            };
                            orders.Add(order);
                        }
                    }
                }
            }

            return orders;
        }

        // Method to search orders by customer name or ID
        public static List<OrderModel> SearchOrders(string searchTerm)
        {
            List<OrderModel> orders = new List<OrderModel>();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "SELECT o.OrderId, o.CustomerId, o.BookId, o.Quantity, o.OrderStatus, o.OrderDate " +
                               "FROM Orders o " +
                               "INNER JOIN Customers c ON o.CustomerID = c.CustomerId " +
                               "WHERE c.Name LIKE @SearchTerm OR c.CustomerId = @SearchTerm";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrderModel order = new OrderModel
                            {
                                OrderId = reader.GetInt32(0),
                                CustomerId = reader.GetInt32(1),
                                BookId = reader.GetInt32(2),
                                Quantity = reader.GetInt32(3),
                                OrderStatus = reader.GetString(4),
                                OrderDate = reader.GetDateTime(5)
                            };
                            orders.Add(order);
                        }
                    }
                }
            }

            return orders;
        }

        // Method to load customer details
        public static List<CustomerModel> LoadCustomers()
        {
            List<CustomerModel> customers = new List<CustomerModel>();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "SELECT CustomerID, Name, Contact, Email FROM Customers";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customers.Add(new CustomerModel
                            {
                                CustomerID = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Contact = reader.GetString(2),
                                Email = reader.GetString(3)
                            });
                        }
                    }
                }
            }

            return customers;
        }


        // Method to load book details
        public static List<BookModel> LoadBooks()
        {
            List<BookModel> books = new List<BookModel>();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "SELECT BookID, Title, Author, Price, StockQuantity FROM Books";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(new BookModel
                            {
                                BookID = reader.GetInt32(0),
                                Title = reader.GetString(1),
                                Author = reader.GetString(2),
                                Price = reader.GetDecimal(3),
                                StockQuantity = reader.GetInt32(4)
                            });
                        }
                    }
                }
            }

            return books;
        }


        // Method to add a new order
        public static void AddOrder(int customerId, int bookId, int quantity, string orderStatus, DateTime orderDate)
        {
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    string query = @"INSERT INTO Orders (CustomerId, BookId, Quantity, OrderStatus, OrderDate) 
                             VALUES (@CustomerId, @BookId, @Quantity, @OrderStatus, @OrderDate)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerId", customerId);
                        cmd.Parameters.AddWithValue("@BookId", bookId);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@OrderStatus", orderStatus);
                        cmd.Parameters.AddWithValue("@OrderDate", orderDate);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Method to update an order
        public static void UpdateOrder(int orderId, int customerId, int bookId, int quantity, string orderStatus)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"UPDATE Orders 
                         SET CustomerId = @CustomerId, 
                             BookId = @BookId, 
                             Quantity = @Quantity, 
                             OrderStatus = @OrderStatus
                         WHERE OrderId = @OrderId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderId", orderId);
                    cmd.Parameters.AddWithValue("@CustomerId", customerId);
                    cmd.Parameters.AddWithValue("@BookId", bookId);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@OrderStatus", orderStatus);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }


        // Delete Order
        public static bool DeleteOrder(int orderId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "DELETE FROM Orders WHERE OrderId = @OrderId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderId", orderId);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
