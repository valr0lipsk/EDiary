using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class AvatarStatusModel
    {
        public IFormFile Picture { get; set; }
        public int? statusId { get; set; }
    }
}
