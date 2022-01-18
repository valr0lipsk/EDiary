using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Models
{
    public class labsSubgroups
    {
        [Key]
        public int labSubgroupId { get; set; }
        
        [Required]
        public int labId { get; set; }
        
        [Required]
        public int subgroupId { get; set; }

        [Required]
        public int teacherId { get; set; }

        [ForeignKey("teacherId")]
        public Teacher teacher { get; set; }

        [ForeignKey("labId")]
        public Labs labs { get; set; }

        [ForeignKey("subgroupId")]
        public Subgroup subgroup { get; set; }
    }
}
