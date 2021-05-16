using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PastryShopApp.Models
{
    public class Pastry
    {
        public int PastryId { get; set; }

        public string PastryName { get; set; }
        public string PastryShortDesc { get; set; }
        public string PastryLongDesc { get; set; }
        public string AllergyInformation { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsPastryOfWeek { get; set; }
        public bool IsPastryInStock { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
