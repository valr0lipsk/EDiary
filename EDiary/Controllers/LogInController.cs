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
using System.Text.RegularExpressions;
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
            string passwordPattern = @"(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[a-zA-Z0-9])";
            if (Regex.IsMatch(resetPassword.newPassword, passwordPattern) && resetPassword.newPassword.Length >= 8)
            {
                if (ModelState.IsValid)
                {
                    var user = await userManager.FindByEmailAsync(resetPassword.userEmail.Trim());
                    if (user == null)
                    {
                        ModelState.AddModelError(nameof(resetPassword.userEmail), "Пользователь не найден");
                        return View(resetPassword);
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
                }
            }
            else
            {
                ModelState.AddModelError(nameof(ResetPasswordModel.newPassword), "Пароль должен состоять из латинских символов (верхнего и нижнего регистров), цифр и быть не менее 8 символов");
            }
            return View(resetPassword);
        }   

        //смена пароля пользователя
        [Authorize]
        public IActionResult ChangePassword() => View("ChangePassword");

        [HttpPost]
        public async Task<IActionResult> ChangePassword(UserChangePasswordModel userPassword)
        {
            string passwordPattern = @"(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[a-zA-Z0-9])";
            if (ModelState.IsValid)
            {
                IdentityUser user = await userManager.FindByIdAsync(userManager.GetUserId(User));
                if (user != null)
                {
                    if (userPassword.oldPassword == userPassword.newPassword)
                    {
                        ModelState.AddModelError(nameof(UserChangePasswordModel.newPassword), "Новый пароль должен отличаться от старого");
                    }
                    else
                    {
                        if (Regex.IsMatch(userPassword.newPassword, passwordPattern) && userPassword.newPassword.Length >= 8)
                        {
                            IdentityResult result = await userManager.ChangePasswordAsync(user, userPassword.oldPassword, userPassword.newPassword);
                            if (result.Succeeded)
                            {
                                if (await userManager.IsInRoleAsync(user, "student"))
                                {
                                    return RedirectToAction("Student", "Student");
                                }
                                else if (await userManager.IsInRoleAsync(user, "teacher"))
                                {
                                    return RedirectToAction("Teacher", "Teacher");
                                }
                            }
                            else
                            {
                                ModelState.AddModelError(nameof(UserChangePasswordModel.oldPassword), "Неправильно введен старый пароль");
                            }
                        }
                        else
                        {
                            ModelState.AddModelError(nameof(UserChangePasswordModel.newPassword), "Пароль должен состоять из латинских символов (верхнего и нижнего регистров), цифр и быть не менее 8 символов");
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
