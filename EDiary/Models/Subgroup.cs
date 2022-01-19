using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Models
{
    public class Subgroup
    {
        [Key]
        public int subgroupId { get; set; }

        [Display(Name = "Название подгруппы")]
        [StringLength(15)]
        [Required]
        public string subgroupName { get; set; }
    }
}
