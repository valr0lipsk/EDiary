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
        public IActionResult Student()
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
            var studentSubject = (from sub in context.subjects
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
            var studentLabs = (from students in context.students
                               join subGr in context.subgroups on students.studentSubgroup equals subGr.subgroupId
                               join labs in context.labs on subGr.subgroupId equals labs.subgroupId
                               join sT in context.subjectTaughts on labs.tsubjectId equals sT.tsubjectId
                               join gr in context.groups on sT.groupId equals gr.groupId
                               join sub in context.subjects on sT.subjectId equals sub.subjectId
                               where students.studentUser == userManager.GetUserId(User) && students.studentGroup == gr.groupId
                               select new SubjectGroupModel
                               {
                                   subjectName = labs.labName.Replace(", 2-ая подгруппа", "").Replace(", 1-ая подгруппа", ""),
                                   labaId = labs.labId,
                                   tsubjectId = sT.tsubjectId,
                                   subIcon = sub.Icon.subjectPicture
                               }).AsNoTracking().ToList();

            //задачи
            var studentTasks = (from students in context.students
                                join subGr in context.subgroups on students.studentSubgroup equals subGr.subgroupId
                                join labs in context.labs on subGr.subgroupId equals labs.subgroupId
                                join sT in context.subjectTaughts on labs.tsubjectId equals sT.tsubjectId
                                join gr in context.groups on sT.groupId equals gr.groupId
                                where students.studentUser == userManager.GetUserId(User) && students.studentGroup == gr.groupId
                                select new SubjectGroupModel
                                {
                                    subjectName = labs.labName.Replace("(лабораторная, 2-ая подгруппа)", "").Replace("(лабораторная, 1-ая подгруппа)", ""),
                                    labaId = labs.labId,
                                    tsubjectId = sT.tsubjectId,
                                    labaCount = labs.countLabs,
                                    zachCount = context.lessons.Join(context.setMarks, less => less.lessonId, sM => sM.lessonId, (less, sM) => new { less, sM })
                                                               .Join(context.marks, sM => sM.sM.markId, m => m.markId, (sM, m) => new { sM, m })
                                                               .Where(less => less.sM.less.lessonTypeId == 6)
                                                               .Where(m => m.m.mark == "зач")
                                                               .Where(st => st.sM.sM.student.studentUser == userManager.GetUserId(User))
                                                               .GroupBy(less => less.sM.less.subjectTaught.tsubjectId)
                                                               .Select(m => m.Count()).FirstOrDefault()
                                }).AsNoTracking().ToList();

            var zach = context.lessons.Join(context.setMarks, less => less.lessonId, sM => sM.lessonId, (less, sM) => new { less, sM })
                                                               .Join(context.marks, sM => sM.sM.markId, m => m.markId, (sM, m) => new { sM, m })
                                                               .Where(less => less.sM.less.lessonTypeId == 6)
                                                               .Where(m => m.m.mark == "зач")
                                                               .Where(st => st.sM.sM.student.studentUser == userManager.GetUserId(User))
                                                               .GroupBy(less => less.sM.less.subjectTaught.tsubjectId)
                                                               .Select(m => m.Count()).ToList();

            //эмоджи-статусы
            var statuses = context.emojiStatuses.AsNoTracking().Take(8).ToList();

            //объединение предметов и лаб
            var subLabs = studentSubject.Concat(studentLabs).OrderBy(x => x.subjectName);

            //объединение в одну модель
            AspStudentGroupModel studentSubjectGroup = new AspStudentGroupModel { students = student, subjects = subLabs, tasks = studentTasks, statuses = statuses };
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
            var studentLabs = (from students in context.students
                               join aspusers in context.Users on students.studentUser equals aspusers.Id
                               join subGr in context.subgroups on students.studentSubgroup equals subGr.subgroupId
                               join labs in context.labs on subGr.subgroupId equals labs.subgroupId
                               join sT in context.subjectTaughts on labs.tsubjectId equals sT.tsubjectId
                               join gr in context.groups on sT.groupId equals gr.groupId
                               join sub in context.subjects on sT.subjectId equals sub.subjectId
                               where students.studentUser == userManager.GetUserId(User) && students.studentGroup == gr.groupId
                               select new SubjectGroupModel
                               {
                                   subjectName = labs.labName.Replace(", 2-ая подгруппа", "").Replace(", 1-ая подгруппа", ""),
                                   labaId = labs.labId,
                                   tsubjectId = sT.tsubjectId,
                                   subIcon = sub.Icon.subjectPicture
                               }).AsNoTracking().ToList();

            //задачи
            var studentTasks = (from students in context.students
                                join aspusers in context.Users on students.studentUser equals aspusers.Id
                                join subGr in context.subgroups on students.studentSubgroup equals subGr.subgroupId
                                join labs in context.labs on subGr.subgroupId equals labs.subgroupId
                                join sT in context.subjectTaughts on labs.tsubjectId equals sT.tsubjectId
                                join gr in context.groups on sT.groupId equals gr.groupId
                                join sub in context.subjects on sT.subjectId equals sub.subjectId
                                where students.studentUser == userManager.GetUserId(User) && students.studentGroup == gr.groupId
                                select new SubjectGroupModel
                                {
                                    subjectName = labs.labName.Replace("(лабораторная, 2-ая подгруппа)", "").Replace("(лабораторная, 1-ая подгруппа)", ""),
                                    labaId = labs.labId,
                                    tsubjectId = sT.tsubjectId,
                                    zachCount = context.marks.Join(context.setMarks, m => m.markId, sM => sM.markId, (m, sM) => new { m, sM })
                                                             .Join(context.lessons, sM => sT.tsubjectId, less => less.tsubjectId, (sM, less) => new { sM, less })
                                                             .Join(context.students, sM => sM.sM.sM.studentId, st => st.studentId, (sM, st) => new { sM, st })
                                                             .Where(less => less.sM.less.lessonTypeId == 6 && less.sM.sM.m.mark == "зач" && less.st.studentUser == userManager.GetUserId(User))
                                                             .GroupBy(st => st.sM.less.tsubjectId)
                                                             .Select(m => m.Count()).FirstOrDefault(),
                                    labaCount = labs.countLabs
                                }).AsNoTracking().ToList();

            //эмоджи-статусы
            var statuses = context.emojiStatuses.AsNoTracking().Take(8).ToList();

            //объединение предметов и лаб
            var subLabs = studentLabs.OrderBy(x => x.subjectName);

            //объединение в одну модель
            AspStudentGroupModel studentSubjectGroup = new AspStudentGroupModel { students = student, subjects = subLabs, tasks = studentTasks, statuses = statuses };
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
            var studentSubject = (from sub in context.subjects
                                  join sT in context.subjectTaughts on sub.subjectId equals sT.subjectId
                                  join gr in context.groups on sT.groupId equals gr.groupId
                                  join st in context.students on gr.groupId equals st.studentGroup
                                  join aspusers in context.Users on st.studentUser equals aspusers.Id
                                  where st.studentUser == userManager.GetUserId(User)
                                  select new SubjectGroupModel
                                  {
                                      tsubjectId = sT.tsubjectId,
                                      subjectName = sub.subjectName,
                                      subIcon = sub.Icon.subjectPicture
                                  }).AsNoTracking().ToList();

            //задачи
            var studentTasks = (from students in context.students
                                join aspusers in context.Users on students.studentUser equals aspusers.Id
                                join subGr in context.subgroups on students.studentSubgroup equals subGr.subgroupId
                                join labs in context.labs on subGr.subgroupId equals labs.subgroupId
                                join sT in context.subjectTaughts on labs.tsubjectId equals sT.tsubjectId
                                join gr in context.groups on sT.groupId equals gr.groupId
                                join sub in context.subjects on sT.subjectId equals sub.subjectId
                                where students.studentUser == userManager.GetUserId(User) && students.studentGroup == gr.groupId
                                select new SubjectGroupModel
                                {
                                    subjectName = labs.labName.Replace("(лабораторная, 2-ая подгруппа)", "").Replace("(лабораторная, 1-ая подгруппа)", ""),
                                    labaId = labs.labId,
                                    tsubjectId = sT.tsubjectId,
                                    zachCount = context.marks.Join(context.setMarks, m => m.markId, sM => sM.markId, (m, sM) => new { m, sM })
                                                             .Join(context.lessons, sM => sT.tsubjectId, less => less.tsubjectId, (sM, less) => new { sM, less })
                                                             .Join(context.students, sM => sM.sM.sM.studentId, st => st.studentId, (sM, st) => new { sM, st })
                                                             .Where(less => less.sM.less.lessonTypeId == 6 && less.sM.sM.m.mark == "зач" && less.st.studentUser == userManager.GetUserId(User))
                                                             .GroupBy(st => st.sM.less.tsubjectId)
                                                             .Select(m => m.Count()).FirstOrDefault(),
                                    labaCount = labs.countLabs
                                }).AsNoTracking().ToList();

            //эмоджи-статусы
            var statuses = context.emojiStatuses.AsNoTracking().Take(8).ToList();

            //объединение предметов и лаб
            var subLabs = studentSubject.OrderBy(x => x.subjectName);

            //объединение в одну модель
            AspStudentGroupModel studentSubjectGroup = new AspStudentGroupModel { students = student, subjects = subLabs, tasks = studentTasks, statuses = statuses };
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
