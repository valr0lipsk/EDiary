using EDiary.Models;
using EDiary.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using EDiary.Repositories;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EDiary.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        UserManager<IdentityUser> userManager;
        EDContext context;
        public AdminController(UserManager<IdentityUser> userManager, EDContext context) 
            => (this.userManager, this.context) = (userManager,context);

        //генерация пароля
        public static string generatePassword()
        {
            string pass = "";
            var r = new Random();
            while (pass.Length < 8)
            {
                char c = (char)r.Next(33, 125);
                if (char.IsLetterOrDigit(c))
                    pass += c;
            }
            return pass;
        }

        //генерация логина
        public static string generateLogin()
        {
            string login = "";
            var r = new Random();
            while (login.Length < 6)
            {
                char c = (char)r.Next(33, 125);
                if (char.IsDigit(c))
                    login += c;
            }
            return login;
        }

        //представление админа
        public IActionResult Admin()
        {
            return View();
        }

        //добавление студента
        public IActionResult AddStudent(AddStudentModel stGroup)
        {
            var stLogin = generateLogin();
            var stPass = generatePassword();
            var groups = context.groups.ToList();
            ViewBag.stLogin = stLogin;
            ViewBag.stPass = stPass;
            stGroup = new AddStudentModel { groups = groups };
            return PartialView("~/Views/Admin/_addStudent.cshtml", stGroup);
        }

        public IActionResult CreateStudent(AddStudentModel createStudent)
        {
            IdentityUser identityStudentUser = new IdentityUser { Id = context.Users.OrderBy(id => id.Id).Select(user => int.Parse(user.Id) + 1).Last().ToString(), UserName = "st" + createStudent.studentLogin, NormalizedUserName = ("st" + createStudent.studentLogin).ToUpper(), PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, createStudent.studentPassword) };
            context.Users.Add(identityStudentUser);
            context.SaveChanges();
            Users studentUser = new Users { userSurname = createStudent.studentSurname, userName = createStudent.studentName, userLastname = createStudent.studentLastname, userId = identityStudentUser.Id };
            context.users.Add(studentUser);
            context.SaveChanges();
            Student student = new Student { studentRole = "student", studentGroup = context.groups.Where(gr => gr.groupName == createStudent.studentGroup).Select(gr => gr.groupId).First(), studentUser = studentUser.idUser };
            context.students.Add(student);
            context.SaveChanges();
            return RedirectToAction("Admin", "Admin");
        }

        //добавление препода
        public IActionResult AddTeacher(AddTeacherModel curGroup)
        {
            var trLogin = generateLogin();
            var trPass = generatePassword();
            var groups = context.groups.ToList();
            ViewBag.trLogin = trLogin;
            ViewBag.trPass = trPass;
            curGroup = new AddTeacherModel { groups = groups };
            return PartialView("~/Views/Admin/_addTeacher.cshtml", curGroup);
        }
        public IActionResult CreateTeacher(AddTeacherModel createTeacher)
        {
            IdentityUser identityTeacherUser = new IdentityUser { Id = context.Users.OrderBy(id => id.Id).Select(user => int.Parse(user.Id) + 1).Last().ToString(), UserName = "tr" + createTeacher.teacherLogin, NormalizedUserName = ("tr" + createTeacher.teacherLogin).ToUpper(), PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, createTeacher.teacherPassword) };
            context.Users.Add(identityTeacherUser);
            context.SaveChanges();
            Users teacherUser = new Users { userSurname = createTeacher.teacherSurname, userName = createTeacher.teacherName, userLastname = createTeacher.teacherLastname, userId = identityTeacherUser.Id };
            context.users.Add(teacherUser);
            context.SaveChanges();
            Teacher teacher = new Teacher { teacherRole = "teacher", teacherUser = teacherUser.idUser };
            context.teachers.Add(teacher);
            context.SaveChanges();
            collegeGroup group = new collegeGroup { curatorId = (from tr in context.teachers join gr in context.groups on tr.teacherId equals gr.curatorId where gr.groupName == createTeacher.curatorGroup select teacher.teacherId).First() };
            context.groups.Update(group);
            context.SaveChanges();
            return RedirectToAction("Admin", "Admin");
        }
        //добавление предмета
        public IActionResult AddSubject(AddSubjectModel createSubject)
        {
            var usersLINQ = from us in context.users
                            join tr in context.teachers on us.idUser equals tr.teacherUser
                            join aspuser in context.Users on us.userId equals aspuser.Id
                            where tr.teacherRole == "teacher"
                            select new Users
                            {
                                userLastname = us.userLastname,
                                userName = us.userName,
                                userSurname = us.userSurname
                            };
            var teachersLINQ = from tr in context.teachers
                               join us in context.users on tr.teacherUser equals us.idUser
                               join aspuser in context.Users on us.userId equals aspuser.Id
                               where tr.teacherRole == "teacher"
                               select new Teacher
                               {
                                   teacherId = tr.teacherId
                               };
            var groups = context.groups.ToList();
            var users = usersLINQ.ToList();
            var teachers = teachersLINQ.ToList();
            createSubject = new AddSubjectModel { Groups = groups, Users = users, Teachers = teachers };
            return PartialView("~/Views/Admin/_addSubject.cshtml", createSubject);
        }
        public IActionResult CreateSubject(AddSubjectModel addSubject)
        {
            Subject subject = new Subject { subjectName = addSubject.subjectName };
            context.subjects.Add(subject);
            context.SaveChanges();
            subjectTaught subjectTaught = new subjectTaught { subjectId = subject.subjectId, teacherId = (from tr in context.teachers join us in context.users on tr.teacherUser equals us.idUser where (us.userSurname + " " + us.userName + " " + us.userLastname).Trim() == addSubject.teacherFullName.Trim() select tr.teacherId).First(),/*(from us in context.users join tr in context.teachers on us.idUser equals tr.teacherUser where addSubject.teacherFullName.Trim()== (us.userSurname + "" + us.userName + "" + us.userLastname).Trim() select tr.teacherId).First(),*/ groupId = context.groups.Where(gr => gr.groupName == addSubject.groupName).Select(gr => gr.groupId).First() };
            context.subjectTaughts.Add(subjectTaught);
            context.SaveChanges();
            return RedirectToAction("Admin","Admin");
        }

        //таблица студентов
        public IActionResult ShowStudents()
        {
            var aspUserStudentGroup = from us in context.users
                                      join st in context.students on us.idUser equals st.studentUser
                                      join gr in context.groups on st.studentGroup equals gr.groupId
                                      join aspuser in context.Users on us.userId equals aspuser.Id
                                      where st.studentRole == "student"
                                      select new AspUserStudentGroup
                                      {
                                          studentId = st.studentId,
                                          studentLogin=aspuser.UserName,
                                          studentSurname=us.userSurname,
                                          studentName=us.userSurname,
                                          studentLastname=us.userLastname,
                                          groupName=gr.groupName
                                      };
            return PartialView("~/Views/Admin/_tableStudent.cshtml", aspUserStudentGroup);
        }
        
        //таблица преподов
        public IActionResult ShowTeachers()
        {
            var teachersTable = from tr in context.teachers
                                join us in context.users on tr.teacherUser equals us.idUser
                                join aspuser in context.Users on us.userId equals aspuser.Id
                                where tr.teacherRole=="teacher"
                                select new TableTeacherModel
                                {
                                    teacherId = tr.teacherId,
                                    teacherLastname = us.userLastname,
                                    teacherName = us.userName,
                                    teacherSurname = us.userSurname,
                                    teacherLogin = aspuser.UserName,
                                    subjectName = string.Join(", ", (from sub in context.subjects
                                                                     join us in context.users on tr.teacherUser equals us.idUser
                                                                     join aspuser in context.Users on us.userId equals aspuser.Id
                                                                     join subTaught in context.subjectTaughts on sub.subjectId equals subTaught.subjectId
                                                                     where subTaught.teacherId == tr.teacherId
                                                                     select sub.subjectName.Trim()).ToArray())
                                };
            return PartialView("~/Views/Admin/_tableTeacher.cshtml",teachersTable);
        }

        //таблица предметов
        public IActionResult ShowSubjects()
        {
            var teacherGroupSubject = (from tr in context.teachers
                                       join subTaught in context.subjectTaughts on tr.teacherId equals subTaught.teacherId
                                       join sub in context.subjects on subTaught.subjectId equals sub.subjectId
                                       join us in context.users on tr.teacherUser equals us.idUser
                                       join gr in context.groups on subTaught.groupId equals gr.groupId
                                       join aspusers in context.Users on us.userId equals aspusers.Id
                                       where tr.teacherRole == "teacher"
                                       select new TeacherGroupSubjectModel
                                       {
                                           tsubjectId = subTaught.tsubjectId,
                                           teacherSurname = us.userSurname,
                                           teacherName = us.userName,
                                           teacherLastname = us.userLastname,
                                           subjectName = sub.subjectName,
                                           groups = gr.groupName
                                       }).ToList();
            return PartialView("~/Views/Admin/_tableSubject.cshtml", teacherGroupSubject);
        }
    }
}
  