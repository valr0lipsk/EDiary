using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class StudentModel
    {
        public int studentId { get; set; }
        public string studentSurname { get; set; }
        public string studentName { get; set; }
        public string studentLastname { get; set; }
        public byte[] studentPic { get; set; }
        public byte[] studentStatus { get; set; }
    }
}
