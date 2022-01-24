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
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<lessonType> lessonType { get; set; }
        public DbSet<EmojiStatus> emojiStatuses { get; set; }
        public DbSet<Labs> labs { get; set; }
        public DbSet<Subgroup> subgroups { get; set; }
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
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "headman",
                Name = "headman",
                NormalizedName = "HEADMAN"
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
                studentUser ="3"
            });

            //2-ой студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "9",
                UserName = "st000002",
                NormalizedUserName = "ST000002",
                Email = "valery.lipskaya03@gmail.com",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "4iNvZYI9")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 2,
                studentSurname = "Липская",
                studentName = "Валерия",
                studentLastname = "Александровна",
                studentGroup = 2,
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
            //3-ий студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "10",
                UserName = "st000003",
                NormalizedUserName = "ST000003",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Cjz7JFqw")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 3,
                studentSurname = "Бичевская",
                studentName = "Анна",
                studentLastname = "Дмитриевна",
                studentGroup = 2,
                studentUser = "10"
            });
            //4-ый студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "11",
                UserName = "st000004",
                NormalizedUserName = "ST000004",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Uyy4T42r")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 4,
                studentSurname = "Болтромеюк",
                studentName = "Матвей",
                studentLastname = "Андреевич",
                studentGroup = 2,
                studentUser = "11"
            });
            //5-ый студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "12",
                UserName = "st000005",
                NormalizedUserName = "ST000005",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "4XakE9LK")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 5,
                studentSurname = "Деревяго",
                studentName = "Артем",
                studentLastname = "Сергеевич",
                studentGroup = 2,
                studentUser = "12"
            });
            //6-ый студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "13",
                UserName = "st000006",
                NormalizedUserName = "ST000006",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "TztR6apz")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 6,
                studentSurname = "Барай",
                studentName = "Мария",
                studentLastname = "Николаевна",
                studentGroup = 2,
                studentUser = "13"
            });
            //7-ой студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "14",
                UserName = "st000007",
                NormalizedUserName = "ST000007",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "6AtxG7g2")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 7,
                studentSurname = "Беленович",
                studentName = "Николай",
                studentLastname = "Андреевич",
                studentGroup = 2,
                studentUser = "14"
            });
            //8-ой студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "15",
                UserName = "st000008",
                NormalizedUserName = "ST000008",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "8VPcADBa")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 8,
                studentSurname = "Валькович",
                studentName = "Владимир",
                studentLastname = "Андреевич",
                studentGroup = 2,
                studentUser = "15"
            });
            //9-ый студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "16",
                UserName = "st000009",
                NormalizedUserName = "ST000009",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "66f45ZAp")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 9,
                studentSurname = "Войлокова",
                studentName = "Дарья",
                studentLastname = "Дмитриевна",
                studentGroup = 2,
                studentUser = "16"
            });
            //10-ый студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "17",
                UserName = "st000010",
                NormalizedUserName = "ST000010",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "fHAvfx7V")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 10,
                studentSurname = "Воронина",
                studentName = "Екатерина",
                studentLastname = "Сергеевна",
                studentGroup = 2,
                studentUser = "17"
            });
            //11-ый студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "18",
                UserName = "st000011",
                NormalizedUserName = "ST000011",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Sj6EvUsw")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 11,
                studentSurname = "Вусик",
                studentName = "Александр",
                studentLastname = "Сергеевич",
                studentGroup = 2,
                studentUser = "18"
            });
            //12-ый студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "19",
                UserName = "st000012",
                NormalizedUserName = "ST000012",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "unfYL7yL")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 12,
                studentSurname = "Глушков",
                studentName = "Иван",
                studentLastname = "Павлович",
                studentGroup = 2,
                studentUser = "19"
            });
            //13-ый студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "20",
                UserName = "st000013",
                NormalizedUserName = "ST000013",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "eGvmdZ4S")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 13,
                studentSurname = "Журомский",
                studentName = "Антон",
                studentLastname = "Владимирович",
                studentGroup = 2,
                studentUser = "20"
            });
            //14-ый студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "21",
                UserName = "st000014",
                NormalizedUserName = "ST000014",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "N2h7e9ZF")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 14,
                studentSurname = "Захарчик",
                studentName = "Константин",
                studentLastname = "Олегович",
                studentGroup = 2,
                studentUser = "21"
            });
            //15-ый студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "22",
                UserName = "st000015",
                NormalizedUserName = "ST000015",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "wefVZ4XF")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 15,
                studentSurname = "Иванов",
                studentName = "Никита",
                studentLastname = "Сергеевич",
                studentGroup = 2,
                studentUser = "22"
            });
            //16-ый студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "23",
                UserName = "st000016",
                NormalizedUserName = "ST000016",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "yhFR55hT")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 16,
                studentSurname = "Казачук",
                studentName = "Никита",
                studentLastname = "Леонидович",
                studentGroup = 2,
                studentUser = "23"
            });
            //17-ый студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "24",
                UserName = "st000017",
                NormalizedUserName = "ST000017",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "r95jtMLU")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 17,
                studentSurname = "Каначевская",
                studentName = "Ксения",
                studentLastname = "Владимировна",
                studentGroup = 2,
                studentUser = "24"
            });
            //18-ый студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "25",
                UserName = "st000018",
                NormalizedUserName = "ST000018",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "k55C3bSQ")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 18,
                studentSurname = "Кобрик",
                studentName = "Даниил",
                studentLastname = "Сергеевич",
                studentGroup = 2,
                studentUser = "25"
            });
            //19-ый студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "26",
                UserName = "st000019",
                NormalizedUserName = "ST000019",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "hqx66Hp4")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 19,
                studentSurname = "Ковалев",
                studentName = "Сергей",
                studentLastname = "Олегович",
                studentGroup = 2,
                studentUser = "26"
            });
            //20-ый студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "27",
                UserName = "st000020",
                NormalizedUserName = "ST000020",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "j9DuA2g2")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 20,
                studentSurname = "Мятеж",
                studentName = "Иван",
                studentLastname = "Святославович",
                studentGroup = 2,
                studentUser = "27"
            });
            //21-ый студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "28",
                UserName = "st000021",
                NormalizedUserName = "ST000021",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "j9DuA2g2")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 21,
                studentSurname = "Савельев",
                studentName = "Евгений",
                studentLastname = "Игоревич",
                studentGroup = 2,
                studentUser = "28"
            });
            //22-ый студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "29",
                UserName = "st000022",
                NormalizedUserName = "ST000022",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Z5rGy6BG")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 22,
                studentSurname = "Селюн",
                studentName = "Егор",
                studentLastname = "Александрович",
                studentGroup = 2,
                studentUser = "29"
            });
            //23-ый студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "30",
                UserName = "st000023",
                NormalizedUserName = "ST000023",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "7qqeByHj")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 23,
                studentSurname = "Соломевич",
                studentName = "Анастасия",
                studentLastname = "Вадимовна",
                studentGroup = 2,
                studentUser = "30"
            });
            //24-ый студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "31",
                UserName = "st000024",
                NormalizedUserName = "ST000024",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "5qW6jkFC")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 24,
                studentSurname = "Тимощенко",
                studentName = "Мария",
                studentLastname = "Александровна",
                studentGroup = 2,
                studentUser = "31"
            });
            //25-ый студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "32",
                UserName = "st000025",
                NormalizedUserName = "ST000025",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "W37kbNtk")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 25,
                studentSurname = "Турута",
                studentName = "Никита",
                studentLastname = "Аркадьевич",
                studentGroup = 2,
                studentUser = "32"
            });
            //26-ой студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "33",
                UserName = "st000026",
                NormalizedUserName = "ST000026",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "ybQT9xcf")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 26,
                studentSurname = "Францкевич",
                studentName = "Кирилл",
                studentLastname = "Андреевич",
                studentGroup = 2,
                studentUser = "33"
            });
            //27-ой студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "34",
                UserName = "st000027",
                NormalizedUserName = "ST000027",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "EVcLSh6D")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 27,
                studentSurname = "Францкевич",
                studentName = "Максим",
                studentLastname = "Дмитриевич",
                studentGroup = 2,
                studentUser = "34"
            });
            //28-ой студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "35",
                UserName = "st000028",
                NormalizedUserName = "ST000028",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "XSAevb5q")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 28,
                studentSurname = "Чэнь",
                studentName = "Роман",
                studentLastname = "",
                studentGroup = 2,
                studentUser = "35"
            });
            //29-ый студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "36",
                UserName = "st000029",
                NormalizedUserName = "ST000029",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "7fd7hJTY")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 29,
                studentSurname = "Шибаков",
                studentName = "Захар",
                studentLastname = "Сергеевич",
                studentGroup = 2,
                studentUser = "36"
            });
            //30-ый студент
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "37",
                UserName = "st000030",
                NormalizedUserName = "ST000030",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "2yD7StQz")
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                studentId = 30,
                studentSurname = "Школьная",
                studentName = "Ксения",
                studentLastname = "Вадимовна",
                studentGroup = 2,
                studentUser = "37"
            });
            //7-ой препод
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "38",
                UserName = "tr000007",
                NormalizedUserName = "TR000007",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "7jOD2Cof")
            });
            modelBuilder.Entity<Teacher>().HasData(new Teacher
            {
                teacherId = 7,
                teacherSurname = "Виничук",
                teacherName = "Ольга",
                teacherLastname = "Николаевна",
                teacherUser = "38"
            });
        }
    }

}
