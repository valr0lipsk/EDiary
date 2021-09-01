using EDiary.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Models
{
    public class EDContext: IdentityDbContext<IdentityUser>
    {
        public DbSet<collegeGroup> groups { get; set; }
        public DbSet<Lesson> lessons { get; set; }
        public DbSet<Mark> marks { get; set; }
        public DbSet<setMark> setMarks { get; set; }
        public DbSet<Subject> subjects { get; set; }
        public DbSet<subjectTaught> subjectTaughts { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Student> students { get; set; }
        public EDContext(DbContextOptions<EDContext> options):base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "admin",
                Name = "admin",
                NormalizedName = "ADMIN"
            });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "teacher",
                Name = "teacher",
                NormalizedName = "TEACHER"
            });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "student",
                Name = "student",
                NormalizedName = "STUDENT"
            });
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "1",
                UserName = "tr000001",
                NormalizedUserName = "TR000001",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "cH854jV9")
            });
            modelBuilder.Entity<Users>().HasData(new Users
            {
                idUser = 1,
                userSurname = "Тынкович",
                userName = "Валентина",
                userLastname = "Владимировна",
                userId = "1",
            });
            modelBuilder.Entity<Teacher>().HasData(new Teacher
            {
                teacherId = 1,
                teacherRole = "teacher",
                teacherUser = 1
            });
        }
    }

}
