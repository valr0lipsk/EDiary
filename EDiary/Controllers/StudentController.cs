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
        public StudentController(UserManager<IdentityUser> userManager, EDContext context) => (this.userManager, this.context) = (userManager, context);



        //представление ученика (все предметы и лабы)
        public IActionResult Student(string search)
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
            var subjects = (from sub in context.subjects
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
                             labaCount = lab.countLabs
                         }).AsNoTracking().OrderBy(s=>s.subjectName).ToList();

            //подсчет сданных лаб
            var zach = context.lessons.Join(context.setMarks, less => less.lessonId, sM => sM.lessonId, (less, sM) => new { less, sM })
                                      .Join(context.marks, sM => sM.sM.markId, m => m.markId, (sM, m) => new { sM, m })
                                      .Where(less => less.sM.less.lessonTypeId == 6)
                                      .Where(m => m.m.mark == "зач")
                                      .Where(st => st.sM.sM.student.studentUser == userManager.GetUserId(User))
                                      .OrderBy(s => s.sM.less.subjectTaught.subject.subjectName)
                                      .GroupBy(less => less.sM.sM.lesson.tsubjectId)
                                      .Select(m => m.Count()).ToList();

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
                                             }).AsNoTracking().OrderBy(st=>st.studentSurname).OrderBy(st=>st.studentName).ToList();

            //подсчет сданных лаб в каждой задаче
            for (int i = 0; i < tasks.Count(); i++)
            {
                tasks[i].zachCount = zach[i];
            }

            //эмоджи-статусы
            var statuses = context.emojiStatuses.AsNoTracking().Take(8).ToList();

            //объединение предметов и лаб
            var subLabs = subjects.Concat(labs).OrderBy(x => x.subjectName).OrderBy(x=>x.groupName).ToList();
            
            //поиск
            if (!string.IsNullOrEmpty(search))
            {
                subLabs = subLabs.Where(s => s.subjectName.ToLower().Contains(search.ToLower()) || s.groupName.ToLower().Contains(search.ToLower())).ToList();
            }

            //объединение в одну модель
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



        //представление ученика (лабы)
        public IActionResult ShowLabs()
        {
            //средний балл
            ViewBag.averageMark = Math.Round((from st in context.students
                                              join sm in context.setMarks on st.studentId equals sm.studentId
                                              join mark in context.marks on sm.markId equals mark.markId
                                              where mark.mark != "зач" && mark.mark != "незач" && mark.mark != "н/б" && mark.mark != "н" && mark.mark != "н/а" && st.studentUser == userManager.GetUserId(User)
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
                                              studentStatus = st.status.emoji
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
                             labaCount = lab.countLabs
                         }).AsNoTracking().OrderBy(s => s.subjectName).ToList();

            //подсчет сданных лаб
            var zach = context.lessons.Join(context.setMarks, less => less.lessonId, sM => sM.lessonId, (less, sM) => new { less, sM })
                                      .Join(context.marks, sM => sM.sM.markId, m => m.markId, (sM, m) => new { sM, m })
                                      .Where(less => less.sM.less.lessonTypeId == 6)
                                      .Where(m => m.m.mark == "зач")
                                      .Where(st => st.sM.sM.student.studentUser == userManager.GetUserId(User))
                                      .OrderBy(s => s.sM.less.subjectTaught.subject.subjectName)
                                      .GroupBy(less => less.sM.sM.lesson.tsubjectId)
                                      .Select(m => m.Count()).ToList();

            //подсчет сданных лаб в каждой задаче
            for (int i = 0; i < tasks.Count(); i++)
            {
                tasks[i].zachCount = zach[i];
            }

            //эмоджи-статусы
            var statuses = context.emojiStatuses.AsNoTracking().Take(8).ToList();

            //объединение предметов и лаб
            var subLabs = labs.OrderBy(x => x.subjectName).OrderBy(x=>x.groupName);

            //объединение в одну модель
            AspStudentGroupModel studentSubjectGroup = new AspStudentGroupModel 
            { 
                students = student,
                subjects = subLabs,
                tasks = tasks,
                statuses = statuses 
            };

            return View("Student", studentSubjectGroup);
        }



        //представление ученика (предметы)
        public IActionResult ShowSubjects()
        {
            //средний балл
            ViewBag.averageMark = Math.Round((from st in context.students
                                              join sm in context.setMarks on st.studentId equals sm.studentId
                                              join mark in context.marks on sm.markId equals mark.markId
                                              where mark.mark != "зач" && mark.mark != "незач" && mark.mark != "н/б" && mark.mark != "н" && mark.mark != "н/а" && st.studentUser == userManager.GetUserId(User)
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
                                              studentStatus = st.status.emoji
                                          }).AsNoTracking().ToList();

            //предметы
            var subjects = (from sub in context.subjects
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
                             labaCount = lab.countLabs
                         }).AsNoTracking().OrderBy(s => s.subjectName).ToList();

            //подсчет сданных лаб
            var zach = context.lessons.Join(context.setMarks, less => less.lessonId, sM => sM.lessonId, (less, sM) => new { less, sM })
                                      .Join(context.marks, sM => sM.sM.markId, m => m.markId, (sM, m) => new { sM, m })
                                      .Where(less => less.sM.less.lessonTypeId == 6)
                                      .Where(m => m.m.mark == "зач")
                                      .Where(st => st.sM.sM.student.studentUser == userManager.GetUserId(User))
                                      .OrderBy(s => s.sM.less.subjectTaught.subject.subjectName)
                                      .GroupBy(less => less.sM.sM.lesson.tsubjectId)
                                      .Select(m => m.Count()).ToList();

            //подсчет сданных лаб в каждой задаче
            for (int i = 0; i < tasks.Count(); i++)
            {
                tasks[i].zachCount = zach[i];
            }

            //эмоджи-статусы
            var statuses = context.emojiStatuses.AsNoTracking().Take(8).ToList();

            //объединение предметов и лаб
            var subLabs = subjects.OrderBy(x => x.subjectName).OrderBy(x=>x.groupName);

            //объединение в одну модель
            AspStudentGroupModel studentSubjectGroup = new AspStudentGroupModel 
            {
                students = student,
                subjects = subLabs,
                tasks = tasks,
                statuses = statuses
            };

            return View("Student", studentSubjectGroup);
        }



        //добавление фотографии студента
        [HttpPost]
        public IActionResult AddPicture(AvatarStatusModel studentPicture)
        {
            context.Database.BeginTransaction();
            var student = context.students.Where(stId => stId.studentUser == userManager.GetUserId(User)).FirstOrDefault();
            byte[] pic = null;
            using (var binaryReader = new BinaryReader(studentPicture.Picture.OpenReadStream()))
            {
                pic = binaryReader.ReadBytes((int)studentPicture.Picture.Length);
            }
            student.studentPic = pic;
            context.students.Update(student);
            context.SaveChanges();
            context.Database.CommitTransaction();
            return RedirectToAction("Student", "Student");
        }

        //добавление эмоджи статуса
        [HttpPost]
        public IActionResult AddStatus(AvatarStatusModel studentStatus)
        {
            context.Database.BeginTransaction();
            var student = context.students.Where(stId => stId.studentUser == userManager.GetUserId(User)).FirstOrDefault();
            student.studentStatus = studentStatus.statusId;
            context.students.Update(student);
            context.SaveChanges();
            context.Database.CommitTransaction();
            return RedirectToAction("Student", "Student");
        }
    }
}
