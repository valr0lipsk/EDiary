using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDiary.Models;

namespace EDiary.IRepositories
{
    public interface ISetMarkRepository
    {
        setMark FindById(Guid setMarkId);
        IEnumerable<setMark> Get();
        void Create(setMark item);
        void Remove(setMark item);
        void Update(setMark item);
        void Save();
    }
}
