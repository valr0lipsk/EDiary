using EDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.IRepositories
{
    public interface ITeacherRepository
    {
        Teacher FindById(int teacherId);
        IEnumerable<Teacher> Get();
        Task createTeacher(Teacher teacher);
        Task updateTeacher(Teacher teacher);
    }
}
