using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductManager _productManager;

        public ProductController(ProductManager productManager)
        {
            _productManager = productManager;
        }

        public IActionResult Index()
        {
         var values =  _productManager.TGetList();
            return View(values);
        }
    }
}
