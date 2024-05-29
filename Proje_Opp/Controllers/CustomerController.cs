using Microsoft.AspNetCore.Mvc;
using Proje_Opp.AppContext;
using Proje_Opp.Entity;
using System.Linq;

namespace Proje_Opp.Controllers
{
    public class CustomerController : Controller
    {
        private readonly Context _context;

        public CustomerController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Customers.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            var value = _context.Customers.Where(x => x.Id == Id).FirstOrDefault();
            _context.Remove(value);
            _context.SaveChanges();
            TempData["success"] = (value.Name + " İsimli müşteri silinmiştir.");
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int Id)
        {
            var value = _context.Customers.Where(x => x.Id == Id).FirstOrDefault();
            return View(value);
        }

        [HttpPost]
        public IActionResult Update(Customer customer )
        {
            var value = _context.Customers.Where(x => x.Id == customer.Id).FirstOrDefault();
            value.Name = customer.Name;
            value.City = customer.City;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
