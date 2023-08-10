using CoffeeShopProd.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopProd.Controllers
{
    public class ProductController : Controller
    {
        private CoffeeShopDbContext _coffeeShopDbContext = new CoffeeShopDbContext();
        public IActionResult Index()
        {
            List<Product> result = _coffeeShopDbContext.Products.ToList();
            return View(result);
        }

        public IActionResult Details(int id)
        {
            Product p = _coffeeShopDbContext.Products.FirstOrDefault(x => x.Id == id);
            return View(p);
        }
    }
}
