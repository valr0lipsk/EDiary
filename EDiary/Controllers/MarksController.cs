using ClosedXML.Excel;
using EDiary.IRepositories;
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
        IMarkRepository marksRep;
        ILessonRepository lessonsRep;
        public MarksController(EDContext context, UserManager<IdentityUser> userManager, IMarkRepository marksRep, ILessonRepository lessonsRep)
                           => (this.context, this.userManager, this.marksRep, this.lessonsRep) = (context, userManager, marksRep, lessonsRep);

        //переадресация на нужный POST-метод
        [HttpPost]
        [Route("Marks/Jurnal/{id?}")]
        public IActionResult Jurnal(int studId, int lessId, string value, LessonModel lessDates, string month) => value == null ? Jurnal(lessDates, month) : Jurnal(studId, lessId, value);



        /**********CRUD-оценок**********/

        //обновление и удаление оценки
        [HttpPut]
        public IActionResult Jurnal(int id, string value)
        {
            var updatedMark = marksRep.findSetMark(id);
            if (updatedMark != null && value != null)
            {
                using var transaction = context.Database.BeginTransaction();
                updatedMark.markId = marksRep.findMark(value).markId;
                marksRep.updateSetMark(updatedMark);
                transaction.Commit();
                return Json(new { status = "updated", message = "Оценка обновлена" });
            }
            else if (value == null)
            {
                using var transaction = context.Database.BeginTransaction();
                marksRep.removeSetMark(updatedMark);
                transaction.Commit();
                return Json(new { status = "deleted", message = "Оценка удалена" });
            }
            else
            {
                return Json(new { status = "error", message = "Ошибка обновления. Попробуйте еще раз" });
            }
        }

        //добавление оценки
        public IActionResult Jurnal(int studId, int lessId, string value)
        {
            var marks = marksRep.findMark(value).mark;
            if (marks != null)
            {
                var markValue = marksRep.findMark(value).markId;
                using var transaction = context.Database.BeginTransaction();
                setMark setMark = new setMark
                {
                    studentId = studId,
                    lessonId = lessId,
                    markId = markValue
                };
                marksRep.createSetMark(setMark);
                var markId = setMark.setmarkId;
                transaction.Commit();
                return Json(new { status = "added", message = "Оценка добавлена", markId = markId });
            }
            else
            {
                return Json(new { status = "error", message = "Ошибка добавления. Такой оценки не существует" });
            }
        }



        /**********ЖУРНАЛ**********/

        //журнал предмета и группы
        [HttpGet]
        [Route("Marks/Jurnal/{id?}")]
        public IActionResult Jurnal(int id, int labId)
        {
            var subid = id;
            var labid = labId;
            
            //предметы препода
            var subjects = (from tsub in context.subjectTaughts
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
                            }).AsNoTracking().ToList();
            //лабы препода
            var labs = (from tsub in context.subjectTaughts
                        join gr in context.groups on tsub.groupId equals gr.groupId
                        join lab in context.labs on tsub.tsubjectId equals lab.tsubjectId
                        join teacher in context.teachers on lab.teacherId equals teacher.teacherId
                        join aspusers in context.Users on teacher.teacherUser equals aspusers.Id
                        where teacher.teacherUser == userManager.GetUserId(User)
                        orderby lab.labName
                        select new SubjectGroupModel
                        {
                            subjectName = lab.labName,
                            labaId = lab.labId,
                            tsubjectId = tsub.tsubjectId,
                            groupName = gr.groupName
                        }).AsNoTracking().ToList();

            //если ученик, то его предметы
            if (User.IsInRole("student"))
            {
                //получение айди ученика
                var studentId = context.students.Join(context.Users, st => st.studentUser, us => us.Id, (st, us) => new { st, us })
                                                .Where(us => us.us.Id == userManager.GetUserId(User))
                                                .Select(st => st.st.studentId).FirstOrDefault();
                ViewBag.studentId = studentId;

                //предметы ученика
                subjects = (from sub in context.subjects
                            join sT in context.subjectTaughts on sub.subjectId equals sT.subjectId
                            join gr in context.groups on sT.groupId equals gr.groupId
                            join st in context.students on gr.groupId equals st.studentGroup
                            join aspusers in context.Users on st.studentUser equals aspusers.Id
                            where st.studentUser == userManager.GetUserId(User)
                            select new SubjectGroupModel
                            {
                                tsubjectId = sT.tsubjectId,
                                subjectName = sub.subjectName
                            }).AsNoTracking().ToList();

                //лабы ученика
                labs = (from student in context.students
                        join aspusers in context.Users on student.studentUser equals aspusers.Id
                        join subGr in context.subgroups on student.studentSubgroup equals subGr.subgroupId
                        join lab in context.labs on subGr.subgroupId equals lab.subgroupId
                        join sT in context.subjectTaughts on lab.tsubjectId equals sT.tsubjectId
                        join sub in context.subjects on sT.subjectId equals sub.subjectId
                        where student.studentUser == userManager.GetUserId(User) && student.studentGroup == sT.groupId
                        select new SubjectGroupModel
                        {
                            subjectName = lab.labName,
                            labaId = lab.labId,
                            tsubjectId = sT.tsubjectId,
                        }).AsNoTracking().ToList();
            }
            var subLabs = subjects.Concat(labs).OrderBy(x => x.subjectName);


            //если журнал лабы
            if (labId != 0)
            {
                //препод
                var teacherJurnal = context.teachers.Join(context.labs, tr => tr.teacherId, lab => lab.teacherId, (tr, lab) => new { tr, lab })
                                                    .Where(lab => lab.lab.labId == labid)
                                                    .Select(tr => new Teacher
                                                    {
                                                        teacherSurname = tr.tr.teacherSurname,
                                                        teacherName = tr.tr.teacherName,
                                                        teacherLastname = tr.tr.teacherLastname
                                                    }).AsNoTracking().ToList();

                //группы
                var groupJurnal = (from lab in context.labs
                                   join subTaught in context.subjectTaughts on lab.tsubjectId equals subTaught.tsubjectId
                                   join gr in context.groups on subTaught.groupId equals gr.groupId
                                   join subGr in context.subgroups on lab.subgroupId equals subGr.subgroupId
                                   where lab.labId == labid
                                   select new collegeGroup
                                   {
                                       groupName = string.Join(" ", gr.groupName, subGr.subgroupName)
                                   }).AsNoTracking().ToList();

                //предмет
                var subjectJurnal = (from lab in context.labs
                                     join subTaught in context.subjectTaughts on lab.tsubjectId equals subTaught.tsubjectId
                                     join gr in context.groups on subTaught.groupId equals gr.groupId
                                     join subGr in context.subgroups on lab.subgroupId equals subGr.subgroupId
                                     where lab.labId == labid
                                     select new SubjectGroupModel
                                     {
                                         subjectName = lab.labName,
                                         labaId = labId
                                     }).AsNoTracking().ToList();

                //студенты
                var studentsJurnal = (from student in context.students
                                      join subGr in context.subgroups on student.studentSubgroup equals subGr.subgroupId
                                      join laba in context.labs on subGr.subgroupId equals laba.subgroupId
                                      join subTaught in context.subjectTaughts on laba.tsubjectId equals subTaught.tsubjectId
                                      join gr in context.groups on subTaught.groupId equals gr.groupId
                                      where laba.labId == labid && student.studentGroup == subTaught.groupId
                                      orderby student.studentSurname
                                      select new Student
                                      {
                                          studentId = student.studentId,
                                          studentSurname = student.studentSurname,
                                          studentName = student.studentName,
                                          studentLastname = student.studentLastname
                                      }).AsNoTracking().ToList();
                //занятие
                var lessonJurnal = (from lesson in context.lessons
                                    join sT in context.subjectTaughts on lesson.tsubjectId equals sT.tsubjectId
                                    join laba in context.labs on sT.tsubjectId equals laba.tsubjectId
                                    where lesson.lessonTypeId == 6 && laba.labId == labid
                                    orderby lesson.lessonDate
                                    select new Lesson
                                    {
                                        lessonId = lesson.lessonId,
                                        lessonDate = lesson.lessonDate,
                                        lessonTypeId = lesson.lessonTypeId
                                    }).AsNoTracking().ToList();

                //выставленные отметки
                var setMarks = (from setMark in context.setMarks
                                join student in context.students on setMark.studentId equals student.studentId
                                join lesson in context.lessons on setMark.lessonId equals lesson.lessonId
                                join mark in context.marks on setMark.markId equals mark.markId
                                join subTaught in context.subjectTaughts on lesson.tsubjectId equals subTaught.tsubjectId
                                join laba in context.labs on subTaught.tsubjectId equals laba.tsubjectId
                                orderby student.studentSurname
                                orderby lesson.lessonDate
                                where lesson.lessonTypeId == 6 && laba.labId == labid
                                select new setMark
                                {
                                    mark = new Mark() { mark = mark.mark, markId = mark.markId },
                                    lessonId = setMark.lessonId,
                                    setmarkId = setMark.setmarkId,
                                    studentId = setMark.studentId
                                }).AsNoTracking().ToList();

                //типы занятий
                var types = lessonsRep.getLessonTypes();
              
                //объединение в одну модель вывода журнала лабораторных
                var jurnal = new JurnalModel 
                { 
                    Teachers = teacherJurnal,
                    Groups = groupJurnal,
                    Lessons = lessonJurnal,
                    Students = studentsJurnal,
                    Subjects = subjectJurnal,
                    setMarks = setMarks,
                    types = types,
                    userSubjects = subLabs 
                };

                return View(jurnal);
            }

            //то журнал предмета
            else
            {
                //преподаватель
                var teacherJurnal = context.teachers.Join(context.subjectTaughts, tr => tr.teacherId, sT => sT.teacherId, (tr, sT) => new { tr, sT })
                                                    .Where(sT => sT.sT.tsubjectId == subid)
                                                    .Select(tr => new Teacher
                                                    {
                                                        teacherSurname = tr.tr.teacherSurname,
                                                        teacherName = tr.tr.teacherName,
                                                        teacherLastname = tr.tr.teacherLastname
                                                    }).AsNoTracking().ToList();

                //группы
                var groupJurnal = context.subjectTaughts.Join(context.groups, sT => sT.groupId, gr => gr.groupId, (sT, gr) => new { sT, gr })
                                                        .Where(sT => sT.sT.tsubjectId == subid)
                                                        .Select(gr => new collegeGroup { groupName = gr.gr.groupName })
                                                        .AsNoTracking().ToList();

                //предмет
                var subjectJurnal = context.subjectTaughts.Join(context.subjects, sT => sT.subjectId, sub => sub.subjectId, (sT, sub) => new { sT, sub })
                                                          .Where(sT => sT.sT.tsubjectId == subid)
                                                          .Select(sub => new SubjectGroupModel { subjectName = sub.sub.subjectName, tsubjectId = subid })
                                                          .AsNoTracking().ToList();

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
                                      }).AsNoTracking().ToList();

                //занятие
                var lessonJurnal = context.lessons.Where(less => less.tsubjectId == subid && less.lessonTypeId != 6)
                                                  .Select(less => new Lesson 
                                                  { 
                                                      lessonId = less.lessonId,
                                                      lessonDate = less.lessonDate,
                                                      lessonTypeId = less.lessonTypeId
                                                  }).AsNoTracking().ToList();

                //выставленные отметки
                var setMarks = (from setMark in context.setMarks
                                join student in context.students on setMark.studentId equals student.studentId
                                join lesson in context.lessons on setMark.lessonId equals lesson.lessonId
                                join mark in context.marks on setMark.markId equals mark.markId
                                join subTaught in context.subjectTaughts on lesson.tsubjectId equals subTaught.tsubjectId
                                orderby student.studentSurname
                                orderby lesson.lessonDate
                                where subTaught.tsubjectId == subid && lesson.lessonTypeId != 6
                                select new setMark
                                {
                                    mark = new Mark() { mark = mark.mark, markId = mark.markId },
                                    lessonId = setMark.lessonId,
                                    setmarkId = setMark.setmarkId,
                                    studentId = setMark.studentId
                                }).AsNoTracking().ToList();

                //типы занятий
                var types = lessonsRep.getLessonTypes();

                //объединение в одну модель вывода журнала предмета
                var jurnal = new JurnalModel
                {
                    Teachers = teacherJurnal,
                    Groups = groupJurnal,
                    Lessons = lessonJurnal,
                    Students = studentsJurnal,
                    Subjects = subjectJurnal,
                    setMarks = setMarks,
                    types = types,
                    userSubjects = subLabs
                };
                return View(jurnal);
            }
        }



        /**********ЖУРНАЛ ПО ДАТАМ**********/

        //показать занятия по промежутку
        public IActionResult Jurnal(DateTime lessDateStart, DateTime lessDateEnd, string month)
        {
            var jurnal = new JurnalModel();

            //если журнал лабораторных
            if (lessDates.labId != 0)
            {
                //преподаватель
                var teacherJurnal = context.teachers.Join(context.labs, tr => tr.teacherId, lab => lab.teacherId, (tr, lab) => new { tr, lab })
                                                    .Where(lab => lab.lab.labId == lessDates.labId)
                                                    .Select(tr => new Teacher
                                                    {
                                                        teacherSurname = tr.tr.teacherSurname,
                                                        teacherName = tr.tr.teacherName,
                                                        teacherLastname = tr.tr.teacherLastname
                                                    }).AsNoTracking().ToList();

                //группы
                var groupJurnal = (from lab in context.labs
                                   join subTaught in context.subjectTaughts on lab.tsubjectId equals subTaught.tsubjectId
                                   join gr in context.groups on subTaught.groupId equals gr.groupId
                                   join subGr in context.subgroups on lab.subgroupId equals subGr.subgroupId
                                   where lab.labId == lessDates.labId
                                   select new collegeGroup
                                   {
                                       groupName = string.Join(" ", gr.groupName, subGr.subgroupName)
                                   }).AsNoTracking().ToList();

                //предмет
                var subjectJurnal = (from lab in context.labs
                                     join subTaught in context.subjectTaughts on lab.tsubjectId equals subTaught.tsubjectId
                                     join gr in context.groups on subTaught.groupId equals gr.groupId
                                     join subGr in context.subgroups on lab.subgroupId equals subGr.subgroupId
                                     select new SubjectGroupModel
                                     {
                                         subjectName = lab.labName
                                     }).AsNoTracking().ToList();

                //студенты
                var studentsJurnal = (from student in context.students
                                      join subGr in context.subgroups on student.studentSubgroup equals subGr.subgroupId
                                      join laba in context.labs on subGr.subgroupId equals laba.subgroupId
                                      join subTaught in context.subjectTaughts on laba.tsubjectId equals subTaught.tsubjectId
                                      join gr in context.groups on subTaught.groupId equals gr.groupId
                                      where student.studentGroup == subTaught.groupId
                                      orderby student.studentSurname
                                      select new Student
                                      {
                                          studentId = student.studentId,
                                          studentSurname = student.studentSurname,
                                          studentName = student.studentName,
                                          studentLastname = student.studentLastname
                                      }).AsNoTracking().ToList();

                //выбор промежутка отображения журнала лабораторных
                if (month == null)
                {
                    //занятие
                    jurnal.Lessons = (from lesson in context.lessons
                                      join sT in context.subjectTaughts on lesson.tsubjectId equals sT.tsubjectId
                                      join laba in context.labs on sT.tsubjectId equals laba.tsubjectId
                                      where lesson.lessonTypeId == 6 
                                      where lesson.lessonDate >= lessDateStart && lesson.lessonDate <= lessDateEnd
                                      orderby lesson.lessonDate
                                      select new Lesson
                                      {
                                          lessonId = lesson.lessonId,
                                          lessonDate = lesson.lessonDate,
                                          lessonTypeId = lesson.lessonTypeId
                                      }).AsNoTracking().ToList();

                    //выставленные отметки
                    jurnal.setMarks = (from setMark in context.setMarks
                                       join student in context.students on setMark.studentId equals student.studentId
                                       join lesson in context.lessons on setMark.lessonId equals lesson.lessonId
                                       join mark in context.marks on setMark.markId equals mark.markId
                                       join subTaught in context.subjectTaughts on lesson.tsubjectId equals subTaught.tsubjectId
                                       join laba in context.labs on subTaught.tsubjectId equals laba.tsubjectId
                                       orderby student.studentSurname
                                       orderby lesson.lessonDate
                                       where lesson.lessonTypeId == 6 && laba.labId == lessDates.labId
                                       where lesson.lessonDate >= lessDates.lessonDateStart && lesson.lessonDate <= lessDates.lessonDateEnd
                                       select new setMark
                                       {
                                           mark = new Mark() { mark = mark.mark, markId = mark.markId },
                                           lessonId = setMark.lessonId,
                                           setmarkId = setMark.setmarkId,
                                           studentId = setMark.studentId
                                       }).AsNoTracking().ToList();
                }

                //выбор месяца отображения журнала лабораторных 
                else
                {
                    jurnal.Lessons = (from lesson in context.lessons
                                      join sT in context.subjectTaughts on lesson.tsubjectId equals sT.tsubjectId
                                      join laba in context.labs on sT.tsubjectId equals laba.tsubjectId
                                      where lesson.lessonTypeId == 6 && laba.labId == lessDates.labId
                                      where lesson.lessonDate.Month.ToString() == month
                                      orderby lesson.lessonDate
                                      select new Lesson
                                      {
                                          lessonId = lesson.lessonId,
                                          lessonDate = lesson.lessonDate,
                                          lessonTypeId = lesson.lessonTypeId
                                      }).AsNoTracking().ToList();

                    //выставленные отметки
                    jurnal.setMarks = (from setMark in context.setMarks
                                       join student in context.students on setMark.studentId equals student.studentId
                                       join lesson in context.lessons on setMark.lessonId equals lesson.lessonId
                                       join mark in context.marks on setMark.markId equals mark.markId
                                       join subTaught in context.subjectTaughts on lesson.tsubjectId equals subTaught.tsubjectId
                                       join laba in context.labs on subTaught.tsubjectId equals laba.tsubjectId
                                       orderby student.studentSurname
                                       orderby lesson.lessonDate
                                       where lesson.lessonTypeId == 6 && laba.labId == lessDates.labId
                                       where lesson.lessonDate.Month.ToString() == month
                                       select new setMark
                                       {
                                           mark = new Mark() { mark = mark.mark, markId = mark.markId },
                                           lessonId = setMark.lessonId,
                                           setmarkId = setMark.setmarkId,
                                           studentId = setMark.studentId
                                       }).AsNoTracking().ToList();
                }

                //типы занятий
                var types = lessonsRep.getLessonTypes();

                //объединение в одну модель
                jurnal.Teachers = teacherJurnal;
                jurnal.Groups = groupJurnal;
                jurnal.Students = studentsJurnal; 
                jurnal.Subjects = subjectJurnal;
                jurnal.types = types;
                return PartialView("~/Views/Marks/_jurnalTable.cshtml", jurnal);
            }


            //то журнал предмета
            else
            {
                //преподаватель
                var teacherJurnal = context.teachers.Join(context.subjectTaughts, tr => tr.teacherId, sT => sT.teacherId, (tr, sT) => new { tr, sT })
                                                    .Where(sT => sT.sT.tsubjectId == lessDates.id)
                                                    .Select(tr => new Teacher
                                                    {
                                                        teacherSurname = tr.tr.teacherSurname,
                                                        teacherName = tr.tr.teacherName,
                                                        teacherLastname = tr.tr.teacherLastname
                                                    }).AsNoTracking().ToList();

                //группы
                var groupJurnal = context.subjectTaughts.Join(context.groups, sT => sT.groupId, gr => gr.groupId, (sT, gr) => new { sT, gr })
                                                        .Where(sT => sT.sT.tsubjectId == lessDates.id)
                                                        .Select(gr => new collegeGroup { groupName = gr.gr.groupName })
                                                        .AsNoTracking().ToList();

                //предмет
                var subjectJurnal = context.subjectTaughts.Join(context.subjects, sT => sT.subjectId, sub => sub.subjectId, (sT, sub) => new { sT, sub })
                                                          .Where(sT => sT.sT.tsubjectId == lessDates.id)
                                                          .Select(sub => new SubjectGroupModel { subjectName = sub.sub.subjectName, tsubjectId = lessDates.id })
                                                          .AsNoTracking().ToList();

                //студенты
                var studentsJurnal = (from student in context.students
                                      join gr in context.groups on student.studentGroup equals gr.groupId
                                      join subTaught in context.subjectTaughts on gr.groupId equals subTaught.groupId
                                      where subTaught.tsubjectId == lessDates.id
                                      orderby student.studentSurname
                                      select new Student
                                      {
                                          studentId = student.studentId,
                                          studentSurname = student.studentSurname,
                                          studentName = student.studentName,
                                          studentLastname = student.studentLastname
                                      }).AsNoTracking().ToList();

                //промежуток отображения журнала предметов
                if (month == null)
                {
                    //занятия
                    jurnal.Lessons = context.lessons.Where(less => less.tsubjectId == lessDates.id && less.lessonTypeId != 6)
                                                    .Where(less => less.lessonDate >= lessDates.lessonDateStart && less.lessonDate <= lessDates.lessonDateEnd)
                                                    .OrderBy(less => less.lessonDate)
                                                    .Select(less => new Lesson
                                                    {
                                                        lessonId = less.lessonId,
                                                        lessonDate = less.lessonDate,
                                                        lessonTypeId = less.lessonTypeId
                                                    }).AsNoTracking().ToList();

                    //выставленные отметки
                    jurnal.setMarks = (from setMark in context.setMarks
                                       join student in context.students on setMark.studentId equals student.studentId
                                       join lesson in context.lessons on setMark.lessonId equals lesson.lessonId
                                       join mark in context.marks on setMark.markId equals mark.markId
                                       join subTaught in context.subjectTaughts on lesson.tsubjectId equals subTaught.tsubjectId
                                       orderby student.studentSurname
                                       orderby lesson.lessonDate
                                       where subTaught.tsubjectId == lessDates.id && lesson.lessonTypeId != 6
                                       where lesson.lessonDate >= lessDates.lessonDateStart && lesson.lessonDate <= lessDates.lessonDateEnd
                                       select new setMark
                                       {
                                           mark = new Mark() { mark = mark.mark, markId = mark.markId },
                                           lessonId = setMark.lessonId,
                                           setmarkId = setMark.setmarkId,
                                           studentId = setMark.studentId
                                       }).AsNoTracking().ToList();
                }

                //месяц отображения журнала предметов
                else
                {
                    jurnal.Lessons = context.lessons.Where(less => less.tsubjectId == lessDates.id && less.lessonTypeId != 6)
                                                    .Where(less => less.lessonDate.Month.ToString() == month)
                                                    .OrderBy(less => less.lessonDate)
                                                    .Select(less => new Lesson
                                                    {
                                                        lessonId = less.lessonId,
                                                        lessonDate = less.lessonDate,
                                                        lessonTypeId = less.lessonTypeId
                                                    }).AsNoTracking().ToList();

                    //выставленные отметки
                    jurnal.setMarks = (from setMark in context.setMarks
                                       join student in context.students on setMark.studentId equals student.studentId
                                       join lesson in context.lessons on setMark.lessonId equals lesson.lessonId
                                       join mark in context.marks on setMark.markId equals mark.markId
                                       join subTaught in context.subjectTaughts on lesson.tsubjectId equals subTaught.tsubjectId
                                       orderby student.studentSurname
                                       orderby lesson.lessonDate
                                       where subTaught.tsubjectId == lessDates.id && lesson.lessonTypeId != 6
                                       where lesson.lessonDate.Month.ToString() == month
                                       select new setMark
                                       {
                                           mark = new Mark() { mark = mark.mark, markId = mark.markId },
                                           lessonId = setMark.lessonId,
                                           setmarkId = setMark.setmarkId,
                                           studentId = setMark.studentId
                                       }).AsNoTracking().ToList();
                }

                //типы занятий
                var types = lessonsRep.getLessonTypes();
                if (month == "0")
                {
                    jurnal.Lessons = context.lessons.Where(less => less.tsubjectId == lessDates.id && less.lessonTypeId != 6)
                                                    .OrderBy(less => less.lessonDate)
                                                    .Select(less => new Lesson
                                                    {
                                                       lessonId = less.lessonId,
                                                       lessonDate = less.lessonDate,
                                                       lessonTypeId = less.lessonTypeId
                                                    }).AsNoTracking().ToList();

                    //выставленные отметки
                    jurnal.setMarks = (from setMark in context.setMarks
                                       join student in context.students on setMark.studentId equals student.studentId
                                       join lesson in context.lessons on setMark.lessonId equals lesson.lessonId
                                       join mark in context.marks on setMark.markId equals mark.markId
                                       join subTaught in context.subjectTaughts on lesson.tsubjectId equals subTaught.tsubjectId
                                       orderby student.studentSurname
                                       orderby lesson.lessonDate
                                       where subTaught.tsubjectId == lessDates.id && lesson.lessonTypeId != 6
                                       select new setMark
                                       {
                                           mark = new Mark() { mark = mark.mark, markId = mark.markId },
                                           lessonId = setMark.lessonId,
                                           setmarkId = setMark.setmarkId,
                                           studentId = setMark.studentId
                                       }).AsNoTracking().ToList();
                }
                //объединение в одну модель журнала
                jurnal.Teachers = teacherJurnal;
                jurnal.Groups = groupJurnal;
                jurnal.Students = studentsJurnal;
                jurnal.Subjects = subjectJurnal;
                jurnal.types = types;

                return PartialView("~/Views/Marks/_jurnalTable.cshtml", jurnal);
            }
        }



        /**********CRUD-занятий**********/

        //добавление занятия
        public async Task <IActionResult> AddLesson(LessonModel addLesson)
        {
            if (addLesson.lessonDate.Month != 8 && DateTime.Now.Year == addLesson.lessonDate.Year || DateTime.Now.Year - addLesson.lessonDate.Year == 1)
            {
                if (addLesson.labId == 0)
                {
                    using var transaction = context.Database.BeginTransaction();
                    Lesson lesson = new Lesson
                    {
                        tsubjectId = addLesson.id,
                        lessonDate = addLesson.lessonDate,
                        lessonTypeId = lessonsRep.findLessonType(addLesson.lessonType)
                    };
                    await lessonsRep.createLessonAsync(lesson);
                    transaction.Commit();
                    return RedirectToAction("Jurnal", "Marks", new { addLesson.id });
                }
                else
                {
                    var tsub = context.subjectTaughts.Join(context.labs, st => st.tsubjectId, lab => lab.tsubjectId, (st, lab) => new { st, lab })
                                                     .Where(l => l.lab.labId == addLesson.labId)
                                                     .Select(sT => sT.st.tsubjectId).FirstOrDefault();
                    using var transaction = context.Database.BeginTransaction();
                    Lesson lesson = new Lesson
                    {
                        tsubjectId = tsub,
                        lessonDate = addLesson.lessonDate,
                        lessonTypeId = 6
                    };
                    await lessonsRep.createLessonAsync(lesson);
                    transaction.Commit();
                    return RedirectToAction("Jurnal", "Marks", new { addLesson.labId });
                }
            }
            return Json("Incorrect date");
        }



        //удаление занятия
        public async Task <IActionResult> DeleteLesson(LessonModel deleteLesson)
        {
            using var transaction = context.Database.BeginTransaction();
            var lesson = lessonsRep.findLesson(deleteLesson.lessonId);
            await lessonsRep.removeLessonAsync(lesson);
            transaction.Commit();
            if (deleteLesson.labId == 0)
            {
                return RedirectToAction("Jurnal", "Marks", new { deleteLesson.id });
            }
            else return RedirectToAction("Jurnal", "Marks", new { deleteLesson.labId });
        }



        //экспорт статистики 
        public IActionResult SaveStatistics()
        {
            using (var workbook = new XLWorkbook())
            {
                //выборка всех оценок 0-10
                var digitals = context.marks.Where(mark => mark.mark != "н/б" && mark.mark != "н/а" && mark.mark != "зач" && mark.mark != "незач" && mark.mark != "н" && mark.mark != "осв")
                                            .Select(mark => new Mark { markId = mark.markId, mark = mark.mark.Trim() })
                                            .ToDictionary(mark => mark.markId, mark => mark.mark.Trim());
                var studentsStats = (from student in context.students
                                     join gr in context.groups on student.studentGroup equals gr.groupId
                                     join subTaught in context.subjectTaughts on gr.groupId equals subTaught.groupId
                                     orderby student.studentSurname
                                     select new StudentJurnal
                                     {
                                         studentId = student.studentId,
                                         studentFullname = string.Join(" ", student.studentSurname, student.studentName.Substring(0, 1) + ".", student.studentLastname.Substring(0, 1) + "."),

                                         //подсчет пропусков по уважительной
                                         studentPassesReason = context.marks.Join(context.setMarks, m => m.markId, sM => sM.markId, (m, sM) => new { m, sM })
                                                                            .Where(m => m.m.mark == "н")
                                                                            .Where(m => m.sM.studentId == student.studentId)
                                                                            .GroupBy(sm => sm.sM.studentId)
                                                                            .Select(m => m.Count()).FirstOrDefault(),

                                         //подсчет пропусков по неуважительной 
                                         studentPassesNoReason = context.marks.Join(context.setMarks, m => m.markId, sM => sM.markId, (m, sM) => new { m, sM })
                                                                              .Where(m => m.m.mark == "н/б")
                                                                              .Where(m => m.sM.studentId == student.studentId)
                                                                              .GroupBy(sm => sm.sM.studentId)
                                                                              .Select(m => m.Count()).FirstOrDefault(),

                                         //подсчет среднего балла
                                         studentAverage = context.marks.Join(context.setMarks, m => m.markId, sM => sM.markId, (m, sM) => new { m, sM })
                                                                       .Where(m => digitals.Values.Contains(m.m.mark))
                                                                       .Where(m => m.sM.studentId == student.studentId)
                                                                       .GroupBy(sm => sm.sM.studentId)
                                                                       .Select(m => m.Average(m => Convert.ToInt32(m.m.mark))).FirstOrDefault()
                                     }).Distinct().AsNoTracking().ToList();

                var worksheet = workbook.Worksheets.Add("Статистика");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "ФИО";
                worksheet.Cell(currentRow, 2).Value = "Пропуски по неуваж.";
                worksheet.Cell(currentRow, 3).Value = "Пропуски по уваж.";
                worksheet.Cell(currentRow, 4).Value = "Средний балл";

                foreach (var student in studentsStats.OrderBy(s => s.studentFullname)) 
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = student.studentFullname;
                    worksheet.Cell(currentRow, 2).Value = student.studentPassesNoReason;
                    worksheet.Cell(currentRow, 3).Value = student.studentPassesReason;
                    worksheet.Cell(currentRow, 4).Value = student.studentAverage;
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
