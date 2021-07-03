using Microsoft.AspNetCore.Mvc;
using R_Store;

namespace Store.Web.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProduct_Repository ProductRepository;
        public ProductController(IProduct_Repository ProductRepository)
        {
            this.ProductRepository = ProductRepository;
        }
        public IActionResult Index(int id)
        {
            Product product = ProductRepository.GetById(id);

            return View(product);
        }
    }
}
