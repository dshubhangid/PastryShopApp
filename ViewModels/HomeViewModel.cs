using PastryShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PastryShopApp.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pastry> PastriesOfTheWeek { get; set; }
    }
}
