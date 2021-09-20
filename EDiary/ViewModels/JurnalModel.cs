using EDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class JurnalModel
    {
        public IEnumerable<StudentsJurnalModel> StudentJurnal { get; set; }
        public IEnumerable<TeacherJurnalModel> TeacherJurnal { get; set; }
    }
}
