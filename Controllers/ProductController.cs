using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using template_csharp_reviews_site.Models;
using System.Linq;

namespace template_csharp_reviews_site.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationContext _context;

        public ProductController()
        {
            _context = new ApplicationContext();
        }
        public IActionResult Index()
        {
            return View(_context.Products.ToList());
        }

        public IActionResult Detail(int id)
        {
            Product cellPhone = _context.Products.ToList().Find(cellPhone => cellPhone.Id == id);
            return View(cellPhone);
        }
    }
}
