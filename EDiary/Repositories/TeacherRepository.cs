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

        public IEnumerable<Teacher> Get()
        {
            return teachers.AsNoTracking().ToList();
        }

        public Teacher FindById(int teacherId)
        {
            return teachers.Find(teacherId);
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
