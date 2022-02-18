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
        public Array studentPassesNoReason { get; set; }
        public Array studentPassesReason { get; set; }
        public double studentAverage { get; set; }
    }
}
