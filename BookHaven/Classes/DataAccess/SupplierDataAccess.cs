using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BookHaven.Classes.Models;
using Microsoft.Data.SqlClient;
using BookHaven.Database;

namespace BookHaven.Classes.DataAccess
{
    public class SupplierDataAccess
    {
        // Add Supplier
        public static bool AddSupplier(SupplierModel supplier)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "INSERT INTO Suppliers (Name, Contact, Email, Address) VALUES (@Name, @Contact, @Email, @Address)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", supplier.Name);
                    cmd.Parameters.AddWithValue("@Contact", supplier.Contact);
                    cmd.Parameters.AddWithValue("@Email", supplier.Email ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Address", supplier.Address ?? (object)DBNull.Value);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Get All Suppliers
        public static List<SupplierModel> GetAllSuppliers()
        {
            List<SupplierModel> suppliers = new List<SupplierModel>();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "SELECT * FROM Suppliers";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            suppliers.Add(new SupplierModel
                            {
                                SupplierID = Convert.ToInt32(reader["SupplierID"]),
                                Name = reader["Name"].ToString(),
                                Contact = reader["Contact"].ToString(),
                                Email = reader["Email"].ToString(),
                                Address = reader["Address"].ToString()
                            });
                        }
                    }
                }
            }

            return suppliers;
        }

        // Search Suppliers
        public static List<SupplierModel> SearchSuppliers(string searchTerm)
        {
            List<SupplierModel> suppliers = new List<SupplierModel>();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"
                    SELECT * FROM Suppliers 
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
                            suppliers.Add(new SupplierModel
                            {
                                SupplierID = Convert.ToInt32(reader["SupplierID"]),
                                Name = reader["Name"].ToString(),
                                Contact = reader["Contact"].ToString(),
                                Email = reader["Email"].ToString(),
                                Address = reader["Address"].ToString()
                            });
                        }
                    }
                }
            }

            return suppliers;
        }

        // Delete Supplier
        public static bool DeleteSupplier(int supplierID)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "DELETE FROM Suppliers WHERE SupplierID = @SupplierID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SupplierID", supplierID);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Update Supplier
        public static bool UpdateSupplier(SupplierModel supplier)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"UPDATE Suppliers 
                         SET Name = @Name, Contact = @Contact, Email = @Email, Address = @Address
                         WHERE SupplierID = @SupplierID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SupplierID", supplier.SupplierID);
                    cmd.Parameters.AddWithValue("@Name", supplier.Name);
                    cmd.Parameters.AddWithValue("@Contact", supplier.Contact);
                    cmd.Parameters.AddWithValue("@Email", supplier.Email ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Address", supplier.Address ?? (object)DBNull.Value);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

    }
}

