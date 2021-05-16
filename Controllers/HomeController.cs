using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PastryShopApp.Models;
using PastryShopApp.ViewModels;

namespace PastryShopApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPastryRepository _pastryRepository;
        public HomeController(IPastryRepository pastryRepository)
        {
            _pastryRepository = pastryRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PastriesOfTheWeek = _pastryRepository.PastriesOfWeek
            };
            
            return View(homeViewModel);
        }

    }
}
