using EDiary.Models;
using EDiary.Service;
using EDiary.ViewModels;
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
    public class TeacherController : Controller
    {
        EDContext context;
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManager;
        public TeacherController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, EDContext context)=> (this.userManager, this.signInManager, this.context) = (userManager, signInManager, context);

        public IActionResult Teacher()
        {
            SqlConnection con = new SqlConnection(Config.ConnectionString);
            con.Open();
            var name = (from user in context.users
                        join aspusers in context.Users on user.userId equals aspusers.Id
                        where user.userId == userManager.GetUserId(User)
                        select new Users
                        {
                            userSurname = user.userSurname,
                            userName = user.userName,
                            userLastname = user.userLastname
                        });
            var fullname = new SqlCommand($@"select concat(B.userSurname,' ',B.userName, ' ', B.userLastname) as fullname from users B inner join AspNetUsers E on B.userId=E.Id where B.userId={userManager.GetUserId(User)}", con).ExecuteScalar().ToString();
            ViewBag.name = fullname;
            var subjectsLINQ = from tsub in context.subjectTaughts
                               join st in context.subjects on tsub.subjectId equals st.subjectId
                               join tr in context.teachers on tsub.teacherId equals tr.teacherId
                               join us in context.users on tr.teacherUser equals us.idUser
                               join aspusers in context.Users on us.userId equals aspusers.Id
                               where aspusers.Id == userManager.GetUserId(User)
                               select new Subject
                               {
                                   subjectName = st.subjectName,
                                   subjectId = tsub.tsubjectId
                               };
            var groupLINQ = from tsub in context.subjectTaughts
                            join st in context.subjects on tsub.subjectId equals st.subjectId
                            join gr in context.groups on tsub.groupId equals gr.groupId
                            join tr in context.teachers on tsub.teacherId equals tr.teacherId
                            join us in context.users on tr.teacherUser equals us.idUser
                            join aspusers in context.Users on us.userId equals aspusers.Id
                            where aspusers.Id == userManager.GetUserId(User)
                            select new collegeGroup
                            {
                                groupName = gr.groupName,
                            };
            var subjects = subjectsLINQ.ToList();
            var groups = groupLINQ.ToList();
            var subjectsGroups = new GroupSubject { Subjects = subjects, Groups = groups };
            return View(subjectsGroups);
        }
    }
}
