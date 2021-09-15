using EDiary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class AddStudentModel
    {
        [Required]
        [Display(Name = "Фамилия студента")]
        public string studentSurname { get; set; }

        [Required]
        [Display(Name = "Имя студента")]
        public string studentName { get; set; }

        [Display(Name = "Отчество студента")]
        public string studentLastname { get; set; }

        [Required]
        [Display(Name = "Логин студента")]
        public string studentLogin { get; set; }

        [Required]
        [Display(Name = "Пароль студента")]
        public string studentPassword { get; set; }

        [Required]
        [Display(Name = "Группа студента")]
        public int studentGroup { get; set; }

        public IEnumerable<collegeGroup> groups;

    }
}
