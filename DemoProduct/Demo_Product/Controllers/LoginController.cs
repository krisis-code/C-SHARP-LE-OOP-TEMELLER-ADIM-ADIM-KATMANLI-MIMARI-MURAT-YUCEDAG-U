using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
