using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using BookHaven.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace BookHaven.Classes.BusinessLogic
{
    public class ReportManager
    {
        public ReportManager() { }

        // Get Sales Report
        /* public DataTable GetSalesReport()
         {
             string query = System.IO.File.ReadAllText("C:\\Users\\DULANGIKA\\Desktop\\dulangi esoft\\Software Engineering Degree\\Aplication Development\\web\\BookHaven\\BookHaven\\Database\\SQLScripts\\GetSalesReport.sql");
             using (SqlConnection conn = DBConnection.GetConnection())  
             {
                 SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                 DataTable salesData = new DataTable();
                 dataAdapter.Fill(salesData);
                 return salesData;
             }
         }*/

        // Get Inventory Report
        public DataTable GetInventoryReport()
        {
            string query = @"
        SELECT 
            b.BookID,
            b.Title AS BookTitle,
            b.Author,
            b.Price,
            b.StockQuantity,
            CASE 
                WHEN b.StockQuantity < 5 THEN 'Low Stock'
                ELSE 'Sufficient Stock'
            END AS StockStatus
        FROM 
            Books b
        ORDER BY 
            b.Title;
    ";


            //string query = System.IO.File.ReadAllText("SQLScripts/GetInventoryReport.sql");
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable inventoryData = new DataTable();
                dataAdapter.Fill(inventoryData);
                return inventoryData;
            }
        }

        // Get Customer Report
        public DataTable GetCustomerReport()
        {
            string query = @"
        SELECT 
            c.CustomerID,
            c.Name AS CustomerName,
            c.Contact,
            c.Email,
            SUM(s.TotalAmount) AS TotalSpent
        FROM 
            Customers c
        LEFT JOIN 
            Sales s ON c.CustomerID = s.CustomerID
        GROUP BY 
            c.CustomerID, c.Name, c.Contact, c.Email
        ORDER BY 
            TotalSpent DESC;
    ";


         //   string query = System.IO.File.ReadAllText("SQLScripts/GetCustomerReport.sql");
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable customerData = new DataTable();
                dataAdapter.Fill(customerData);
                return customerData;
            }
        }

        // Get Sales Report with Book details
        public DataTable GetSalesReport()
        {
            string query = @"
                SELECT 
                    s.SaleID,
                    c.Name AS CustomerName,
                    s.TotalAmount,
                    s.SaleDate,
                    b.Title AS BookTitle,
                    b.Author,
                    sd.Quantity,
                    sd.TotalPrice
                FROM 
                    Sales s
                JOIN 
                    Customers c ON s.CustomerID = c.CustomerID
                JOIN 
                    SaleDetails sd ON s.SaleID = sd.SaleID
                JOIN 
                    Books b ON sd.BookID = b.BookID
                ORDER BY 
                    s.SaleDate DESC;
            ";
            ;

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable salesData = new DataTable();
                dataAdapter.Fill(salesData);
                return salesData;
            }
        }
    }
}
