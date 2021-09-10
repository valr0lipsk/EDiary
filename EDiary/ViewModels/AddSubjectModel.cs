using EDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class AddSubjectModel
    {
        public string subjectName { get; set; }
        public int subjectId { get; set; }
        public int teacherId { get; set; }
        public int groupId { get; set; }
        public IEnumerable<Subject> Subjects { get; set; }
        public IEnumerable<Users> Users { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<collegeGroup> Groups { get; set; }
    }
}
