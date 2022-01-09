using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Models
{
    public class lessonType
    {
        [Key]
        public int lessonTypeId { get; set; }

        [Display(Name = "Название типа")]
        [StringLength(6)]
        [Required]
        public string typeName { get; set; }
    }
}
