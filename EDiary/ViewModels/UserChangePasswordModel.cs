﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class UserChangePasswordModel
    {
        public string oldPassword { get; set; }
        public string newPassword { get; set; }
    }
}
