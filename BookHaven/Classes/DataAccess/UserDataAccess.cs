using System;
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using BookHaven.Classes.Models;
using BookHaven.Utils.Extensions;
using System.Windows.Forms; 

namespace BookHaven.Classes.DataAccess
{
    public class UserDataAccess
    {
        public static UserModel? ValidateUser(string username, string enteredPassword)
        {
            try
            {
                using (var connection = DBExtensions.GetConnection())
                {
                    string query = @"
                        SELECT * FROM Users
                        WHERE Username COLLATE SQL_Latin1_General_CP1_CI_AS = @Username
                        AND Password = @EnteredPassword";

                    var user = connection.QueryFirstOrDefault<UserModel>(query, new
                    {
                        Username = username.Trim(),
                        EnteredPassword = enteredPassword.Trim()
                    });

                    if (user == null)
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }

                    // Successful login
                    MessageBox.Show($"Welcome, {user.Username}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return user;
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}