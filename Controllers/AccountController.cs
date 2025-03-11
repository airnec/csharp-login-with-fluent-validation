using System.Security.Cryptography.X509Certificates;
using CSharpLoginWithFluentValidation.Models;
using CSharpLoginWithFluentValidation.Validators;
using Microsoft.AspNetCore.Mvc;

namespace CSharpLoginWithFluentValidation.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }

            // Eğer doğrulama başarılıysa, kullanıcı girişini kontrol edelim:
            if (user.Email == "admin@example.com" && user.Password == "Test123!")
            {
                return RedirectToAction("Index", "Home"); // Giriş başarılı
            }

            ViewData["ErrorMessage"] = "Geçersiz e-posta veya şifre!";
            return View();
        }
    }
}
