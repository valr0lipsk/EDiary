using EDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.IRepositories
{
    public interface ISubjectTaughtRepository
    {
        subjectTaught FindById(Guid subjectTaughtId);
        IEnumerable<subjectTaught> Get();
        void Create(subjectTaught item);
        void Remove(subjectTaught item);
        void Update(subjectTaught item);
        void Save();
    }
}

