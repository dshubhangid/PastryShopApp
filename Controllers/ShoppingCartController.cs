using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PastryShopApp.Models;
using PastryShopApp.ViewModels;

namespace PastryShopApp.Controllers
{
    public class ShoppingCartController : Controller
    {
       private readonly IPastryRepository _pastryRepository;
       private readonly ShoppingCart _shoppingCart;

       public ShoppingCartController(IPastryRepository pastryRepository, ShoppingCart shoppingCart)
       {
            _pastryRepository = pastryRepository;
            _shoppingCart = shoppingCart;
       }

        public ViewResult Index()
        {
            List<ShoppingCartItem> items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int pastryId)
        {
            Pastry selectedPastry = _pastryRepository.AllPastries.FirstOrDefault(p => p.PastryId == pastryId);

            if (selectedPastry != null)
            {
                _shoppingCart.AddToCart(selectedPastry, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int pastryId)
        {
            var selectedPastry = _pastryRepository.AllPastries.FirstOrDefault(p => p.PastryId == pastryId);

            if (selectedPastry != null)
            {
                _shoppingCart.RemoveFromCart(selectedPastry);
            }
            return RedirectToAction("Index");
        }
    }
}
