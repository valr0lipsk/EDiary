using EDiary.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class AspTeacherSubjectGroupModel
    {
        public IEnumerable<TeacherModel> Teachers { get; set; }
        public IEnumerable<SubjectGroupModel> subjectGroups { get; set; }
        public IEnumerable<collegeGroup> groups { get; set; }
        public IEnumerable<EmojiStatus> statuses { get; set; }
        public IEnumerable<StudentModel> students { get; set; }
        public IEnumerable<SubjectGroupModel> tasks { get; set; }
        public int teacherId { get; set; }
        public int tsubjectId { get; set; }
        public string teacherLastname { get; set; }
        public string teacherFullname { get; set; }
        public string teacherName { get; set; } 
        public string teacherSurname { get; set; }
        public string subjectName { get; set; }
        public string teacherLogin { get; set; }
        public string groupName { get; set; }
        public string teacherEmail { get; set; }        
    }
}
