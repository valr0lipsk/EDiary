using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Models
{
    public class ResetPasswordModel
    {
        [Required]
        [EmailAddress]
        public string userEmail { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Пароль должен сожержать не менее 8 символов", MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string newPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение пароля")]
        [Compare("newPassword", ErrorMessage = "Пароли не совпадают")]
        public string confirmPassword { get; set; }

        public string userCode { get; set; }
    }
}
