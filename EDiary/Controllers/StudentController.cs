﻿using EDiary.Models;
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
                                       studentLastname = student.studentLastname,
                                       studentPic = student.studentPic
                                   }).ToList();
            return View(studentFullName);
        }

        //добавление авы студента
        [HttpPost]
        public IActionResult AddPicture(AvatarModel studentPicture)
        {
            var student = context.students.Where(stId => stId.studentUser == userManager.GetUserId(User)).First();
            byte[] pic = null;
            using (var binaryReader = new BinaryReader(studentPicture.Picture.OpenReadStream()))
            {
                pic = binaryReader.ReadBytes((int)studentPicture.Picture.Length);
            }
            student.studentPic = pic;
            context.students.Update(student);
            context.SaveChanges();
            return RedirectToAction("Student", "Student");
        }
    }
}
