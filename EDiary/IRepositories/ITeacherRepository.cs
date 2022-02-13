using EDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.IRepositories
{
    public interface ITeacherRepository
    {
        Teacher findTeacher(string teacher);
        List<Teacher> allTeachers();
        Task createTeacher(Teacher teacher);
        Task updateTeacher(Teacher teacher);
    }
}
