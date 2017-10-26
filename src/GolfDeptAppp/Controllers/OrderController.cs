﻿using Microsoft.AspNetCore.Mvc;
using GolfDeptAppp.Data.Interfaces;
using GolfDeptAppp.Data.Models;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using GolfDeptAppp.Data;
using GolfDeptAppp.Migrations;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GolfDeptAppp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;
        private readonly AppDbContext _appDbContext;

        public Order localOrder;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }

        [Authorize]
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Checkout(Order order)
        {
            int id = 0;
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your card is empty, add some clubs first");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                localOrder = order;
                return RedirectToAction("CheckoutComplete");
            }

            return View(order);

        }

        [HttpGet]
        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thanks for your order! :) ";
            ViewBag.CheckoutCompleteData = localOrder;
            return View();
        }
    }
}