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
        DbSet<EmojiStatus> statuses;
        public StudentRepository(EDContext context)
        {
            this.context = context;
            this.students = context.Set<Student>();
            this.statuses = context.Set<EmojiStatus>();
        }

        //получение студента как пользователя
        public Student findStudent(string student)
        {
            return students.Where(st => st.studentUser == student).FirstOrDefault();
        }

        //создание студента
        public async Task createStudentAsync(Student student)
        {
            await students.AddAsync(student);
            await context.SaveChangesAsync();
        }

        //обновление студента
        public async Task updateStudentAsync(Student student)
        {
            students.Update(student);
            await context.SaveChangesAsync();
        }

        //получение эмоджи-статусов студента
        public List<EmojiStatus> studentsStatuses()
        {
            return statuses.Take(8).AsNoTracking().ToList();
        }
    }
}
