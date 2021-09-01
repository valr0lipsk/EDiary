using EDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.IRepositories
{
    public interface ITeacherRepository
    {
        Teacher FindById(Guid teacherId);
        IEnumerable<Teacher> Get();
        void Create(Teacher item);
        void Remove(Teacher item);
        void Update(Teacher item);
        void Save();
    }
}
