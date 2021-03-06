using Microsoft.AspNetCore.Mvc;
using R_Store;

namespace Store.Web.Controllers
{
    public class SearchController : Controller//Наследование
    {
        private readonly IProduct_Repository ProductRepository;

        //внедрение через конструктор
        public SearchController(IProduct_Repository product_Repository) 
        {
            this.ProductRepository = product_Repository;
        }
        public IActionResult Index(string query)
        {
            var products = ProductRepository.GetAllByTitle(query);
            return View(products);
        }
    }
}
