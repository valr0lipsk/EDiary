using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EDiary.Models;

namespace EDiary.IRepositories
{
    public interface IGroupRepository
    {
        collegeGroup FindById(Guid id);
        IEnumerable<collegeGroup> Get();
        void Create(collegeGroup item);
        void Remove(collegeGroup item);
        void Update(collegeGroup item);
        void Save();
    }
}
