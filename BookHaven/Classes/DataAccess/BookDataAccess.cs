using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using BookHaven.Database;
using BookHaven.Classes.Models;

namespace BookHaven.Classes.DataAccess
{
    public class BookDataAccess
    {
        // Get all books from the database
        public DataTable GetBooks()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "SELECT BookID, Title, Author, ISBN, Price, StockQuantity, Genre FROM Books";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        // Add new book
        public void AddBook(BookModel book)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"
        INSERT INTO Books (Title, Author, ISBN, Price, StockQuantity, Genre)
        VALUES (@Title, @Author, @ISBN, @Price, @StockQuantity, @Genre)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters for the values to be inserted
                    cmd.Parameters.AddWithValue("@Title", book.Title);
                    cmd.Parameters.AddWithValue("@Author", book.Author);
                    cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
                    cmd.Parameters.AddWithValue("@Price", book.Price);
                    cmd.Parameters.AddWithValue("@StockQuantity", book.StockQuantity);
                    cmd.Parameters.AddWithValue("@Genre", book.Genre);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }




        // Edit book details
        public void EditBook(BookModel book)
        {
            string query = @"
        UPDATE Books
        SET Title = @Title, 
            Author = @Author, 
            ISBN = @ISBN, 
            Price = @Price, 
            StockQuantity = @StockQuantity, 
            Genre = @Genre
        WHERE BookID = @BookID";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add parameters for the updated values
                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@Author", book.Author);
                cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
                cmd.Parameters.AddWithValue("@Price", book.Price);
                cmd.Parameters.AddWithValue("@StockQuantity", book.StockQuantity);
                cmd.Parameters.AddWithValue("@Genre", book.Genre);
                cmd.Parameters.AddWithValue("@BookID", book.BookID);  

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Debugging the result
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Book updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No rows were updated. Please check if the BookID exists.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating book: " + ex.Message);
                }
            }
        }



        // Delete book
        public void DeleteBook(int bookID)
        {
            string query = "DELETE FROM Books WHERE BookID = @BookID";

            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Add parameter for BookID to specify which book to delete
                    cmd.Parameters.AddWithValue("@BookID", bookID);

                    conn.Open();  // Ensure connection is open before executing the command
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Check if any rows were affected
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Book deleted successfully from the database.");
                    }
                    else
                    {
                        Console.WriteLine("No rows affected. Make sure the BookID is valid.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception for debugging purposes
                Console.WriteLine("Error deleting book: " + ex.Message);
            }
        }

        public DataTable SearchBooks(string searchTerm)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"
            SELECT BookID, Title, Author, ISBN, Price, StockQuantity, Genre
            FROM Books
            WHERE Title LIKE @SearchTerm OR Author LIKE @SearchTerm OR ISBN LIKE @SearchTerm";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add the search parameter (searchTerm wrapped with % for LIKE)
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }



    }


}