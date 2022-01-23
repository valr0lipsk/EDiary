using ClosedXML.Excel;
using EDiary.Models;
using EDiary.Service;
using EDiary.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
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

            var teacherSubject = (from tsub in context.subjectTaughts
                                  join subject in context.subjects on tsub.subjectId equals subject.subjectId
                                  join gr in context.groups on tsub.groupId equals gr.groupId
                                  join teacher in context.teachers on tsub.teacherId equals teacher.teacherId
                                  join aspusers in context.Users on teacher.teacherUser equals aspusers.Id
                                  where teacher.teacherUser == userManager.GetUserId(User)
                                  orderby subject.subjectName
                                  select new SubjectGroupModel
                                  {
                                      groupName = gr.groupName,
                                      subjectName = subject.subjectName,
                                      tsubjectId = tsub.tsubjectId
                                  }).ToList();

            var jurnal = new JurnalModel { Teachers = teacherJurnal, Groups = groupJurnal, Lessons = lessonJurnal, Students = studentsJurnal, Subjects = subjectJurnal, setMarks = setMarks, types = types, teacherSubjects = teacherSubject };
            return View(jurnal);
        }

      

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
        public async Task<IActionResult> SaveStatistics()
        {
            using (var workbook = new XLWorkbook())
            {
                //var statistic = new StatisticModel();
                //выбор только цифр в словарь
                //var marks = (from mark in context.marks
                //             where mark.mark != "н/б" && mark.mark != "н/а" && mark.mark != "зач" && mark.mark != "незач" && mark.mark != "н" && mark.mark != "осв"
                //             select new Mark { markId = mark.markId, mark = mark.mark.Trim() }).ToDictionary(mark => mark.markId, mark => mark.mark.Trim());

                //выбор таблиц и группировка по айди
                ///*var all = (from st in context.students
                //           join sM in context.setMarks on st.studentId equals sM.studentId
                //           join mark in context.marks on sM.markId equals mark.markId
                //           join gr in context.groups on st.studentGroup equals gr.groupId
                //           where gr.groupName == "8к2492"
                //           orderby st.studentSurname
                //           select new
                //           {
                //               st, sM, mark, gr,
                //               name = string.Join(" ", st.studentSurname, st.studentName.Substring(0, 1) + "."),
                //               marks = (from stud in context.students
                //                        join setm in context.setMarks on stud.studentId equals setm.studentId
                //                        join m in context.marks on setm.markId equals m.markId
                //                        join grou in context.groups on stud.studentGroup equals grou.groupId
                //                        where grou.groupName == "8к2492" && m.mark == marks.FirstOrDefault().Value
                //                        select m.mark.Count()).AsEnumerable().GroupBy(stats => st.studentId, stats=>st.studentSurname)
                //           }).AsEnumerable().GroupBy(stats => stats.st.studentId);

                ///*че-то новое*/
                //var allwork = (from st in context.students
                //               join sM in context.setMarks on st.studentId equals sM.studentId
                //               join mark in context.marks on sM.markId equals mark.markId
                //               join gr in context.groups on st.studentGroup equals gr.groupId
                //               where gr.groupName == "8к2492"
                //               orderby st.studentSurname
                //               select new
                //               {
                //                   st,
                //                   sM,
                //                   mark,
                //                   gr
                //               } into stats
                //               group stats by stats.st.studentId into statits
                //               select new
                //               {
                //                   name = string.Join(" ", statits.FirstOrDefault().st.studentSurname, statits.FirstOrDefault().st.studentName.Substring(0, 1) + "."),
                //                   noReason = (from m1 in statits
                //                               where m1.mark.mark == "н/б"
                //                               select m1.mark.mark).Count(),
                //                   reason = (from m2 in statits
                //                             where m2.mark.mark == "н"
                //                             select m2.mark).Count(),
                //                   average = (from m3 in statits
                //                              where m3.mark.mark.Contains("%[0-9]%")
                //                              select Convert.ToInt32(m3.mark)).Average()
                //               }).AsEnumerable();

                ///*еще новее*/
                //var allwork2 = (from st in context.students
                //                join sM in context.setMarks on st.studentId equals sM.studentId
                //                join mark in context.marks on sM.markId equals mark.markId
                //                join gr in context.groups on st.studentGroup equals gr.groupId
                //                where gr.groupName == "8к2492"
                //                orderby st.studentSurname
                //                select new
                //                {
                //                    st,
                //                    sM,
                //                    mark,
                //                    gr,
                //                    name = string.Join(" ", st.studentSurname, st.studentName.Substring(0, 1) + "."),
                //                    noReason = (from m1 in context.marks
                //                                where m1.mark == "н/б"
                //                                select m1.mark).Count(),
                //                    reason = (from m2 in context.marks
                //                              where m2.mark == "н"
                //                              select m2.mark).Count(),
                //                    average = (from m3 in context.marks
                //                               where m3.mark == marks.FirstOrDefault().Value
                //                               select Convert.ToInt32(m3.mark)).Average()
                //                }).AsEnumerable().GroupBy(st => st.st.studentId);

                //попытка
                ///*var aln = (from st in context.students
                //           join sM in context.setMarks on st.studentId equals sM.studentId
                //           join mark in context.marks on sM.markId equals mark.markId
                //           join gr in context.groups on st.studentGroup equals gr.groupId
                //           where gr.groupName == "8к2492"
                //           orderby st.studentSurname
                //           select new
                //           {
                //               st,
                //               sM,
                //               mark,
                //               gr,
                //               name = string.Join(" ", st.studentSurname, st.studentName.Substring(0, 1) + "."),
                //               marks = string.Join(", ",mark.mark)
                //           }).GroupBy(stats => stats.st).Select(stats=>new { stats.Key, cnt=stats.FirstOrDefault().mark.mark.Count()});*/

                //среднее
                ///*var average = (from st in context.students
                //               join sM in context.setMarks on st.studentId equals sM.studentId
                //               where sM.mark.mark != "н/б" && sM.mark.mark != "н/а" && sM.mark.mark != "зач" && sM.mark.mark != "незач" && sM.mark.mark != "н"
                //               select Convert.ToInt32(sM.mark.mark)).AsEnumerable();*/

                //ФИО
                ///*statistic.fullName = (from student in context.students
                //                      join gr in context.groups on student.studentGroup equals gr.groupId
                //                      orderby student.studentSurname
                //                      where gr.groupName == "8к2492"
                //                      select string.Join(" ", student.studentSurname, student.studentName.Substring(0, 1) + ".")).ToList();*/

                //пропуски без причины
                ///*= (from nrp in all
                //           where nrp.FirstOrDefault().mark.mark == "н/б" && nrp.FirstOrDefault().gr.groupName == "8к2492"
                //           select nrp.FirstOrDefault().mark.mark.Count());*/

                //пропуски по причине
                ///*statistic.reasonPass = (from st in context.students
                //                        group st by st.studentId into student
                //                        join sM in context.setMarks on student.FirstOrDefault().studentId equals sM.studentId
                //                        join mark in context.marks on sM.markId equals mark.markId
                //                        join gr in context.groups on student.FirstOrDefault().studentGroup equals gr.groupId
                //                        orderby student.FirstOrDefault().studentSurname
                //                        where mark.mark.Trim() == "н" && subT.tsubjectId == 1 && gr.groupName == "8к2492"
                //                        select mark.mark.Count()).ToList();*/
                //фио
                ///*var name = (from al in all
                //            select string.Join(" ", al.FirstOrDefault().st.studentSurname, al.FirstOrDefault().st.studentName.Substring(0, 1) + ".")).ToList();*/
                //средний балл
                ///*var averageMark = (from al in all
                //                   join mr in marks on al.FirstOrDefault().mark.markId equals mr.Key
                //                   join st in context.students on al.FirstOrDefault().st.studentId equals st.studentId
                //                   join sM in context.setMarks on st.studentId equals sM.studentId
                //                   join mark in context.marks on al.FirstOrDefault().mark.markId equals mark.markId
                //                   join gr in context.groups on al.FirstOrDefault().gr.groupId equals gr.groupId
                //                   where al.FirstOrDefault().gr.groupName == "8к2492" && al.FirstOrDefault().sM.studentId == al.FirstOrDefault().st.studentId
                //                   select Convert.ToInt32(al.FirstOrDefault().mark.mark.Trim())).ToList();*/
               
               
                var worksheet = workbook.Worksheets.Add("Статистика");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "ФИО";
                worksheet.Cell(currentRow, 2).Value = "Пропуски по неуваж.";
                worksheet.Cell(currentRow, 3).Value = "Пропуски не по уваж.";
                worksheet.Cell(currentRow, 4).Value = "Средний балл";
                using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
                {
                    await connection.OpenAsync();
                    SqlCommand command = new SqlCommand("FullStatistic", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {   
                                currentRow++;
                                worksheet.Cell(currentRow, 1).Value = reader.GetString(0);
                                worksheet.Cell(currentRow, 2).Value = reader.GetInt32(1);
                                worksheet.Cell(currentRow, 3).Value = reader.GetInt32(2);
                                worksheet.Cell(currentRow, 4).Value = reader.GetDouble(3);
                            }
                        }
                    }
                }
                //foreach (var stats in statistic)
                //{
                   
                //}

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
