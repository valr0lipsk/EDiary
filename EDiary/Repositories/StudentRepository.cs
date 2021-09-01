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
    public class StudentRepository : IStudentRepository
    {
        private readonly EDContext context;
        DbSet<Student> dbSetStudent;
        public StudentRepository(EDContext context)
        {
            this.context = context;
            this.dbSetStudent = context.Set<Student>();
        }
        public IQueryable<Student> GetStudents()
        {
            return context.students.OrderBy(x => x.studentId);
        }
        public IEnumerable<Student> GetList()
        {
            return context.students;
        }
        public IEnumerable<Student> Get()
        {
            return dbSetStudent.AsNoTracking().ToList();
        }

        public Student FindById(Guid studentId)
        {
            return dbSetStudent.Find(studentId);
        }

        public void Create(Student item)
        {
            dbSetStudent.Add(item);
            context.SaveChanges();
        }
        public void Update(Student item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Remove(Student item)
        {
            dbSetStudent.Remove(item);
            context.SaveChanges();
        }
        public void Save()
        {
            context.SaveChanges();
        }

    }

}
