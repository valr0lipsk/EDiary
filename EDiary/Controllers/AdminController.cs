using EDiary.Models;
using EDiary.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using EDiary.Repositories;
using System.Collections.Generic;

namespace EDiary.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        UserManager<IdentityUser> userManager;
        EDContext context;
        public AdminController(UserManager<IdentityUser> userManager, EDContext context) => (this.userManager, this.context) = (userManager,context);
        public IActionResult Admin()
        {
            return View();
        }

        public async Task<IActionResult> AddStudent(CreateStudentModel createStudent)
        {
            if (ModelState.IsValid)
            {
                IdentityUser identityStudentUser = new IdentityUser { UserName = createStudent.studentLogin, PasswordHash=createStudent.studentPassword };
                Users studentUser = new Users {userSurname = createStudent.studentSurname, userName = createStudent.studentName, userLastname = createStudent.studentLastname };
                Student student = new Student { studentRole = "student", studentGroup = createStudent.studentGroup};
                var result = await userManager.CreateAsync(identityStudentUser, createStudent.studentPassword);
                if (result.Succeeded)
                {
                    return RedirectToAction("AddStudent");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return PartialView("~/Views/Admin/_addStudent.cshtml");
        }
        public IActionResult AddTeacher()
        {
            return PartialView("~/Views/Admin/_addTeacher.cshtml");
        }

        public IActionResult AddSubject()
        {
            return PartialView("~/Views/Admin/_addSubject.cshtml");
        }

        public IActionResult ShowStudents()
        {
            var studentsLINQ = from us in context.users
                               join st in context.students on us.idUser equals st.studentUser
                               join gr in context.groups on st.studentGroup equals gr.groupId
                               join aspuser in context.Users on us.userId equals aspuser.Id
                               where st.studentRole == "student"
                               select new Student
                               {
                                   studentId = st.studentId
                               };
            var usersLINQ = from us in context.users
                            join st in context.students on us.idUser equals st.studentUser
                            join gr in context.groups on st.studentGroup equals gr.groupId
                            join aspuser in context.Users on us.userId equals aspuser.Id
                            where st.studentRole=="student"
                            select new Users
                            {
                                userLastname = us.userLastname,
                                userName = us.userName,
                                userSurname = us.userSurname
                            };
            var groupsLINQ = from us in context.users
                             join st in context.students on us.idUser equals st.studentUser
                             join gr in context.groups on st.studentGroup equals gr.groupId
                             join aspuser in context.Users on us.userId equals aspuser.Id
                             where st.studentRole == "student"
                             select new collegeGroup
                             {
                                 groupName = gr.groupName
                             };
            var aspusersLINQ = from us in context.users
                             join st in context.students on us.idUser equals st.studentUser
                             join gr in context.groups on st.studentGroup equals gr.groupId
                             join aspuser in context.Users on us.userId equals aspuser.Id
                             where st.studentRole == "student"
                             select new IdentityUser
                             {
                                 UserName=aspuser.UserName
                             };
            var students = studentsLINQ.ToList();
            var groups = groupsLINQ.ToList();
            var users = usersLINQ.ToList();
            var aspusers = aspusersLINQ.ToList();
            var aspUserStudentGroup = new AspUserStudentGroup { Students = students, Groups = groups, Users = users, AspUsers = aspusers };
            return PartialView("~/Views/Admin/_tableStudent.cshtml", aspUserStudentGroup);
        }

        public IActionResult ShowTeachers()
        {
            var teachersLINQ = from us in context.users
                               join tr in context.teachers on us.idUser equals tr.teacherUser
                               join subTaught in context.subjectTaughts on tr.teacherId equals subTaught.teacherId
                               join sub in context.subjects on subTaught.subjectId equals sub.subjectId
                               join aspuser in context.Users on us.userId equals aspuser.Id
                               where tr.teacherRole == "teacher"
                               select new Teacher
                               {
                                   teacherId = tr.teacherId
                               };
            var usersLINQ = from us in context.users
                            join tr in context.teachers on us.idUser equals tr.teacherUser
                            join subTaught in context.subjectTaughts on tr.teacherId equals subTaught.teacherId
                            join sub in context.subjects on subTaught.subjectId equals sub.subjectId
                            join aspuser in context.Users on us.userId equals aspuser.Id
                            where tr.teacherRole == "teacher"
                            select new Users
                            {
                                userLastname = us.userLastname,
                                userName = us.userName,
                                userSurname = us.userSurname
                            };
            var subjectsLINQ = from us in context.users
                             join tr in context.teachers on us.idUser equals tr.teacherUser
                             join subTaught in context.subjectTaughts on tr.teacherId equals subTaught.teacherId
                             join sub in context.subjects on subTaught.subjectId equals sub.subjectId
                             join aspuser in context.Users on us.userId equals aspuser.Id
                             where tr.teacherRole == "teacher"
                             select new Subject
                             {
                                 subjectName=sub.subjectName
                             };
            var aspusersLINQ = from us in context.users
                               join tr in context.teachers on us.idUser equals tr.teacherUser
                               join subTaught in context.subjectTaughts on tr.teacherId equals subTaught.teacherId
                               join sub in context.subjects on subTaught.subjectId equals sub.subjectId
                               join aspuser in context.Users on us.userId equals aspuser.Id
                               where tr.teacherRole == "teacher"
                               select new IdentityUser
                               {
                                   UserName = aspuser.UserName
                               };
            var teachers = teachersLINQ.ToList();
            var subjects = subjectsLINQ.ToList();
            var users = usersLINQ.ToList();
            var aspusers = aspusersLINQ.ToList();
            var aspUserTeacherSubject = new AspUserTeacherSubject { Subjects = subjects, Teachers = teachers, Users = users, AspUsers = aspusers };
            return PartialView("~/Views/Admin/_tableTeacher.cshtml",aspUserTeacherSubject);
        }
        public IActionResult ShowSubjects()
        {
            return PartialView("~/Views/Admin/_tableSubject.cshtml");
        }
    }
}
