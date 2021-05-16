using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PastryShopApp.Models
{
    public class PastryRepository : IPastryRepository
    {
  
        private readonly AppDbContext _appDbContext;

        public PastryRepository (AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pastry> AllPastries
        {
            get
            {
                return _appDbContext.Pastries.Include(c => c.Category);
            }
        }

        public IEnumerable<Pastry> PastriesOfWeek
        {
            get
            {
                return _appDbContext.Pastries.Include(c => c.Category).Where(p => p.IsPastryOfWeek);
            }
        }

        public Pastry GetPastryById(int pastryId)
        {
            return _appDbContext.Pastries.FirstOrDefault(p => p.PastryId == pastryId);
        }
    }
}
