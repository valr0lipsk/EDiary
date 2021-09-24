using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class TeacherJurnalModel
    {
        public int tsubjectId { get; set; }
        public string teacherSurname { get; set; }
        public string teacherName { get; set; }
        public string teacherLastname { get; set; }
        public string subjectName { get; set; }
        public string groups { get; set; }
    }
}
