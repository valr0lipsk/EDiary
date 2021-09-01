using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Models
{
    public class collegeGroup
    {
        [Key]
        public int groupId { get; set; }

        [Display(Name = "Название группы")]
        [StringLength(10)]
        [Required]
        public string groupName { get; set; }

        [Display(Name ="Куратор")]
        public int curatorId { get; set; }

        [ForeignKey("curatorId")]
        public Teacher teacher { get; set; }
    }
}
