using EDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.IRepositories
{
    public interface IMarkRepository
    {
        setMark findSetMark(int setMarkId);
        Mark findMark(string mark);
        void createSetMark(setMark setMark);
        void removeSetMark(setMark setMark);
        void updateSetMark(setMark setMark);
    }
}
