using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Models
{
    public class loginViewModel
    {
        [Required (ErrorMessage = "Введите логин")]
        [Display(Name = "Логин")]
        public string userName { get; set; }

        [Required (ErrorMessage = "Введите пароль")]
        [UIHint("password")]
        [Display (Name = "Пароль")]
        public string Password { get; set; }

        [Display (Name = "Запомнить?")]
        public bool Remember { get; set; }
    }
}
