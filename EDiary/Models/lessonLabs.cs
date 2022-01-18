using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Models
{
    public class lessonLabs
    {
        [Key]
        public int lessonLabaId { get; set; }

        [Display(Name = "Дата лабораторной работы")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime labsDate { get; set; }

        [Required]
        public int labId { get; set; }

        [ForeignKey("labId")]
        public Labs labs { get; set; }

    }
}
