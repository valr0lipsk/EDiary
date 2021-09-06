using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Models
{
    public class Admin
    {
        [Key]
        public int adminId { get; set; }

        [Display(Name = "Роль")]
        [Required]
        public string adminRole { get; set; }

        [Required]
        public string adminUser { get; set; }

        [ForeignKey("adminRole")]
        public IdentityRole role { get; set; }
        
        [ForeignKey("adminUser")]
        public IdentityUser adUser { get; set; }


    }
}
