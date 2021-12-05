using EDiary.Models;
using EDiary.Service;
using EDiary.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
            var teacherName = (from teacher in context.teachers
                                       join aspusers in context.Users on teacher.teacherUser equals aspusers.Id
                                       where teacher.teacherUser == userManager.GetUserId(User)
                                       select new Teacher
                                       {
                                           teacherSurname = teacher.teacherSurname,
                                           teacherName = teacher.teacherName,
                                           teacherLastname = teacher.teacherLastname
                                       }).ToList();

            var subjects = (from tsub in context.subjectTaughts
                                join subject in context.subjects on tsub.subjectId equals subject.subjectId
                                join teacher in context.teachers on tsub.teacherId equals teacher.teacherId
                                join aspusers in context.Users on teacher.teacherUser equals aspusers.Id
                                where aspusers.Id == userManager.GetUserId(User)
                                select new Subject
                                {
                                    subjectName = subject.subjectName,
                                    subjectId = tsub.tsubjectId
                                }).ToList();

            var group = (from tsub in context.subjectTaughts
                             join subject in context.subjects on tsub.subjectId equals subject.subjectId
                             join gr in context.groups on tsub.groupId equals gr.groupId
                             join teacher in context.teachers on tsub.teacherId equals teacher.teacherId
                             join aspusers in context.Users on teacher.teacherUser equals aspusers.Id
                             where aspusers.Id == userManager.GetUserId(User)
                             select new collegeGroup
                             {
                                 groupName = gr.groupName,
                             }).ToList();

            var teacherSubjectsGroups = new TeacherGroupSubjectModel { Subjects = subjects, Groups = group, Teachers = teacherName };
            return View(teacherSubjectsGroups);
        }

        //смена пароля преподавателя
        public IActionResult ChangePassword(TeacherGroupSubjectModel teacher)
        {
            var teacherUser = context.Users.Where(trId => trId.Id == userManager.GetUserId(User)).First();
            teacherUser.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, teacher.teacherPassword);
            context.Users.Update(teacherUser);
            context.SaveChanges();
            return RedirectToAction("Teacher", "Teacher");
        }
        public IActionResult Jurnal()
        {
            return RedirectToAction("Jurnal", "Marks");
        }
    }
}
