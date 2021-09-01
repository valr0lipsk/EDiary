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
        DbSet<Teacher> dbSetTeacher;

        public TeacherRepository(EDContext context)
        {
            this.context = context;
            this.dbSetTeacher = context.Set<Teacher>();
        }

        public IEnumerable<Teacher> Get()
        {
            return dbSetTeacher.AsNoTracking().ToList();
        }

        public Teacher FindById(Guid teacherId)
        {
            return dbSetTeacher.Find(teacherId);
        }

        public void Create(Teacher item)
        {
            dbSetTeacher.Add(item);
            context.SaveChanges();
        }
        public void Update(Teacher item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Remove(Teacher item)
        {
            dbSetTeacher.Remove(item);
            context.SaveChanges();
        }
        public void Save()
        {
            context.SaveChanges();
        }

    }

}
