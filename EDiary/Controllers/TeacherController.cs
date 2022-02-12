using EDiary.Models;
using EDiary.Service;
using EDiary.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Controllers
{
    [Authorize(Roles = "teacher")]
    public class TeacherController : Controller
    {
        EDContext context;
        private UserManager<IdentityUser> userManager;
        public TeacherController(UserManager<IdentityUser> userManager, EDContext context) => (this.userManager, this.context) = (userManager, context);



        //представление препода(фамилия, предметы и группы, поиск)
        public IActionResult Teacher(string search)
        {
            //отметки-цифры
            var digitals = context.marks.Where(mark => mark.mark != "н/б" && mark.mark != "н/а" && mark.mark != "зач" && mark.mark != "незач" && mark.mark != "н" && mark.mark != "осв")
                                            .Select(mark => new Mark { markId = mark.markId, mark = mark.mark.Trim() })
                                            .ToDictionary(mark => mark.markId, mark => mark.mark.Trim());

            //кураторская группа
            ViewBag.curatorGroup = context.teachers.Join(context.groups, tr => tr.teacherId, gr => gr.curatorId, (tr, gr) => new { tr, gr })
                                                   .Where(tr => tr.tr.teacherUser == userManager.GetUserId(User))
                                                   .Select(gr => gr.gr.groupName).FirstOrDefault();

            //инфо о преподе
            var teacher = context.teachers.Where(tr => tr.teacherUser == userManager.GetUserId(User))
                                          .Select(tr => new TeacherModel
                                          {
                                              teacherSurname = tr.teacherSurname,
                                              teacherName = tr.teacherName,
                                              teacherLastname = tr.teacherLastname,
                                              teacherPic = tr.teacherPic,
                                              teacherStatus = tr.status.emoji,
                                              teacherGroup = context.groups.Where(tr => tr.teacher.teacherUser == userManager.GetUserId(User))
                                                                           .Select(gr => gr.groupId).FirstOrDefault()
                                          }).AsNoTracking().ToList();

            //предметы
            var subjectGroups = (from tsub in context.subjectTaughts
                                 join subject in context.subjects on tsub.subjectId equals subject.subjectId
                                 join gr in context.groups on tsub.groupId equals gr.groupId
                                 join teachers in context.teachers on tsub.teacherId equals teachers.teacherId
                                 where teachers.teacherUser == userManager.GetUserId(User)
                                 select new SubjectGroupModel
                                 {
                                     groupName = gr.groupName,
                                     subjectName = subject.subjectName,
                                     tsubjectId = tsub.tsubjectId,
                                     subIcon = subject.Icon.subjectPicture
                                 }).AsNoTracking().ToList();

            //лабы
            var labs = (from tsub in context.subjectTaughts
                        join gr in context.groups on tsub.groupId equals gr.groupId
                        join lab in context.labs on tsub.tsubjectId equals lab.tsubjectId
                        join teachers in context.teachers on lab.teacherId equals teachers.teacherId
                        where teachers.teacherUser == userManager.GetUserId(User)
                        select new SubjectGroupModel
                        {
                            subjectName = lab.labName,
                            labaId = lab.labId,
                            tsubjectId = tsub.tsubjectId,
                            groupName = gr.groupName,
                            subIcon = tsub.subject.Icon.subjectPicture
                        }).AsNoTracking().ToList();

            //задачи
            var tasks = context.labs.Join(context.teachers, lab => lab.teacherId, tr => tr.teacherId, (lab, tr) => new { lab, tr })
                                    .Where(tr => tr.tr.teacherUser == userManager.GetUserId(User))
                                    .Select(task => new SubjectGroupModel
                                    {
                                        subjectName = task.lab.labName,
                                        groupName = task.lab.tsubject.@group.groupName,
                                        labaCount = task.lab.countLabs,
                                        lessCount = context.lessons.Join(context.subjectTaughts, less => less.tsubjectId, sT => sT.tsubjectId, (less, sT) => new { less, sT })
                                                                   .Join(context.labs, sT => sT.sT.tsubjectId, lab => lab.tsubjectId, (sT, lab) => new { sT, lab })
                                                                   .Where(less => less.sT.less.lessonTypeId == 6)
                                                                   .Where(lab => lab.lab.teacher.teacherUser == userManager.GetUserId(User))
                                                                   .Where(lb => lb.lab.labId == task.lab.labId)
                                                                   .GroupBy(l => l.lab.labId)
                                                                   .Select(lab => lab.Count()).FirstOrDefault()
                                    }).AsNoTracking().OrderBy(lab => lab.subjectName).OrderBy(gr => gr.groupName).ToList();

            //учащиеся кураторской группы
            var students = context.students.Where(gr => gr.studentGroup == teacher.FirstOrDefault().teacherGroup)
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
                                            }).AsNoTracking().OrderBy(st => st.studentSurname).OrderBy(st => st.studentName).ToList();

            //эмоджи-статусы
            var statuses = context.emojiStatuses.Take(7).OrderByDescending(e => e.statusId).ToList();

            //объединение лаб и предметов
            var subLabs = subjectGroups.Concat(labs).OrderBy(x => x.subjectName).OrderBy(gr => gr.groupName).ToList();

            //поиск
            if (!string.IsNullOrEmpty(search))
            {
                subLabs = subLabs.Where(s => s.subjectName.ToLower().Contains(search.ToLower()) || s.groupName.ToLower().Contains(search.ToLower())).ToList();
            }

            //объединение в одну модель
            AspTeacherSubjectGroupModel teacherSubjectGroup = new AspTeacherSubjectGroupModel
            {
                Teachers = teacher,
                subjectGroups = subLabs,
                statuses = statuses,
                tasks = tasks,
                students = students,
            };

            return View(teacherSubjectGroup);
        }



        //представление препода (лабы)
        public IActionResult ShowLabs()
        {
            //кураторская группа
            ViewBag.curatorGroup = context.teachers.Join(context.groups, tr => tr.teacherId, gr => gr.curatorId, (tr, gr) => new { tr, gr })
                                                   .Where(tr => tr.tr.teacherUser == userManager.GetUserId(User))
                                                   .Select(gr => gr.gr.groupName).FirstOrDefault();

            //инфо о преподе
            var teacher = context.teachers.Where(tr => tr.teacherUser == userManager.GetUserId(User))
                                          .Select(tr => new TeacherModel
                                          {
                                              teacherSurname = tr.teacherSurname,
                                              teacherName = tr.teacherName,
                                              teacherLastname = tr.teacherLastname,
                                              teacherPic = tr.teacherPic,
                                              teacherStatus = tr.status.emoji
                                          }).AsNoTracking().ToList();


            //лабы
            var labs = (from tsub in context.subjectTaughts
                        join gr in context.groups on tsub.groupId equals gr.groupId
                        join lab in context.labs on tsub.tsubjectId equals lab.tsubjectId
                        join teachers in context.teachers on lab.teacherId equals teachers.teacherId
                        where teachers.teacherUser == userManager.GetUserId(User)
                        select new SubjectGroupModel
                        {
                            subjectName = lab.labName,
                            labaId = lab.labId,
                            tsubjectId = tsub.tsubjectId,
                            groupName = gr.groupName,
                            subIcon = tsub.subject.Icon.subjectPicture
                        }).AsNoTracking().ToList();

            //задачи
            var tasks = context.labs.Join(context.teachers, lab => lab.teacherId, tr => tr.teacherId, (lab, tr) => new { lab, tr })
                                    .Where(tr => tr.tr.teacherUser == userManager.GetUserId(User))
                                    .Select(task => new SubjectGroupModel
                                    {
                                        subjectName = task.lab.labName,
                                        groupName = task.lab.tsubject.@group.groupName,
                                        labaCount = task.lab.countLabs,
                                        lessCount = context.lessons.Join(context.subjectTaughts, less => less.tsubjectId, sT => sT.tsubjectId, (less, sT) => new { less, sT })
                                                                   .Join(context.labs, sT => sT.sT.tsubjectId, lab => lab.tsubjectId, (sT, lab) => new { sT, lab })
                                                                   .Where(less => less.sT.less.lessonTypeId == 6)
                                                                   .Where(lab => lab.lab.teacher.teacherUser == userManager.GetUserId(User))
                                                                   .Where(lb => lb.lab.labId == task.lab.labId)
                                                                   .GroupBy(l => l.lab.labId)
                                                                   .Select(lab => lab.Count()).FirstOrDefault()
                                    }).AsNoTracking().OrderBy(lab => lab.subjectName).OrderBy(gr => gr.groupName).ToList();

            //эмоджи-статусы
            var statuses = context.emojiStatuses.Take(7).OrderByDescending(e => e.statusId).ToList();

            //объединение лаб и предметов
            var subLabs = labs.OrderBy(x => x.subjectName).OrderBy(gr => gr.groupName).ToList();

            //объединение в одну модель
            AspTeacherSubjectGroupModel teacherSubjectGroup = new AspTeacherSubjectGroupModel
            {
                Teachers = teacher,
                subjectGroups = subLabs,
                statuses = statuses,
                tasks = tasks
            };

            return View("Teacher", teacherSubjectGroup);
        }



        //представление препода (предметы)
        public IActionResult ShowSubjects()
        {
            //кураторская группа
            ViewBag.curatorGroup = context.teachers.Join(context.groups, tr => tr.teacherId, gr => gr.curatorId, (tr, gr) => new { tr, gr })
                                                   .Where(tr => tr.tr.teacherUser == userManager.GetUserId(User))
                                                   .Select(gr => gr.gr.groupName).FirstOrDefault();

            //инфо о преподе
            var teacher = context.teachers.Where(tr => tr.teacherUser == userManager.GetUserId(User))
                                          .Select(tr => new TeacherModel
                                          {
                                              teacherSurname = tr.teacherSurname,
                                              teacherName = tr.teacherName,
                                              teacherLastname = tr.teacherLastname,
                                              teacherPic = tr.teacherPic,
                                              teacherStatus = tr.status.emoji
                                          }).AsNoTracking().ToList();

            //предметы
            var subjectGroups = (from tsub in context.subjectTaughts
                                 join subject in context.subjects on tsub.subjectId equals subject.subjectId
                                 join gr in context.groups on tsub.groupId equals gr.groupId
                                 join teachers in context.teachers on tsub.teacherId equals teachers.teacherId
                                 where teachers.teacherUser == userManager.GetUserId(User)
                                 select new SubjectGroupModel
                                 {
                                     groupName = gr.groupName,
                                     subjectName = subject.subjectName,
                                     tsubjectId = tsub.tsubjectId,
                                     subIcon = subject.Icon.subjectPicture
                                 }).AsNoTracking().ToList();

            //задачи
            var tasks = context.labs.Join(context.teachers, lab => lab.teacherId, tr => tr.teacherId, (lab, tr) => new { lab, tr })
                                    .Where(tr => tr.tr.teacherUser == userManager.GetUserId(User))
                                    .Select(task => new SubjectGroupModel
                                    {
                                        subjectName = task.lab.labName,
                                        groupName = task.lab.tsubject.@group.groupName,
                                        labaCount = task.lab.countLabs,
                                        lessCount = context.lessons.Join(context.subjectTaughts, less => less.tsubjectId, sT => sT.tsubjectId, (less, sT) => new { less, sT })
                                                                   .Join(context.labs, sT => sT.sT.tsubjectId, lab => lab.tsubjectId, (sT, lab) => new { sT, lab })
                                                                   .Where(less => less.sT.less.lessonTypeId == 6)
                                                                   .Where(lab => lab.lab.teacher.teacherUser == userManager.GetUserId(User))
                                                                   .Where(lb => lb.lab.labId == task.lab.labId)
                                                                   .GroupBy(l => l.lab.labId)
                                                                   .Select(lab => lab.Count()).FirstOrDefault()
                                    }).AsNoTracking().OrderBy(lab => lab.subjectName).OrderBy(gr => gr.groupName).ToList();

            //эмоджи-статусы
            var statuses = context.emojiStatuses.Take(7).OrderByDescending(e => e.statusId).ToList();

            //объединение лаб и предметов
            var subLabs = subjectGroups.OrderBy(x => x.subjectName).OrderBy(gr => gr.groupName).ToList();

            //объединение в одну модель
            AspTeacherSubjectGroupModel teacherSubjectGroup = new AspTeacherSubjectGroupModel
            {
                Teachers = teacher,
                subjectGroups = subLabs,
                statuses = statuses,
                tasks = tasks
            };

            return View("Teacher", teacherSubjectGroup);
        }



        //добавление фотографии преподавателя
        [HttpPost]
        public async Task<IActionResult> AddPicture(AvatarStatusModel teacherPicture)
        { 
            var teacher = context.teachers.Where(trId => trId.teacherUser == userManager.GetUserId(User)).FirstOrDefault();
            if (teacherPicture.Picture == null)
            {
                teacher.teacherPic = null;
                context.teachers.Update(teacher);
                await context.SaveChangesAsync();
                return RedirectToAction("Teacher", "Teacher");
            }
            else if (teacherPicture.Picture.ContentType.Contains("image"))
            { 
                using (var binaryReader = new BinaryReader(teacherPicture.Picture.OpenReadStream()))    
                {
                    teacher.teacherPic = binaryReader.ReadBytes((int)teacherPicture.Picture.Length);
                }
                context.teachers.Update(teacher);
                await context.SaveChangesAsync();
                return RedirectToAction("Teacher", "Teacher");
            }
            else
            {
                return Json("Error of add picture");
            }
        }



        //добавление эмоджи статуса
        [HttpPost]
        public async Task<IActionResult> AddStatus(AvatarStatusModel teacherStatus)
        {
            var teacher = context.teachers.Where(trId => trId.teacherUser == userManager.GetUserId(User)).FirstOrDefault();
            teacher.teacherStatus = teacherStatus.statusId;
            context.teachers.Update(teacher);
            await context.SaveChangesAsync();
            return RedirectToAction("Teacher", "Teacher");
        }
    }
}