using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace BookHaven.Database
{
    public class DBConnection
    {
        // Database Connection String
        public static string ConnectionString = @"Data Source=Dulangi\SQLEXPRESS;Initial Catalog=BookHavenDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        // Create and return a new SQL Connection
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
