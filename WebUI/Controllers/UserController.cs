using ETicaretBusiness.Abstract;
using ETicaretEntities.Concrete;
using Microsoft.AspNetCore.Mvc;
using WebUI.ViewModels;

namespace WebUI.Controllers
{
    public class UserController : Controller
    {
        private IUserService userService;
        public UserController(IUserService _userService)
        {
            userService = _userService;
        }
        [HttpPost]
        public IActionResult Login(LogInVM logInVm)
        {
            var user = userService.GetByEmailAndPassword(logInVm.UserName, logInVm.Passwords.PasswordContent);
            if (user == null)
            {
                //TempData["Message"] = "Giriş bilgileri hatalı!";
                return View();
            }

            HttpContext.Session.SetString("username", User.UserName);

            TempData["Message"] = "Hoşgeldin!";
            return RedirectToAction("index", "Home");

        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("username");
            //TempData["Message"] = "Güle Güle";
            return RedirectToAction("index", "Home");
        }

        public IActionResult ProductList()
        {
            return View();
        }
    }
}
