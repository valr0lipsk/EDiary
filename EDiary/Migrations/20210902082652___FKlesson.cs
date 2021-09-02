using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class __FKlesson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_setMarks_lessonId",
                table: "setMarks",
                column: "lessonId");

            migrationBuilder.AddForeignKey(
                name: "FK_setMarks_lessons_lessonId",
                table: "setMarks",
                column: "lessonId",
                principalTable: "lessons",
                principalColumn: "lessonId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_setMarks_lessons_lessonId",
                table: "setMarks");

            migrationBuilder.DropIndex(
                name: "IX_setMarks_lessonId",
                table: "setMarks");

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
        }
    }
}
