using EDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.IRepositories
{
    public interface IStudentRepository
    {
        Student FindById(Guid studentId);
        IEnumerable<Student> Get();
        IEnumerable<Student> GetList();
        IQueryable<Student> GetStudents();
        void AddStudent(Student item);
        void DeleteStudent(Student item);
        void UpdateStudent(Student item);
        void Save();
    }
}
