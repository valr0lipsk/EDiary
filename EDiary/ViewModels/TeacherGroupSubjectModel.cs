using EDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class TeacherGroupSubjectModel
    {
        public IEnumerable<collegeGroup> Groups { get; set; }
        public IEnumerable<Subject> Subjects { get; set; }
        public IEnumerable<Users> Users { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<subjectTaught> subjectTaughts { get; set; }
        public int tsubjectId { get; set; }
        public string teacherSurname { get; set; }
        public string teacherName { get; set; }
        public string teacherLastname { get; set; }
        public string subjectName { get; set; }
        public string groups { get; set; }
        public string teacherPassword { get; set; }

    }
}
