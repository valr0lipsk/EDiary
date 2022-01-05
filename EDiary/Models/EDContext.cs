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
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Student> students { get; set; }
        public EDContext(DbContextOptions<EDContext> options):base(options) {}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //добавление ролей
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

            //1-ый препод
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "1",
                UserName = "tr000001",
                NormalizedUserName = "TR000001",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "cH854jV9")
            });
            modelBuilder.Entity<Teacher>().HasData(new Teacher
            {
                teacherId = 1,
                teacherSurname = "Тынкович",
                teacherName = "Валентина",
                teacherLastname = "Владимировна",
                teacherRole = "teacher",
                teacherUser = "1"
            });

            //2-ый препод
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "2",
                UserName = "tr000002",
                NormalizedUserName = "TR000002",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "6Z21AsZ1")
            });
            modelBuilder.Entity<Teacher>().HasData(new Teacher
            {
                teacherId = 2,
                teacherSurname = "Лазицкас",
                teacherName = "Екатерина",
                teacherLastname = "Александровна",
                teacherRole = "teacher",
                teacherUser = "2"
            });

            //1-ый студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "3",
                UserName = "st000001",
                NormalizedUserName = "ST000001",
                Email = "kuper2468@gmail.com",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "4u6tv3Sm")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 1,
                studentSurname = "Купреенко",
                studentName = "Александр",
                studentLastname = "Андреевич",
                studentGroup = 2,
                studentRole = "student",
                studentUser ="3"
            });

            //2-ой студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "9",
                UserName = "st000002",
                NormalizedUserName = "ST000002",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "4iNvZYI9")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 2,
                studentSurname = "Липская",
                studentName = "Валерия",
                studentLastname = "Александровна",
                studentGroup = 2,
                studentRole = "student",
                studentUser = "9"
            });

            //добавление админа
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

            //3-ий препод
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "5",
                UserName = "tr000003",
                NormalizedUserName = "TR000003",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "3ApHY46c")
            });
            modelBuilder.Entity<Teacher>().HasData(new Teacher
            {
                teacherId = 3,
                teacherSurname = "Терешко",
                teacherName = "Ольга",
                teacherLastname = "Николаевна",
                teacherRole = "teacher",
                teacherUser = "5"
            });

            //4-ый препод
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "6",
                UserName = "tr000004",
                NormalizedUserName = "TR000004",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "56W3gpHz")
            });
            modelBuilder.Entity<Teacher>().HasData(new Teacher
            {
                teacherId = 4,
                teacherSurname = "Апанасевич",
                teacherName = "Сергей",
                teacherLastname = "Александрович",
                teacherRole = "teacher",
                teacherUser = "6"
            });

            //5-ый препод
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "7",
                UserName = "tr000005",
                NormalizedUserName = "TR000005",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "ph2jCcD8")
            });
            modelBuilder.Entity<Teacher>().HasData(new Teacher
            {
                teacherId = 5,
                teacherSurname = "Карпович",
                teacherName = "Дарья",
                teacherLastname = "Валерьевна",
                teacherRole = "teacher",
                teacherUser = "7"
            });

            //6-ый препод
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "8",
                UserName = "tr000006",
                NormalizedUserName = "TR000006",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "7jOD2Cof")
            });
            modelBuilder.Entity<Teacher>().HasData(new Teacher
            {
                teacherId = 6,
                teacherSurname = "Гордеюк",
                teacherName = "Анастасия",
                teacherLastname = "Владимировна",
                teacherRole = "teacher",
                teacherUser = "8"
            });
            //1-ая группа
            modelBuilder.Entity<collegeGroup>().HasData(new collegeGroup
            {
               groupId=1,
               groupName="8к2491",
               curatorId=6
            });
            modelBuilder.Entity<collegeGroup>().HasData(new collegeGroup
            {
                groupId = 2,
                groupName = "8к2492",
                curatorId = 2
            });
            modelBuilder.Entity<collegeGroup>().HasData(new collegeGroup
            {
                groupId = 3,
                groupName = "8к2493",
                curatorId = 5
            });
        }
    }

}
