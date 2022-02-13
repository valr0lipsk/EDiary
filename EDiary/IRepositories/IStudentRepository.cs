using EDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.IRepositories
{
    public interface IStudentRepository
    {
        Student findStudent(string student);
        IEnumerable<Student> Get();
        IEnumerable<Student> GetList();
        IQueryable<Student> GetStudents();
        Task createStudent(Student student);
        Task updateStudent(Student student);
    }
}
