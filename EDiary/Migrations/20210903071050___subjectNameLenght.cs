using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class __subjectNameLenght : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "subjectName",
                table: "subjects",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "7b76ac1c-30a5-4e93-a644-6567f75b9341");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "d3db0385-bea2-4d2a-a7e2-35cf0a446695");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "f9194939-e178-4dff-a8ad-5f9f8811ac65");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec8a10c0-b237-4b3c-897d-cee3b84f09d5", "AQAAAAEAACcQAAAAEP4HgnUMueqtOiCDQzhvWRDhKxU/nBJ0BVYnUtj1ZWH7kRpQvbsvtknaMFbvJcOzlg==", "dfceba77-3b8e-4e6d-8d64-06a7f3a5aaa8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "subjectName",
                table: "subjects",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "31bc5295-1785-4dac-a96c-0b6fe0e74d85");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "9ec676eb-08f7-441e-8b5a-3115f2003dba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "e8a69303-9cb2-40b4-a08d-e3cd3165dcd1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6780ba0-fb28-441d-9ff7-086dfe02f599", "AQAAAAEAACcQAAAAEB/fOi7ggkEiPApSsTKQXdaa5V2oKSumTbM3xIuN6B1rxdzhdCoKFnlmHa/qzxyB2Q==", "70b98f2a-1794-4801-806b-141611d45c22" });
        }
    }
}
