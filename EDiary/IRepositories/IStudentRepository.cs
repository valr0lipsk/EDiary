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
        void Create(Student item);
        void Remove(Student item);
        void Update(Student item);
        void Save();
    }
}
