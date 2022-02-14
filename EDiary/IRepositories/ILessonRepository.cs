using EDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.IRepositories
{
    public interface ILessonRepository
    {
        Task createLessonAsync(Lesson lesson);
        Task removeLessonAsync(Lesson lesson);
        Lesson findLesson(int lessonId);
        int findLessonType(string lessonType);
        List<lessonType> getLessonTypes();
    }
}
