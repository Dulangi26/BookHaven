using BookHaven.Forms;
using BookHaven.Forms.Admin;
using BookHaven.Forms.BookManagement;
using BookHaven.Forms.CustomerManagement;
using BookHaven.Forms.Login;
using BookHaven.Forms.OrderManagement;
using BookHaven.Forms.PaymentManagement;
using BookHaven.Forms.Reports;
using BookHaven.Forms.SalesTransaction;
using BookHaven.Forms.Security;
using BookHaven.Forms.SupplierManagement;

namespace BookHaven
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Set the license context for EPPlus (free version)
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin());
        }
    }
}