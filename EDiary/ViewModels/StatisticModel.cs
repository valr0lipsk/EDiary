using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class StatisticModel
    {
        public List<string> fullName { get; set; }
        public List<int> averageMark { get; set; }
        public List<int> noReasonPass { get; set; }
        public List<int> reasonPass { get; set; }
    }
}
