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
        public DbSet<Admin> admins { get; set; }
        public DbSet<collegeGroup> groups { get; set; }
        public DbSet<Lesson> lessons { get; set; }
        public DbSet<Mark> marks { get; set; }
        public DbSet<setMark> setMarks { get; set; }
        public DbSet<Subject> subjects { get; set; }
        public DbSet<subjectTaught> subjectTaughts { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<IdentityUser> aspnetusers { get; set; }
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

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "2",
                UserName = "tr000002",
                NormalizedUserName = "TR000002",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "6Z21AsZ1")
            });
            modelBuilder.Entity<Users>().HasData(new Users
            {
                idUser = 2,
                userSurname = "Лазицкас",
                userName = "Екатерина",
                userLastname = "Александровна",
                userId = "2",
            });
            modelBuilder.Entity<Teacher>().HasData(new Teacher
            {
                teacherId = 2,
                teacherRole = "teacher",
                teacherUser = 2
            });
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "3",
                UserName = "st000001",
                NormalizedUserName = "ST000001",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "4u6tv3Sm")
            });
            modelBuilder.Entity<Users>().HasData(new Users
            {
                idUser = 3,
                userSurname = "Купреенко",
                userName = "Александр",
                userLastname = "Андреевич",
                userId = "3",
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
               studentId=1,
               studentGroup=2,
               studentRole="student",
               studentUser=3
            });
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "4",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "UDrIJ5cR")
            });
            modelBuilder.Entity<Admin>().HasData(new Admin
            {
                adminId = 1,
                adminRole = "admin",
                adminUser = "4"
            });

        }
    }

}
