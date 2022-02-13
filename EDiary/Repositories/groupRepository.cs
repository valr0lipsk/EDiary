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

        //создание группы
        public async Task createGroupAsync(collegeGroup group)
        {
            await groups.AddAsync(group);
            await context.SaveChangesAsync();
        }

        //удаление группы
        public async Task removeGroupAsync(collegeGroup group)
        {
            groups.Remove(group);
            await context.SaveChangesAsync();
        }

        //обновление группы
        public async Task updateGroupAsync(collegeGroup group)
        {
            groups.Update(group);
            await context.SaveChangesAsync();
        }

        //получение всех групп
        public List<collegeGroup> allGroups()
        {
            return groups.AsNoTracking().ToList();
        }

        //получение группы по названию
        public collegeGroup getGroup(string group)
        {
            return groups.Where(gr => gr.groupName == group).FirstOrDefault();
        }
    }
}
