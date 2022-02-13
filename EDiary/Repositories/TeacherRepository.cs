using EDiary.IRepositories;
using EDiary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EDiary.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        EDContext context;
        DbSet<Teacher> teachers;
        DbSet<EmojiStatus> statuses;

        public TeacherRepository(EDContext context)
        {
            this.context = context;
            this.teachers = context.Set<Teacher>();
            this.statuses = context.Set<EmojiStatus>();
        }

        //получение всех преподавателей
        public List<Teacher> allTeachers()
        {
            return teachers.AsNoTracking().ToList();
        }

        //получение преподавателя как пользователя
        public Teacher findTeacher(string teacher)
        {
            return teachers.Where(tr => tr.teacherUser == teacher).FirstOrDefault();
        }

        //создание преподавателя
        public async Task createTeacherAsync(Teacher item)
        {
            await teachers.AddAsync(item);
            await context.SaveChangesAsync();
        }

        //обновление преподавателя
        public async Task updateTeacherAsync(Teacher teacher)
        {
            teachers.Update(teacher);
            await context.SaveChangesAsync();
        }

        //получение эмоджи-статусов преподавателя
        public List<EmojiStatus> teachersStatuses()
        {
            return statuses.Take(7).OrderByDescending(e => e.statusId).AsNoTracking().ToList();
        }
    }
}
