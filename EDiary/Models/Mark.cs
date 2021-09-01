using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Models
{
    public class Mark
    {
        [Key]
        public int markId { get; set; }

        [Display (Name ="Оценка")]
        [StringLength(5)]
        [Required]
        public string mark { get; set; }
    }
}
