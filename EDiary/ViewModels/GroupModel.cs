using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class GroupModel
    {
        
        public string groupName { get; set; }
        public string curator { get; set; }
        public int studentsCount { get; set; }
        public int groupId { get; set; }
    }
}
