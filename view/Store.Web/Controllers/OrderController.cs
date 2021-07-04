using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using R_Store;

using Store.Web.Models;

namespace Store.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IProduct_Repository ProductRepository;
        private readonly IOOOrder_Repository Order_Repository;
        public OrderController(IProduct_Repository ProductRepository,
                               IOOOrder_Repository Order_Repository)
        {
            this.ProductRepository = ProductRepository;
            this.Order_Repository = Order_Repository;
            
        }
        public IActionResult Index()
        {
          
            if (HttpContext.Session.TryGetCart(out Cart cart))
            {
                var order = Order_Repository.GetById(cart.OrderId);
                OrderModel model = Map(order);

              return View(model);
            }
            return View("Empty");
        }
        private OrderModel Map(Order order)
        {
            var productIds = order.Items.Select(item => item.ProductId);
            var products = ProductRepository.GetAllByIds(productIds);
            var itemModels = from item in order.Items
                             join Product in products on item.ProductId equals Product.Id
                             select new OrderItemModel
                             {
                                            ProductId = Product.Id,
                                            Title = Product.Title,
                                            Information = Product.Information,
                                            Company = Product.Company,
                                             Price = item.Price,
                                             Count = item.Count,
                                        
                             };
            return new OrderModel
            {
                Id = order.Id,
                Items = itemModels.ToArray(),
                TotalCount = order.TotalCount,
                TotalPrice = order.TotalPrice,
            };
        }

        public IActionResult Add(int id)
        {
            Order order;
            Cart cart;

            if (HttpContext.Session.TryGetCart(out cart))
            {
                order = Order_Repository.GetById(cart.OrderId);
            }
            else
            {
                order = Order_Repository.Create();
                cart = new Cart(order.Id);
            }
            var product = ProductRepository.GetById(id);

            order.AddItem(product, 1);
            Order_Repository.Update(order);
            cart.TotalCount = order.TotalCount;
            cart.TotalPrice = order.TotalPrice; //сохранили изменения в корзине

            HttpContext.Session.Set(cart); //обновили состояние сессии

            return RedirectToAction("Index", "Product", new { id });
        }
    }
}
