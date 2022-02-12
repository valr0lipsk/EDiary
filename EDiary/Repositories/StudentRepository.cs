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
        DbSet<Student> students;
        public StudentRepository(EDContext context)
        {
            this.context = context;
            this.students = context.Set<Student>();
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
            return students.AsNoTracking().ToList();
        }

        public Student FindById(Guid studentId)
        {
            return students.Find(studentId);
        }

        public async Task createStudent(Student student)
        {
            await students.AddAsync(student);
            await context.SaveChangesAsync();
        }
        public async Task updateStudent(Student student)
        {
            students.Update(student);
            await context.SaveChangesAsync();
        }
    }
}
