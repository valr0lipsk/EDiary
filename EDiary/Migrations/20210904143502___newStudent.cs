using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class __newStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "34e86e31-e89c-4291-ae21-de75ee4c4e4c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "8feba137-7311-4129-a3a5-5a19c2875487");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "b48e9009-d6ff-4c86-94d3-2ee58ea3419c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da1c415b-af31-4732-826c-ee39a3c8c4ba", "AQAAAAEAACcQAAAAEGIlRpGEm5RAcG1d4esJuoWbMRykbUKfHaRvqFZth7numUYRFuC67rWprW2xAXJk/w==", "412efec1-de10-4533-b2cd-5def7c692214" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "140ccb2c-473f-48c0-8166-ee9dc109044b", "AQAAAAEAACcQAAAAEHJR1VOOhXtw/GBo4qIEc/+3R8HGavuox2p0D49o0PacWzhs2lPJHDNSUHjc96gmAA==", "220a1e0c-2ba8-4f05-9894-3ae6f7db6943" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3", 0, "43c03a6d-e5f5-4f2f-92f8-56b647db0d75", null, false, false, null, null, "ST000001", "AQAAAAEAACcQAAAAEOPn98kTig32iA23fidzGI/P5YheCwH5tzbPAg5sfDtRJqX0yJcpd3PBZlF00kovbg==", null, false, "eb7f9544-27c2-4865-8130-036f43320bf6", false, "st000001" });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "idUser", "userId", "userLastname", "userName", "userPic", "userSurname" },
                values: new object[] { 3, "3", "Андреевич", "Александр", null, "Купреенко" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "studentId", "studentGroup", "studentRole", "studentUser" },
                values: new object[] { 1, 2, "student", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "idUser",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5b2d7db-7e35-43ed-ae1a-023f7f9374b0", "AQAAAAEAACcQAAAAEB19jd0K15+50sWdCBqQ3HiTDcbHiZZIWIXmfRV6X0nX09d9fTeDpDobNicKaFOK6Q==", "8a3e5c0c-6cf8-4195-a06e-6ed88105b7a3" });
        }
    }
}
