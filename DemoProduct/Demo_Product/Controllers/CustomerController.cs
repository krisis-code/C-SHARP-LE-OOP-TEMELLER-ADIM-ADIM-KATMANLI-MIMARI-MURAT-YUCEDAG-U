using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Demo_customer.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerManager _customerManager;
        private readonly CustomerValidator _customerValidator;
        private readonly JobManager _jobManager;

        public CustomerController(CustomerManager customerManager, CustomerValidator CustomerValidator, JobManager jobManager)
        {
            _customerManager = customerManager;
            _customerValidator = CustomerValidator;
            _jobManager = jobManager;
        }

        public IActionResult Index()
        {
         var values =  _customerManager.GetCustomersWithJob();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {
            // Job listesini almak ve ViewBag'e eklemek
            var jobList = _jobManager.GetList();
            ViewBag.JobList = new SelectList(jobList, "JobId", "Name");

            return View(new Customer()); // Boş bir Customer nesnesi döndürmek
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
                // Job listesini yeniden almak ve ViewBag'e eklemek
                var jobList = _jobManager.GetList();
                ViewBag.JobList = new SelectList(jobList, "JobId", "Name");

                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(customer);
            }
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
