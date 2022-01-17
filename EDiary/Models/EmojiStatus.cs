using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Models
{
    public class EmojiStatus
    {
        [Key]
        public int statusId { get; set; }

        [Display(Name = "Статус")]
        [StringLength(25)]
        [Required]
        public string status { get; set; }

        [Display(Name = "Эмодзи")]
        [Required]
        public byte[] emoji { get; set; }
    }
}
