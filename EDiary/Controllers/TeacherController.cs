﻿using EDiary.Models;
using EDiary.Service;
using EDiary.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Controllers
{
    [Authorize]
    public class TeacherController : Controller
    {
        EDContext context;
        private UserManager<IdentityUser> userManager;
        public TeacherController(UserManager<IdentityUser> userManager, EDContext context)=> (this.userManager, this.context) = (userManager, context);

        //представление препода(фамилия, предметы и группы)
        public IActionResult Teacher()
        {
            var teacherNamePic = (from teacher in context.teachers
                               join aspusers in context.Users on teacher.teacherUser equals aspusers.Id
                               where teacher.teacherUser == userManager.GetUserId(User)
                               select new Teacher
                               {
                                   teacherSurname = teacher.teacherSurname,
                                   teacherName = teacher.teacherName,
                                   teacherLastname = teacher.teacherLastname,
                                   teacherPic = teacher.teacherPic
                               }).ToList();

            var subjectGroups = (from tsub in context.subjectTaughts
                          join subject in context.subjects on tsub.subjectId equals subject.subjectId
                          join gr in context.groups on tsub.groupId equals gr.groupId
                          join teacher in context.teachers on tsub.teacherId equals teacher.teacherId
                          join aspusers in context.Users on teacher.teacherUser equals aspusers.Id
                          where teacher.teacherUser == userManager.GetUserId(User)
                          select new SubjectGroup
                          {
                              groupName = gr.groupName,
                              subjectName = subject.subjectName,
                              tsubjectId = tsub.tsubjectId
                          }).ToList();

            AspTeacherSubjectGroup teacherSubjectGroup = new AspTeacherSubjectGroup { Teachers= teacherNamePic, subjectGroups=subjectGroups};
            return View(teacherSubjectGroup);
        }

        //смена пароля преподавателя
        public IActionResult ChangePassword() => View("ChangePasswordTeacher");

        [HttpPost]
        public async Task<IActionResult> ChangePassword(TeacherChangePassword teacherPassword)
        {
            if (ModelState.IsValid)
            {
                IdentityUser student = await userManager.FindByIdAsync(userManager.GetUserId(User));
                if (student != null)
                {
                    IdentityResult result = await userManager.ChangePasswordAsync(student, teacherPassword.oldTeacherPassword, teacherPassword.newTeacherPassword);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Teacher", "Teacher");
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
            return View(teacherPassword);
        }

        //добавление аватарочки преподавателя
        [HttpPost]
        public IActionResult AddPicture(AvatarModel teacherPicture)
        {
            var teacher = context.teachers.Where(trId => trId.teacherUser == userManager.GetUserId(User)).First();
            byte[] pic = null;
            using (var binaryReader = new BinaryReader(teacherPicture.Picture.OpenReadStream()))
            {
                pic = binaryReader.ReadBytes((int)teacherPicture.Picture.Length);
            }
            teacher.teacherPic = pic;
            context.teachers.Update(teacher);
            context.SaveChanges();
            return RedirectToAction("Teacher", "Teacher");
        }

        //представление журнала
        public IActionResult Jurnal() => RedirectToAction("Jurnal", "Marks");
    }
}
