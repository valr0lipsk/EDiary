using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Models
{
    public class Subject
    {
        [Key]
        public int subjectId { get; set; }

        [Display(Name = "Название предмета")]
        [StringLength(150)]
        [Required]
        public string subjectName { get; set; }

        [Display(Name = "Фотография предмета")]
        public int? subjectPicture { get; set; }

        [ForeignKey("subjectPicture")]
        public subjectIcons Icon { get; set; }
    }
}
