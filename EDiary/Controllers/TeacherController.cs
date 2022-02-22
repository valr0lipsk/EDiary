using EDiary.IRepositories;
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
        ITeacherRepository teachersRep;
        public TeacherController(UserManager<IdentityUser> userManager, EDContext context, ITeacherRepository teachersRep)
                             => (this.userManager, this.context, this.teachersRep) = (userManager, context, teachersRep);



        //представление препода(фамилия, предметы и группы, поиск)
        [HttpGet]
        public IActionResult Teacher(string category)
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
                                              teacherId = tr.teacherId,
                                              teacherSurname = tr.teacherSurname,
                                              teacherName = tr.teacherName,
                                              teacherLastname = tr.teacherLastname,
                                              teacherPic = tr.teacherPic,
                                              teacherStatus = tr.status.emoji,
                                              teacherGroup = context.groups.Where(tr => tr.teacher.teacherUser == userManager.GetUserId(User))
                                                                           .Select(gr => gr.groupId).FirstOrDefault()
                                          }).AsNoTracking().ToList();

            //предметы
            var subjects = (from tsub in context.subjectTaughts
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
                            }).AsNoTracking().OrderBy(sub => sub.subjectName).ThenBy(gr => gr.groupName).ToList();

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
                        }).AsNoTracking().OrderBy(sub => sub.subjectName).ThenBy(gr => gr.groupName).ToList();

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
                                    }).AsNoTracking().OrderBy(sub => sub.subjectName).ThenBy(gr => gr.groupName).ToList();

            //коллеги по предмету
            var colleagues = context.teachers.Join(context.subjectTaughts, tr => tr.teacherId, sT => sT.teacherId, (tr, sT) => new { tr, sT })
                                             .Where(sub => sub.sT.subject.subjectName == subjects.FirstOrDefault().subjectName)
                                             .Where(tr => tr.tr.teacherId != teacher.FirstOrDefault().teacherId)
                                             .Select(tr => new TeacherModel
                                             {
                                                 teacherSurname = tr.tr.teacherSurname,
                                                 teacherName = tr.tr.teacherName,
                                                 teacherLastname = tr.tr.teacherLastname,
                                                 teacherPic = tr.tr.teacherPic,
                                                 teacherStatus = tr.tr.status.emoji
                                             }).AsNoTracking().OrderBy(tr => tr.teacherSurname).ThenBy(tr => tr.teacherName).ToList();

            //эмоджи-статусы
            var statuses = teachersRep.teachersStatuses();

            //отображение все/лекции/лабы
            var subLabs = new List<SubjectGroupModel>();

            //все
            if (category == "1")
            {
                subLabs = subjects.Concat(labs).OrderBy(sub => sub.subjectName).ThenBy(gr => gr.groupName).ToList();
                AspTeacherSubjectGroupModel teacherSubjectGroup = new AspTeacherSubjectGroupModel
                {
                    Teachers = teacher,
                    subjectGroups = subLabs,
                    statuses = statuses,
                    tasks = tasks,
                    colleagues = colleagues,
                };
                return PartialView("~/Views/Teacher/_subjectsBlock.cshtml", teacherSubjectGroup);
            }

            //только лекции
            else if (category == "2")
            {
                subLabs = subjects.OrderBy(sub => sub.subjectName).ThenBy(gr => gr.groupName).ToList();
                AspTeacherSubjectGroupModel teacherSubjectGroup = new AspTeacherSubjectGroupModel
                {
                    Teachers = teacher,
                    subjectGroups = subLabs,
                    statuses = statuses,
                    tasks = tasks,
                    colleagues = colleagues,
                };
                return PartialView("~/Views/Teacher/_subjectsBlock.cshtml", teacherSubjectGroup);
            }

            //только лабы
            else if (category == "3")
            {
                subLabs = labs.OrderBy(sub => sub.subjectName).ThenBy(gr => gr.groupName).ToList();
                AspTeacherSubjectGroupModel teacherSubjectGroup = new AspTeacherSubjectGroupModel
                {
                    Teachers = teacher,
                    subjectGroups = subLabs,
                    statuses = statuses,
                    tasks = tasks,
                    colleagues = colleagues,
                };
                return PartialView("~/Views/Teacher/_subjectsBlock.cshtml", teacherSubjectGroup);
            }

            //начальная загрузка
            else
            {
                subLabs = subjects.Concat(labs).OrderBy(sub => sub.subjectName).ThenBy(gr => gr.groupName).ToList();
                AspTeacherSubjectGroupModel teacherSubjectGroup = new AspTeacherSubjectGroupModel
                {
                    Teachers = teacher,
                    subjectGroups = subLabs,
                    statuses = statuses,
                    tasks = tasks,
                    colleagues = colleagues,
                };
                return View(teacherSubjectGroup);
            }
        }



        //добавление фотографии преподавателя
        [HttpPost]
        public async Task<IActionResult> AddPicture(AvatarStatusModel teacherPicture)
        {
            var teacher = teachersRep.findTeacher(userManager.GetUserId(User));
            if (teacherPicture.Picture == null)
            {
                teacher.teacherPic = null;
                await teachersRep.updateTeacherAsync(teacher);
                return RedirectToAction("Teacher", "Teacher");
            }
            else if (teacherPicture.Picture.ContentType.Contains("image"))
            { 
                using (var binaryReader = new BinaryReader(teacherPicture.Picture.OpenReadStream()))    
                {
                    teacher.teacherPic = binaryReader.ReadBytes((int)teacherPicture.Picture.Length);
                }
                await teachersRep.updateTeacherAsync(teacher);
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
            var teacher = teachersRep.findTeacher(userManager.GetUserId(User));
            teacher.teacherStatus = teacherStatus.statusId;
            await teachersRep.updateTeacherAsync(teacher);
            return RedirectToAction("Teacher", "Teacher");
        }
    }
}