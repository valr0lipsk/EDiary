using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EDiary.Models;
using Microsoft.AspNetCore.Identity;

namespace EDiary.IRepositories
{
    public interface IGroupRepository
    {
        Task createGroupAsync(collegeGroup group);
        Task removeGroupAsync(collegeGroup group);
        Task updateGroupAsync(collegeGroup group);
        List<collegeGroup> allGroups();
        collegeGroup getGroup(string group);
    }
}
