using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PastryShopApp.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
        public string CategoryDesc { get; set; }
        public List<Pastry> Pastries { get; set; }
    }
}
