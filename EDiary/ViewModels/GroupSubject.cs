using EDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class GroupSubject
    {
        public IEnumerable<collegeGroup> Groups { get; set; }
        public IEnumerable<Subject> Subjects { get; set; }
    }
}
