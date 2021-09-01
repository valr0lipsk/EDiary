using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Models
{
    public class Users
    {
        [Key]
        public int idUser { get; set; }

        [Display(Name = "Фамилия")]
        [StringLength(15)]
        public string userSurname { get; set; }

        [Display(Name = "Имя")]
        [StringLength(15)]
        public string userName { get; set; }

        [Display(Name = "Отчество")]
        [StringLength(15)]
        public string userLastname { get; set; }

        [Display(Name = "Аватарка")]
        [StringLength(100)]
        public string userPic { get; set; }

        [Required]
        public string userId { get; set; }

        [ForeignKey("userId")]
        public IdentityUser identityUser { get; set; }
    }
}
