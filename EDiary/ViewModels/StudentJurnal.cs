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
        public List<int> studentPassesNoReason { get; set; }
        public List<int> studentPassesReason { get; set; }
        public double studentAverage { get; set; }
    }
}
