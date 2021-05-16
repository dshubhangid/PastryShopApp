using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PastryShopApp.Models;
using PastryShopApp.ViewModels;

namespace PastryShopApp.Controllers
{
    public class PastryController : Controller
    {
        private readonly IPastryRepository _pastryRepository;
        private readonly ICategoryRepository _categoryRepository;   
        public PastryController(IPastryRepository pastryRepository, ICategoryRepository CategoryRepository)
        {
            _pastryRepository = pastryRepository;
            _categoryRepository = CategoryRepository;
        }

      

        public IActionResult Details(int id)
        {
            var pastry = _pastryRepository.GetPastryById(id);
            if(pastry == null)
            {
                return NotFound();
            }
            return View(pastry);
        }


        public ViewResult List(string category)
        {
            IEnumerable<Pastry> pastries;
            string currentCategory;

            if(string.IsNullOrEmpty(category))
            {
                pastries = _pastryRepository.AllPastries.OrderBy(p => p.PastryId);
                currentCategory = "All Pastries";
            }
            else
            {
                pastries = _pastryRepository.AllPastries.Where(p => p.Category.CategoryName == category).OrderBy(p => p.PastryId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category).CategoryName;
            }

            return View(new PastriesListViewModel
            {
                Pastries = pastries,
                CurrentCategory = currentCategory
            });
        }
    }
}
