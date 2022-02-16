using Microsoft.AspNetCore.Mvc;
using System.Linq;
using template_csharp_reviews_site.Models;

namespace template_csharp_reviews_site.Controllers
{
    public class ReviewController : Controller
    {
        private ApplicationContext _context;

        public ReviewController()
        {
            _context = new ApplicationContext();
        }

        public IActionResult Index()
        {
            ViewBag.cellPhones = _context.Products.ToList();
            return View(_context.Reviews.ToList());
        }

        public IActionResult Detail(int id)
        {
            Review review = _context.Reviews.Find(id);
            ViewBag.cellPhone = _context.Products.Find(review.ProductId);
            return View(review);
        }
    }
}
