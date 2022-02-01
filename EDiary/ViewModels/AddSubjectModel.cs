using EDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class AddSubjectModel
    {
        public string firstTeacher { get; set; }
        public string secondTeacher { get; set; }
        public string subjectName { get; set; }
        public string groupName { get; set; }
        public int labsCount { get; set; }
        public IEnumerable<Teacher> teachers { get; set; }
        public IEnumerable<collegeGroup> groups { get; set; }
        public IEnumerable<subjectIcons> icons { get; set; }
    }
}
