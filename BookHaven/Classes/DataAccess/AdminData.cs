using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using BookHaven.Classes.Models;
using BookHaven.Database;

namespace BookHaven.Classes.DataAccess
{
    public class AdminData
    {
        // Load Admin Data for DataGridView
        public List<UserModel> GetAllAdmins()
        {
            List<UserModel> adminList = new List<UserModel>();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "SELECT UserID, Username, Role, Password FROM Users";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        adminList.Add(new UserModel
                        {
                            UserID = Convert.ToInt32(reader["UserID"]),
                            Username = reader["Username"].ToString(),
                            Role = reader["Role"].ToString(),
                            Password = reader["Password"].ToString()
                        });
                    }
                }
            }

            return adminList;
        }

        // Add New Admin
        public bool AddAdmin(string username, string password, string role)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Role", role);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;  // Return true if insertion is successful
            }
        }

        // Edit Admin Details
        public bool EditAdmin(int userId, string username, string password, string role)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "UPDATE Users SET Username = @Username, Password = @Password, Role = @Role WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Role", role);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Delete Admin
        public bool DeleteAdmin(int userId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "DELETE FROM Users WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}

