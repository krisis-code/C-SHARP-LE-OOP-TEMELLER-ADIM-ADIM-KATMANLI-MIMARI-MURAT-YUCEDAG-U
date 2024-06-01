using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Demo_customer.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerManager _customerManager;
        private readonly CustomerValidator _customerValidator;

        public CustomerController(CustomerManager customerManager, CustomerValidator CustomerValidator)
        {
            _customerManager = customerManager;
            _customerValidator = CustomerValidator;
        }

        public IActionResult Index()
        {
         var values =  _customerManager.TGetList();
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
            ValidationResult result = _customerValidator.Validate(customer);
            if (result.IsValid)
            {
                _customerManager.TInsert(customer);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(customer);
            }
            return View();
        }
     
        public IActionResult Delete(int id)
        {
            var customer = _customerManager.TGetById(id);
            _customerManager.TDelete(customer);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update (int id)
        {
            var value = _customerManager.TGetById(id);

            return View(value);
        }
        [HttpPost]
        public IActionResult Update(Customer customer)
        {
            ValidationResult result = _customerValidator.Validate(customer);
          
            if (result.IsValid)
            {
                _customerManager.TUpdate(customer);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(customer);
            }
           
        }


    }
}
