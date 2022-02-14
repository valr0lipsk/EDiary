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
        Task createStudentAsync(Student student);
        Task updateStudentAsync(Student student);
        List<EmojiStatus> studentsStatuses();
    }
}
