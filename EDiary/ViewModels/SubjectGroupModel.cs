using EDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class SubjectGroupModel
    {
        public int tsubjectId { get; set; }
        public int labaId { get; set; }
        public string groupName { get; set; }
        public string subjectName { get; set; }
        public string labaName { get; set; }
    }
}
