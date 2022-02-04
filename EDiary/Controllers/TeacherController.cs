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
        public TeacherController(UserManager<IdentityUser> userManager, EDContext context)=> (this.userManager, this.context) = (userManager, context);

        //представление препода(фамилия, предметы и группы)
        public IActionResult Teacher()
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
                                 orderby subject.subjectName, gr.groupName
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
                        orderby lab.labName, gr.groupName
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
                                        labaCount = task.lab.countLabs
                                    }).AsNoTracking().OrderBy(lab=>lab.subjectName).OrderBy(gr=>gr.groupName).ToList();

            //подсчет проведенных лаб
            var less = context.lessons.Join(context.subjectTaughts, less => less.tsubjectId, sT => sT.tsubjectId, (less, sT) => new { less, sT })
                                      .Join(context.labs, sT => sT.sT.tsubjectId, lab => lab.tsubjectId, (sT, lab) => new { sT, lab })
                                      .Where(less => less.sT.less.lessonTypeId == 6)
                                      .Where(lab => lab.lab.teacher.teacherUser == userManager.GetUserId(User))
                                      .OrderBy(lab => lab.lab.labName)
                                      .OrderBy(gr => gr.lab.tsubject.group.groupName)
                                      .GroupBy(l => l.lab.labId)
                                      .Select(lab => lab.Count()).ToList();

            //подсчет проведенных лаб в каждой задаче
            for (int i = 0; i < tasks.Count(); i++)
            {
                tasks[i].lessCount = less[i];
            }

            //эмоджи-статусы
            var statuses = context.emojiStatuses.Take(7).OrderByDescending(e=>e.statusId).ToList();

            //объединение лаб и предметов
            var subLabs = subjectGroups.Concat(labs).OrderBy(x=>x.subjectName).OrderBy(gr=>gr.groupName);

            //объединение в одну модель
            AspTeacherSubjectGroupModel teacherSubjectGroup = new AspTeacherSubjectGroupModel
            {
                Teachers = teacher,
                subjectGroups = subLabs,
                statuses = statuses,
                tasks = tasks
            };

            return View(teacherSubjectGroup);
        }
        


        //добавление фотографии преподавателя
        [HttpPost]
        public IActionResult AddPicture(AvatarStatusModel teacherPicture)
        {
            context.Database.BeginTransaction();
            var teacher = context.teachers.Where(trId => trId.teacherUser == userManager.GetUserId(User)).First();
            byte[] pic = null;
            using (var binaryReader = new BinaryReader(teacherPicture.Picture.OpenReadStream()))
            {
                pic = binaryReader.ReadBytes((int)teacherPicture.Picture.Length);
            }
            teacher.teacherPic = pic;
            context.teachers.Update(teacher);
            context.SaveChanges();
            context.Database.CommitTransaction();
            return RedirectToAction("Teacher", "Teacher");
        }



        //добавление эмоджи статуса
        [HttpPost]
        public IActionResult AddStatus(AvatarStatusModel teacherStatus)
        {
            context.Database.BeginTransaction();
            var teacher = context.teachers.Where(trId => trId.teacherUser == userManager.GetUserId(User)).FirstOrDefault();
            teacher.teacherStatus = teacherStatus.statusId;
            context.teachers.Update(teacher);
            context.SaveChanges();
            context.Database.CommitTransaction();
            return RedirectToAction("Teacher", "Teacher");
        }
    }
}
