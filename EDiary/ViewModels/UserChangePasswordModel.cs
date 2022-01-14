using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class UserChangePasswordModel
    {
        [StringLength(100, ErrorMessage = "Пароль должен сожержать не менее 8 символов", MinimumLength = 8)]
        public string oldPassword { get; set; }
        public string newPassword { get; set; }
    }
}
