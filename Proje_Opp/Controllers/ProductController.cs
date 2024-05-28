using Microsoft.AspNetCore.Mvc;

namespace Proje_Opp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
