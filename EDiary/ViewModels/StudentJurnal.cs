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
        public int studentPassesNoReason { get; set; }
        public int studentPassesReason { get; set; }
        public double studentAverage { get; set; }
    }
}
