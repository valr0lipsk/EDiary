using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class TeacherModel
    {
        public int teacherId { get; set; }
        public string teacherSurname { get; set; }
        public string teacherName { get; set; }
        public string teacherLastname { get; set; }
        public byte[] teacherPic { get; set; }
        public byte[] teacherStatus { get; set; }
    }
}
