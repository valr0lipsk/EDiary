using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Models
{
    public class Teacher
    {
        [Key]
        public int teacherId { get; set; }

        [Display(Name = "Роль")]
        [Required]
        public string teacherRole { get; set; }

        [Required]
        public int teacherUser { get; set; }

        [ForeignKey("teacherRole")]
        public IdentityRole role { get; set; }

        [ForeignKey("teacherUser")]
        public Users user { get; set; }
    }
}
