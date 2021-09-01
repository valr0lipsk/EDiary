using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class __newUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "5816fcf2-e1ab-4ad4-bfc9-c83ef1de784b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "7e4bba17-dc2e-4d8b-98c6-f99738fa2e62");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "114e2704-8119-44ea-a7d9-cfc0aed06d81");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "0f144504-2a61-42ce-8b29-01125c98a6df", null, false, false, null, null, "TR000001", "AQAAAAEAACcQAAAAEJzrFs5onN9T1bmCQZgNc0meEYxJMWrIFmfSijnC6L+W1P1ZJinJO8zQbRKH2mDh6A==", null, false, "0be9af38-c52b-40e8-a097-3f1bf95d1d13", false, "tr000001" });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "idUser", "userId", "userLastname", "userName", "userPic", "userSurname" },
                values: new object[] { 1, "1", "Владимировна", "Валентина", null, "Тынкович" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "idUser",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "8fa659da-d2d8-45df-bb51-b55ed0df0ad1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "9948a400-92c2-43fb-a0ef-f90c47ff5d81");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "22ab7c45-62c5-4339-8626-573beb2aa193");
        }
    }
}
