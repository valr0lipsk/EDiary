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

        public subjectTaught findSubjectTaught(int subjectTaughtId)
        {
            return subjectTaughts.Find(subjectTaughtId);
        }
        public Subject findSubject(string subject)
        {
            return subjects.Where(sub => sub.subjectName == subject).FirstOrDefault();
        }
        public async Task createSubject(Subject subject)
        {
            await subjects.AddAsync(subject);
            await context.SaveChangesAsync();
        }
        public async Task createLabs(Labs laba)
        {
            await labs.AddAsync(laba);
            await context.SaveChangesAsync();
        }
        public async Task createSubjectTaught(subjectTaught subjectTaught)
        {
            await subjectTaughts.AddAsync(subjectTaught);
            await context.SaveChangesAsync();
        }
        public async Task updateSubjectTaught(subjectTaught subjectTaught)
        {
            subjectTaughts.Update(subjectTaught);
            await context.SaveChangesAsync();
        }
        public async Task removeSubjectTaught(subjectTaught subjectTaught)
        {
            subjectTaughts.Remove(subjectTaught);
            await context.SaveChangesAsync();
        }
        public List<subjectIcons> allSubjectIcons()
        {
            return icons.AsNoTracking().ToList();
        }
    }
}
