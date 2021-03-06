using EDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class JurnalModel
    {
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<Lesson> Lessons { get; set; }
        public IEnumerable<collegeGroup> Groups { get; set; }
        public IEnumerable<SubjectGroupModel> Subjects { get; set; }
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<setMark> setMarks { get; set; }
        public IEnumerable<lessonType> types { get; set; }
        public IEnumerable<SubjectGroupModel> userSubjects { get; set; }
        public LessonModel addLesson { get; set; }
        public LessonModel deleteLesson { get; set; }
        public LessonModel lessDates { get; set; }
    }
}
