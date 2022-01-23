using EDiary.Models;
using EDiary.Service;
using EDiary.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Controllers
{
    [Authorize(Roles = "student")]
    public class StudentController : Controller
    {
        EDContext context;
        private UserManager<IdentityUser> userManager;
        public StudentController(UserManager<IdentityUser> userManager, EDContext context) => (this.userManager, this.context) = (userManager, context);

        //представление ученика(имя)
        public IActionResult Student()
        {
            ViewBag.averageMark = Math.Round((from st in context.students
                                              join sm in context.setMarks on st.studentId equals sm.studentId
                                              join mark in context.marks on sm.markId equals mark.markId
                                              where mark.mark != "н/б" && mark.mark != "н/а" && mark.mark != "зач" && mark.mark != "незач" && mark.mark != "н" && st.studentUser == userManager.GetUserId(User)
                                              select Convert.ToInt32(mark.mark)).Average(), 2);

            //ФИО учника
            var studentFullName = (from student in context.students
                                   join aspusers in context.Users on student.studentUser equals aspusers.Id
                                   where student.studentUser == userManager.GetUserId(User)
                                   select new Student
                                   {
                                       studentId = student.studentId,
                                       studentSurname = student.studentSurname,
                                       studentName = student.studentName,
                                       studentLastname = student.studentLastname,
                                       studentPic = student.studentPic
                                   }).ToList();

            var studentSubject = (from sub in context.subjects
                                  join sT in context.subjectTaughts on sub.subjectId equals sT.subjectId
                                  join gr in context.groups on sT.groupId equals gr.groupId
                                  join st in context.students on gr.groupId equals st.studentGroup
                                  join aspusers in context.Users on st.studentUser equals aspusers.Id
                                  where st.studentUser == userManager.GetUserId(User)
                                  select new SubjectGroupModel
                                  {
                                      tsubjectId = sT.tsubjectId,
                                      subjectName = sub.subjectName
                                  }).ToList();

            var studentLabs = (from student in context.students
                               join aspusers in context.Users on student.studentUser equals aspusers.Id
                               join subGr in context.subgroups on student.studentSubgroup equals subGr.subgroupId
                               join labs in context.labs on subGr.subgroupId equals labs.subgroupId
                               join sT in context.subjectTaughts on labs.tsubjectId equals sT.tsubjectId
                               join sub in context.subjects on sT.subjectId equals sub.subjectId
                               where student.studentUser == userManager.GetUserId(User)
                               select new SubjectGroupModel
                               {
                                   subjectName = labs.labName,
                                   labaId = labs.labId,
                                   tsubjectId = sT.tsubjectId,
                               }).ToList();
            var subLabs = studentSubject.Concat(studentLabs).OrderBy(x=>x.subjectName);
            AspStudentGroupModel studentSubjectGroup = new AspStudentGroupModel { students = studentFullName, subjects = subLabs};
            return View(studentSubjectGroup);
        }

        //добавление фотографии студента
        [HttpPost]
        public IActionResult AddPicture(AvatarModel studentPicture)
        {
            var student = context.students.Where(stId => stId.studentUser == userManager.GetUserId(User)).FirstOrDefault();
            byte[] pic = null;
            using (var binaryReader = new BinaryReader(studentPicture.Picture.OpenReadStream()))
            {
                pic = binaryReader.ReadBytes((int)studentPicture.Picture.Length);
            }
            student.studentPic = pic;
            context.students.Update(student);
            context.SaveChanges();
            return RedirectToAction("Student", "Student");
        }
    }
}
