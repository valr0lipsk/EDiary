using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public byte[] subjectPicture { get; set; }
    }
}
