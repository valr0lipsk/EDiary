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
    public class subjectsRepository : ISubjectsRepository
    {
        EDContext context;
        DbSet<subjectTaught> subjectTaughts;
        DbSet<Subject> subjects;
        DbSet<Labs> labs;
        DbSet<subjectIcons> icons;
        public subjectsRepository(EDContext context)
        {
            this.context = context;
            this.subjectTaughts = context.Set<subjectTaught>();
            this.subjects = context.Set<Subject>();
            this.labs = context.Set<Labs>();
            this.icons = context.Set<subjectIcons>();
        }

        //получение преподаваемого предмета по id
        public subjectTaught findSubjectTaught(int subjectTaughtId)
        {
            return subjectTaughts.Find(subjectTaughtId);
        }

        //получение предмета по названию
        public Subject findSubject(string subject)
        {
            return subjects.Where(sub => sub.subjectName == subject).FirstOrDefault();
        }

        //создание предмета
        public async Task createSubjectAsync(Subject subject)
        {
            await subjects.AddAsync(subject);
            await context.SaveChangesAsync();
        }

        //создание лабы
        public async Task createLabAsync(Labs laba)
        {
            await labs.AddAsync(laba);
            await context.SaveChangesAsync();
        }

        //создание преподаваемого предмета
        public async Task createSubjectTaughtAsync(subjectTaught subjectTaught)
        {
            await subjectTaughts.AddAsync(subjectTaught);
            await context.SaveChangesAsync();
        }

        //обновление преподаваемого предмета
        public async Task updateSubjectTaughtAsync(subjectTaught subjectTaught)
        {
            subjectTaughts.Update(subjectTaught);
            await context.SaveChangesAsync();
        }

        //удаление преподаваемого предмета
        public async Task removeSubjectTaughtAsync(subjectTaught subjectTaught)
        {
            subjectTaughts.Remove(subjectTaught);
            await context.SaveChangesAsync();
        }

        //получение иконок предметов
        public List<subjectIcons> allSubjectIcons()
        {
            return icons.AsNoTracking().ToList();
        }
    }
}
