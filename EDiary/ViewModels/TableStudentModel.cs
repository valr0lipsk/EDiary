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

    }
}
