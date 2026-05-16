using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using BookHaven.Database;
using BookHaven.Classes.DataAccess;
using BookHaven.Classes.Models;
using BookHaven.Forms.Admin;

namespace BookHaven.Forms.BookManagement
{
    public partial class BookManagementForm : Form
    {
        private BookDataAccess bookDataAccess;
        public BookManagementForm()
        {
            InitializeComponent();
            bookDataAccess = new BookDataAccess();
            LoadBooks();
            LoadGenres();
        }

        // Load all books into the DataGridView
        private void LoadBooks()
        {
            try
            {
                DataTable books = bookDataAccess.GetBooks();
                dgvBooks.DataSource = books;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
        }

        // Load genres into the ComboBox (cmbGenre)
        private void LoadGenres()
        {
            try
            {
                // Sample genres (you can also load them from the database if needed)
                List<string> genres = new List<string>
                {
                    "Fiction", "Non-Fiction", "Science", "History", "Biography", "Mystery", "Fantasy", "Romance"
                };

                // Add genres to the ComboBox
                cmbGenre.DataSource = genres;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading genres: " + ex.Message);
            }
        }


        private void BookManagementForm_Load(object sender, EventArgs e)
        {

        }

        // DataGridView row selection event to load selected book into textboxes and combo box
        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvBooks.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvBooks.SelectedRows[0];

                    // Fill textboxes with selected row data
                    txtBookID.Text = selectedRow.Cells["BookID"].Value.ToString();
                    txtTitle.Text = selectedRow.Cells["Title"].Value.ToString();
                    txtAuthor.Text = selectedRow.Cells["Author"].Value.ToString();
                    txtISBN.Text = selectedRow.Cells["ISBN"].Value.ToString();
                    txtPrice.Text = selectedRow.Cells["Price"].Value.ToString();
                    txtStockQuantity.Text = selectedRow.Cells["StockQuantity"].Value.ToString();
                    cmbGenre.SelectedItem = selectedRow.Cells["Genre"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting book: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtBookID.Text) ||
                    string.IsNullOrWhiteSpace(txtTitle.Text) ||
                    string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                    string.IsNullOrWhiteSpace(txtISBN.Text) ||
                    string.IsNullOrWhiteSpace(txtPrice.Text) ||
                    string.IsNullOrWhiteSpace(txtStockQuantity.Text) ||
                    cmbGenre.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Parse price and stock quantity
                if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
                {
                    MessageBox.Show("Invalid price. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtStockQuantity.Text, out int stockQuantity) || stockQuantity < 0)
                {
                    MessageBox.Show("Invalid stock quantity. Please enter a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create BookModel object based on the form input
                BookModel book = new BookModel
                {
                    BookID = int.Parse(txtBookID.Text),
                    Title = txtTitle.Text,
                    Author = txtAuthor.Text,
                    ISBN = txtISBN.Text,
                    Price = price,
                    StockQuantity = stockQuantity,
                    Genre = cmbGenre.SelectedItem.ToString()
                };

                // Call EditBook method from BookDataAccess class to update the book
                bookDataAccess.EditBook(book);

                // Refresh book list
                LoadBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error editing book: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBooks.SelectedRows.Count > 0)
                {
                    int bookID = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["BookID"].Value);

                    var confirmResult = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        // Call DeleteBook method to delete the selected book
                        bookDataAccess.DeleteBook(bookID);

                        // Refresh book list
                        LoadBooks();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a book to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting book: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtBookID.Clear();
                txtTitle.Clear();
                txtAuthor.Clear();
                txtISBN.Clear();
                txtPrice.Clear();
                txtStockQuantity.Clear();
                cmbGenre.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error clearing fields: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearch.Text.Trim();

                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    MessageBox.Show("Please enter a search term.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Call SearchBooks method to get search results
                DataTable searchResults = bookDataAccess.SearchBooks(searchTerm);
                dgvBooks.DataSource = searchResults;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching books: " + ex.Message);
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            try
            {
                txtSearch.Clear();
                LoadBooks();  // Reload all books to the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error clearing search: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                    string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                    string.IsNullOrWhiteSpace(txtISBN.Text) ||
                    string.IsNullOrWhiteSpace(txtPrice.Text) ||
                    string.IsNullOrWhiteSpace(txtStockQuantity.Text) ||
                    cmbGenre.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Parse price and stock quantity
                if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
                {
                    MessageBox.Show("Invalid price. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtStockQuantity.Text, out int stockQuantity) || stockQuantity < 0)
                {
                    MessageBox.Show("Invalid stock quantity. Please enter a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create BookModel object based on the form input
                BookModel book = new BookModel
                {
                    Title = txtTitle.Text,
                    Author = txtAuthor.Text,
                    ISBN = txtISBN.Text,
                    Price = price,
                    StockQuantity = stockQuantity,
                    Genre = cmbGenre.SelectedItem.ToString()
                };

                // Call AddBook method from BookDataAccess class to add the new book
                bookDataAccess.AddBook(book);

                // Refresh book list
                LoadBooks();
                MessageBox.Show("Book added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding book: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var confirmExit = MessageBox.Show(
    "Are you sure you want to exit?",
    "Exit Confirmation",
     MessageBoxButtons.YesNo,
     MessageBoxIcon.Question);

            if (confirmExit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboardForm sup = new AdminDashboardForm();
            sup.Show();
            this.Hide();
        }
    }
}
