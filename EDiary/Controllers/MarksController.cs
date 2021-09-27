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

            /*преподаватель, группа и предмет*/
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

            var subjectJurnal = (from subTaught in context.subjectTaughts
                                 join st in context.subjects on subTaught.subjectId equals st.subjectId
                                 where subTaught.tsubjectId == subid
                                 select new Subject
                                 {
                                   subjectName = st.subjectName
                                 }).ToList();
            /*студенты*/
            var studentsJurnal = (from st in context.students
                                  join user in context.users on st.studentUser equals user.idUser
                                  select new Users
                                  {
                                      userSurname = user.userSurname,
                                      userName = user.userName,
                                      userLastname = user.userLastname
                                  }).ToList();
            var studentsId = (from setMark in context.setMarks
                              join st in context.students on setMark.studentId equals st.studentId
                              join user in context.users on st.studentUser equals user.idUser
                              join lesson in context.lessons on setMark.lessonId equals lesson.lessonId
                              join mark in context.marks on setMark.markId equals mark.markId
                              join subTaught in context.subjectTaughts on lesson.tsubjectId equals subTaught.tsubjectId
                              where subTaught.tsubjectId == subid
                              select new Student
                              {
                                  studentId = st.studentId,
                              }).ToList();
            var lessonJurnal = (from lesson in context.lessons
                                join setMark in context.setMarks on lesson.lessonId equals setMark.lessonId
                                where lesson.tsubjectId == subid
                                select new Lesson
                                {
                                    lessonId = lesson.lessonId,
                                    lessonDate = lesson.lessonDate
                                }).ToList();
            var markJurnal = (from setMark in context.setMarks
                              join mark in context.marks on setMark.markId equals mark.markId
                              join st in context.students on setMark.studentId equals st.studentId
                              join lesson in context.lessons on setMark.lessonId equals lesson.lessonId
                              join subTaught in context.subjectTaughts on lesson.tsubjectId equals subTaught.tsubjectId
                              where subTaught.tsubjectId == subid
                              select new Mark
                              {
                                  mark = mark.mark
                              }).ToList();
            var setMarks = (from setMark in context.setMarks
                            join st in context.students on setMark.studentId equals st.studentId
                            join lesson in context.lessons on setMark.lessonId equals lesson.lessonId
                            join mark in context.marks on setMark.markId equals mark.markId
                            join subTaught in context.subjectTaughts on lesson.tsubjectId equals subTaught.tsubjectId
                            where subTaught.tsubjectId == subid
                            select new setMark
                            {
                                setmarkId = setMark.setmarkId,
                                studentId = setMark.studentId
                            }).ToList();
            //var studentJurnal = new StudentsJurnalModel { Users = studentsJurnal, Marks = markJurnal, Lessons = lessonJurnal };
            var jurnal = new JurnalModel { Teachers = teacherJurnal, Groups = groupJurnal, Lessons = lessonJurnal, Marks = markJurnal, Students = studentsJurnal, Subjects = subjectJurnal, StudentsId = studentsId, setMarks = setMarks };
            return View(jurnal);
        }
    }
}
