﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using R_Store;
using Store.Web.Models;

namespace Store.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly IProduct_Repository ProductRepository;
        public CartController(IProduct_Repository ProductRepository)
        {
            this.ProductRepository = ProductRepository;
        }
        public IActionResult Add(int id)
        {
            var product = ProductRepository.GetById(id);
            Cart cart;
            if (!HttpContext.Session.TryGetCart(out cart))
                cart = new Cart();

            if (cart.Items.ContainsKey(id))
                cart.Items[id]++;
            else
                cart.Items[id] = 1;
                cart.Amount += product.Price;

            HttpContext.Session.Set(cart);

            return RedirectToAction("Index", "Product", new { id });
        }
    }
}
