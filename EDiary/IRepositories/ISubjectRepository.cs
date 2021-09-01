using EDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.IRepositories
{
    public interface ISubjectRepository
    {
        Subject FindById(Guid subjectId);
        IEnumerable<Subject> Get();
        void Create(Subject item);
        void Remove(Subject item);
        void Update(Subject item);
        void Save();
    }
}

