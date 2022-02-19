using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class StudentJurnal
    {
        public int studentId { get; set; }
        public string studentFullname { get; set; }
        public int passesNoReason { get; set; }
        public int passesReason { get; set; }
        public double average { get; set; }
        public int sumPasses { get; set; }
        public string tsub { get; set; }
        public int day { get; set; }
    }
}
