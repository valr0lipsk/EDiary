using EDiary.Models;
using EDiary.Service;
using EDiary.ViewModels;
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
        public LogInController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, EDContext context) => (this.userManager, this.signInManager, this.context) = (userManager, signInManager, context);

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
                        if (await userManager.IsInRoleAsync(user, "admin"))
                        {
                            return RedirectToAction("Admin", "Admin");
                        }
                        if (await userManager.IsInRoleAsync(user, "teacher"))
                        {
                            return RedirectToAction("Teacher", "Teacher");
                        }
                        if (await userManager.IsInRoleAsync(user, "student"))
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
        public async Task<IActionResult> ForgotPassword(ForgotPasswordModel forgotPassword)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(forgotPassword.userEmail.Trim());
                if (user == null || !(await userManager.IsEmailConfirmedAsync(user)))
                {
                    return View("Login");
                }

                var сode = await userManager.GeneratePasswordResetTokenAsync(user);
                var callbackUrl = Url.Action("ResetPassword", "LogIn", new { userId = user.Id, code = сode }, protocol: HttpContext.Request.Scheme);
                EmailService emailService = new EmailService();
                await emailService.SendEmailAsync(forgotPassword.userEmail.Trim(), "Сброс пароля", $"Для сброса пароля перейдите по ссылке: <a href='{callbackUrl}'>Сбросить пароль</a>");
                return View("ForgotPasswordInfo");
            }
            return View(forgotPassword);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPassword(string code)
        {
            return code == null ? View("Error") : View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel resetPassword)
        {
            if (!ModelState.IsValid)
            {
                return View(resetPassword);
            }
            var user = await userManager.FindByEmailAsync(resetPassword.userEmail.Trim());
            if (user == null)
            {
                return View("ResetPasswordInfo");
            }
            var result = await userManager.ResetPasswordAsync(user, resetPassword.Code, resetPassword.newPassword);
            if (result.Succeeded)
            {
                return View("ResetPasswordInfo");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return View(resetPassword);
        }   

        //смена пароля пользователя
        [Authorize]
        public IActionResult ChangePassword() => View("ChangePassword");

        [HttpPost]
        public async Task<IActionResult> ChangePassword(userChangePassword userPassword)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await userManager.FindByIdAsync(userManager.GetUserId(User));
                if (user != null)
                {
                    IdentityResult result = await userManager.ChangePasswordAsync(user, userPassword.oldPassword, userPassword.newPassword);
                    if (result.Succeeded)
                    {
                        if (user.UserName.Contains("st")) 
                        { 
                            return RedirectToAction("Student", "Student"); 
                        }
                        else if (user.UserName.Contains("tr"))
                        {
                            return RedirectToAction("Teacher", "Teacher"); 
                        }
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }
            }
            return View(userPassword);
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
