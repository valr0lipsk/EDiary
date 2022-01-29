using EDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.ViewModels
{
    public class TableGroupModel
    {
        public string groupName { get; set; }
        public string curator { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
    }
}
