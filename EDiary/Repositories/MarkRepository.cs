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
    public class MarkRepository : IMarkRepository
    {
        EDContext context;
        DbSet<Mark> dbSetMark;

        public MarkRepository(EDContext context)
        {
            this.context = context;
            this.dbSetMark = context.Set<Mark>();
        }

        public IEnumerable<Mark> Get()
        {
            return dbSetMark.AsNoTracking().ToList();
        }

        public Mark FindById(Guid lessonId)
        {
            return dbSetMark.Find(lessonId);
        }

        public void Create(Mark item)
        {
            dbSetMark.Add(item);
            context.SaveChanges();
        }
        public void Update(Mark item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Remove(Mark item)
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
