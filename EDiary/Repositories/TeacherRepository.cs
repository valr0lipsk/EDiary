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

        public TeacherRepository(EDContext context)
        {
            this.context = context;
            this.teachers = context.Set<Teacher>();
        }

        public List<Teacher> allTeachers()
        {
            return teachers.AsNoTracking().ToList();
        }

        public Teacher findTeacher(string teacher)
        {
            return teachers.Where(tr => tr.teacherUser == teacher).FirstOrDefault();
        }

        public async Task createTeacher(Teacher item)
        {
            await teachers.AddAsync(item);
            await context.SaveChangesAsync();
        }

        public async Task updateTeacher(Teacher teacher)
        {
            teachers.Update(teacher);
            await context.SaveChangesAsync();
        }
    }
}
