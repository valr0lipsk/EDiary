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
            var teacherFullName = (from user in context.users
                                       join aspusers in context.Users on user.userId equals aspusers.Id
                                       where user.userId == userManager.GetUserId(User)
                                       select new Users
                                       {
                                           userSurname = user.userSurname,
                                           userName = user.userName,
                                           userLastname = user.userLastname
                                       }).ToList();
            var subjects = (from tsub in context.subjectTaughts
                                join st in context.subjects on tsub.subjectId equals st.subjectId
                                join tr in context.teachers on tsub.teacherId equals tr.teacherId
                                join us in context.users on tr.teacherUser equals us.idUser
                                join aspusers in context.Users on us.userId equals aspusers.Id
                                where aspusers.Id == userManager.GetUserId(User)
                                select new Subject
                                {
                                    subjectName = st.subjectName,
                                    subjectId = tsub.tsubjectId
                                }).ToList();
            var group = (from tsub in context.subjectTaughts
                             join st in context.subjects on tsub.subjectId equals st.subjectId
                             join gr in context.groups on tsub.groupId equals gr.groupId
                             join tr in context.teachers on tsub.teacherId equals tr.teacherId
                             join us in context.users on tr.teacherUser equals us.idUser
                             join aspusers in context.Users on us.userId equals aspusers.Id
                             where aspusers.Id == userManager.GetUserId(User)
                             select new collegeGroup
                             {
                                 groupName = gr.groupName,
                             }).ToList();
            var teacherSubjectsGroups = new TeacherGroupSubjectModel { Subjects = subjects, Groups = group, Users = teacherFullName };
            return View(teacherSubjectsGroups);
        }
        public IActionResult Jurnal()
        {
            return RedirectToAction("Jurnal", "Marks");
        }
    }
}
