using Microsoft.AspNetCore.Mvc;
using Proje_Opp.AppContext;
using System.Linq;

namespace Proje_Opp.Controllers
{
    public class ProductController : Controller
    {
        private readonly Context _context;

        public ProductController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Products.ToList();
            return View(values);
        }
    }
}
