using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Classes.Models
{
    public class SalesTransaction
    {
        public int TransactionID { get; set; }
        public int CustomerID { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentDetails { get; set; }
    }
}
