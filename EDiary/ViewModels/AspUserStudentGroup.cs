using EDiary.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class AspUserStudentGroup
    {
       public IEnumerable<Users> Users { get; set; }
       public IEnumerable<Student> Students { get; set; }
       public IEnumerable<collegeGroup> Groups { get; set; }
       public IEnumerable<IdentityUser> AspUsers { get; set; }
    }
}
