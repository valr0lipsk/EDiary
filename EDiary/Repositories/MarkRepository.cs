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
        DbSet<setMark> setMarks;
        DbSet<Mark> marks;

        public MarkRepository(EDContext context)
        {
            this.context = context;
            this.setMarks = context.Set<setMark>();
            this.marks = context.Set<Mark>();
        }

        //найти выставленную оценку по айди
        public setMark findSetMark(int setMarkId)
        {
            return setMarks.Find(setMarkId);
        }

        //найти оценку
        public Mark findMark(string mark)
        {
            return marks.Where(m => m.mark == mark).FirstOrDefault();
        }

        //добавить выставленную оценку
        public void createSetMark(setMark setMark)
        {
            setMarks.Add(setMark);
            context.SaveChanges();
        }

        //обновить выставленную оценку
        public void updateSetMark(setMark setMark)
        {
            setMarks.Update(setMark);
            context.SaveChanges();
        }

        //удалить выставленную оценку
        public void removeSetMark(setMark setMark)
        {
            setMarks.Remove(setMark);
            context.SaveChanges();
        }
    }
}
