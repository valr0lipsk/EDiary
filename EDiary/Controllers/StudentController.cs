using EDiary.IRepositories;
using EDiary.Models;
using EDiary.Service;
using EDiary.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EDiary.Controllers
{
    [Authorize(Roles = "student")]
    public class StudentController : Controller
    {
        EDContext context;
        private UserManager<IdentityUser> userManager;
        IStudentRepository studentsRep;
        public StudentController(UserManager<IdentityUser> userManager, EDContext context, IStudentRepository studentsRep) 
                             => (this.userManager, this.context, this.studentsRep) = (userManager, context, studentsRep);



        //представление ученика (все предметы и лабы)
        [HttpGet]
        public IActionResult Student(string category)
        {
            //отметки-цифры
            var digitals = context.marks.Where(mark => mark.mark != "н/б" && mark.mark != "н/а" && mark.mark != "зач" && mark.mark != "незач" && mark.mark != "н" && mark.mark != "осв")
                                        .Select(mark => new Mark { markId = mark.markId, mark = mark.mark.Trim() })
                                        .ToDictionary(mark => mark.markId, mark => mark.mark.Trim());

            //средний балл
            ViewBag.averageMark = Math.Round((from st in context.students
                                              join sm in context.setMarks on st.studentId equals sm.studentId
                                              join mark in context.marks on sm.markId equals mark.markId
                                              where digitals.Values.Contains(mark.mark) && st.studentUser == userManager.GetUserId(User)
                                              select Convert.ToInt32(mark.mark)).Average(), 2);

            //ФИО учника
            var student = context.students.Where(st => st.studentUser == userManager.GetUserId(User))
                                          .Select(st => new StudentModel
                                          {
                                              studentId = st.studentId,
                                              studentSurname = st.studentSurname,
                                              studentName = st.studentName,
                                              studentLastname = st.studentLastname,
                                              studentPic = st.studentPic,
                                              studentStatus = st.status.emoji,
                                              studentGroup = st.studentGroup
                                          }).AsNoTracking().ToList();

            //предметы
            var studentSubjects = (from sub in context.subjects
                                   join sT in context.subjectTaughts on sub.subjectId equals sT.subjectId
                                   join gr in context.groups on sT.groupId equals gr.groupId
                                   join st in context.students on gr.groupId equals st.studentGroup
                                   where st.studentUser == userManager.GetUserId(User)
                                   select new SubjectGroupModel
                                   {
                                       tsubjectId = sT.tsubjectId,
                                       subjectName = sub.subjectName,
                                       subIcon = sub.Icon.subjectPicture
                                   }).AsNoTracking().ToList();

            //лабы
            var labs = (from students in context.students
                        join subGr in context.subgroups on students.studentSubgroup equals subGr.subgroupId
                        join lab in context.labs on subGr.subgroupId equals lab.subgroupId
                        join sT in context.subjectTaughts on lab.tsubjectId equals sT.tsubjectId
                        join gr in context.groups on sT.groupId equals gr.groupId
                        join sub in context.subjects on sT.subjectId equals sub.subjectId
                        where students.studentUser == userManager.GetUserId(User) && students.studentGroup == gr.groupId
                        select new SubjectGroupModel
                        {
                            subjectName = lab.labName.Replace(", 2-ая подгруппа", "").Replace(", 1-ая подгруппа", ""),
                            labaId = lab.labId,
                            tsubjectId = sT.tsubjectId,
                            subIcon = sub.Icon.subjectPicture
                        }).AsNoTracking().ToList();

            //задачи
            var tasks = (from students in context.students
                         join subGr in context.subgroups on students.studentSubgroup equals subGr.subgroupId
                         join lab in context.labs on subGr.subgroupId equals lab.subgroupId
                         join sT in context.subjectTaughts on lab.tsubjectId equals sT.tsubjectId
                         join gr in context.groups on sT.groupId equals gr.groupId
                         where students.studentUser == userManager.GetUserId(User) && students.studentGroup == gr.groupId
                         select new SubjectGroupModel
                         {
                             subjectName = lab.labName.Replace("(лабораторная, 2-ая подгруппа)", "").Replace("(лабораторная, 1-ая подгруппа)", ""),
                             labaCount = lab.countLabs,
                             zachCount = context.lessons.Join(context.setMarks, less => less.lessonId, sM => sM.lessonId, (less, sM) => new { less, sM })
                                                        .Join(context.marks, sM => sM.sM.markId, m => m.markId, (sM, m) => new { sM, m })
                                                        .Where(m => m.m.mark == "зач")
                                                        .Where(st => st.sM.sM.student.studentUser == students.studentUser)
                                                        .Where(less => less.sM.less.tsubjectId == sT.tsubjectId)
                                                        .GroupBy(less => less.sM.less.tsubjectId)
                                                        .Select(m => m.Count()).FirstOrDefault()
                         }).AsNoTracking().OrderBy(s=>s.subjectName).ToList();

            //одногруппники
            var groupmates = context.students.Where(gr => gr.studentGroup == student.FirstOrDefault().studentGroup)
                                             .Where(st => st.studentUser != userManager.GetUserId(User))
                                             .Select(st => new StudentModel
                                             {
                                                 studentId = st.studentId,
                                                 studentSurname = st.studentSurname,
                                                 studentName = st.studentName,
                                                 studentLastname = st.studentLastname,
                                                 studentPic = st.studentPic,
                                                 studentStatus = st.status.emoji,
                                                 studentsAverage = Math.Round(context.marks.Join(context.setMarks, m => m.markId, sM => sM.markId, (m, sM) => new { m, sM })
                                                                       .Where(m => digitals.Values.Contains(m.m.mark))
                                                                       .Where(m => m.sM.studentId == st.studentId)
                                                                       .GroupBy(sm => sm.sM.studentId)
                                                                       .Select(m => m.Average(m => Convert.ToInt32(m.m.mark))).FirstOrDefault(), 2)
                                             }).AsNoTracking().OrderBy(st => st.studentName).OrderBy(st => st.studentSurname).ToList();

            //эмоджи-статусы
            var statuses = context.emojiStatuses.AsNoTracking().Take(8).ToList();

            //отображение все/лекции/лабы
            var subLabs = new List<SubjectGroupModel>();
            //все
            if (category == "1")
            {
                subLabs = studentSubjects.Concat(labs).OrderBy(x => x.subjectName).OrderBy(gr => gr.groupName).ToList();
                AspStudentGroupModel studentSubjectGroup = new AspStudentGroupModel
                {
                    student = student,
                    students = groupmates,
                    subjects = subLabs,
                    tasks = tasks,
                    statuses = statuses
                };

                return PartialView("~/Views/Student/_subjectsBlock.cshtml", studentSubjectGroup);
            }
            //только лекции
            else if (category == "2")
            {
                subLabs = studentSubjects.OrderBy(x => x.subjectName).OrderBy(gr => gr.groupName).ToList();
                AspStudentGroupModel studentSubjectGroup = new AspStudentGroupModel
                {
                    student = student,
                    students = groupmates,
                    subjects = subLabs,
                    tasks = tasks,
                    statuses = statuses
                };
                return PartialView("~/Views/Student/_subjectsBlock.cshtml", studentSubjectGroup);
            }
            //только лабы
            else if (category == "3")
            {
                subLabs = labs.OrderBy(x => x.subjectName).OrderBy(gr => gr.groupName).ToList();
                AspStudentGroupModel studentSubjectGroup = new AspStudentGroupModel
                {
                    student = student,
                    students = groupmates,
                    subjects = subLabs,
                    tasks = tasks,
                    statuses = statuses
                };
                return PartialView("~/Views/Student/_subjectsBlock.cshtml", studentSubjectGroup);
            }
            //начальная загрузка
            else
            {
                subLabs = studentSubjects.Concat(labs).OrderBy(x => x.subjectName).OrderBy(gr => gr.groupName).ToList();
                AspStudentGroupModel studentSubjectGroup = new AspStudentGroupModel
                {
                    student = student,
                    students = groupmates,
                    subjects = subLabs,
                    tasks = tasks,
                    statuses = statuses
                };
                return View(studentSubjectGroup);
            }            
        }


        
        //добавление фотографии студента
        [HttpPost]
        public async Task <IActionResult> AddPicture(AvatarStatusModel studentPicture)
        {
            var student = studentsRep.findStudent(userManager.GetUserId(User));
            if (studentPicture.Picture == null)
            {
                student.studentPic = null;
                await studentsRep.updateStudentAsync(student);
                return RedirectToAction("Student", "Student");
            }
            else if (studentPicture.Picture.ContentType.Contains("image"))
            { 
                using (var binaryReader = new BinaryReader(studentPicture.Picture.OpenReadStream()))
                {
                    student.studentPic = binaryReader.ReadBytes((int)studentPicture.Picture.Length);
                }
                await studentsRep.updateStudentAsync(student);
                return RedirectToAction("Student", "Student");
            }
            else 
            {
                return Json("Error of add picture"); 
            }
        }

        //добавление эмоджи статуса
        [HttpPost]
        public async Task <IActionResult> AddStatus(AvatarStatusModel studentStatus)
        {
            var student = studentsRep.findStudent(userManager.GetUserId(User));
            student.studentStatus = studentStatus.statusId;
            await studentsRep.updateStudentAsync(student);
            return RedirectToAction("Student", "Student");
        }
    }
}
