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
        public EDContext context;
        public LogInController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, EDContext context) => (this.userManager, this.signInManager, this.context) = (userManager, signInManager,context);

        //представление авторизации
        [AllowAnonymous]
        public IActionResult Login() => View(new loginViewModel());
        
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

        //сброс пароля
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPassword() => View();

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = (from us in context.Users where us.Email.Trim() == model.Email.Trim() select new IdentityUser{ Email=model.Email.Trim()}).First();
                if (user == null)
                {
                    return View("Login");
                }

                var code = await userManager.GeneratePasswordResetTokenAsync(user);
                var callbackUrl = Url.Action("ResetPassword", "LogIn", new { userId = user.Id, code = code }, protocol: HttpContext.Request.Scheme);
                EmailService emailService = new EmailService();
                await emailService.SendEmailAsync(model.Email, "Сброс пароля", $"Для сброса пароля перейдите по ссылке: <a href='{callbackUrl}'>Сбросить пароль</a>");
                return View("ForgotPasswordInfo");
            }
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPassword(string code = null) => code == null ? View("Error") : View();

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            IdentityUser user = (from us in context.Users where us.Email.Trim() == model.Email.Trim() select new IdentityUser { Email = model.Email.Trim() }).First();
            if (user == null)
            {
                return View("ResetPasswordInfo");
            }
            var result = await userManager.ResetPasswordAsync(user, model.Code, model.Password);
            if (result.Succeeded)
            {
                return View("ResetPasswordInfo");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return View(model);
        }

        //выход
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "LogIn");
        }
        
        //ошибка
        public IActionResult AlertMessage() => PartialView("~/Views/Login/_alertMessage.cshtml");
    }
}
