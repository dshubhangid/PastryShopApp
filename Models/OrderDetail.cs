using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PastryShopApp.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int PastryId { get; set; }
        public int Amount { get; set; }
        [Column(TypeName = "decimal(18,2)")]

        public decimal Price { get; set; }
        public Pastry Pastry { get; set; }
        public Order Order { get; set; }
    }
}
