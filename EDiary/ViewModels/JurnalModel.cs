using EDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class JurnalModel
    {
        public IEnumerable<Users> Teachers { get; set; }
        public IEnumerable<Users> Students { get; set; }
        public IEnumerable<Lesson> Lessons { get; set; }
        public IEnumerable<Mark> Marks { get; set; }
        public IEnumerable<collegeGroup> Groups { get; set; }
        public IEnumerable<Subject> Subjects { get; set; }
        public IEnumerable<Student> StudentsId { get; set; }
        public IEnumerable<setMark> setMarks { get; set; }

        //public IEnumerable<StudentsJurnalModel> StudentJurnal { get; set; }
        //public IEnumerable<TeacherJurnalModel> TeacherJurnal { get; set; }
    }
}
