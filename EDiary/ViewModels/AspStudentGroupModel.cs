using EDiary.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class AspStudentGroupModel
    {
        public IEnumerable<StudentModel> student { get; set; }
        public IEnumerable<StudentModel> students { get; set; }
        public IEnumerable<SubjectGroupModel> subjects { get; set; }
        public IEnumerable<SubjectGroupModel> tasks { get; set; }
        public IEnumerable<EmojiStatus> statuses { get; set; }
        public int studentId { get; set; }
        public string studentLastname { get; set; }
        public string studentName { get; set; }
        public string studentSurname { get; set; }
        public string groupName { get; set; }
        public string studentLogin { get; set; }
        public string studentEmail { get; set; }
    }
}
