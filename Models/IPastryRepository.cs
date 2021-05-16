using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PastryShopApp.Models
{
    public interface IPastryRepository
    { 
        IEnumerable<Pastry> AllPastries { get; }
        IEnumerable<Pastry> PastriesOfWeek { get; }

        Pastry GetPastryById(int pastryId);
    }
}
