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
    public class setMarkRepository : ISetMarkRepository
    {
        EDContext context;
        DbSet<setMark> dbSetMark;

        public setMarkRepository(EDContext context)
        {
            this.context = context;
            this.dbSetMark = context.Set<setMark>();
        }

        public IEnumerable<setMark> Get()
        {
            return dbSetMark.AsNoTracking().ToList();
        }

        public setMark FindById(Guid setMarkId)
        {
            return dbSetMark.Find(setMarkId);
        }

        public void Create(setMark item)
        {
            dbSetMark.Add(item);
            context.SaveChanges();
        }
        public void Update(setMark item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Remove(setMark item)
        {
            dbSetMark.Remove(item);
            context.SaveChanges();
        }
        public void Save()
        {
            context.SaveChanges();
        }

    }

}
