using EDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.IRepositories
{
    public interface IMarkRepository
    {
        setMark FindById(int markId);
        IEnumerable<setMark> Get();
        void Create(setMark item);
        void Remove(setMark item);
        void Update(setMark item);
        void Save();
    }
}
