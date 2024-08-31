using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentaiton.Areas.Admin.Controllers
{
    public class DasboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
