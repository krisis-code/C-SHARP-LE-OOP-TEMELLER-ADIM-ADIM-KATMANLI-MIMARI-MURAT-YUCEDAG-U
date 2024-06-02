using Demo_Product.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
       

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
           
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel user)
        {
            var appUser = new AppUser
            {
                Name = user.Name,
                Surname = user.SurName,
                UserName = user.UserName,
                Email = user.Email
            };
            if (user.Password == user.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser, user.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }

            return View(user);
        }
    }
}
