using EDiary.Models;
using EDiary.ViewModels;
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
    public class MarksController : Controller
    {
        EDContext context;
        public MarksController(EDContext context) => this.context = context;

        //представление журнала
        public IActionResult Jurnal()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Jurnal(int id)
        {
            var subid = id;
            var teacherGroup = (from user in context.users
                                join tr in context.teachers on user.idUser equals tr.teacherUser
                                join subTaught in context.subjectTaughts on tr.teacherId equals subTaught.teacherId
                                join st in context.subjects on subTaught.subjectId equals st.subjectId
                                join gr in context.groups on subTaught.groupId equals gr.groupId
                                join aspusers in context.Users on user.userId equals aspusers.Id
                                where subTaught.tsubjectId == subid
                                select new TeacherGroupSubjectModel
                                {
                                    teacherSurname = user.userSurname,
                                    teacherName = user.userName,
                                    teacherLastname = user.userLastname,
                                    groups = gr.groupName,
                                    subjectName = st.subjectName
                                }).ToList();
            var group = (from user in context.users
                         join tr in context.teachers on user.idUser equals tr.teacherUser
                         join subTaught in context.subjectTaughts on subid equals subTaught.tsubjectId
                         join st in context.subjects on subTaught.subjectId equals st.subjectId
                         join gr in context.groups on subTaught.groupId equals gr.groupId
                         join aspusers in context.Users on user.userId equals aspusers.Id
                         where subTaught.tsubjectId == subid
                         select new collegeGroup
                         {
                             groupName = gr.groupName,
                         }).ToList();
            return View(teacherGroup);
        }
    }
}
