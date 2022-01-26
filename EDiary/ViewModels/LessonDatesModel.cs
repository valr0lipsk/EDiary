using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class LessonDatesModel
    {
        public int tsubjectId { get; set; }
        public int labaId { get; set; }
        public DateTime lessonDateStart { get; set; }
        public DateTime lessonDateEnd { get; set; }

    }
}
