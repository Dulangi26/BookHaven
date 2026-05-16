using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Classes.Models
{
    public class PaymentModel
    {
        public int PaymentID { get; set; }
        public int SaleID { get; set; }
        public int CustomerID { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Amount { get; set; }
        public string PaymentStatus { get; set; }
    }
}
