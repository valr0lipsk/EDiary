using EDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.IRepositories
{
    public interface ILessonRepository
    {
        Lesson FindById(Guid lessonId);
        IEnumerable<Lesson> Get();
        void Create(Lesson item);
        void Remove(Lesson item);
        void Update(Lesson item);
        void Save();
    }
}
