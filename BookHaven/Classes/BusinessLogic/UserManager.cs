using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using BookHaven.Database;
using System.Data;
using BookHaven.Classes.Models;


namespace BookHaven.Classes.BusinessLogic
{
    public static class UserManager
    {
    public static DataTable GetAllUsers()
        {
            DataTable dtUsers = new DataTable();

            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    string query = "SELECT UserID, Username, Password, Role FROM Users"; // Confirm all columns are here
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dtUsers);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }

            return dtUsers;
        }


        public static void AddUser(UserModel user)
    {
        using (SqlConnection conn = DBConnection.GetConnection())
        {
            string query = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Username", user.Username);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@Role", user.Role);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public static void UpdateUser(UserModel user)
    {
        using (SqlConnection conn = DBConnection.GetConnection())
        {
            string query = "UPDATE Users SET Username = @Username, Password = @Password, Role = @Role WHERE UserId = @UserId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Username", user.Username);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@Role", user.Role);
            cmd.Parameters.AddWithValue("@UserId", user.UserID);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public static void DeleteUser(int userId)
    {
        using (SqlConnection conn = DBConnection.GetConnection())
        {
            string query = "DELETE FROM Users WHERE UserId = @UserId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", userId);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
}
