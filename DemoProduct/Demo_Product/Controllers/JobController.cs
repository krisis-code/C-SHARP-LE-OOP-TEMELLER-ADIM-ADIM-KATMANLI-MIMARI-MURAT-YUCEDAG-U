using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Demo_customer.Controllers
{
    public class JobController : Controller
    {
        private readonly JobManager _jobManager;
        private readonly JobValidator _jobValidator;

        public JobController(JobManager jobManager, JobValidator jobValidator)
        {
            _jobManager = jobManager;
            _jobValidator = jobValidator;
        }





        public IActionResult Index()
        {
            var values = _jobManager.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Add(Job job)
        {
            ValidationResult result = _jobValidator.Validate(job);
            if (result.IsValid)
            {
                _jobManager.Insert(job);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(job);
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            var Job = _jobManager.GetById(id);
            _jobManager.Delete(Job);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = _jobManager.GetById(id);

            return View(value);
        }
        [HttpPost]
        public IActionResult Update(Job job)
        {
            ValidationResult result = _jobValidator.Validate(job);

            if (result.IsValid)
            {
                var existingJob = _jobManager.GetById(job.JobId); // Mevcut kaydı yükleyin

                if (existingJob != null)
                {
                    // Gerekirse sadece gerekli alanları güncelleyin
                    existingJob.Name = job.Name;
                    // Diğer alanları da burada güncelleyebilirsiniz

                    _jobManager.Update(existingJob); // Mevcut kaydı güncelleyin
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Job not found.");
                    return View(job);
                }
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(job);
            }
        }



    }
}
