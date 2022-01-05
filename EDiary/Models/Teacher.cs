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

        [Display(Name = "Фамилия")]
        [StringLength(15)]
        [Required]
        public string teacherSurname { get; set; }

        [Display(Name = "Имя")]
        [StringLength(15)]
        [Required]
        public string teacherName { get; set; }

        [Display(Name = "Отчество")]
        [StringLength(15)]
        public string teacherLastname { get; set; }

        [Display(Name = "Аватарка")]
        [StringLength(100)]
        public string teacherPic { get; set; }

        [Display(Name = "Роль")]
        [Required]
        public string teacherRole { get; set; }

        [Required]
        public string teacherUser { get; set; }

        [ForeignKey("teacherRole")]
        public IdentityRole role { get; set; }

        [ForeignKey("teacherUser")]
        public IdentityUser user { get; set; }
    }
}
