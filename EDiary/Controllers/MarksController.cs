﻿using ClosedXML.Excel;
using EDiary.Models;
using EDiary.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Controllers
{
    [Authorize(Roles = "teacher, student")]
    public class MarksController : Controller
    {
        UserManager<IdentityUser> userManager;
        EDContext context;
        public MarksController(EDContext context, UserManager<IdentityUser> userManager) => (this.context, this.userManager) = (context, userManager);

        //представление журнала
        //public IActionResult Jurnal() => View();
        
        //обновление оценки
        [HttpPut]
        public IActionResult Jurnal(int id, string value)
        {
            var markId = value;
            var setmark = id;
            var updatedMark = context.setMarks.Where(sM => sM.setmarkId == id).FirstOrDefault();
            if (updatedMark != null && value != null)
            {
                updatedMark.markId = (from mark in context.marks where mark.mark == value select mark.markId).FirstOrDefault();
                context.setMarks.Update(updatedMark);
                context.SaveChanges();
                return Json(new { status = "updated", message = "Оценка обновлена" });
            }
            else if (value == null)
            {
                context.setMarks.Remove(updatedMark);
                context.SaveChanges();
                return Json(new { status = "deleted", message = "Оценка удалена" });
            }
            else
            {
                return Json(new { status = "error", message = "Ошибка обновления. Попробуйте еще раз" });
            }
        }

        //добавление оценки
        [HttpPost]
        public IActionResult Jurnal(int studId, int lessId, string value)
        {
            var marks = (from mark in context.marks where mark.mark == value select mark.mark).FirstOrDefault();
            if (marks != null)
            {
                var markValue = (from mark in context.marks where mark.mark == value select mark.markId).FirstOrDefault(); 
                setMark setMark = new setMark { studentId = studId, lessonId = lessId, markId = markValue };
                context.setMarks.Add(setMark);
                context.SaveChanges();
                var markId = (from sM in context.setMarks orderby sM.setmarkId descending select sM.setmarkId).FirstOrDefault();
                return Json(new { status = "added", message = "Оценка добавлена", markId = markId });
            }        
            else
            {
                return Json(new { status = "error", message = "Ошибка добавления. Такой оценки не существует" });
            }
        }

        //журнал предмета и группы
        [HttpGet]
        public IActionResult Jurnal(int id)
        {
            if (User.IsInRole("student"))
            {
                var studentId = (from st in context.students join us in context.Users on st.studentUser equals us.Id where us.Id == userManager.GetUserId(User) select st.studentId).FirstOrDefault();
                ViewBag.studentId = studentId;
            }

            var subid = id;

            //преподаватель
            var teacherJurnal = (from teacher in context.teachers
                                 join subTaught in context.subjectTaughts on teacher.teacherId equals subTaught.teacherId
                                 where subTaught.tsubjectId == subid
                                 select new Teacher
                                 {
                                     teacherSurname = teacher.teacherSurname,
                                     teacherName = teacher.teacherName,
                                     teacherLastname = teacher.teacherLastname
                                 }).ToList();
            //группы
            var groupJurnal = (from subTaught in context.subjectTaughts
                               join gr in context.groups on subTaught.groupId equals gr.groupId
                               where subTaught.tsubjectId == subid
                               select new collegeGroup
                               {
                                   groupName = gr.groupName,
                               }).ToList();

            //предмет
            var subjectJurnal = (from subTaught in context.subjectTaughts
                                 join st in context.subjects on subTaught.subjectId equals st.subjectId
                                 where subTaught.tsubjectId == subid
                                 select new Subject
                                 {
                                     subjectName = st.subjectName,
                                     subjectId = subid
                                 }).ToList();

            //студенты
            var studentsJurnal = (from student in context.students
                                  join gr in context.groups on student.studentGroup equals gr.groupId
                                  join subTaught in context.subjectTaughts on gr.groupId equals subTaught.groupId
                                  where subTaught.tsubjectId == subid
                                  orderby student.studentSurname
                                  select new Student
                                  {
                                      studentId = student.studentId,
                                      studentSurname = student.studentSurname,
                                      studentName = student.studentName,
                                      studentLastname = student.studentLastname
                                  }).ToList();
            //занятие
            var lessonJurnal = (from lesson in context.lessons
                                where lesson.tsubjectId == subid
                                orderby lesson.lessonDate
                                select new Lesson
                                {
                                    lessonId = lesson.lessonId,
                                    lessonDate = lesson.lessonDate,
                                    lessonTypeId = lesson.lessonTypeId
                                }).ToList();

            //выставленные отметки
            var setMarks = (from setMark in context.setMarks
                            join student in context.students on setMark.studentId equals student.studentId
                            join lesson in context.lessons on setMark.lessonId equals lesson.lessonId
                            join mark in context.marks on setMark.markId equals mark.markId
                            join subTaught in context.subjectTaughts on lesson.tsubjectId equals subTaught.tsubjectId
                            orderby student.studentSurname
                            orderby lesson.lessonDate
                            where subTaught.tsubjectId == subid
                            select new setMark
                            {
                                mark = new Mark() { mark = mark.mark, markId = mark.markId },
                                lessonId = setMark.lessonId,
                                setmarkId = setMark.setmarkId,
                                studentId = setMark.studentId
                            }).ToList();

            //типы занятий
            var types = (from type in context.lessonType
                         select new lessonType
                         {
                             lessonTypeId = type.lessonTypeId,
                             typeName = type.typeName
                         }).ToList();

            var jurnal = new JurnalModel { Teachers = teacherJurnal, Groups = groupJurnal, Lessons = lessonJurnal, Students = studentsJurnal, Subjects = subjectJurnal, setMarks = setMarks, types = types };
            return View(jurnal);
        }

        //представление журнала (лабы)
        //[HttpGet]
        //public IActionResult Jurnal(int Id, int labaId)
        //{
        //    if (User.IsInRole("student"))
        //    {
        //        var studentId = (from st in context.students join us in context.Users on st.studentUser equals us.Id where us.Id == userManager.GetUserId(User) select st.studentId).FirstOrDefault();
        //        ViewBag.studentId = studentId;
        //    }

        //    var subId = Id;
        //    var laba = labaId;

        //    //преподаватель
        //    var teacherJurnal = (from teacher in context.teachers
        //                         join lab in context.labs on teacher.teacherId equals lab.teacherId
        //                         where lab.labId == laba
        //                         select new Teacher
        //                         {
        //                             teacherSurname = teacher.teacherSurname,
        //                             teacherName = teacher.teacherName,
        //                             teacherLastname = teacher.teacherLastname
        //                         }).ToList();
        //    //группы
        //    var groupJurnal = (from lab in context.labs
        //                       join gr in context.groups on lab.groupId equals gr.groupId
        //                       where lab.labId == laba 
        //                       select new collegeGroup
        //                       {
        //                           groupName = gr.groupName,
        //                       }).ToList();

        //    //предмет
        //    var subjectJurnal = (from subTaught in context.subjectTaughts
        //                         join lab in context.labs on subTaught.tsubjectId equals lab.tsubjectId
        //                         where lab.labId == laba
        //                         select new Labs
        //                         {  
        //                             labName = lab.labName,
        //                         }).ToList();

        //    //студенты
        //    var studentsJurnal = (from student in context.students
        //                          join gr in context.groups on student.studentGroup equals gr.groupId
        //                          join subTaught in context.subjectTaughts on gr.groupId equals subTaught.groupId
        //                          join lab in context.labs on subTaught.tsubjectId equals lab.tsubjectId
        //                          join subgr in context.subgroups on student.studentSubgroup equals subgr.subgroupId
        //                          where lab.labId == laba
        //                          orderby student.studentSurname
        //                          select new Student
        //                          {
        //                              studentId = student.studentId,
        //                              studentSurname = student.studentSurname,
        //                              studentName = student.studentName,
        //                              studentLastname = student.studentLastname
        //                          }).ToList();
        //    //занятие
        //    var lessonJurnal = (from lesson in context.lessons
        //                        where lesson.tsubjectId == subId && lesson.lessonTypeId == 6
        //                        orderby lesson.lessonDate
        //                        select new Lesson
        //                        {
        //                            lessonId = lesson.lessonId,
        //                            lessonDate = lesson.lessonDate,
        //                            lessonTypeId = lesson.lessonTypeId
        //                        }).ToList();

        //    //выставленные отметки
        //    var setMarks = (from setMark in context.setMarks
        //                    join student in context.students on setMark.studentId equals student.studentId
        //                    join lesson in context.lessons on setMark.lessonId equals lesson.lessonId
        //                    join mark in context.marks on setMark.markId equals mark.markId
        //                    join subTaught in context.subjectTaughts on lesson.tsubjectId equals subTaught.tsubjectId
        //                    join lab in context.labs on subTaught.tsubjectId equals lab.tsubjectId
        //                    orderby student.studentSurname
        //                    orderby lesson.lessonDate
        //                    where lab.labId == laba
        //                    select new setMark
        //                    {
        //                        mark = new Mark() { mark = mark.mark, markId = mark.markId },
        //                        lessonId = setMark.lessonId,
        //                        setmarkId = setMark.setmarkId,
        //                        studentId = setMark.studentId
        //                    }).ToList();

        //    //типы занятий
        //    var types = (from type in context.lessonType
        //                 select new lessonType
        //                 {
        //                     lessonTypeId = type.lessonTypeId,
        //                     typeName = type.typeName
        //                 }).ToList();

        //    var jurnal = new JurnalModel { Teachers = teacherJurnal, Groups = groupJurnal, Lessons = lessonJurnal, Students = studentsJurnal, labs = subjectJurnal, setMarks = setMarks, types = types };
        //    return View(jurnal);
        //}

        //добавление занятия
        public IActionResult AddLesson(LessonModel addLesson)
        {
            Lesson lesson = new Lesson { tsubjectId = addLesson.id, lessonDate = addLesson.lessonDate, lessonTypeId = (from lT in context.lessonType where lT.typeName == addLesson.lessonType select lT.lessonTypeId).FirstOrDefault()};
            context.lessons.Add(lesson);
            context.SaveChanges();
            return RedirectToAction("Jurnal", "Marks", new { addLesson.id });
        }
        
        //удаление занятия
        [HttpPost]
        public IActionResult DeleteLesson(LessonModel deleteLesson)
        {
            var lesson = context.lessons.Where(lessId => lessId.lessonId == deleteLesson.lessonId).FirstOrDefault();
            context.lessons.Remove(lesson);
            context.SaveChanges();
            return RedirectToAction("Jurnal", "Marks", new { deleteLesson.id });
        }

        //экспорт статистики 
        public IActionResult SaveStatistics()
        {
            using (var workbook = new XLWorkbook())
            {
                var statistic = new StatisticModel();
                var all = (from st in context.students
                           join sM in context.setMarks on st.studentId equals sM.studentId
                           join mark in context.marks on sM.markId equals mark.markId
                           join gr in context.groups on st.studentGroup equals gr.groupId
                           orderby st.studentSurname
                           select new
                           {
                               st = st, sM = sM, mark = mark, gr = gr,
                               name= string.Join(" ", st.studentSurname, st.studentName.Substring(0, 1) + "."),
                               noRP = (from m in context.marks
                                       join sm in context.setMarks on m.markId equals sm.markId
                                       join St in context.students on sm.studentId equals st.studentId
                                       where m.mark == "н/б" select mark.mark).Count()

            }).AsEnumerable().GroupBy(stats => stats.st.studentId);

                //ФИО
                //statistic.fullName = (from student in context.students
                //                      join gr in context.groups on student.studentGroup equals gr.groupId
                //                      orderby student.studentSurname
                //                      where gr.groupName == "8к2492"
                //                      select string.Join(" ", student.studentSurname, student.studentName.Substring(0, 1) + ".")).ToList();

                //пропуски без причины
                 //= (from nrp in all
                 //           where nrp.FirstOrDefault().mark.mark == "н/б" && nrp.FirstOrDefault().gr.groupName == "8к2492"
                 //           select nrp.FirstOrDefault().mark.mark.Count());
                //пропуски по причине
                /*statistic.reasonPass = (from st in context.students
                                        group st by st.studentId into student
                                        join sM in context.setMarks on student.FirstOrDefault().studentId equals sM.studentId
                                        join mark in context.marks on sM.markId equals mark.markId
                                        join gr in context.groups on student.FirstOrDefault().studentGroup equals gr.groupId
                                        orderby student.FirstOrDefault().studentSurname
                                        where mark.mark.Trim() == "н" && subT.tsubjectId == 1 && gr.groupName == "8к2492"
                                        select mark.mark.Count()).ToList();*/

                //средний балл
                //statistic.averageMark = (from st in context.students
                //                         group st by st.studentId into student
                //                         join sM in context.setMarks on student.FirstOrDefault().studentId equals sM.studentId
                //                         join mark in context.marks on sM.markId equals mark.markId
                //                         join st in context.students on sM.studentId equals st.studentId
                //                         orderby student.FirstOrDefault().studentSurname
                //                         where mark.mark.Trim() != "н/б" && mark.mark.Trim() != "н"
                //                         select Convert.ToInt32(mark.mark)).ToList().Average()

                var fullStats = statistic.fullName/*.Zip(statistic.reasonPass)*/;
                var worksheet = workbook.Worksheets.Add("Статистика");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "ФИО";
                worksheet.Cell(currentRow, 2).Value = "Пропуски по неуваж.";
                //worksheet.Cell(currentRow, 3).Value = "Пропуски не по уваж.";
                //worksheet.Cell(currentRow, 4).Value = "Средний балл";

                foreach (var stats in all)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = stats.FirstOrDefault().name;
                    worksheet.Cell(currentRow, 2).Value = stats.FirstOrDefault().noRP;
                    //worksheet.Cell(currentRow, 3).Value = user.Second;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(
                        content,
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "Statistics.xlsx");
                }
            }
        }
    }
}
