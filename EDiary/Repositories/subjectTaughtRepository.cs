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
    public class subjectTaughtRepository : ISubjectTaughtRepository
    {
        EDContext context;
        DbSet<subjectTaught> dbSetsubjTaught;

        public subjectTaughtRepository(EDContext context)
        {
            this.context = context;
            this.dbSetsubjTaught = context.Set<subjectTaught>();
        }

        public IEnumerable<subjectTaught> Get()
        {
            return dbSetsubjTaught.AsNoTracking().ToList();
        }

        public subjectTaught FindById(Guid subjectTaughtId)
        {
            return dbSetsubjTaught.Find(subjectTaughtId);
        }

        public void Create(subjectTaught item)
        {
            dbSetsubjTaught.Add(item);
            context.SaveChanges();
        }
        public void Update(subjectTaught item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Remove(subjectTaught item)
        {
            dbSetsubjTaught.Remove(item);
            context.SaveChanges();
        }
        public void Save()
        {
            context.SaveChanges();
        }

    }

}
