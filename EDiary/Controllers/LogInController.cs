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
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace EDiary.Controllers
{
    [Authorize] 
    public class LogInController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        public EDContext context;
        public LogInController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, EDContext context) 
                           => (this.userManager, this.signInManager, this.context) = (userManager, signInManager, context);

        //представление авторизации
        [HttpGet]
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
                    SignInResult result = await signInManager.PasswordSignInAsync(user, loginModel.Password, loginModel.Remember, false);
                    if (result.Succeeded)
                    {
                        //если админ
                        if (await userManager.IsInRoleAsync(user, "admin"))
                        {
                            return RedirectToAction("Admin", "Admin");
                        }

                        //если препод
                        if (await userManager.IsInRoleAsync(user, "teacher"))
                        {
                            return RedirectToAction("Teacher", "Teacher");
                        }

                        //если студент
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



        //забыли пароль
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
                if (user == null || !await userManager.IsEmailConfirmedAsync(user))
                {
                    ModelState.AddModelError(nameof(ForgotPasswordModel.userEmail), "Не удалось найти пользователя с указанным адресом эл. почты");
                }
                //генерация токена для восстановления 
                var сode = await userManager.GeneratePasswordResetTokenAsync(user);
                //генерация сслыки
                var callbackUrl = Url.Action("ResetPassword", "LogIn", new { userId = user.Id, code = сode }, protocol: HttpContext.Request.Scheme);
                EmailService emailService = new EmailService();
                await emailService.SendEmailAsync(forgotPassword.userEmail.Trim(), "Сброс пароля", $"Для сброса пароля перейдите по ссылке: <a href='{callbackUrl}'>Сбросить пароль</a>");
                return View("ForgotPasswordInfo");
            }
            return View(forgotPassword);
        }

        //сброс пароля
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
                        ModelState.AddModelError(nameof(ResetPasswordModel.userEmail), "Не удалось найти пользователя с указанным адресом эл. почты");
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
        [HttpGet]
        public IActionResult ChangePassword() => View();

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
                                //если студент
                                if (await userManager.IsInRoleAsync(user, "student"))
                                {
                                    return RedirectToAction("Student", "Student");
                                }
                                
                                //если преподаватель
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



        //смена почты
        [Authorize]
        [HttpGet]
        public IActionResult ChangeEmail() => View();
      
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ChangeEmail(ChangeEmailModel changeEmail)
        {
            var user = await userManager.FindByIdAsync(userManager.GetUserId(User));
            if (user.Email == changeEmail.oldEmail)
            {
                user.Email = changeEmail.newEmail;
                context.Users.Update(user);
                await context.SaveChangesAsync();

                //если студент
                if (await userManager.IsInRoleAsync(user, "student"))
                {
                    return RedirectToAction("Student", "Student");
                }

                //если преподаватель
                else if (await userManager.IsInRoleAsync(user, "teacher"))
                {
                    return RedirectToAction("Teacher", "Teacher");
                }
            }
            else
            {
                ModelState.AddModelError(nameof(ChangeEmailModel.oldEmail), "Неправильно введен старый email");
            }
            return View(changeEmail);
        }



        //подтвержение почты
        [Authorize]
        public async Task<IActionResult> ConfirmSend()
        {
            var user = await userManager.FindByIdAsync(userManager.GetUserId(User));
            //генерация токена для подтверждения
            var code = await userManager.GenerateEmailConfirmationTokenAsync(user);
            var callbackUrl = Url.Action("ConfirmEmail", "LogIn", new { userId = user.Id, code = code }, protocol: HttpContext.Request.Scheme);
            EmailService emailService = new EmailService();
            await emailService.SendEmailAsync(user.Email, "Подтверждение почты", $"Подтвердите почту, перейдя по ссылке: <a href='{callbackUrl}'>Подтвердить почту аккаунта {user.UserName}</a>");
            return Content("Для подтверждения почты перейдите по ссылке, указанной в отправленном письме");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return Json("Error");
            }
            var user = await userManager.FindByIdAsync(userId);
            var result = await userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
            {
                //если студент
                if (await userManager.IsInRoleAsync(user, "student"))
                {
                    return RedirectToAction("Student", "Student");
                }

                //если преподаватель
                else if (await userManager.IsInRoleAsync(user, "teacher"))
                {
                    return RedirectToAction("Teacher", "Teacher");
                }
            }
            return Json("Error");
        }



        //ошибка
        public IActionResult AlertMessage() => PartialView("~/Views/Login/_alertMessage.cshtml");
    }
}
