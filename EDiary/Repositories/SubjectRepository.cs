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
    public class SubjectRepository : ISubjectRepository
    {
        EDContext context;
        DbSet<Subject> dbSetSubject;

        public SubjectRepository(EDContext context)
        {
            this.context = context;
            this.dbSetSubject = context.Set<Subject>();
        }

        public IEnumerable<Subject> Get()
        {
            return dbSetSubject.AsNoTracking().ToList();
        }

        public Subject FindById(Guid subjectId)
        {
            return dbSetSubject.Find(subjectId);
        }

        public void Create(Subject item)
        {
            dbSetSubject.Add(item);
            context.SaveChanges();
        }
        public void Update(Subject item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Remove(Subject item)
        {
            dbSetSubject.Remove(item);
            context.SaveChanges();
        }
        public void Save()
        {
            context.SaveChanges();
        }

    }

}
