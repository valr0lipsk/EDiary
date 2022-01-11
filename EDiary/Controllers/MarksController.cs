﻿using EDiary.Models;
using EDiary.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Controllers
{ 
    [Authorize]
    public class MarksController : Controller
    {
        EDContext context;
        public MarksController(EDContext context) => this.context = context;

        //представление журнала
        //public IActionResult Jurnal() => View();
        [HttpPost]
        public IActionResult Jurnal(int id, string value)
        {
            var markId = value;
            var setmark = id;
            var updatedMark = context.setMarks.Where(sM => sM.setmarkId == id).FirstOrDefault();
            if (updatedMark != null)
            {
                updatedMark.markId = (from mark in context.marks where mark.mark == value select mark.markId).FirstOrDefault();
                context.setMarks.Update(updatedMark);
                context.SaveChanges();
                return Json(new { status = "success", message = "Оценка обновлена" });
            }
            else
            {
                return Json(new { status = "error", message = "Ошибка обновления. Попробуйте еще раз" });
            }
        }

        //журнал предмета и группы
        [HttpGet]
        public IActionResult Jurnal(int id)
        {
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
                                   subjectName = st.subjectName
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
                                select new Lesson
                                {
                                    lessonId = lesson.lessonId,
                                    lessonDate = lesson.lessonDate
                                }).ToList();

            //выставленные отметки
            var setMarks = (from setMark in context.setMarks
                            join student in context.students on setMark.studentId equals student.studentId
                            join lesson in context.lessons on setMark.lessonId equals lesson.lessonId
                            join mark in context.marks on setMark.markId equals mark.markId
                            join subTaught in context.subjectTaughts on lesson.tsubjectId equals subTaught.tsubjectId
                            orderby student.studentSurname
                            where subTaught.tsubjectId == subid
                            select new setMark
                            {
                                mark = new Mark() { mark = mark.mark, markId = mark.markId},
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

            var jurnal = new JurnalModel { Teachers = teacherJurnal, Groups = groupJurnal, Lessons = lessonJurnal, Students = studentsJurnal, Subjects = subjectJurnal, setMarks = setMarks, types = types};
            return View(jurnal);
        }



        //обновление оценки 
        public IActionResult updateMark(int id, string value)
        {
            var markId = value;
            var setmark = id;
            var updatedMark = context.setMarks.Where(sM => sM.setmarkId == id).FirstOrDefault();
            if (updatedMark != null )
            {
                updatedMark.markId = (from mark in context.marks where mark.mark == value select mark.markId).FirstOrDefault();
                context.setMarks.Update(updatedMark);
                context.SaveChanges();
                return Json(new { status = "error", message = "Ошибка обновления. Попробуйте еще раз" });
            }
            else
            {
                return Json(new { status = "error", message = "Ошибка обновления. Попробуйте еще раз" });
            }
        }

        //добавление занятия
        //public IActionResult lessonData(DateTime lessonDate, string lessonType, int subid)
        //{
        //    var lessType = (from lT in context.lessonType where lT.typeName == lessonType select lT.lessonTypeId).FirstOrDefault();
        //    Lesson lesson = new Lesson { tsubjectId = subid, lessonDate = lessonDate, lessonTypeId = lessType  };
        //    context.lessons.Add(lesson);
        //    context.SaveChanges();
        //    return RedirectToAction("Jurnal", "Marks", subid);
        //}
        public IActionResult AddLesson(AddLessonType addLesson)
        {
            Lesson lesson = new Lesson { tsubjectId = addLesson.subid, lessonDate = addLesson.lessonDate, lessonTypeId = (from lT in context.lessonType where lT.typeName == addLesson.lessonType select lT.lessonTypeId).FirstOrDefault()};
            context.lessons.Add(lesson);
            context.SaveChanges();
            return RedirectToAction("Jurnal", "Marks", addLesson.subid);
        }
    }
}
