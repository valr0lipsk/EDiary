using EDiary.IRepositories;
using EDiary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EDiary.Repositories
{
    public class UserRepository : IUserRepository
    {
        EDContext context;
        DbSet<collegeGroup> dbSetGroup;

        public UserRepository(EDContext context)
        {
            this.context = context;
            this.dbSetGroup = context.Set<collegeGroup>();
        }

        public IEnumerable<collegeGroup> Get()
        {
            return dbSetGroup.AsNoTracking().ToList();
        }

        public collegeGroup FindById(Guid groupId)
        {
            return dbSetGroup.Find(groupId);
        }

        public void Create(collegeGroup item)
        {
            dbSetGroup.Add(item);
            context.SaveChanges();
        }
        public void Update(collegeGroup item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Remove(collegeGroup item)
        {
            dbSetGroup.Remove(item);
            context.SaveChanges();
        }
        public void Save()
        {
            context.SaveChanges();
        }

    }

}
