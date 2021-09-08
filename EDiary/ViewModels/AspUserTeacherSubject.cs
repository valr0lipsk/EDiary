using EDiary.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class AspUserTeacherSubject
    {
       public IEnumerable<Users> Users { get; set; }
       public IEnumerable<Teacher> Teachers { get; set; }
       public IEnumerable<Subject> Subjects { get; set; }
       public IEnumerable<IdentityUser> AspUsers { get; set; }
    }
}
