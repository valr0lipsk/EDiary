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
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        UserManager<IdentityUser> userManager;
        EDContext context;
        public AdminController(UserManager<IdentityUser> userManager, EDContext context) => (this.userManager, this.context) = (userManager, context);

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


        /**********CRUD-студента**********/

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
            context.Database.BeginTransaction();
            IdentityUser identityStudentUser = new IdentityUser { Id = createStudent.studentLogin, UserName = "st" + createStudent.studentLogin, NormalizedUserName = ("st" + createStudent.studentLogin).ToUpper(), PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, createStudent.studentPassword) };
            context.Users.Add(identityStudentUser);
            context.SaveChanges();
            userManager.AddToRoleAsync(identityStudentUser, "student");
            Student student = new Student { studentSurname = createStudent.studentSurname, studentName = createStudent.studentName, studentLastname = createStudent.studentLastname, studentGroup = context.groups.Where(gr => gr.groupName == createStudent.studentGroup).Select(gr => gr.groupId).First(), studentUser = identityStudentUser.Id, studentSubgroup = 1 };
            context.students.Add(student);
            context.SaveChanges();
            context.Database.CommitTransactionAsync();
            return RedirectToAction("ShowStudents");
        }

        //удаление студента
        public IActionResult DeleteStudent(TableStudentModel deleteStudent)
        {
            var student = userManager.FindByNameAsync(deleteStudent.studentLogin).Result;
            context.Users.Remove(student);
            context.SaveChanges();
            return RedirectToAction("ShowStudents");
        }

        //обновление студента
        public IActionResult UpdateStudent(TableStudentModel updateStudent)
        {
            var user = userManager.FindByNameAsync(updateStudent.studentLogin).Result;
            user.Email = updateStudent.studentEmail;
            context.Users.Update(user);
            context.SaveChanges();
            var student = context.students.Where(st => st.studentUser == user.Id).First();
            student.studentName = updateStudent.studentName;
            student.studentSurname = updateStudent.studentSurname;
            student.studentLastname = updateStudent.studentLastname;
            student.studentGroup = context.groups.Where(gr => gr.groupName == updateStudent.studentGroup).Select(gr => gr.groupId).First();
            context.students.Update(student);
            context.SaveChanges();
            return RedirectToAction("ShowStudents");
        }

        //таблица студентов
        public IActionResult ShowStudents()
        {
            var students = from student in context.students
                           join gr in context.groups on student.studentGroup equals gr.groupId
                           join aspuser in context.Users on student.studentUser equals aspuser.Id
                           orderby student.studentSurname
                           select new AspStudentGroupModel
                           {
                               studentId = student.studentId,
                               studentLogin = aspuser.UserName,
                               studentSurname = student.studentSurname,
                               studentName = student.studentName,
                               studentLastname = student.studentLastname,
                               groupName = gr.groupName,
                               studentEmail = aspuser.Email,
                               groups = context.groups.ToList()
                           };
            var tableStudents = new TableStudentModel { students = students, groups = context.groups.ToList() };
            return PartialView("~/Views/Admin/_tableStudent.cshtml", tableStudents);
        }



        /**********CRUD-преподавателя**********/

        //добавление препода
        public IActionResult AddTeacher(AddTeacherModel curGroup)
        {
            var teacherLogin = generateLogin();
            var teacherPass = generatePassword();
            var groups = context.groups.ToList();
            ViewBag.teacherLogin = teacherLogin;
            ViewBag.teacherPass = teacherPass;
            curGroup.groups = groups;
            return PartialView("~/Views/Admin/_addTeacher.cshtml", curGroup);
        }
        public IActionResult CreateTeacher(AddTeacherModel createTeacher)
        {
            IdentityUser identityTeacherUser = new IdentityUser { Id = createTeacher.teacherLogin, UserName = "tr" + createTeacher.teacherLogin, NormalizedUserName = ("tr" + createTeacher.teacherLogin).ToUpper(), PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, createTeacher.teacherPassword) };
            context.Users.Add(identityTeacherUser);
            context.SaveChanges();
            userManager.AddToRoleAsync(identityTeacherUser, "teacher");
            context.SaveChanges();
            Teacher teacher = new Teacher { teacherSurname = createTeacher.teacherSurname, teacherName = createTeacher.teacherName, teacherLastname = createTeacher.teacherLastname, teacherUser = identityTeacherUser.Id };
            context.teachers.Add(teacher);
            context.SaveChanges();
            if (createTeacher.curatorGroup != null)
            {
                var group = context.groups.Where(grId => grId.groupName == createTeacher.curatorGroup).FirstOrDefault();
                group.curatorId = teacher.teacherId;
                context.groups.Update(group);
            }
            context.SaveChanges();
            return RedirectToAction("ShowTeachers");
        }
        
        //удаление препода
        public IActionResult DeleteTeacher(TableTeacherModel deleteTeacher)
        {
            var teacher = userManager.FindByNameAsync(deleteTeacher.teacherLogin).Result;
            context.Users.Remove(teacher);
            context.SaveChanges();
            return RedirectToAction("ShowTeachers");
        }
        
        //обновление препода
        public IActionResult UpdateTeacher(TableTeacherModel updateTeacher)
        {
            var user = userManager.FindByNameAsync(updateTeacher.teacherLogin).Result;
            user.Email = updateTeacher.teacherEmail;
            context.Users.Update(user);
            context.SaveChanges();
            var teacher = context.teachers.Where(tr => tr.teacherUser == user.Id).First();
            teacher.teacherName = updateTeacher.teacherName;
            teacher.teacherSurname = teacher.teacherSurname;
            teacher.teacherLastname = teacher.teacherLastname;
            context.teachers.Update(teacher);
            context.SaveChanges();
            return RedirectToAction("ShowTeachers");
        }

        //таблица преподов
        public IActionResult ShowTeachers()
        {
            var teachers = (from teacher in context.teachers
                            join aspuser in context.Users on teacher.teacherUser equals aspuser.Id
                            orderby teacher.teacherSurname
                            select new AspTeacherSubjectGroupModel
                            {
                                teacherId = teacher.teacherId,
                                teacherLastname = teacher.teacherLastname,
                                teacherName = teacher.teacherName,
                                teacherSurname = teacher.teacherSurname,
                                teacherLogin = aspuser.UserName,
                                teacherEmail = aspuser.Email,
                                subjectName = string.Join(", ", (from sub in context.subjects
                                                                 join subTaught in context.subjectTaughts on sub.subjectId equals subTaught.subjectId
                                                                 where subTaught.teacherId == teacher.teacherId
                                                                 orderby teacher.teacherSurname
                                                                 select sub.subjectName.Trim()).ToArray()),
                                groupName = (from sub in context.subjects
                                             join subTaught in context.subjectTaughts on sub.subjectId equals subTaught.subjectId
                                             join gr in context.groups on subTaught.groupId equals gr.groupId
                                             where subTaught.teacherId == teacher.teacherId
                                             orderby teacher.teacherSurname
                                             select gr.groupName).FirstOrDefault(),
                                groups = context.groups.ToList()

                            }).ToList();
            var tableTeachers = new TableTeacherModel { teachers = teachers, groups = context.groups.ToList() };
            return PartialView("~/Views/Admin/_tableTeacher.cshtml", tableTeachers);
        }



        /**********CRUD-предмета**********/

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
            subjectTaught subjectTaught = new subjectTaught
            {
                subjectId = subject.subjectId,
                teacherId = context.teachers.Where(tr => string.Join(" ", tr.teacherSurname, tr.teacherName, tr.teacherLastname).Trim() == addSubject.firstTeacher.Trim())
                                            .Select(tr => tr.teacherId).FirstOrDefault(),
                groupId = context.groups.Where(gr => gr.groupName == addSubject.groupName)
                                        .Select(gr => gr.groupId).FirstOrDefault()
            };
            context.subjectTaughts.Add(subjectTaught);
            context.SaveChanges();
            if(addSubject.haveLabs)
            {
                Labs labaFirst = new Labs
                {
                    labName = string.Join(" ", addSubject.subjectName, "(лабораторная, 1-ая подгруппа)"),
                    subgroupId = 1,
                    teacherId = subjectTaught.teacherId,
                    countLabs = addSubject.labsCount,
                    tsubjectId = subjectTaught.tsubjectId
                };
                context.labs.Add(labaFirst);
                context.SaveChanges();
                Labs labaSecond = new Labs
                {
                    labName = string.Join(" ", addSubject.subjectName, "(лабораторная, 2-ая подгруппа)"),
                    subgroupId = 2,
                    teacherId = context.teachers.Where(tr => string.Join(" ", tr.teacherSurname, tr.teacherName, tr.teacherLastname).Trim() == addSubject.secondTeacher.Trim())
                                            .Select(tr => tr.teacherId).FirstOrDefault(),
                    countLabs = addSubject.labsCount,
                    tsubjectId = subjectTaught.tsubjectId
                };
                context.labs.Add(labaSecond);
                context.SaveChanges();
            }
            return RedirectToAction("ShowSubjects");
        }

        //удаление предмета
        public IActionResult DeleteSubject(TableSubjectModel deleteSubject)
        {
            var subject = context.subjects.Where(s => s.subjectName == deleteSubject.subjectName).FirstOrDefault();
            context.subjects.Remove(subject);
            context.SaveChanges();
            return RedirectToAction("ShowSubjects");
        }

        //обновление предмета  нужно доделать!!!
        public IActionResult UpdateSubject(TableSubjectModel updateSubject)
        {
            var subject = context.subjects.Where(s => s.subjectId == updateSubject.subjectId).FirstOrDefault();
            subject.subjectName = updateSubject.subjectName;
            context.subjects.Update(subject);
            context.SaveChanges();
            var teacher = context.teachers.Where(tr => string.Join(" ", tr.teacherSurname, tr.teacherName.Substring(0, 1) + ".", tr.teacherLastname.Substring(0, 1) + ".") == updateSubject.teacher).FirstOrDefault();
            var group = context.groups.Where(gr => gr.groupName == updateSubject.group).FirstOrDefault();
            var subTaught = context.subjectTaughts.Where(sT => sT.subjectId == subject.subjectId).FirstOrDefault();
            context.subjectTaughts.Update(subTaught);
            context.SaveChanges();
            return RedirectToAction("Show");
        }

        //таблица предметов
        public IActionResult ShowSubjects()
        {
            var subjects = (from teacher in context.teachers
                                       join aspuser in context.Users on teacher.teacherUser equals aspuser.Id
                                       from sub in context.subjects
                                       join subTaught in context.subjectTaughts on sub.subjectId equals subTaught.subjectId
                                       where subTaught.teacherId == teacher.teacherId
                                       orderby sub.subjectName
                                       select new AspTeacherSubjectGroupModel
                                       {
                                           teacherFullname = string.Join(", ", string.Join(" ", teacher.teacherSurname, teacher.teacherName.Substring(0, 1).Trim() + ".", teacher.teacherLastname.Substring(0, 1).Trim() + ".")),
                                           subjectName = sub.subjectName,
                                           groupName = (from sub in context.subjects
                                                        join subTaught in context.subjectTaughts on sub.subjectId equals subTaught.subjectId
                                                        join gr in context.groups on subTaught.groupId equals gr.groupId
                                                        where subTaught.teacherId == teacher.teacherId
                                                        orderby sub.subjectName
                                                        select gr.groupName).FirstOrDefault(),
                                       }).ToList();
            var groups = context.groups.ToList();
            var teachers = context.teachers.ToList();
            var tableSubjects = new TableSubjectModel { teachers = teachers, subjects = subjects, groups = groups };
            return PartialView("~/Views/Admin/_tableSubject.cshtml", tableSubjects);
        }



        /**********CRUD-группы**********/

        //добавление группы
        public IActionResult AddGroup(TableGroupModel addGroup)
        {
            var teachers = context.teachers.ToList();
            return PartialView("~/Views/Admin/_addGroup.cshtml", teachers);
        }
        //public IActionResult CreateGroup(TableGroupModel addGroup)
        //{
        //    Subject subject = new Subject { subjectName = addSubject.subjectName };
        //    context.subjects.Add(subject);
        //    context.SaveChanges();
        //    subjectTaught subjectTaught = new subjectTaught
        //    {
        //        subjectId = subject.subjectId,
        //        teacherId = context.teachers.Where(tr => string.Join(" ", tr.teacherSurname, tr.teacherName, tr.teacherLastname).Trim() == addSubject.firstTeacher.Trim())
        //                                    .Select(tr => tr.teacherId).FirstOrDefault(),
        //        groupId = context.groups.Where(gr => gr.groupName == addSubject.groupName)
        //                                .Select(gr => gr.groupId).FirstOrDefault()
        //    };
        //    context.subjectTaughts.Add(subjectTaught);
        //    context.SaveChanges();
        //    if (addSubject.haveLabs)
        //    {
        //        Labs labaFirst = new Labs
        //        {
        //            labName = string.Join(" ", addSubject.subjectName, "(лабораторная, 1-ая подгруппа)"),
        //            subgroupId = 1,
        //            teacherId = subjectTaught.teacherId,
        //            countLabs = addSubject.labsCount,
        //            tsubjectId = subjectTaught.tsubjectId
        //        };
        //        context.labs.Add(labaFirst);
        //        context.SaveChanges();
        //        Labs labaSecond = new Labs
        //        {
        //            labName = string.Join(" ", addSubject.subjectName, "(лабораторная, 2-ая подгруппа)"),
        //            subgroupId = 2,
        //            teacherId = context.teachers.Where(tr => string.Join(" ", tr.teacherSurname, tr.teacherName, tr.teacherLastname).Trim() == addSubject.secondTeacher.Trim())
        //                                    .Select(tr => tr.teacherId).FirstOrDefault(),
        //            countLabs = addSubject.labsCount,
        //            tsubjectId = subjectTaught.tsubjectId
        //        };
        //        context.labs.Add(labaSecond);
        //        context.SaveChanges();
        //    }
        //    return RedirectToAction("ShowSubjects");
        //}

        ////удаление группы
        //public IActionResult DeleteGroup(TableSubjectModel deleteSubject)
        //{
        //    var subject = context.subjects.Where(s => s.subjectName == deleteSubject.subjectName).FirstOrDefault();
        //    context.subjects.Remove(subject);
        //    context.SaveChanges();
        //    return RedirectToAction("ShowSubjects");
        //}

        ////обновление группы 
        //public IActionResult UpdateGroup(TableSubjectModel updateSubject)
        //{
        //    var subject = context.subjects.Where(s => s.subjectId == updateSubject.subjectId).FirstOrDefault();
        //    subject.subjectName = updateSubject.subjectName;
        //    context.subjects.Update(subject);
        //    context.SaveChanges();
        //    var teacher = context.teachers.Where(tr => string.Join(" ", tr.teacherSurname, tr.teacherName.Substring(0, 1) + ".", tr.teacherLastname.Substring(0, 1) + ".") == updateSubject.teacher).FirstOrDefault();
        //    var group = context.groups.Where(gr => gr.groupName == updateSubject.group).FirstOrDefault();
        //    var subTaught = context.subjectTaughts.Where(sT => sT.subjectId == subject.subjectId).FirstOrDefault();
        //    context.subjectTaughts.Update(subTaught);
        //    context.SaveChanges();
        //    return RedirectToAction("Show");
        //}

        ////таблица групп
        //public IActionResult ShowGroups()
        //{
        //    var subjects = (from teacher in context.teachers
        //                    join aspuser in context.Users on teacher.teacherUser equals aspuser.Id
        //                    from sub in context.subjects
        //                    join subTaught in context.subjectTaughts on sub.subjectId equals subTaught.subjectId
        //                    where subTaught.teacherId == teacher.teacherId
        //                    orderby sub.subjectName
        //                    select new AspTeacherSubjectGroupModel
        //                    {
        //                        teacherFullname = string.Join(", ", string.Join(" ", teacher.teacherSurname, teacher.teacherName.Substring(0, 1).Trim() + ".", teacher.teacherLastname.Substring(0, 1).Trim() + ".")),
        //                        subjectName = sub.subjectName,
        //                        groupName = (from sub in context.subjects
        //                                     join subTaught in context.subjectTaughts on sub.subjectId equals subTaught.subjectId
        //                                     join gr in context.groups on subTaught.groupId equals gr.groupId
        //                                     where subTaught.teacherId == teacher.teacherId
        //                                     orderby sub.subjectName
        //                                     select gr.groupName).FirstOrDefault(),
        //                    }).ToList();
        //    var groups = context.groups.ToList();
        //    var teachers = context.teachers.ToList();
        //    var tableSubjects = new TableSubjectModel { teachers = teachers, subjects = subjects, groups = groups };
        //    return PartialView("~/Views/Admin/_tableSubject.cshtml", tableSubjects);
        //}
    }
}
  