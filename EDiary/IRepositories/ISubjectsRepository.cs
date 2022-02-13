using EDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.IRepositories
{
    public interface ISubjectsRepository
    {
        subjectTaught findSubjectTaught(int subjectTaughtId);
        Subject findSubject(string subject);
        Task createSubjectAsync(Subject subject);
        Task createLabAsync(Labs laba);
        Task createSubjectTaughtAsync(subjectTaught subjectTaught);
        Task updateSubjectTaughtAsync(subjectTaught subjectTaught);
        Task removeSubjectTaughtAsync(subjectTaught subjectTaught);
        List<subjectIcons> allSubjectIcons();
    }
}

