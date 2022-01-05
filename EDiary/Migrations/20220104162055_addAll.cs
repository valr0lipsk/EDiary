using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class addAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "marks",
                columns: table => new
                {
                    markId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mark = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marks", x => x.markId);
                });

            migrationBuilder.CreateTable(
                name: "subjects",
                columns: table => new
                {
                    subjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subjectName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subjects", x => x.subjectId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    adminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adminUser = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    adminRole = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.adminId);
                    table.ForeignKey(
                        name: "FK_admins_AspNetRoles_adminRole",
                        column: x => x.adminRole,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_admins_AspNetUsers_adminUser",
                        column: x => x.adminUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "teachers",
                columns: table => new
                {
                    teacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    teacherSurname = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    teacherName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    teacherLastname = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    teacherPic = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    teacherRole = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    teacherUser = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teachers", x => x.teacherId);
                    table.ForeignKey(
                        name: "FK_teachers_AspNetRoles_teacherRole",
                        column: x => x.teacherRole,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_teachers_AspNetUsers_teacherUser",
                        column: x => x.teacherUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "groups",
                columns: table => new
                {
                    groupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    groupName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    curatorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_groups", x => x.groupId);
                    table.ForeignKey(
                        name: "FK_groups_teachers_curatorId",
                        column: x => x.curatorId,
                        principalTable: "teachers",
                        principalColumn: "teacherId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    studentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentSurname = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    studentName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    studentLastname = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    studentPic = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    studentGroup = table.Column<int>(type: "int", nullable: false),
                    studentRole = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    studentUser = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.studentId);
                    table.ForeignKey(
                        name: "FK_students_AspNetRoles_studentRole",
                        column: x => x.studentRole,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_students_AspNetUsers_studentUser",
                        column: x => x.studentUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_students_groups_studentGroup",
                        column: x => x.studentGroup,
                        principalTable: "groups",
                        principalColumn: "groupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "subjectTaughts",
                columns: table => new
                {
                    tsubjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subjectId = table.Column<int>(type: "int", nullable: false),
                    teacherId = table.Column<int>(type: "int", nullable: false),
                    groupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subjectTaughts", x => x.tsubjectId);
                    table.ForeignKey(
                        name: "FK_subjectTaughts_groups_groupId",
                        column: x => x.groupId,
                        principalTable: "groups",
                        principalColumn: "groupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_subjectTaughts_subjects_subjectId",
                        column: x => x.subjectId,
                        principalTable: "subjects",
                        principalColumn: "subjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_subjectTaughts_teachers_teacherId",
                        column: x => x.teacherId,
                        principalTable: "teachers",
                        principalColumn: "teacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "lessons",
                columns: table => new
                {
                    lessonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lessonDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tsubjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lessons", x => x.lessonId);
                    table.ForeignKey(
                        name: "FK_lessons_subjectTaughts_tsubjectId",
                        column: x => x.tsubjectId,
                        principalTable: "subjectTaughts",
                        principalColumn: "tsubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "setMarks",
                columns: table => new
                {
                    setmarkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lessonId = table.Column<int>(type: "int", nullable: false),
                    studentId = table.Column<int>(type: "int", nullable: false),
                    markId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_setMarks", x => x.setmarkId);
                    table.ForeignKey(
                        name: "FK_setMarks_lessons_lessonId",
                        column: x => x.lessonId,
                        principalTable: "lessons",
                        principalColumn: "lessonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_setMarks_marks_markId",
                        column: x => x.markId,
                        principalTable: "marks",
                        principalColumn: "markId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_setMarks_students_studentId",
                        column: x => x.studentId,
                        principalTable: "students",
                        principalColumn: "studentId",
                        /*исправить*/onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "admin", "1b6e158d-5e5f-4ac0-9018-34b43b8111c7", "admin", "ADMIN" },
                    { "teacher", "03f9ab92-07bf-4681-9e4b-931b6447b67d", "teacher", "TEACHER" },
                    { "student", "44588590-b846-497a-a36b-e19882d9ee90", "student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "efaf5fe3-aaf6-4620-bec1-630129eade01", null, false, false, null, null, "TR000001", "AQAAAAEAACcQAAAAEHfEJ2tLk0ITNezMmmJuF/sCxiUeozq9S+Pru2urfIWe8n01k/BXXMGifNhQ2AheuQ==", null, false, "64651029-9703-4f4a-837d-bbd5e34d289f", false, "tr000001" },
                    { "2", 0, "22bbee36-ed67-4b47-8cb0-b91267e1817a", null, false, false, null, null, "TR000002", "AQAAAAEAACcQAAAAEGgVg2QfgyIG5/rLrUnjkkH2rXNdYk3o1g8iBDHH1iFDuPQO0BFT8r7iK3ykvug+yQ==", null, false, "74943d9e-56e6-4df8-895a-1ffaa285b6b4", false, "tr000002" },
                    { "3", 0, "5223b31e-ee7b-4d4f-96ab-7f3c2e86ed8b", "kuper2468@gmail.com", true, false, null, null, "ST000001", "AQAAAAEAACcQAAAAEDgxCj4DeQi17miSiEPuGDebhWxcjKp1iKntS0m/dWCcBxL5hJWeYDf8pYdmwCsQ5g==", null, false, "f832b661-94cc-42f8-a425-3d9ebd049717", false, "st000001" },
                    { "9", 0, "689e472f-cd9c-4ac7-82d7-46ea2b768d05", null, false, false, null, null, "ST000002", "AQAAAAEAACcQAAAAEP2ekKoJpuSbQQY1lSMZZm91LpZc18Lz0tjoMuYMVQ5XaOMO4fXjaGnyTS4nPQCQQw==", null, false, "5b44ee10-0960-4987-a775-3153e948d04f", false, "st000002" },
                    { "4", 0, "0eddbf85-3ff5-42e4-bd7a-9951564ba063", null, false, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEJIlu0WLcF1R6hu5HRKhPBdHfOXTk3YoBatI3XviWBtLWVdrBPZmIxGnlsCXdSNSQg==", null, false, "c7fd6438-55e4-4674-a58f-516ae89d7536", false, "admin" },
                    { "5", 0, "f32322ee-bea6-4b62-9f3b-32dc4efacb34", null, false, false, null, null, "TR000003", "AQAAAAEAACcQAAAAEEFJSB7fg2rUWaDQrsRcJW+9bEShS13tOlyjPuoBOu08WTrok12TYasWSQbrYF7vHg==", null, false, "1a6a0e38-b97d-43b6-bb87-b7ea734b4318", false, "tr000003" },
                    { "6", 0, "721cecc7-8e45-45be-a38b-7493ea3900fa", null, false, false, null, null, "TR000004", "AQAAAAEAACcQAAAAEJvHXwrzYqsJ39OHkf+M6uYPYkrh6o5Bvt4xDW1kHyVJgUjpRHZPUBg/uwFiZPOk8Q==", null, false, "9aa518b9-1ab6-4052-9a2d-b33b42ee2501", false, "tr000004" },
                    { "7", 0, "9bf3e22a-db01-49e5-ae11-3404fd8b17a9", null, false, false, null, null, "TR000005", "AQAAAAEAACcQAAAAEEMJiDTgXvdatti8LEShC3dMvE4qnhNy6S1qPVaSq3v/FQ8uQlER+E8hpaccYyTdtw==", null, false, "09c2e816-0b3e-4b39-a6f6-5d99568da4b3", false, "tr000005" },
                    { "8", 0, "16b7f76e-3175-4b54-b4f0-240343828488", null, false, false, null, null, "TR000006", "AQAAAAEAACcQAAAAEKcE2b5h4h/uZhGmHhyAJTlwm82QMNmDudu5oRiudMc4TXKKbw7dTLEp8nzYZqxHtA==", null, false, "af845009-c96b-47af-bc43-b73456f283ce", false, "tr000006" }
                });

            migrationBuilder.InsertData(
                table: "admins",
                columns: new[] { "adminId", "adminRole", "adminUser" },
                values: new object[] { 1, "admin", "4" });

            migrationBuilder.InsertData(
                table: "teachers",
                columns: new[] { "teacherId", "teacherLastname", "teacherName", "teacherPic", "teacherRole", "teacherSurname", "teacherUser" },
                values: new object[,]
                {
                    { 1, "Владимировна", "Валентина", null, "teacher", "Тынкович", "1" },
                    { 2, "Александровна", "Екатерина", null, "teacher", "Лазицкас", "2" },
                    { 3, "Николаевна", "Ольга", null, "teacher", "Терешко", "5" },
                    { 4, "Александрович", "Сергей", null, "teacher", "Апанасевич", "6" },
                    { 5, "Валерьевна", "Дарья", null, "teacher", "Карпович", "7" },
                    { 6, "Владимировна", "Анастасия", null, "teacher", "Гордеюк", "8" }
                });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "groupId", "curatorId", "groupName" },
                values: new object[] { 2, 2, "8к2492" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "groupId", "curatorId", "groupName" },
                values: new object[] { 3, 5, "8к2493" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "groupId", "curatorId", "groupName" },
                values: new object[] { 1, 6, "8к2491" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "studentId", "studentGroup", "studentLastname", "studentName", "studentPic", "studentRole", "studentSurname", "studentUser" },
                values: new object[] { 1, 2, "Андреевич", "Александр", null, "student", "Купреенко", "3" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "studentId", "studentGroup", "studentLastname", "studentName", "studentPic", "studentRole", "studentSurname", "studentUser" },
                values: new object[] { 2, 2, "Александровна", "Валерия", null, "student", "Липская", "9" });

            migrationBuilder.CreateIndex(
                name: "IX_admins_adminRole",
                table: "admins",
                column: "adminRole");

            migrationBuilder.CreateIndex(
                name: "IX_admins_adminUser",
                table: "admins",
                column: "adminUser");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_groups_curatorId",
                table: "groups",
                column: "curatorId");

            migrationBuilder.CreateIndex(
                name: "IX_lessons_tsubjectId",
                table: "lessons",
                column: "tsubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_setMarks_lessonId",
                table: "setMarks",
                column: "lessonId");

            migrationBuilder.CreateIndex(
                name: "IX_setMarks_markId",
                table: "setMarks",
                column: "markId");

            migrationBuilder.CreateIndex(
                name: "IX_setMarks_studentId",
                table: "setMarks",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_students_studentGroup",
                table: "students",
                column: "studentGroup");

            migrationBuilder.CreateIndex(
                name: "IX_students_studentRole",
                table: "students",
                column: "studentRole");

            migrationBuilder.CreateIndex(
                name: "IX_students_studentUser",
                table: "students",
                column: "studentUser");

            migrationBuilder.CreateIndex(
                name: "IX_subjectTaughts_groupId",
                table: "subjectTaughts",
                column: "groupId");

            migrationBuilder.CreateIndex(
                name: "IX_subjectTaughts_subjectId",
                table: "subjectTaughts",
                column: "subjectId");

            migrationBuilder.CreateIndex(
                name: "IX_subjectTaughts_teacherId",
                table: "subjectTaughts",
                column: "teacherId");

            migrationBuilder.CreateIndex(
                name: "IX_teachers_teacherRole",
                table: "teachers",
                column: "teacherRole");

            migrationBuilder.CreateIndex(
                name: "IX_teachers_teacherUser",
                table: "teachers",
                column: "teacherUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "setMarks");

            migrationBuilder.DropTable(
                name: "lessons");

            migrationBuilder.DropTable(
                name: "marks");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "subjectTaughts");

            migrationBuilder.DropTable(
                name: "groups");

            migrationBuilder.DropTable(
                name: "subjects");

            migrationBuilder.DropTable(
                name: "teachers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
