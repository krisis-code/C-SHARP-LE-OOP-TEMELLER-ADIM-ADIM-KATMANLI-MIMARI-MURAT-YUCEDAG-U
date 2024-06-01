using BusinessLayer.Concrete;
using EntityLayer.Concrete;
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

        [HttpGet]
        public IActionResult Add()
        {
            
            return View(); 
        }

        [HttpPost]
        public IActionResult Add(Product product) 
        {
            if (product != null)
            {
                _productManager.TInsert(product);
            }
            else
            {
                return View(product);
            }
            return RedirectToAction("Index");
        }
    }
}
