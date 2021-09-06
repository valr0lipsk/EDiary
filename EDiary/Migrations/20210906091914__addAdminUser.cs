using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class _addAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4", 0, "e29f5fb4-86f0-41fc-b7cb-0e74d69f52e4", null, false, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEHrOJUIvaD4We51wYLrnw38SRXFwfxmvjOOFNxD0qTRfcNO7yTRrANmND+ltyMzaHQ==", null, false, "c2766409-7574-4be4-b070-9d9e9d96366a", false, "admin" });

            migrationBuilder.InsertData(
                table: "admins",
                columns: new[] { "adminId", "adminRole", "adminUser" },
                values: new object[] { 1, "admin", "4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "admins",
                keyColumn: "adminId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "c91bfdee-a7b6-4285-821e-a8e2a9e733f9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "124b42af-8ade-4c2b-802a-0301aa791f2e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "98faa446-463e-44c3-865d-fdcd9033fc6d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22e156ef-2b0c-4a75-bd1c-87d281b2b697", "AQAAAAEAACcQAAAAEBprbQOtzxyGQvAuhUUj2dFbWr3DnO/yjkzU/pv7h5sdjKNqYDaaZ+80z8KUDGzg0A==", "5ca2fb36-d248-45b0-bb02-b61965d856e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a807c9df-ea21-435f-a85c-ea28e3fed781", "AQAAAAEAACcQAAAAENSIKzPjioWG7KT1fqWHMuMXerc710H+xMReSbDkhdoP15fDbUjd0pfpNpUyxymVBg==", "b06447c4-1144-41f7-8911-1dffc9abd6f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a55a34b6-29ca-4561-bff9-857ca9dbd322", "AQAAAAEAACcQAAAAEISH5oCeXb0hDvsryHEp0Bt6DtI3Vvax6FDpChs4SF4t0PiQBgmZ8ZlK4NgSHO2JYg==", "b9524128-e2fc-4022-aee9-749eb9fb6b30" });
        }
    }
}
