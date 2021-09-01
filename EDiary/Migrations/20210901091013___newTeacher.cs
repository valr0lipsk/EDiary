using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class __newTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "377fb267-f189-472d-9977-dd10f51735ba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "4025ef61-c8a6-4421-879b-9349dd725cfe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "35d97943-5fb0-403d-b3e2-3f0d4111df04");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cbd5c49-d3f0-40b5-abf7-697b5eb6d4f7", "AQAAAAEAACcQAAAAEL1tUUd2ujMojtKLEOAyji44B5fFH+mxqIMQBT3gxdsym+90FirC1vcqDIWvKyZbAw==", "ddbcd791-71f3-47ea-b8c1-d97b0fcee583" });

            migrationBuilder.InsertData(
                table: "teachers",
                columns: new[] { "teacherId", "teacherRole", "teacherUser" },
                values: new object[] { 1, "teacher", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "teacherId",
                keyValue: 1);

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f144504-2a61-42ce-8b29-01125c98a6df", "AQAAAAEAACcQAAAAEJzrFs5onN9T1bmCQZgNc0meEYxJMWrIFmfSijnC6L+W1P1ZJinJO8zQbRKH2mDh6A==", "0be9af38-c52b-40e8-a097-3f1bf95d1d13" });
        }
    }
}
