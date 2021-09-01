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
    public class LessonRepository : ILessonRepository
    {
        EDContext context;
        DbSet<Lesson> dbSetLesson;

        public LessonRepository(EDContext context)
        {
            this.context = context;
            this.dbSetLesson = context.Set<Lesson>();
        }

        public IEnumerable<Lesson> Get()
        {
            return dbSetLesson.AsNoTracking().ToList();
        }

        public Lesson FindById(Guid lessonId)
        {
            return dbSetLesson.Find(lessonId);
        }

        public void Create(Lesson item)
        {
            dbSetLesson.Add(item);
            context.SaveChanges();
        }
        public void Update(Lesson item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Remove(Lesson item)
        {
            dbSetLesson.Remove(item);
            context.SaveChanges();
        }
        public void Save()
        {
            context.SaveChanges();
        }

    }

}
