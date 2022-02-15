using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using template_csharp_reviews_site.Models;
using System.Linq;

namespace template_csharp_reviews_site.Controllers
{
    public class ProductController : Controller
    {
        List<Product> cellPhones = new ApplicationContext().Products.ToList();

        public ProductController()
        {
            
        }
        public IActionResult Index()
        {

            return View(cellPhones);
        }

        public IActionResult Detail(int id)
        {
            Product cellPhone = cellPhones.Find(cellPhones => cellPhones.Id == id);
            return View(cellPhone);
        }
    }
}
