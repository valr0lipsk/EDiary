using EDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.IRepositories
{
    public interface ISubjectsRepository
    {
        subjectTaught findSubject(int subjectTaughtId);
        IEnumerable<subjectTaught> Get();
        Task createSubject(Subject subject);
        Task createLabs(Labs laba);
        Task createSubjectTaught(subjectTaught subjectTaught);
        Task updateSubjectTaught(subjectTaught subjectTaught);
        Task removeSubjectTaught(subjectTaught subjectTaught);
    }
}

