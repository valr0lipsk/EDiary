using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class UserChangePasswordModel
    {
        public string oldPassword { get; set; }

        [StringLength(100, MinimumLength = 8)]
        public string newPassword { get; set; }
    }
}
