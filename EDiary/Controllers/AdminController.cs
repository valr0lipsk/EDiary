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
    [Authorize(Roles ="admin")]
    public class AdminController : Controller
    {
        UserManager<IdentityUser> userManager;
        EDContext context;
        public AdminController(UserManager<IdentityUser> userManager, EDContext context) => (this.userManager, this.context) = (userManager,context);

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
        public string generateLogin()
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
        public IActionResult Admin() => View();

        //добавление студента
        public IActionResult AddStudent(AddStudentModel stGroup)
        {
            var studentLogin = generateLogin();
            var studentPass = generatePassword();
            var groups = context.groups.ToList();
            ViewBag.studentLogin = studentLogin;
            ViewBag.studentPass = studentPass;
            stGroup = new AddStudentModel { groups = groups };
            return PartialView("~/Views/Admin/_addStudent.cshtml", stGroup);
        }
        public IActionResult CreateStudent(AddStudentModel createStudent)
        {
            IdentityUser identityStudentUser = new IdentityUser { Id = createStudent.studentLogin, UserName = "st" + createStudent.studentLogin, NormalizedUserName = ("st" + createStudent.studentLogin).ToUpper(), PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, createStudent.studentPassword) };
            context.Users.Add(identityStudentUser);
            context.SaveChanges();
            Student student = new Student { studentSurname = createStudent.studentSurname, studentName = createStudent.studentName, studentLastname = createStudent.studentLastname, studentRole = "student", studentGroup = context.groups.Where(gr => gr.groupName == createStudent.studentGroup).Select(gr => gr.groupId).First(), studentUser = identityStudentUser.Id };
            context.students.Add(student);
            context.SaveChanges();
            return RedirectToAction("Admin", "Admin");
        }

        //добавление препода
        public IActionResult AddTeacher(AddTeacherModel curGroup)
        {
            var teacherLogin = generateLogin();
            var teacherPass = generatePassword();
            var groups = context.groups.ToList();
            ViewBag.teacherLogin = teacherLogin;
            ViewBag.teacherPass = teacherPass;
            curGroup = new AddTeacherModel { groups = groups };
            return PartialView("~/Views/Admin/_addTeacher.cshtml", curGroup);
        }
        public IActionResult CreateTeacher(AddTeacherModel createTeacher)
        {
            IdentityUser identityTeacherUser = new IdentityUser { Id = createTeacher.teacherLogin, UserName = "tr" + createTeacher.teacherLogin, NormalizedUserName = ("tr" + createTeacher.teacherLogin).ToUpper(), PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, createTeacher.teacherPassword) };
            context.Users.Add(identityTeacherUser);
            context.SaveChanges();
            Teacher teacher = new Teacher { teacherSurname = createTeacher.teacherSurname, teacherName = createTeacher.teacherName, teacherLastname = createTeacher.teacherLastname, teacherRole = "teacher", teacherUser = identityTeacherUser.Id };
            context.teachers.Add(teacher);
            context.SaveChanges();
            var group = context.groups.Where(grId => grId.groupName ==  createTeacher.curatorGroup).First();
            group.curatorId = teacher.teacherId;
            context.groups.Update(group);
            context.SaveChanges();
            return RedirectToAction("Admin", "Admin");
        }

        //добавление предмета
        public IActionResult AddSubject(AddSubjectModel createSubject)
        {
            var groups = context.groups.ToList();
            var teachers = context.teachers.ToList();
            createSubject = new AddSubjectModel { Groups = groups, Teachers = teachers };
            return PartialView("~/Views/Admin/_addSubject.cshtml", createSubject);
        }
        public IActionResult CreateSubject(AddSubjectModel addSubject)
        {
            Subject subject = new Subject { subjectName = addSubject.subjectName };
            context.subjects.Add(subject);
            context.SaveChanges();
            subjectTaught subjectTaught = new subjectTaught { subjectId = subject.subjectId, teacherId = (from teacher in context.teachers where (teacher.teacherSurname + " " + teacher.teacherName + " " + teacher.teacherLastname).Trim() == addSubject.teacher.Trim() select teacher.teacherId).First(), groupId = context.groups.Where(gr => gr.groupName == addSubject.groupName).Select(gr => gr.groupId).First() };
            context.subjectTaughts.Add(subjectTaught);
            context.SaveChanges();
            return RedirectToAction("Admin","Admin");
        }

        //таблица студентов
        public IActionResult ShowStudents()
        {
            var aspUserStudentGroup = from student in context.students
                                      join gr in context.groups on student.studentGroup equals gr.groupId
                                      join aspuser in context.Users on student.studentUser equals aspuser.Id
                                      where student.studentRole == "student"
                                      orderby student.studentSurname
                                      select new AspStudentGroup
                                      {
                                          studentId = student.studentId,
                                          studentLogin = aspuser.UserName,
                                          studentSurname = student.studentSurname,
                                          studentName = student.studentName,
                                          studentLastname = student.studentLastname,
                                          groupName = gr.groupName,
                                          studentEmail= aspuser.Email
                                      };
            return PartialView("~/Views/Admin/_tableStudent.cshtml", aspUserStudentGroup);
        }
        
        //таблица преподов
        public IActionResult ShowTeachers()
        {
            var teachersTable = from teacher in context.teachers
                                join aspuser in context.Users on teacher.teacherUser equals aspuser.Id
                                where teacher.teacherRole=="teacher"
                                orderby teacher.teacherSurname
                                select new AspTeacherSubjectGroup
                                {
                                    teacherId = teacher.teacherId,
                                    teacherLastname = teacher.teacherLastname,
                                    teacherName = teacher.teacherName,
                                    teacherSurname = teacher.teacherSurname,
                                    teacherLogin = aspuser.UserName,
                                    teacherEmail=aspuser.Email,
                                    subjectName = string.Join(", ", (from sub in context.subjects
                                                                     join subTaught in context.subjectTaughts on sub.subjectId equals subTaught.subjectId
                                                                     where subTaught.teacherId == teacher.teacherId
                                                                     orderby teacher.teacherSurname
                                                                     select sub.subjectName.Trim()).ToArray())
                                };
            return PartialView("~/Views/Admin/_tableTeacher.cshtml",teachersTable);
        }

        //таблица предметов
        public IActionResult ShowSubjects()
        {
            var teacherGroupSubject = (from sub in context.subjects
                                       join subTaught in context.subjectTaughts on sub.subjectId equals subTaught.subjectId
                                       join teacher in context.teachers on subTaught.teacherId equals teacher.teacherId
                                       join gr in context.groups on subTaught.groupId equals gr.groupId
                                       orderby sub.subjectName
                                       select new AspTeacherSubjectGroup
                                       {
                                           teacherLastname = teacher.teacherLastname,
                                           teacherName = teacher.teacherName,
                                           teacherSurname = teacher.teacherSurname,
                                           groupName = gr.groupName,
                                           subjectName = string.Join(", ", (from sub in context.subjects
                                                                            join subTaught in context.subjectTaughts on sub.subjectId equals subTaught.subjectId
                                                                            where subTaught.teacherId == teacher.teacherId
                                                                            orderby sub.subjectName
                                                                            select sub.subjectName.Trim()).ToArray())
                                       });

            return PartialView("~/Views/Admin/_tableSubject.cshtml", teacherGroupSubject);
        }
    }
}
  