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
        DbSet<Lesson> lessons;
        DbSet<lessonType> lessonTypes;

        public LessonRepository(EDContext context)
        {
            this.context = context;
            this.lessons = context.Set<Lesson>();
            this.lessonTypes = context.Set<lessonType>();
        }

        //создание занятия
        public async Task createLessonAsync(Lesson lesson)
        {
            await lessons.AddAsync(lesson);
            await context.SaveChangesAsync();
        }
        
        //удаление занятия
        public async Task removeLessonAsync(Lesson lesson)
        {
            lessons.Remove(lesson);
            await context.SaveChangesAsync();
        }
        
        //получение всех типов занятий
        public List<lessonType> getLessonTypes()
        {
            return lessonTypes.AsNoTracking().Take(5).ToList();
        }

        //получение id типа занятия
        public int findLessonType(string lessonType)
        {
            return lessonTypes.Where(type => type.typeName == lessonType).Select(type => type.lessonTypeId).FirstOrDefault();
        }

        //получение занятия
        public Lesson findLesson(int lessonId)
        {
            return lessons.Find(lessonId);
        }
    }
}
