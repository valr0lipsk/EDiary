using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Models
{
    public class labaLessons
    {
        [Key]
        public int labaLessonId { get; set; }

        [Required]
        public int lessonId { get; set; }

        [Required]
        public int labId { get; set; }

        [ForeignKey("labId")]
        public Labs labs { get; set; }

        [ForeignKey("lessonId")]
        public Lesson lesson { get; set; }

    }
}
