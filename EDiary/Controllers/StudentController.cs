using EDiary.Models;
using EDiary.Service;
using EDiary.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.IO;
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
            var studentFullName = (from student in context.students
                        join aspusers in context.Users on student.studentUser equals aspusers.Id
                        where student.studentUser == userManager.GetUserId(User)
                        select new Student
                        {
                            studentSurname = student.studentSurname,
                            studentName = student.studentName,
                            studentLastname = student.studentLastname
                        }).ToList();
            return View(studentFullName);
        }

        //смена пароля студента
        public IActionResult ChangePassword(StudentChangePassword student)
        {
            var studentUser = context.Users.Where(stId => stId.Id == userManager.GetUserId(User)).First();
            studentUser.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, student.studentPassword);
            context.Users.Update(studentUser);
            context.SaveChanges();
            return RedirectToAction("Student", "Student");
        }
        
        [HttpPost]
        public IActionResult AddPicture(AvatarModel picture)
        {
            var student = context.students.Where(stId => stId.studentUser == userManager.GetUserId(User)).First();
            if (student.studentPic != null)
            {
                byte[] pic = null;
                using (var binaryReader = new BinaryReader(picture.Picture.OpenReadStream()))
                {
                    pic = binaryReader.ReadBytes((int)picture.Picture.Length);
                }
                student.studentPic = pic;
            }
            context.students.Update(student);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
