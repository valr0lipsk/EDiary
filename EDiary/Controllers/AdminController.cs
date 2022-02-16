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
using System.Data.Common;
using EDiary.Service;
using EDiary.IRepositories;

namespace EDiary.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        UserManager<IdentityUser> userManager;
        EDContext context;
        IUserRepository usersRep;
        IStudentRepository studentsRep;
        ITeacherRepository teachersRep;
        ISubjectsRepository subjectsRep;
        IGroupRepository groupsRep;
        public AdminController(UserManager<IdentityUser> userManager, EDContext context, IUserRepository usersRep, IStudentRepository studentsRep, ITeacherRepository teachersRep, ISubjectsRepository subjectsRep, IGroupRepository groupsRep)
                           => (this.userManager, this.context, this.usersRep, this.studentsRep, this.teachersRep, this.subjectsRep, this.groupsRep) = (userManager, context, usersRep, studentsRep, teachersRep, subjectsRep, groupsRep);

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
            if (userManager.FindByNameAsync("st" + studentLogin).Result != null) 
            {
                studentLogin = generateLogin();
            }
            var studentPass = generatePassword();
            var groups = groupsRep.allGroups();
            ViewBag.studentLogin = studentLogin;
            ViewBag.studentPass = studentPass;
            stGroup = new AddStudentModel { groups = groups };
            return PartialView("~/Views/Admin/_addStudent.cshtml", stGroup);
        }
        public async Task <IActionResult> CreateStudent(AddStudentModel createStudent)
        {
            using var transaction = context.Database.BeginTransaction();
            if (groupsRep.getGroup(createStudent.studentGroup) != null)
            { 
                IdentityUser user = new IdentityUser
                {
                    Id = createStudent.studentLogin,
                    UserName = "st" + createStudent.studentLogin,
                    NormalizedUserName = ("st" + createStudent.studentLogin).ToUpper(),
                    PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, createStudent.studentPassword)
                };
                await usersRep.createUserAsync(user);
                Student student = new Student
                {
                    studentSurname = createStudent.studentSurname,
                    studentName = createStudent.studentName,
                    studentLastname = createStudent.studentLastname,
                    studentGroup = groupsRep.getGroup(createStudent.studentGroup).groupId,
                    studentUser = user.Id
                };
                await studentsRep.createStudentAsync(student);
                await userManager.AddToRoleAsync(user, "student");
                transaction.Commit();
                return RedirectToAction("Admin");
            }
            else
            {
                transaction.Rollback();
                return Json("Group does not exist");
            }
        }

        //удаление студента
        public async Task <IActionResult> DeleteStudent(TableStudentModel deleteStudent)
        {
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var student = userManager.FindByNameAsync(deleteStudent.studentLogin).Result;
                await usersRep.removeUserAsync(student);
                transaction.Commit();
                return RedirectToAction("Admin");
            }
            catch
            {
                transaction.Rollback();
                return Json("Error of delete student");
            }
            
        }

        //обновление студента
        public async Task <IActionResult> UpdateStudent(TableStudentModel updateStudent)
        {
            using var transaction = context.Database.BeginTransaction();
            if (groupsRep.getGroup(updateStudent.studentGroup) != null)
            {
                //пользователь
                var user = userManager.FindByNameAsync(updateStudent.studentLogin).Result;
                user.Email = updateStudent.studentEmail;
                await usersRep.updateUserAsync(user);
                //студент
                var student = studentsRep.findStudent(user.Id);
                student.studentName = updateStudent.studentName;
                student.studentSurname = updateStudent.studentSurname;
                student.studentLastname = updateStudent.studentLastname;
                student.studentGroup = groupsRep.getGroup(updateStudent.studentGroup).groupId;
                await studentsRep.updateStudentAsync(student);
                transaction.Commit();
                return RedirectToAction("Admin");
            }
            else
            {
                transaction.Rollback();
                return Json("Group does not exist");
            }
        }

        //таблица студентов
        public IActionResult ShowStudents()
        {
            var students = from student in context.students
                           join gr in context.groups on student.studentGroup equals gr.groupId
                           join aspuser in context.Users on student.studentUser equals aspuser.Id
                           orderby student.studentSurname, student.studentName
                           select new AspStudentGroupModel
                           {
                               studentId = student.studentId,
                               studentLogin = aspuser.UserName,
                               studentSurname = student.studentSurname,
                               studentName = student.studentName,
                               studentLastname = student.studentLastname,
                               groupName = gr.groupName,
                               studentEmail = aspuser.Email,
                           };
            var tableStudents = new TableStudentModel { students = students, groups = groupsRep.allGroups() };
            return PartialView("~/Views/Admin/_tableStudent.cshtml", tableStudents);
        }



        /**********CRUD-преподавателя**********/

        //добавление препода
        public IActionResult AddTeacher(AddTeacherModel curGroup)
        {
            var teacherLogin = generateLogin();
            if (userManager.FindByNameAsync("tr" + teacherLogin).Result != null) 
            {
                teacherLogin = generateLogin();
            }
            var teacherPass = generatePassword();
            var groups = groupsRep.allGroups();
            ViewBag.teacherLogin = teacherLogin;
            ViewBag.teacherPass = teacherPass;
            curGroup.groups = groups;
            return PartialView("~/Views/Admin/_addTeacher.cshtml", curGroup);
        }
        public async Task <IActionResult> CreateTeacher(AddTeacherModel createTeacher)
        {
            using var transaction = context.Database.BeginTransaction();
            if (groupsRep.getGroup(createTeacher.curatorGroup) != null)
            {
                IdentityUser user = new IdentityUser
                {
                    Id = createTeacher.teacherLogin,
                    UserName = "tr" + createTeacher.teacherLogin,
                    NormalizedUserName = ("tr" + createTeacher.teacherLogin).ToUpper(),
                    PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, createTeacher.teacherPassword)
                };
                await usersRep.createUserAsync(user);
                Teacher teacher = new Teacher
                {
                    teacherSurname = createTeacher.teacherSurname,
                    teacherName = createTeacher.teacherName,
                    teacherLastname = createTeacher.teacherLastname,
                    teacherUser = user.Id
                };
                await teachersRep.createTeacherAsync(teacher);
                if (createTeacher.curatorGroup != null)
                {
                    var group = groupsRep.getGroup(createTeacher.curatorGroup);
                    group.curatorId = teacher.teacherId;
                    await groupsRep.updateGroupAsync(group);
                }
                await userManager.AddToRoleAsync(user, "teacher");
                await context.SaveChangesAsync();
                transaction.Commit();
                return RedirectToAction("Admin");
            }
            else
            {
                transaction.Rollback();
                return Json("Group does not exist");
            }

        }

        //удаление препода
        public async Task <IActionResult> DeleteTeacher(TableTeacherModel deleteTeacher)
        {
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var teacher = userManager.FindByNameAsync(deleteTeacher.teacherLogin).Result;
                await usersRep.removeUserAsync(teacher);
                return RedirectToAction("Admin");
            }
            catch
            {
                transaction.Rollback();
                return Json("Error of delete teacher");
            }
        }
        
        //обновление препода
        public async Task <IActionResult> UpdateTeacher(TableTeacherModel updateTeacher)
        {
            using var transaction = context.Database.BeginTransaction();
            try
            {
                //пользователь
                var user = userManager.FindByNameAsync(updateTeacher.teacherLogin).Result;
                user.Email = updateTeacher.teacherEmail;
                await usersRep.updateUserAsync(user);
                //преподаватель
                var teacher = teachersRep.findTeacher(user.Id);
                teacher.teacherName = updateTeacher.teacherName;
                teacher.teacherSurname = updateTeacher.teacherSurname;
                teacher.teacherLastname = updateTeacher.teacherLastname;
                await teachersRep.updateTeacherAsync(teacher);
                transaction.Commit();
                return RedirectToAction("Admin");
            }
            catch
            {
                transaction.Rollback();
                return Json("Error of update teacher");
            }
        }

        //таблица преподов
        public IActionResult ShowTeachers()
        {
            var teachers = context.teachers.Select(tr => new AspTeacherSubjectGroupModel
            {
                teacherId = tr.teacherId,
                teacherLastname = tr.teacherLastname,
                teacherName = tr.teacherName,
                teacherSurname = tr.teacherSurname,
                teacherLogin = tr.user.UserName,
                teacherEmail = tr.user.Email,
                subjectName = string.Join(", ", context.subjectTaughts.Where(teacher => teacher.teacherId == tr.teacherId).Distinct().Select(sub => sub.subject.subjectId).ToArray())
            }).AsNoTracking().ToList();
            var tableTeachers = new TableTeacherModel { teachers = teachers, groups = groupsRep.allGroups() };
            return PartialView("~/Views/Admin/_tableTeacher.cshtml", tableTeachers);
        }



        /**********CRUD-предмета**********/

        //добавление предмета
        public IActionResult AddSubject(AddSubjectModel createSubject)
        {
            var groups = groupsRep.allGroups();
            var teachers = teachersRep.allTeachers();
            var icons = subjectsRep.allSubjectIcons();
            createSubject = new AddSubjectModel { groups = groups, teachers = teachers, icons = icons };
            return PartialView("~/Views/Admin/_addSubject.cshtml", createSubject);
        }
        public async Task <IActionResult> CreateSubject(AddSubjectModel addSubject)
        {
            var havedSub = context.subjectTaughts.Where(s => s.subject.subjectName.Trim() == addSubject.subjectName.Trim())
                                                 .Where(tr => tr.teacher.teacherSurname + " " + tr.teacher.teacherName + " " + tr.teacher.teacherLastname == addSubject.firstTeacher.Trim())
                                                 .Where(gr => gr.group.groupName.Trim() == addSubject.groupName.Trim())
                                                 .Select(s=>s).FirstOrDefault();
            var sub = subjectsRep.findSubject(addSubject.subjectName);
            if (havedSub == null) 
            {
                if (sub == null)
                {
                    using var transaction = context.Database.BeginTransaction();
                    if (groupsRep.getGroup(addSubject.groupName) != null)
                    {
                        Subject subject = new Subject { subjectName = addSubject.subjectName, subjectPicture = addSubject.subjectIcon };
                        await subjectsRep.createSubjectAsync(subject);
                        subjectTaught subjectTaught = new subjectTaught
                        {
                            subjectId = subject.subjectId,
                            teacherId = context.teachers.Where(tr => tr.teacherSurname + " " + tr.teacherName + " " + tr.teacherLastname == addSubject.firstTeacher)
                                                        .Select(tr => tr.teacherId).FirstOrDefault(),
                            groupId = groupsRep.getGroup(addSubject.groupName).groupId
                        };
                        await subjectsRep.createSubjectTaughtAsync(subjectTaught);

                        if (addSubject.secondTeacher != null)
                        {
                            Labs labaFirst = new Labs
                            {
                                labName = addSubject.subjectName.Trim() + " (лабораторная, 1-ая подгруппа)",
                                subgroupId = 1,
                                teacherId = subjectTaught.teacherId,
                                countLabs = addSubject.labsCount,
                                tsubjectId = subjectTaught.tsubjectId
                            };
                            await subjectsRep.createLabAsync(labaFirst);
                            Labs labaSecond = new Labs
                            {
                                labName = addSubject.subjectName.Trim() + " (лабораторная, 2-ая подгруппа)",
                                subgroupId = 2,
                                teacherId = context.teachers.Where(tr => tr.teacherSurname + " " + tr.teacherName + " " + tr.teacherLastname == addSubject.secondTeacher)
                                                            .Select(tr => tr.teacherId).FirstOrDefault(),
                                countLabs = addSubject.labsCount,
                                tsubjectId = subjectTaught.tsubjectId
                            };
                            await subjectsRep.createLabAsync(labaSecond);
                        }
                        transaction.Commit();
                        return RedirectToAction("Admin");
                    }
                    else
                    {
                        transaction.Rollback();
                        return Json("Group does not exist");
                    }
                }
                else
                {
                    using var transaction = context.Database.BeginTransaction();
                    if (groupsRep.getGroup(addSubject.groupName) != null) 
                    {
                        subjectTaught subjectTaught = new subjectTaught
                        {
                            subjectId = sub.subjectId,
                            teacherId = context.teachers.Where(tr => tr.teacherSurname + " " + tr.teacherName + " " + tr.teacherLastname == addSubject.firstTeacher)
                                                       .Select(tr => tr.teacherId).FirstOrDefault(),
                            groupId = groupsRep.getGroup(addSubject.groupName).groupId
                        };
                        await subjectsRep.createSubjectTaughtAsync(subjectTaught);
                        if (addSubject.secondTeacher != null)
                        {
                            Labs labaFirst = new Labs
                            {
                                labName = addSubject.subjectName + "(лабораторная, 1-ая подгруппа)",
                                subgroupId = 1,
                                teacherId = subjectTaught.teacherId,
                                countLabs = addSubject.labsCount,
                                tsubjectId = subjectTaught.tsubjectId
                            };
                            await subjectsRep.createLabAsync(labaFirst);
                            Labs labaSecond = new Labs
                            {
                                labName = addSubject.subjectName + "(лабораторная, 2-ая подгруппа)",
                                subgroupId = 2,
                                teacherId = context.teachers.Where(tr => tr.teacherSurname + " " + tr.teacherName + " " + tr.teacherLastname == addSubject.secondTeacher)
                                                            .Select(tr => tr.teacherId).FirstOrDefault(),
                                countLabs = addSubject.labsCount,
                                tsubjectId = subjectTaught.tsubjectId
                            };
                            await subjectsRep.createLabAsync(labaSecond);
                        }
                        transaction.Commit();
                        return RedirectToAction("Admin");
                    }
                    else
                    {
                        transaction.Rollback();
                        return Json("Group does not exist");
                    }
                }
            }
            else 
            {
                return Json("Subject is already exist");
            }     
        }

        //удаление предмета
        public async Task <IActionResult> DeleteSubject(TableSubjectModel deleteSubject)
        {
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var subjectTaught = subjectsRep.findSubjectTaught(deleteSubject.tsubjectId);
                await subjectsRep.removeSubjectTaughtAsync(subjectTaught);
                transaction.Commit();
                return RedirectToAction("Admin");
            }
            catch
            {
                transaction.Rollback();
                return Json("Error of delete subject");
            }
        }

        //обновление предмета 
        public async Task <IActionResult> UpdateSubject(TableSubjectModel updateSubject)
        {
            var havedSub = context.subjectTaughts.Where(s => s.subject.subjectName.Trim() == updateSubject.subjectName.Trim())
                                                 .Where(tr => tr.teacher.teacherSurname + " " + tr.teacher.teacherName + " " + tr.teacher.teacherLastname == updateSubject.teacher.Trim())
                                                 .Where(gr => gr.group.groupName.Trim() == updateSubject.group.Trim())
                                                 .Select(s => s).FirstOrDefault();
            
            if (havedSub == null)
            {
                using var transaction = context.Database.BeginTransaction();
                var subjectTaught = subjectsRep.findSubjectTaught(updateSubject.tsubjectId);
                var subjectId = subjectsRep.findSubject(updateSubject.subjectName).subjectId;
                var groupId = groupsRep.getGroup(updateSubject.group).groupId;
                var teacherId= context.teachers.Where(tr => (tr.teacherSurname + " " + tr.teacherName.Substring(0, 1) + ". " + tr.teacherLastname.Substring(0, 1) + ". ") == updateSubject.teacher.Trim())
                                               .Select(tr => tr.teacherId).FirstOrDefault();
                if (subjectId != 0)
                {
                    subjectTaught.subjectId = subjectId;
                }
                else
                {
                    transaction.Rollback();
                    return Json ("Subject does not exist");                                               
                }
                if (groupId != 0)
                {
                    subjectTaught.groupId = groupId;
                }
                else
                {
                    transaction.Rollback();
                    return Json("Group does not exist");
                }
                if (teacherId != 0)
                {
                    subjectTaught.teacherId = teacherId;
                }
                else
                {
                    transaction.Rollback();
                    return Json("Teacher does not exist");
                }
                await subjectsRep.updateSubjectTaughtAsync(subjectTaught);
                transaction.Commit();
                return RedirectToAction("Admin");
            }
            else
            { 
                return Json("Subject is already exist");
            }
        }

        //таблица предметов
        public IActionResult ShowSubjects()
        {
            var subjects = (from teacher in context.teachers
                            join aspuser in context.Users on teacher.teacherUser equals aspuser.Id
                            from sub in context.subjects
                            join subTaught in context.subjectTaughts on sub.subjectId equals subTaught.subjectId
                            join gr in context.groups on subTaught.groupId equals gr.groupId
                            where subTaught.teacherId == teacher.teacherId
                            orderby sub.subjectName
                            select new AspTeacherSubjectGroupModel
                            {
                                teacherFullname = string.Join(" ", teacher.teacherSurname, teacher.teacherName.Substring(0, 1).Trim() + ".", teacher.teacherLastname.Substring(0, 1).Trim() + "."),
                                subjectName = sub.subjectName,
                                groupName = gr.groupName,
                                tsubjectId = subTaught.tsubjectId
                            }).AsNoTracking().ToList();
            var groups = groupsRep.allGroups();
            var teachers = teachersRep.allTeachers();
            var tableSubjects = new TableSubjectModel { teachers = teachers, subjects = subjects, groups = groups };
            return PartialView("~/Views/Admin/_tableSubject.cshtml", tableSubjects);
        }



        /**********CRUD-группы**********/

        //добавление группы
        public IActionResult AddGroup(TableGroupModel addGroup)
        {
            var teachers = teachersRep.allTeachers();
            addGroup = new TableGroupModel { teachers = teachers };
            return PartialView("~/Views/Admin/_addGroup.cshtml", addGroup);
        }
        public async Task <IActionResult> CreateGroup(TableGroupModel addGroup)
        {
            if (groupsRep.getGroup(addGroup.groupName) == null)
            {
                using var transaction = context.Database.BeginTransaction();
                try
                {
                    collegeGroup group = new collegeGroup
                    {
                        groupName = addGroup.groupName,
                        curatorId = context.teachers.Where(tr => (tr.teacherSurname + " " + tr.teacherName.Substring(0, 1) + "." + " " + tr.teacherLastname.Substring(0, 1) + ".") == addGroup.curator)
                                                    .Select(tr => tr.teacherId)
                                                    .FirstOrDefault()
                    };
                    await groupsRep.createGroupAsync(group);
                    transaction.Commit();
                    return RedirectToAction("Admin");
                }
                catch
                {
                    transaction.Rollback();
                    return Json("Error of add group");
                }
            }
            else 
            {
                return Json("Group is already exists");
            }
        }

        //обновление группы
        public async Task<IActionResult> UpdateGroup(TableGroupModel addGroup)
        {
            var group = context.groups.Where(gr => gr.groupId == addGroup.groupId).FirstOrDefault();
            var groupName = groupsRep.getGroup(addGroup.groupName);
            if (groupName == null)
            {
                using var transaction = context.Database.BeginTransaction();
                try
                {
                    group.groupName = addGroup.groupName;
                    group.curatorId = context.teachers.Where(tr => (tr.teacherSurname + " " + tr.teacherName.Substring(0, 1) + "." + " " + tr.teacherLastname.Substring(0, 1) + ".") == addGroup.curator)
                                                      .Select(tr => tr.teacherId)
                                                      .FirstOrDefault();
                    await groupsRep.updateGroupAsync(group);
                    transaction.Commit();
                    return RedirectToAction("Admin");
                }
                catch
                {
                    transaction.Rollback();
                    return Json("Error of update group");
                }
            }
            else
            {
                return Json("Group is already exists");
            }
        }

        //удаление группы
        public async Task<IActionResult> DeleteGroup(TableGroupModel deleteGroup)
        {
            try
            {
                using var transaction = context.Database.BeginTransaction();
                await groupsRep.removeGroupAsync(groupsRep.getGroup(deleteGroup.groupName));
                transaction.Commit();
                return RedirectToAction("Admin");
            }
            catch
            {
                return Json("Error of delete group");
            }
        }

        //таблица групп
        public IActionResult ShowGroups()
        {
            var groups = context.groups.Join(context.teachers, gr => gr.curatorId, tr => tr.teacherId, (gr, tr) => new { gr, tr })
                                       .Select(gr => new GroupModel
                                       {
                                           groupId = gr.gr.groupId,
                                           groupName = gr.gr.groupName,
                                           curator = string.Join(" ", gr.tr.teacherSurname, gr.tr.teacherName.Substring(0, 1) + ".", gr.tr.teacherLastname.Substring(0, 1) + "."),
                                           studentsCount = context.students.Join(context.groups, st => st.studentGroup, group => group.groupId, (st, gr) => new { st, gr })
                                                                           .Where(st => st.st.studentGroup == gr.gr.groupId)
                                                                           .GroupBy(gr => gr.gr.groupId)
                                                                           .Select(st => st.Count()).FirstOrDefault()
                                       }).AsNoTracking().ToList();
            var teachers = teachersRep.allTeachers();
            var tableSubjects = new TableGroupModel { teachers = teachers, groups = groups };
            return PartialView("~/Views/Admin/_tableGroups.cshtml", tableSubjects);
        }
    }
}
  