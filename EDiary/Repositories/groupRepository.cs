using EDiary.IRepositories;
using EDiary.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EDiary.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        EDContext context;
        DbSet<collegeGroup> groups;

        public GroupRepository(EDContext context)
        {
            this.context = context;
            this.groups = context.Set<collegeGroup>();
        }

        public async Task createGroup(collegeGroup group)
        {
            await groups.AddAsync(group);
            await context.SaveChangesAsync();
        }

        public async Task removeGroup(collegeGroup group)
        {
            groups.Remove(group);
            await context.SaveChangesAsync();
        }
        public async Task updateGroup(collegeGroup group)
        {
            groups.Update(group);
            await context.SaveChangesAsync();
        }
        public List<collegeGroup> allGroups()
        {
            return groups.AsNoTracking().ToList();
        }
        public collegeGroup getGroup(string group)
        {
            return groups.Where(gr => gr.groupName == group).FirstOrDefault();
        }
    }
}
