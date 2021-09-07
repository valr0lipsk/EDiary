using EDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class TeacherSubject
    {
        public IEnumerable<Teacher> teachers { get; set; }
        public IEnumerable<Subject> subjects { get; set; }
    }
}
