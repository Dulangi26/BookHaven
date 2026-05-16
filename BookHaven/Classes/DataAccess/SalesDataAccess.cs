using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Database;

namespace BookHaven.Classes.DataAccess
{
    public class SalesDataAccess
    {
        // Get total sales, total transactions, and total items sold
        public static (decimal totalSales, int totalTransactions, int totalItemsSold) GetSalesSummary()
        {
            decimal totalSales = 0;
            int totalTransactions = 0;
            int totalItemsSold = 0;

            string query = @"
                SELECT 
                    SUM(s.TotalAmount) AS TotalSales, 
                    COUNT(s.SaleID) AS TotalTransactions, 
                    SUM(sd.Quantity) AS TotalItemsSold
                FROM Sales s
                JOIN SalesDetails sd ON s.SaleID = sd.SaleID";

            using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        totalSales = reader.GetDecimal(reader.GetOrdinal("TotalSales"));
                        totalTransactions = reader.GetInt32(reader.GetOrdinal("TotalTransactions"));
                        totalItemsSold = reader.GetInt32(reader.GetOrdinal("TotalItemsSold"));
                    }
                }
            }

            return (totalSales, totalTransactions, totalItemsSold);
        }

        // Get sales data for the chart (total sales by month or date range)
        public static List<SalesChartData> GetSalesDataForChart(DateTime startDate, DateTime endDate)
        {
            List<SalesChartData> salesData = new List<SalesChartData>();

            string query = @"
                SELECT 
                    MONTH(s.SaleDate) AS SaleMonth, 
                    SUM(s.TotalAmount) AS TotalSales
                FROM Sales s
                WHERE s.SaleDate BETWEEN @startDate AND @endDate
                GROUP BY MONTH(s.SaleDate)
                ORDER BY SaleMonth";

            using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var data = new SalesChartData
                        {
                            SaleMonth = reader.GetInt32(reader.GetOrdinal("SaleMonth")),
                            TotalSales = reader.GetDecimal(reader.GetOrdinal("TotalSales"))
                        };
                        salesData.Add(data);
                    }
                }
            }

            return salesData;
        }
    }

    public class SalesChartData
    {
        public int SaleMonth { get; set; }
        public decimal TotalSales { get; set; }
    }
}
