using EDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class TableSubjectModel
    {
        public IEnumerable<AspTeacherSubjectGroupModel> subjects {get;set;}
        public IEnumerable<collegeGroup> groups {get;set;}
        public IEnumerable<Teacher> teachers {get;set;}

    }
}
