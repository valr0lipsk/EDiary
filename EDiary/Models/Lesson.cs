using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Models
{
    public class Lesson
    {
        [Key]
        public int lessonId { get; set; }

        [Display(Name = "Дата занятия")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime lessonDate { get; set; }

        [Display(Name = "Предмет")]
        [Required]
        public int tsubjectId { get; set; }

        [ForeignKey("tsubjectId")]
        public subjectTaught subjectTaught { get; set; }
    }
}
