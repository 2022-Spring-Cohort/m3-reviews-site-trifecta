using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using template_csharp_reviews_site.Models;

namespace template_csharp_reviews_site.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            List<Product> cellPhones = new List<Product>();
            cellPhones.Add(new Product() { Brand = "Samsung", Model = "Galaxy", OSVer = "Android 10", Price = 800.00, ReleaseDate = System.DateTime.Now });
            cellPhones.Add(new Product() { Brand = "Apple", Model = "iPhone 13 Pro Max", OSVer = "iOS", Price = 1099.00, ReleaseDate = System.DateTime.Now });
            cellPhones.Add(new Product() { Brand = "Motorola", Model = "Razr", OSVer = "Android 9", Price = 499.00, ReleaseDate = System.DateTime.Now });
            cellPhones.Add(new Product() { Brand = "GooglePhone", Model = "Pixel 6 Pro", OSVer = "Android 12", Price = 599.00, ReleaseDate = System.DateTime.Now });






            return View();
        }
    }
}
