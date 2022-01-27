using EDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class TableStudentModel
    {
        public IEnumerable<collegeGroup> groups { get; set; }
        public IEnumerable<AspStudentGroupModel> students { get; set; }
        public string studentLogin { get; set; }
        public string studentName { get; set; }
        public string studentSurname { get; set; }
        public string studentLastname { get; set; }
        public string studentEmail { get; set; }
        public string studentGroup { get; set; }
    }
}
