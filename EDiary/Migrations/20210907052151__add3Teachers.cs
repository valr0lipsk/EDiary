using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class _add3Teachers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "6f985be6-bb9e-4009-88a7-391bc173da21");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "33416d67-db66-4bc4-8dae-106facf513ca");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "d279750c-4448-4e21-a522-69f94af41f82");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57c47638-0b52-4803-a613-39ef8b01d419", "AQAAAAEAACcQAAAAEHUZnEZuG2Lf/v8VCqc/mtadiAOWdokvB8j2urvb/DdH5jUs5wfpnL/w7rsFAGTrew==", "42997e7c-cc51-4ea4-815c-c0017be7c545" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a68f60a-a7eb-498b-98a9-a279b56c96b5", "AQAAAAEAACcQAAAAEHEWf+xB5sXZTpwTAjrC6PJfnsusOpKIev27WuTreu/ObV8VKBqjGnxC8cGtett9rA==", "b1ad61df-66ab-4143-8f41-4755be48cfb7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27edcb06-92b8-4e7f-8e8a-36388c06a3fd", "AQAAAAEAACcQAAAAEFjSIpEy6hY667Q4wWUH6h/HnoIa/8q1E7dajo3uqtOiM6yOt8iOT5c/6IxtSSCFPQ==", "d784a2ee-8ab7-4cc6-a917-8cb6097ac385" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8da9c2fb-9177-4976-bb8f-99e3fc0d70b0", "AQAAAAEAACcQAAAAEBiozNSKyuHCRPdWUFc7xUnW/ACbsDlIHW1TtsUFqKeuU6ubC4Qqvi5pjpIUTj3JBQ==", "ec5f08b8-bbd9-49b0-b9e7-8398c2d298fe" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5", 0, "1adacb74-0fb9-4b9f-8bdc-f9d7c88704c7", null, false, false, null, null, "TR000003", "AQAAAAEAACcQAAAAEIOPcsy/Jzfo0WcYmfM+0GMttuo0SEX3Sc7sBIZcJLXKVx8Cd3N6NTRO2Ya4eCP7HA==", null, false, "391728d1-a343-4188-88ac-efd575526764", false, "tr000003" },
                    { "6", 0, "8257089e-9797-4962-9fae-57770c9d8ce9", null, false, false, null, null, "TR000004", "AQAAAAEAACcQAAAAEOXxbYnc80TLMigUUkEdfKUrJLlrE0dXYr7oMxoLm4sBNxi1fJK/uTuL0tC0rrrrXg==", null, false, "7ce9c4b7-14c4-4d41-8e17-23d3ea45a3ae", false, "tr000004" },
                    { "7", 0, "9cace8fb-9a9d-44e6-b0aa-a743719d93d4", null, false, false, null, null, "TR000005", "AQAAAAEAACcQAAAAEG5Kc6JFXkJ6egB7UxtWIlcHqDlK6Gc1XyGkrA8FXD6c1uksz6gVaaK01wpTnMN61A==", null, false, "250ca85f-8a55-44d6-a471-2bf8dee8b0a0", false, "tr000005" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "idUser", "userId", "userLastname", "userName", "userPic", "userSurname" },
                values: new object[] { 4, "5", "Николаевна", "Ольга", null, "Терешко" });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "idUser", "userId", "userLastname", "userName", "userPic", "userSurname" },
                values: new object[] { 5, "6", "Александрович", "Сергей", null, "Апанасевич" });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "idUser", "userId", "userLastname", "userName", "userPic", "userSurname" },
                values: new object[] { 6, "7", "Валерьевна", "Дарья", null, "Карпович" });

            migrationBuilder.InsertData(
                table: "teachers",
                columns: new[] { "teacherId", "teacherRole", "teacherUser" },
                values: new object[] { 3, "teacher", 4 });

            migrationBuilder.InsertData(
                table: "teachers",
                columns: new[] { "teacherId", "teacherRole", "teacherUser" },
                values: new object[] { 4, "teacher", 5 });

            migrationBuilder.InsertData(
                table: "teachers",
                columns: new[] { "teacherId", "teacherRole", "teacherUser" },
                values: new object[] { 5, "teacher", 6 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "teacherId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "teacherId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "teacherId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "idUser",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "idUser",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "idUser",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "e9275f1d-fe74-4f28-811c-cde3f795d8f4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "e29b474f-3653-4796-b773-5bc39441d620");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "5f9d9b79-77ca-43a1-b534-64281c304c2d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22e47f59-0f23-4481-9351-570512e1a728", "AQAAAAEAACcQAAAAEFxwPvbLcReEAboGAyXJDVVSewTp1KZYE4cK2Et03FMW5Js7gsjLZv0QKbe23pxTQg==", "61d20ffa-10e6-42b3-873f-a0df25711fd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a4c69c8-157b-459b-baee-961141be46c5", "AQAAAAEAACcQAAAAED8k7P4ogwTdrtjbNN/m3VEasFbYNXHjFz8KfUtIGfRgxHFEg8fQ+Iup/1/lv4vS0A==", "d18cf415-fb31-401c-b01a-c78a4e1befc7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e48901f5-c3d7-442a-96b5-8d621fdf397f", "AQAAAAEAACcQAAAAECXhPbxzeOfZNl95sGq7EDyNmsk33c/LAR9+uFYAIt3c1TW3tau4Xdg4TvKS5ukkSA==", "4797e740-9cd5-4d94-8c12-7b0b35863df2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e29f5fb4-86f0-41fc-b7cb-0e74d69f52e4", "AQAAAAEAACcQAAAAEHrOJUIvaD4We51wYLrnw38SRXFwfxmvjOOFNxD0qTRfcNO7yTRrANmND+ltyMzaHQ==", "c2766409-7574-4be4-b070-9d9e9d96366a" });
        }
    }
}
