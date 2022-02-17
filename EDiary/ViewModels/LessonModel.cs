using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class LessonModel
    {
        public int lessonId { get; set; }
        public DateTime lessDateStart { get; set; }
        public DateTime lessDateEnd { get; set; }
        public DateTime lessonDate { get; set; }
        public string lessonType { get; set; }
        public int id { get; set; }
        public int labId { get; set; }
    }
}
