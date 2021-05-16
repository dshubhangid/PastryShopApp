using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PastryShopApp.Models;

namespace PastryShopApp.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository _orderRepository;
        private ShoppingCart _cart;

        public OrderController(IOrderRepository orderRepository, ShoppingCart cart)
        {
            _orderRepository = orderRepository;
            _cart = cart;
        }
        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var shoppingCartItems = _cart.GetShoppingCartItems();
            _cart.ShoppingCartItems = shoppingCartItems;

            if (shoppingCartItems.Count() == 0)
            {
                ModelState.AddModelError("", "Your cart is empty, add pastries first!");
            }
            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _cart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }

            return View(order);
        }
        public IActionResult CheckoutComplete()
        {
            ViewBag.CompleteCheckoutMessage = "Thanks for your order.You'll soon enjoy your delicious pies!";
            return View();
        }
    }
}
