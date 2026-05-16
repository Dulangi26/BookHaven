using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Classes.Models
{
    public class BookModel
    {
        public int BookID { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; }

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public string Genre { get; set; }
    }

}
