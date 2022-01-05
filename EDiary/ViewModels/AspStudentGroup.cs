using EDiary.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class AspStudentGroup
    {
        public int studentId { get; set; }
        public string studentLastname { get; set; }
        public string studentName { get; set; }
        public string studentSurname { get; set; }
        public string groupName { get; set; }
        public string studentLogin { get; set; }
        public string studentEmail { get; set; }
    }
}
