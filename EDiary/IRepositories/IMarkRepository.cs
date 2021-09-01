using EDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.IRepositories
{
    public interface IMarkRepository
    {
        Mark FindById(Guid markId);
        IEnumerable<Mark> Get();
        void Create(Mark item);
        void Remove(Mark item);
        void Update(Mark item);
        void Save();
    }
}
