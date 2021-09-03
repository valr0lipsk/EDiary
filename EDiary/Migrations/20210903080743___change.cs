using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class __change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_groups_teachers_curatorId",
                table: "groups");

            migrationBuilder.AlterColumn<int>(
                name: "curatorId",
                table: "groups",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_groups_teachers_curatorId",
                table: "groups",
                column: "curatorId",
                principalTable: "teachers",
                principalColumn: "teacherId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_groups_teachers_curatorId",
                table: "groups");

            migrationBuilder.AlterColumn<int>(
                name: "curatorId",
                table: "groups",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_groups_teachers_curatorId",
                table: "groups",
                column: "curatorId",
                principalTable: "teachers",
                principalColumn: "teacherId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
