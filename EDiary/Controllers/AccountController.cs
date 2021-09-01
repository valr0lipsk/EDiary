﻿using EDiary.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View(new loginViewModel());
        }
        //[HttpGet]
        //public IActionResult Login(string returnUrl = null)
        //{
        //    return View(new loginViewModel { returnUrl = returnUrl });
        //}

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(loginViewModel loginModel, string returnUrl)
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
                        return RedirectToAction("Teacher", "Home");
                        //if (userManager.IsInRoleAsync(user,"admin1"))
                        //{

                        //}
                        //{
                        //    return RedirectToAction("Admin", "Home");
                        //}
                        //return Redirect("~/Home/Index");
                        //return Redirect(returnUrl ?? "/");
                        //return Redirect(loginModel.returnUrl);
                        //return RedirectToAction("Admin", "Home");

                    }
                }
                ModelState.AddModelError(nameof(loginViewModel.userName), "Неправильно введен логин или пароль");
            }
            return View(loginModel);
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
    }
}
