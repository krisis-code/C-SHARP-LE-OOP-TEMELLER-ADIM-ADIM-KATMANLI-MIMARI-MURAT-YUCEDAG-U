using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductManager _productManager;
        private readonly ProductValidator _productValidator;

        public ProductController(ProductManager productManager, ProductValidator productValidator)
        {
            _productManager = productManager;
            _productValidator = productValidator;
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
            ValidationResult result = _productValidator.Validate(product);
            if (result.IsValid)
            {
                _productManager.TInsert(product);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(product);
            }
            return View();
        }
     
        public IActionResult Delete(int id)
        {
            var product = _productManager.TGetById(id);
            _productManager.TDelete(product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update (int id)
        {
            var value = _productManager.TGetById(id);

            return View(value);
        }
        [HttpPost]
        public IActionResult Update(Product product)
        {
            ValidationResult result = _productValidator.Validate(product);
          
            if (result.IsValid)
            {
                _productManager.TUpdate(product);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(product);
            }
           
        }


    }
}
