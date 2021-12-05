using EDiary.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class AspTeacherSubject
    {
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<Subject> Subjects { get; set; }
        public IEnumerable<IdentityUser> AspUsers { get; set; }
        public IEnumerable<subjectTaught> subjectTaughts { get; set; }
        public int teacherId { get; set; }
        public string teacherLastname { get; set; }
        public string teacherName { get; set; } 
        public string teacherSurname { get; set; }
        public string subjectName { get; set; }
        public string teacherLogin { get; set; }

    }
}
