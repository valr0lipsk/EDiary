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
        [Required]
        public string studentSurname { get; set; }

        [Display(Name = "Имя")]
        [StringLength(15)]
        [Required]
        public string studentName { get; set; }

        [Display(Name = "Отчество")]
        [StringLength(15)]
        public string studentLastname { get; set; }

        [Display(Name = "Аватарка")]
        public byte[] studentPic { get; set; }

        [Display(Name = "Группа")]
        [Required]
        public int studentGroup { get; set; }

        [Display(Name = "Подгруппа")]
        [Required]
        public int studentSubgroup { get; set; }

        [Display(Name = "Эмодзи-статус")]
        public int? studentStatus { get; set; }

        [Required]
        public string studentUser { get; set; }

        [ForeignKey("studentGroup")]
        public collegeGroup group { get; set; }

        [ForeignKey("studentSubgroup")]
        public Subgroup subgroup { get; set; }

        [ForeignKey("studentUser")]
        public IdentityUser user { get; set; }

        [ForeignKey("studentStatus")]
        public EmojiStatus status { get; set; }
    }
}
