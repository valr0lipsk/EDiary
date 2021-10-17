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
    public class StudentController : Controller
    {
        EDContext context;
        private UserManager<IdentityUser> userManager;
        public StudentController(UserManager<IdentityUser> userManager, EDContext context) => (this.userManager, this.context) = (userManager, context);

        //представление ученика(имя)
        public IActionResult Student()
        {
            var studentFullName = (from user in context.users
                        join aspusers in context.Users on user.userId equals aspusers.Id
                        where user.userId == userManager.GetUserId(User)
                        select new Users
                        {
                            userSurname = user.userSurname,
                            userName = user.userName,
                            userLastname = user.userLastname
                        }).ToList();
            return View(studentFullName);
        }
        //смена пароля преподавателя
        public IActionResult ChangePassword(StudentChangePassword student)
        {
            var studentUser = context.Users.Where(stId => stId.Id == userManager.GetUserId(User)).First();
            studentUser.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, student.studentPassword);
            context.Users.Update(studentUser);
            context.SaveChanges();
            return RedirectToAction("Student", "Student");
        }
    }
}
