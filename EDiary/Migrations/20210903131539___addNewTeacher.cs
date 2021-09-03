using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class __addNewTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "5a79f57a-ed4d-4b71-bea4-4df03ea70906");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "01557e03-c685-4c8f-ac1b-912886ce2912");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "cd5a8d25-688c-4ff9-98a0-07121d022e2f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa22e225-81c9-4b03-9162-b63e236ff0ed", "AQAAAAEAACcQAAAAELq0sHTcGKf9xzqzISQyBMvnF6nAaAS8V4KFZQqH6k29k2Uuel6YTOW7wdhtIQ457A==", "8b4d299e-8216-4985-90db-2ab3ab10bd0f" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2", 0, "c5b2d7db-7e35-43ed-ae1a-023f7f9374b0", null, false, false, null, null, "TR000002", "AQAAAAEAACcQAAAAEB19jd0K15+50sWdCBqQ3HiTDcbHiZZIWIXmfRV6X0nX09d9fTeDpDobNicKaFOK6Q==", null, false, "8a3e5c0c-6cf8-4195-a06e-6ed88105b7a3", false, "tr000002" });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "idUser", "userId", "userLastname", "userName", "userPic", "userSurname" },
                values: new object[] { 2, "2", "Александровна", "Екатерина", null, "Лазицкас" });

            migrationBuilder.InsertData(
                table: "teachers",
                columns: new[] { "teacherId", "teacherRole", "teacherUser" },
                values: new object[] { 2, "teacher", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "teacherId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "idUser",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "f08083b2-8fca-4db5-b9f4-7dc42653a6ba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "9a0a01c0-544a-4823-9fb6-e85dabb15ba0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "faec8485-4831-4f61-9afa-88501fe3d77c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "442f739c-43d0-4e8a-9f46-8bd112fb4a99", "AQAAAAEAACcQAAAAEEyBfP7QbH76YBn+d3Hiv6jtvnmjtZe0dbmqd17T/A5GctgNLZQNUNGrjr6ppcyR5g==", "755051a8-8b3b-477a-996a-2c55b568e970" });
        }
    }
}
