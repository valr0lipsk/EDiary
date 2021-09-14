using EDiary.Models;
using EDiary.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Controllers
{
    [Authorize] 
    public class LogInController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        public LogInController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager) => (this.userManager, this.signInManager) = (userManager, signInManager);

        //представление авторизации
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View(new loginViewModel());
        }
        
        //авторизация
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(loginViewModel loginModel)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await userManager.FindByNameAsync(loginModel.userName);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, loginModel.Password, loginModel.Remember, false);
                    if (result.Succeeded)
                    {
                        if (user.UserName=="admin")
                        {
                            return RedirectToAction("Admin", "Admin");
                        }
                        if (user.UserName.Contains("tr"))
                        {
                            return RedirectToAction("Teacher", "Teacher");
                        }
                        if (user.UserName.Contains("st"))
                        {
                            return RedirectToAction("Student", "Student");
                        }
                    }  
                }
                ModelState.AddModelError(nameof(loginViewModel.userName), "Неправильно введен логин или пароль");
            }
            return View(loginModel);
        }

        //выход
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "LogIn");
        }
        
        //ошибка
        public IActionResult AlertMessage()
        {
            return PartialView("~/Views/Login/_alertMessage.cshtml");
        }
    }
}
