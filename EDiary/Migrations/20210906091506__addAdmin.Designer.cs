﻿// <auto-generated />
using System;
using EDiary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EDiary.Migrations
{
    [DbContext(typeof(EDContext))]
    [Migration("20210906091506__addAdmin")]
    partial class _addAdmin
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EDiary.Models.Admin", b =>
                {
                    b.Property<int>("adminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("adminRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("adminUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("adminId");

                    b.HasIndex("adminRole");

                    b.HasIndex("adminUser");

                    b.ToTable("admins");
                });

            modelBuilder.Entity("EDiary.Models.Lesson", b =>
                {
                    b.Property<int>("lessonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("lessonDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("tsubjectId")
                        .HasColumnType("int");

                    b.HasKey("lessonId");

                    b.HasIndex("tsubjectId");

                    b.ToTable("lessons");
                });

            modelBuilder.Entity("EDiary.Models.Mark", b =>
                {
                    b.Property<int>("markId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("mark")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("markId");

                    b.ToTable("marks");
                });

            modelBuilder.Entity("EDiary.Models.Student", b =>
                {
                    b.Property<int>("studentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("studentGroup")
                        .HasColumnType("int");

                    b.Property<string>("studentRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("studentUser")
                        .HasColumnType("int");

                    b.HasKey("studentId");

                    b.HasIndex("studentGroup");

                    b.HasIndex("studentRole");

                    b.HasIndex("studentUser");

                    b.ToTable("students");

                    b.HasData(
                        new
                        {
                            studentId = 1,
                            studentGroup = 2,
                            studentRole = "student",
                            studentUser = 3
                        });
                });

            modelBuilder.Entity("EDiary.Models.Subject", b =>
                {
                    b.Property<int>("subjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("subjectName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("subjectId");

                    b.ToTable("subjects");
                });

            modelBuilder.Entity("EDiary.Models.Teacher", b =>
                {
                    b.Property<int>("teacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("teacherRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("teacherUser")
                        .HasColumnType("int");

                    b.HasKey("teacherId");

                    b.HasIndex("teacherRole");

                    b.HasIndex("teacherUser");

                    b.ToTable("teachers");

                    b.HasData(
                        new
                        {
                            teacherId = 1,
                            teacherRole = "teacher",
                            teacherUser = 1
                        },
                        new
                        {
                            teacherId = 2,
                            teacherRole = "teacher",
                            teacherUser = 2
                        });
                });

            modelBuilder.Entity("EDiary.Models.Users", b =>
                {
                    b.Property<int>("idUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("userId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("userLastname")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("userName")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("userPic")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("userSurname")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("idUser");

                    b.HasIndex("userId");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            idUser = 1,
                            userId = "1",
                            userLastname = "Владимировна",
                            userName = "Валентина",
                            userSurname = "Тынкович"
                        },
                        new
                        {
                            idUser = 2,
                            userId = "2",
                            userLastname = "Александровна",
                            userName = "Екатерина",
                            userSurname = "Лазицкас"
                        },
                        new
                        {
                            idUser = 3,
                            userId = "3",
                            userLastname = "Андреевич",
                            userName = "Александр",
                            userSurname = "Купреенко"
                        });
                });

            modelBuilder.Entity("EDiary.Models.collegeGroup", b =>
                {
                    b.Property<int>("groupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("curatorId")
                        .HasColumnType("int");

                    b.Property<string>("groupName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("groupId");

                    b.HasIndex("curatorId");

                    b.ToTable("groups");
                });

            modelBuilder.Entity("EDiary.Models.setMark", b =>
                {
                    b.Property<int>("setmarkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("lessonId")
                        .HasColumnType("int");

                    b.Property<int>("markId")
                        .HasColumnType("int");

                    b.Property<int>("studentId")
                        .HasColumnType("int");

                    b.HasKey("setmarkId");

                    b.HasIndex("lessonId");

                    b.HasIndex("markId");

                    b.HasIndex("studentId");

                    b.ToTable("setMarks");
                });

            modelBuilder.Entity("EDiary.Models.subjectTaught", b =>
                {
                    b.Property<int>("tsubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("groupId")
                        .HasColumnType("int");

                    b.Property<int>("subjectId")
                        .HasColumnType("int");

                    b.Property<int>("teacherId")
                        .HasColumnType("int");

                    b.HasKey("tsubjectId");

                    b.HasIndex("groupId");

                    b.HasIndex("subjectId");

                    b.HasIndex("teacherId");

                    b.ToTable("subjectTaughts");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "admin",
                            ConcurrencyStamp = "c91bfdee-a7b6-4285-821e-a8e2a9e733f9",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "teacher",
                            ConcurrencyStamp = "98faa446-463e-44c3-865d-fdcd9033fc6d",
                            Name = "teacher",
                            NormalizedName = "TEACHER"
                        },
                        new
                        {
                            Id = "student",
                            ConcurrencyStamp = "124b42af-8ade-4c2b-802a-0301aa791f2e",
                            Name = "student",
                            NormalizedName = "STUDENT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "22e156ef-2b0c-4a75-bd1c-87d281b2b697",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "TR000001",
                            PasswordHash = "AQAAAAEAACcQAAAAEBprbQOtzxyGQvAuhUUj2dFbWr3DnO/yjkzU/pv7h5sdjKNqYDaaZ+80z8KUDGzg0A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5ca2fb36-d248-45b0-bb02-b61965d856e6",
                            TwoFactorEnabled = false,
                            UserName = "tr000001"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a807c9df-ea21-435f-a85c-ea28e3fed781",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "TR000002",
                            PasswordHash = "AQAAAAEAACcQAAAAENSIKzPjioWG7KT1fqWHMuMXerc710H+xMReSbDkhdoP15fDbUjd0pfpNpUyxymVBg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b06447c4-1144-41f7-8911-1dffc9abd6f2",
                            TwoFactorEnabled = false,
                            UserName = "tr000002"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a55a34b6-29ca-4561-bff9-857ca9dbd322",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "ST000001",
                            PasswordHash = "AQAAAAEAACcQAAAAEISH5oCeXb0hDvsryHEp0Bt6DtI3Vvax6FDpChs4SF4t0PiQBgmZ8ZlK4NgSHO2JYg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b9524128-e2fc-4022-aee9-749eb9fb6b30",
                            TwoFactorEnabled = false,
                            UserName = "st000001"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("EDiary.Models.Admin", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", "role")
                        .WithMany()
                        .HasForeignKey("adminRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "adUser")
                        .WithMany()
                        .HasForeignKey("adminUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("adUser");

                    b.Navigation("role");
                });

            modelBuilder.Entity("EDiary.Models.Lesson", b =>
                {
                    b.HasOne("EDiary.Models.subjectTaught", "subjectTaught")
                        .WithMany()
                        .HasForeignKey("tsubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("subjectTaught");
                });

            modelBuilder.Entity("EDiary.Models.Student", b =>
                {
                    b.HasOne("EDiary.Models.collegeGroup", "group")
                        .WithMany()
                        .HasForeignKey("studentGroup")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", "role")
                        .WithMany()
                        .HasForeignKey("studentRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EDiary.Models.Users", "user")
                        .WithMany()
                        .HasForeignKey("studentUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("group");

                    b.Navigation("role");

                    b.Navigation("user");
                });

            modelBuilder.Entity("EDiary.Models.Teacher", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", "role")
                        .WithMany()
                        .HasForeignKey("teacherRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EDiary.Models.Users", "user")
                        .WithMany()
                        .HasForeignKey("teacherUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("role");

                    b.Navigation("user");
                });

            modelBuilder.Entity("EDiary.Models.Users", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "identityUser")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("identityUser");
                });

            modelBuilder.Entity("EDiary.Models.collegeGroup", b =>
                {
                    b.HasOne("EDiary.Models.Teacher", "teacher")
                        .WithMany()
                        .HasForeignKey("curatorId");

                    b.Navigation("teacher");
                });

            modelBuilder.Entity("EDiary.Models.setMark", b =>
                {
                    b.HasOne("EDiary.Models.Lesson", "lesson")
                        .WithMany()
                        .HasForeignKey("lessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EDiary.Models.Mark", "mark")
                        .WithMany()
                        .HasForeignKey("markId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EDiary.Models.Student", "student")
                        .WithMany()
                        .HasForeignKey("studentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("lesson");

                    b.Navigation("mark");

                    b.Navigation("student");
                });

            modelBuilder.Entity("EDiary.Models.subjectTaught", b =>
                {
                    b.HasOne("EDiary.Models.collegeGroup", "group")
                        .WithMany()
                        .HasForeignKey("groupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EDiary.Models.Subject", "subject")
                        .WithMany()
                        .HasForeignKey("subjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EDiary.Models.Teacher", "teacher")
                        .WithMany()
                        .HasForeignKey("teacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("group");

                    b.Navigation("subject");

                    b.Navigation("teacher");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}