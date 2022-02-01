using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Models
{
    public class subjectIcons
    {
        [Key]
        public int subjectIconId { get; set; }

        [Display(Name = "Фотография предмета")]
        public byte[] subjectPicture { get; set; }
    }
}
