using EDiary.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class AspTeacherSubjectGroup
    {
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<SubjectGroup> subjectGroups { get; set; }
        public int teacherId { get; set; }
        public string teacherLastname { get; set; }
        public string teacherName { get; set; } 
        public string teacherSurname { get; set; }
        public string subjectName { get; set; }
        public string teacherLogin { get; set; }
        public string groupName { get; set; }
        public string teacherEmail { get; set; }        
    }
}
