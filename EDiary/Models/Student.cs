using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Models
{
    public class Student
    {
        [Key]
        public int studentId { get; set; }

        [Display(Name = "Фамилия")]
        [StringLength(15)]
        public string studentSurname { get; set; }

        [Display(Name = "Имя")]
        [StringLength(15)]
        public string studentName { get; set; }

        [Display(Name = "Отчество")]
        [StringLength(15)]
        public string studentLastname { get; set; }

        [Display(Name = "Аватарка")]
        [StringLength(100)]
        public string studentPic { get; set; }

        [Display(Name = "Группа")]
        [Required]
        public int studentGroup { get; set; }

        [Display(Name = "Роль")]
        [Required]
        public string studentRole { get; set; }

        [Required]
        public string studentUser { get; set; }

        [ForeignKey("studentRole")]
        public IdentityRole role { get; set; }

        [ForeignKey("studentGroup")]
        public collegeGroup group { get; set; }

        [ForeignKey("studentUser")]
        public IdentityUser user { get; set; }
    }
}
