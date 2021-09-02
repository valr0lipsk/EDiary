using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Models
{
    public class setMark
    {
        [Key]
        public int setmarkId { get; set; }

        [Display(Name = "Занятие")]
        [Required]
        public int lessonId { get; set; }

        [Display(Name = "Студент")]
        [Required]
        public int studentId { get; set; }

        [Display(Name = "Оценка")]
        [Required]
        public int markId { get; set; }

        [ForeignKey("studentId")]
        public Student student { get; set; }

        [ForeignKey("markId")]
        public Mark mark { get; set; }

        [ForeignKey("lessonId")]
        public Lesson lesson { get; set; }
    }
}
