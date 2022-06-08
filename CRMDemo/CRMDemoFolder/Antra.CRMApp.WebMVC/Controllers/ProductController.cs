using Microsoft.AspNetCore.Mvc;
using Antra.CRMApp.WebMVC.Models;
namespace Antra.CRMApp.WebMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product() { Id = 1, Name="Laptop", Color="Silver", Price=2000});
            products.Add(new Product() { Id = 2, Name = "Iphone", Color = "Black", Price = 1000 });
            products.Add(new Product() { Id = 3, Name = "Samsung Galaxy", Color = "Blue", Price = 900 });
            products.Add(new Product() { Id = 4, Name = "Chair", Color = "Wooden", Price = 120 });
            products.Add(new Product() { Id = 5, Name = "Table", Color = "White", Price = 250 });

            ViewData["Title"] = "Product/Index";
            return View(products);
        }
        public IActionResult Detail()
        {
            ViewData["Title"] = "Product/Details";
            return View("explain");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(product);
            
        }

        public IActionResult Edit(int id)
        {
            return View();
        }
    }
}
