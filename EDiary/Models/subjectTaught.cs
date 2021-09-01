using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Models
{
    public class subjectTaught
    {
        [Key]
        public int tsubjectId { get; set; }

        [Display(Name = "Преподаваемый предмет")]
        [Required]
        public int subjectId { get; set; }

        [Display(Name = "Фамилия преподавателя")]
        [Required]
        public int teacherId { get; set; }

        [Display(Name = "№ группы")]
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
