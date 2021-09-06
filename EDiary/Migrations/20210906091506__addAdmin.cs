using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class _addAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    adminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adminRole = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    adminUser = table.Column<string>(type: "nvarchar(450)", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_admins_adminRole",
                table: "admins",
                column: "adminRole");

            migrationBuilder.CreateIndex(
                name: "IX_admins_adminUser",
                table: "admins",
                column: "adminUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admins");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43c03a6d-e5f5-4f2f-92f8-56b647db0d75", "AQAAAAEAACcQAAAAEOPn98kTig32iA23fidzGI/P5YheCwH5tzbPAg5sfDtRJqX0yJcpd3PBZlF00kovbg==", "eb7f9544-27c2-4865-8130-036f43320bf6" });
        }
    }
}
