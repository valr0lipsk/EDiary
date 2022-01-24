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
        [StringLength(150)]
        [Required]
        public string labName { get; set; }

        [Display(Name = "Количество лабораторных")]
        [Required]
        public int countLabs { get; set; }

        [Required]
        public int tsubjectId { get; set; }

        [Required]
        public int subgroupId { get; set; }

        [Required]
        public int groupId { get; set; }

        [Required]
        public int teacherId { get; set; }

        [ForeignKey("teacherId")]
        public Teacher teacher { get; set; }

        [ForeignKey("tsubjectId")]
        public subjectTaught tsubject { get; set; }

        [ForeignKey("groupId")]
        public collegeGroup group { get; set; }

        [ForeignKey("subgroupId")]
        public Subgroup subgroup { get; set; }

    }
}
