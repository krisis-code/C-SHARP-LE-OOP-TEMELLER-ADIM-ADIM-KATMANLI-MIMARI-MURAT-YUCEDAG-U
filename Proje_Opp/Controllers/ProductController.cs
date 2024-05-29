using Microsoft.AspNetCore.Mvc;
using Proje_Opp.AppContext;
using Proje_Opp.Entity;
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

        [HttpGet]
        public IActionResult Add() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            var value = _context.Products.Where(x => x.Id == Id).FirstOrDefault();
            _context.Remove(value);
            _context.SaveChanges();
            TempData["success"] = (value.Name + " İsimli ürün silinmiştir.");
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int Id)
        {
            var value = _context.Products.Where(x => x.Id == Id).FirstOrDefault();
            return View(value);
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            var value = _context.Products.Where(x => x.Id == product.Id).FirstOrDefault();
            value.Name = product.Name;
            value.Price = product.Price;
            value.Stock = product.Stock;
            
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
