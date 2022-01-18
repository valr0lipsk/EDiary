using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class StatisticModel
    {
        public List<string> fullName { get; set; }
        public string fN { get; set; }
        public List<int> averageMark { get; set; }
        public int aM { get; set; }
        public List<int> noReasonPass { get; set; }
        public int nRP { get; set; }
        public List<int> reasonPass { get; set; }
        public int rP { get; set; }
        public int id { get; set; }


    }
}
