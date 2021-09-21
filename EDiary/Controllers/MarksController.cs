using EDiary.Models;
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
        public IActionResult Jurnal()
        {
            return View();
        }

        //[HttpGet]
        //public IActionResult Jurnal(int id)
        //{
        //    var subid = id;
        //    var teacherGroup = (from user in context.users
        //                        join tr in context.teachers on user.idUser equals tr.teacherUser
        //                        join subTaught in context.subjectTaughts on tr.teacherId equals subTaught.teacherId
        //                        join st in context.subjects on subTaught.subjectId equals st.subjectId
        //                        join gr in context.groups on subTaught.groupId equals gr.groupId
        //                        join aspusers in context.Users on user.userId equals aspusers.Id
        //                        where subTaught.tsubjectId == subid
        //                        select new TeacherGroupSubjectModel
        //                        {
        //                            teacherSurname = user.userSurname,
        //                            teacherName = user.userName,
        //                            teacherLastname = user.userLastname,
        //                            groups = gr.groupName,
        //                            subjectName = st.subjectName
        //                        }).ToList();
        //    return View(teacherGroup);
        //}
        [HttpGet]
        public IActionResult Jurnal(int id)
        {
            var subid = id;
            /*рабочий варик*/
            //var teacherJurnal = (from user in context.users
            //                    join tr in context.teachers on user.idUser equals tr.teacherUser
            //                    join subTaught in context.subjectTaughts on tr.teacherId equals subTaught.teacherId
            //                    join st in context.subjects on subTaught.subjectId equals st.subjectId
            //                    join gr in context.groups on subTaught.groupId equals gr.groupId
            //                    join aspusers in context.Users on user.userId equals aspusers.Id
            //                    where subTaught.tsubjectId == subid
            //                    select new TeacherJurnalModel
            //                    {
            //                        teacherSurname = user.userSurname,
            //                        teacherName = user.userName,
            //                        teacherLastname = user.userLastname,
            //                        groups = gr.groupName,
            //                        subjectName = st.subjectName
            //                    }).ToList();
            //var studentJurnal = (from user in context.users
            //                     join st in context.students on user.idUser equals st.studentUser
            //                     join setMark in context.setMarks on st.studentId equals setMark.studentId
            //                     join mark in context.marks on setMark.markId equals mark.markId
            //                     join lesson in context.lessons on setMark.lessonId equals lesson.lessonId
            //                     join subTaught in context.subjectTaughts on lesson.tsubjectId equals subTaught.tsubjectId
            //                     join gr in context.groups on st.studentGroup equals gr.groupId
            //                     join aspusers in context.Users on user.userId equals aspusers.Id
            //                     where lesson.tsubjectId == subid
            //                     select new StudentsJurnalModel
            //                     {
            //                         studentSurname = user.userSurname,
            //                         studentName = user.userName,
            //                         studentLastname = user.userLastname,
            //                     }).ToList();
            //var lessonJurnal = (from user in context.users
            //                    join st in context.students on user.idUser equals st.studentUser
            //                    join setMark in context.setMarks on st.studentId equals setMark.studentId
            //                    join mark in context.marks on setMark.markId equals mark.markId
            //                    join lesson in context.lessons on setMark.lessonId equals lesson.lessonId
            //                    join subTaught in context.subjectTaughts on lesson.tsubjectId equals subTaught.tsubjectId
            //                    join gr in context.groups on st.studentGroup equals gr.groupId
            //                    join aspusers in context.Users on user.userId equals aspusers.Id
            //                    where lesson.tsubjectId == subid
            //                    select new StudentsJurnalModel
            //                    {
            //                        lessonDate = lesson.lessonDate.ToString("dd.MM.yyyy")
            //                    }).ToList();
            //var markJurnal = (from user in context.users
            //                  join st in context.students on user.idUser equals st.studentUser
            //                  join setMark in context.setMarks on st.studentId equals setMark.studentId
            //                  join mark in context.marks on setMark.markId equals mark.markId
            //                  join lesson in context.lessons on setMark.lessonId equals lesson.lessonId
            //                  join subTaught in context.subjectTaughts on lesson.tsubjectId equals subTaught.tsubjectId
            //                  join gr in context.groups on st.studentGroup equals gr.groupId
            //                  join aspusers in context.Users on user.userId equals aspusers.Id
            //                  where lesson.tsubjectId == subid
            //                  select new StudentsJurnalModel
            //                  {
            //                      studentMark = mark.mark
            //                  }).ToList();
            /*рабочий варик*/
            var teacherJurnal = (from user in context.users
                                 join tr in context.teachers on user.idUser equals tr.teacherUser
                                 join subTaught in context.subjectTaughts on tr.teacherId equals subTaught.teacherId
                                 join st in context.subjects on subTaught.subjectId equals st.subjectId
                                 join gr in context.groups on subTaught.groupId equals gr.groupId
                                 join aspusers in context.Users on user.userId equals aspusers.Id
                                 where subTaught.tsubjectId == subid
                                 select new Users
                                 {
                                     userSurname = user.userSurname,
                                     userName = user.userName,
                                     userLastname = user.userLastname
                                 }).ToList();
            var groupJurnal = (from user in context.users
                                 join tr in context.teachers on user.idUser equals tr.teacherUser
                                 join subTaught in context.subjectTaughts on tr.teacherId equals subTaught.teacherId
                                 join st in context.subjects on subTaught.subjectId equals st.subjectId
                                 join gr in context.groups on subTaught.groupId equals gr.groupId
                                 join aspusers in context.Users on user.userId equals aspusers.Id
                                 where subTaught.tsubjectId == subid
                                 select new collegeGroup
                                 {
                                     groupName = gr.groupName,
                                 }).ToList();
            var subjectJurnal = (from user in context.users
                                 join tr in context.teachers on user.idUser equals tr.teacherUser
                                 join subTaught in context.subjectTaughts on tr.teacherId equals subTaught.teacherId
                                 join st in context.subjects on subTaught.subjectId equals st.subjectId
                                 join gr in context.groups on subTaught.groupId equals gr.groupId
                                 join aspusers in context.Users on user.userId equals aspusers.Id
                                 where subTaught.tsubjectId == subid
                                 select new Subject
                                 {
                                     subjectName = st.subjectName
                                 }).ToList();
            var studentsJurnal = (from user in context.users
                                 join st in context.students on user.idUser equals st.studentUser
                                 join gr in context.groups on st.studentGroup equals gr.groupId
                                 join aspusers in context.Users on user.userId equals aspusers.Id
                                 join subTaught in context.subjectTaughts on gr.groupId equals subTaught.groupId
                                 where subTaught.tsubjectId == subid
                                 select new Users
                                 {
                                     userSurname = user.userSurname,
                                     userName = user.userName,
                                     userLastname = user.userLastname,
                                 }).ToList();
            var lessonJurnal = (from lesson in context.lessons
                                where lesson.tsubjectId == subid
                                select new Lesson
                                {
                                    lessonDate = lesson.lessonDate
                                }).ToList();
            var markJurnal = (from user in context.users
                              join st in context.students on user.idUser equals st.studentUser
                              join setMark in context.setMarks on st.studentId equals setMark.studentId
                              join mark in context.marks on setMark.markId equals mark.markId
                              join lesson in context.lessons on setMark.lessonId equals lesson.lessonId
                              where lesson.tsubjectId == subid && st.studentId == setMark.studentId
                              select new Mark
                              {
                                  mark = mark.mark
                              }).ToList();
            //var studentJurnal = new StudentsJurnalModel { Users = studentsJurnal, Marks = markJurnal, Lessons = lessonJurnal };
            var jurnal = new JurnalModel { Teachers = teacherJurnal, Groups = groupJurnal, Lessons = lessonJurnal, Marks = markJurnal, Students = studentsJurnal, Subjects = subjectJurnal };
            return View(jurnal);
        }
    }
}
