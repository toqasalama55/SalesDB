using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.Models
{
    public class Sale
    {
        public int SaleID { get; set; }
        public DateTime Date { get; set; }
        public Product Product { get; set; }
        public int ProductID { get; set; }

        public Store Store { get; set; }
        public int StoreID { get; set; }

        public Customer Customer { get; set; }
        public int CustomerID { get; set; }

        public string CreatedBy { get; set; } 
    }
}
