using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PastryShopApp.Models;

namespace PastryShopApp.ViewModels
{
    public class PastriesListViewModel
    {
        public IEnumerable<Pastry> Pastries{get; set; }
        public string CurrentCategory { get; set; }
    }
}
