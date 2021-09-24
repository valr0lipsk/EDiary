using EDiary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class AddTeacherModel
    {
        [Required]
        [Display(Name = "Фамилия преподавателя")]
        public string teacherSurname { get; set; }

        [Required]
        [Display(Name = "Имя преподавателя")]
        public string teacherName { get; set; }

        [Required]
        [Display(Name = "Отчество преподавателя")]
        public string teacherLastname { get; set; }

        [Required]
        [Display(Name = "Логин преподавателя")]
        public string teacherLogin { get; set; }

        [Required]
        [Display(Name = "Пароль преподавателя")]
        public string teacherPassword { get; set; }
        
        [Display(Name = "Курируемая группа")]
        public string curatorGroup { get; set; }

        public IEnumerable<collegeGroup> groups { get; set; }
    }
}
