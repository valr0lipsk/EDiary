using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class LessonModel
    {
        public int lessonId { get; set; }
        public DateTime lessonDate { get; set; }
         public DateTime lessonDateStart { get; set; }
        public DateTime lessonDateEnd { get; set; }
        public string lessonType { get; set; }
        public int id { get; set; }
        public int labId { get; set; }
    }
}
