using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.Models
{
    public class Store
    {
        public int StoreID { get; set; }
        public String? Name { get; set; }
        List<Sale> Sales { get; set; }

    }
}
