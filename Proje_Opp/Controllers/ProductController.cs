using Microsoft.AspNetCore.Mvc;
using Proje_Opp.AppContext;
using Proje_Opp.Entity;

namespace Proje_Opp.Controllers
{
    public class ProductController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Products.ToList();
            return View(values);
        }
    }
}
