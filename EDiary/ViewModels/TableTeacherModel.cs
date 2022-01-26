using EDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class TableTeacherModel
    {
        public IEnumerable<collegeGroup> groups { get; set; }
        public IEnumerable<AspTeacherSubjectGroupModel> teachers { get; set; }

    }
}
