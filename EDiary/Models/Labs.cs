using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Models
{
    public class Labs
    {
        [Key]
        public int labId { get; set; }

        [Display(Name = "Лабораторная работа")]
        [StringLength(40)]
        [Required]
        public string labName { get; set; }

        [Display(Name = "Количество лабораторных")]
        [Required]
        public int countLabs { get; set; }

        [Display(Name = "Учеников в подгруппе")]
        [Required]
        public int studentsCount { get; set; }

        [Required]
        public int subjectId { get; set; }
        
        [Required]
        public int teacherId { get; set; }
        
        [Required]
        public int groupId { get; set; }

        [ForeignKey("subjectId")]
        public Subject subject { get; set; }

        [ForeignKey("groupId")]
        public collegeGroup group { get; set; }

        [ForeignKey("teacherId")]
        public Teacher teacher { get; set; }
    }
}
