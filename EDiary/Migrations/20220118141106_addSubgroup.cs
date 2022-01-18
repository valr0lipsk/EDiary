using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class addSubgroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lessonLabs");

            migrationBuilder.DropColumn(
                name: "studentsCount",
                table: "labs");

            migrationBuilder.AddColumn<int>(
                name: "studentSubgroup",
                table: "students",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "subgroups",
                columns: table => new
                {
                    subgroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subgroupName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subgroups", x => x.subgroupId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "12a45541-eef6-4401-8391-62afaebffe8b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "8248250e-4265-4a09-bc67-8a3b561b8748");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "3f57e549-1f9e-418e-81e4-f9725f2d11b8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "a183e990-82cc-48e7-8976-3bf49be9cf61");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "589adec6-6872-4628-9229-1b25593c1262", "AQAAAAEAACcQAAAAEPaApNcgrSKUpNyrKYqfps2mkTwX8bgxy/eJUdcd4ynqg+cORsV/DTU2LyM87EFFWA==", "da035d0b-f946-467e-9ade-c3573f165646" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "717a6b91-c2df-43d6-a315-88e650963cb9", "AQAAAAEAACcQAAAAEPZf5Wa8wFo1i8EoSzF1ew8Ezdri9MGs8gqufsUn31JlrtcbLn1UWwIvPxXy6jB3dw==", "b3ac9a98-8e4b-4e13-a689-130eb33c6fc9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de922344-2f25-4a7b-b9bf-2509edc1540a", "AQAAAAEAACcQAAAAEHXUw9h7KyvLoLERliAogYzpzyrg6x2rmb6GhFVKy1Xh+8S7eq0RnVrLO7fy1utPUQ==", "0ffc360e-dcc6-4a7d-8851-c208a2d7c51a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f24ceaa1-03fe-4174-898d-e0337b36d1d8", "AQAAAAEAACcQAAAAECxnQ4LC23iqsMrruKb4I2/Imxy/R1IrlzbbliwcsScslze9v3XpS0VX2O9H6Jwr+g==", "92aaf351-c3f2-42f2-b425-9a6fc9d3c9db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33c9cf49-60e3-4a80-89ec-013882234e9f", "AQAAAAEAACcQAAAAEBz+wL6f6WR0mRLuwwIJg36+qxDj692zwLRMHTZnE4DF/QpX546Y2S2/vKlmJSiLug==", "bc3c91a6-2bc3-4a6a-a3db-5a2dff30cdfc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3037cf63-bad5-4cdb-83a1-93733b25001c", "AQAAAAEAACcQAAAAEBdZaLDIvAP6FAjWP0qAh3ZG0trBhpjvJ5zBLYcr+Bp6FvCugtgSG1x2+/OMcaRQRA==", "f1f0fd67-c723-4cc7-be40-3ec333375ac9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f66f2412-c801-4083-9400-07e5def16d08", "AQAAAAEAACcQAAAAEIgiNkme8WztG+Av0DwEeUcHUGTXeCsAWPKhpU+F0q/HOMkP5M/+MVjsN5scvhcT4Q==", "cc601848-c60c-4d81-bb9f-04babfc2d68b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ce6ec23-21c7-4769-8935-69fb3a08ff22", "AQAAAAEAACcQAAAAEN1uWi6Yl3oHbxNU6uVDKDC+wXGi3XHKDefDc8lI36gaNL6tvf4XhPuYu2PpPS/5Qg==", "b819e6f1-9983-488b-96d5-4233de54a76d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cb46eba-eb42-47ee-a37f-9419cc8e7fdf", "AQAAAAEAACcQAAAAEGKJICS3wtTjvCU+SR97gs0Hizj0heE8q8gyhtLgOZlqciu+saXuOLVoCMs5atP8dg==", "ce1dc1b1-eadb-4f7b-83b7-87e631d980fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "659bc699-2f77-4d4e-94d5-33392599a92c", "AQAAAAEAACcQAAAAEIyG2l4CSt59tmeJoeLWCMGsALTrfZDPrrl1TtNfH7MAgKZV+8+y1FfCGq8FaXegvA==", "3b817650-29f1-4abb-b79d-dab14adbeaf2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc15e7e8-020a-435a-bef3-f48d9b4b3961", "AQAAAAEAACcQAAAAEDQiHHwrZaOEM4uPoxYm/YWaknqCUtWT1ShTFUZw90BhfTNplPSkbVzbUkPjhXbl0Q==", "c15d4399-ac13-4ffa-a8c3-36801f31439e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8ffd8dc-76d4-455e-b6a5-2f1373f09587", "AQAAAAEAACcQAAAAELrkvg8VpjhlB6SiuVWfwYDQ9KL14TyneAlkWrKh+kyq0cP4ildQA1n8hSXgwN4tKg==", "5cea6f35-d3e8-41d0-b998-b5146dc4e40c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fa9c3be-c9d4-466b-abff-8b320cf61e8d", "AQAAAAEAACcQAAAAEKnZRGXNgTb2VE/WPELZCTVtHsgQLMzfY3UmKiM1gruJUnOCi8EYOUodr9KShHelfQ==", "08c06c70-ce64-4365-a830-837e8a063849" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "761d6581-8898-4276-81be-b7a6f8148a68", "AQAAAAEAACcQAAAAEIvG4rCkTglEePj2BOihU2OBJJmpxoGTIAVpsZ7VHrRNRo81Mvjwy2jeaOImOlZYaQ==", "0d6c84b5-d828-488e-85df-58eff5db2964" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a7aec0e-eb53-4514-9b8f-ea2aeedfc120", "AQAAAAEAACcQAAAAELSXA56nFDUMjsSZu62G9DyEgoS6ywjedQ+gwldQkWPl5aXT4zrsSG6/NVMa+4bSpg==", "0e295531-fcee-4a4e-a41d-8b395b5aa41f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e05aa22-9293-4a2b-9f26-2a7b42e2e9d2", "AQAAAAEAACcQAAAAEHoXdrv6RWTQev7R5uHQWhjmpJ03R249u0YoQs7cEWJhEah33guXbhlSMSVXodYAqQ==", "07954258-c06e-42e6-98ce-2201511ed067" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80dc29a8-edbc-493d-b7cd-53bc54e7ad62", "AQAAAAEAACcQAAAAEInUicbHT7p7U10YuqwSDDALanyTiz4nYz3nBC9/ksUo7+dgujIvXC8dp8oRQwsK0Q==", "f1b9bcc1-228b-4732-bba4-35c8d7a75611" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "daf51b66-b839-4f7e-b1cf-b4265c983875", "AQAAAAEAACcQAAAAEOw0UVGCnUr0gc+THVUQr+myKOHI6iAaVjiivVz/4RaJYW9av0hBj4A8YQEmvXPKlA==", "423c4331-58c1-4156-917c-4cfbc9b34c08" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52927efb-7883-4565-bf70-b383a72f8700", "AQAAAAEAACcQAAAAEEd6b3OVByHOv948xMO5Qby7KgwRjmYuIOuq8K2ZiFSU7oenmbMbF1YLbPgR6ANrFg==", "f0c82725-122d-4b44-a08e-470061afe078" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "054bc72b-fa99-4b40-b1ad-d8d58d2964ea", "AQAAAAEAACcQAAAAEBgYAFLdrZkMBVFAwg0ooBO2cM3hi2y6SIhn8mgWUXMh1JvUlpwQ674pGJu75uSIjQ==", "cb8da753-cc37-4e38-824a-5247883a4c06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8a3db6c-35e6-4d77-9a57-56748c80c5e8", "AQAAAAEAACcQAAAAEPL1oc5BtTBGtmRDx6jmdxoIC7IXopyy0LQ70Zo9ynuEM67zphIqMs4DiZQ/J3EOIw==", "c579f0ae-5ae0-4915-b8ac-baae69c5bd33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b28f1576-d6a0-455d-9d59-0a644aae0a41", "AQAAAAEAACcQAAAAEDfCthQ5bebdu4rLzNcIfJKKkmzHnfExXT/0AhHxL0QHNojg19XmOJfW5KSGQHL34A==", "faadeb10-85a9-4d1a-8a1d-181b1bd51737" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0350ab83-cf1e-48a3-8784-92eec8810a4a", "AQAAAAEAACcQAAAAEJ3gePVAIQTF1dn1lhYdusl4AKmhH6xS2cTQuraPXqVXIWI3/uSqegYcEoEaQUJXvw==", "dff76111-74f1-428e-88d8-51de46c2826d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32e654bf-93a1-4f98-ba24-91e4c368d053", "AQAAAAEAACcQAAAAEOVkTCN54HTxenD42EoEy+Aodx28VpbtAd2Qp3jt2Zm11sNkpCvB3+GdkD2CSOBVeg==", "71d9e8af-8146-4e18-9c31-98cf2d8ebc12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2320ed68-902e-4f01-be89-dfb3676fcba9", "AQAAAAEAACcQAAAAEJTYrjgnsN3rqwYaWr/LM2h6mjt/WXd+h65IcRu/wDtDBypxB2e9ficgw+apl6j2fQ==", "e247e898-b352-444b-a1f2-40f676bcc728" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4518da15-9cb0-4456-aed3-f53951768e19", "AQAAAAEAACcQAAAAEGaqokTTkQpiahtpPICv9uYClpUsPZwUAF3H1z37c5MIrC7YEVStVzvYSEQz28Cvpg==", "54916f33-8e4d-41b3-a34f-9e27575eb8c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "421d477e-99aa-4b3b-8ef6-2e98c8fb3c2c", "AQAAAAEAACcQAAAAEFn2aJOipRCAZNzz/p0n+c9szk5jfR6OUJjP59w3L/PZl04CaAGCyvc67n9KJa7HBQ==", "2df88571-cad7-47bb-b7d7-be41144964bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37952295-d4e1-43b8-8474-9b65eabfde10", "AQAAAAEAACcQAAAAEBSqCPp4CYUYDG80N3i9tmoIaJu9A6udV9yI1bRoAlrbdmuwv96eHJPJRcVHNe3Q2A==", "444addf3-d273-44dd-b81b-e9bcf6afd593" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf731469-069c-430f-8b72-a047f29f904e", "AQAAAAEAACcQAAAAEBest+XWUSshAD/AH1BiIzY1out8ZiYfw0Ude/pF7WGYMQqM/28HJfnEzjOoHRGI7Q==", "50337efb-46c7-4237-8767-687c11fe4646" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22e790c2-4a8a-41c6-b79a-c5c20521deb7", "AQAAAAEAACcQAAAAEB+mWUZGUdCzYV5yhkw9SeEm23aGFfkhxqlntTmqS4we8ZrHfF0oRiQSaWa80w0FxA==", "275643b5-499b-4968-947a-eaf40356ea4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48c5c82b-7acd-48ed-b850-ec7a68c76191", "AQAAAAEAACcQAAAAEHMc9Jl0yIbWgyCdV5KDH9gKExFvqFCfp7lmHwPdG9qA1aOI2nvNkgJfte2FQ3+xBA==", "68e5ad53-f015-4406-94fb-9f7772e73893" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe195296-85c6-4361-ac5d-ab0baa461cbe", "AQAAAAEAACcQAAAAEE2w+7EPr2GLWmox0BJuQZ1TDBnruJmnItwUUk3DrKQAqNumA7wR9PrTPLrAUH5qLQ==", "b1752a9e-9809-428c-945a-36007b1d6ac5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfee2f43-8829-414f-8d60-f4f9b62f626d", "AQAAAAEAACcQAAAAEAJ3+QZO0BxkoOW/cTmR7uKuJND9EHDfyDGQzWSOqVYi1y1mkcB0zcJAkrDetGLLpw==", "be884c5d-026b-49fb-9e84-91f7fe6a0b5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "157588a5-d1e0-4001-98a4-984f41816d82", "AQAAAAEAACcQAAAAEPsHLQFILA3dyOTCO8ZHeXIhBhd/RIEBHyKVI2WKdnA3i5pT4BglBcm42JjEgPE6Fg==", "66b7bd0a-d09e-44e1-b567-3e9ac8ddffb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d09bc00-a584-4bb2-b1ba-c2dc8264a994", "AQAAAAEAACcQAAAAEMLHe6CjWCBWtVptKlbxpEB8nQF9RVFtgCenqdLu0RCDupeTPtVaOqoqppakgn59eA==", "ed07fea6-3bfc-4732-86d2-5fa1dcb8cb45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f4bbdf3-3d84-460c-bdb6-4254de79d410", "AQAAAAEAACcQAAAAEJc8mLIaa+1Bh+9vYWGgJqCkHGzhvnlZuj53//68XANPaArcXdhZMw/rJC7EYTZyRw==", "d8a0d316-5c12-4180-ac41-154dee78083d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac7101f9-ba0a-4c8f-b89e-85fdae4413d1", "AQAAAAEAACcQAAAAEJAsGMmlaDnxnjJ1pOi9lnILwwUz0d0Oz9LPoKj1Tx1oTT5i0Jlk8SvTkdU7znPNAg==", "3c1dc325-38b9-4b11-a25b-e0cf186a4de8" });

            migrationBuilder.CreateIndex(
                name: "IX_students_studentSubgroup",
                table: "students",
                column: "studentSubgroup");

            migrationBuilder.AddForeignKey(
                name: "FK_students_subgroups_studentSubgroup",
                table: "students",
                column: "studentSubgroup",
                principalTable: "subgroups",
                principalColumn: "subgroupId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_subgroups_studentSubgroup",
                table: "students");

            migrationBuilder.DropTable(
                name: "subgroups");

            migrationBuilder.DropIndex(
                name: "IX_students_studentSubgroup",
                table: "students");

            migrationBuilder.DropColumn(
                name: "studentSubgroup",
                table: "students");

            migrationBuilder.AddColumn<int>(
                name: "studentsCount",
                table: "labs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "lessonLabs",
                columns: table => new
                {
                    lessonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    labaDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    labaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lessonLabs", x => x.lessonId);
                    table.ForeignKey(
                        name: "FK_lessonLabs_labs_labaId",
                        column: x => x.labaId,
                        principalTable: "labs",
                        principalColumn: "labId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "3248e7cc-29a9-4071-aac8-d90af474916f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "f10a0d29-c787-4d75-9d0f-2c86855bc6a0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "eb103bcf-eee8-4c65-bbe5-260ed9805090");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "22fbfa22-8ded-4ed5-8d1e-6ae05cb95d93");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86525239-e220-4a38-b2ac-579c547e0d98", "AQAAAAEAACcQAAAAEJobhCC/LHKcYCBEe3A9yopQpcrdXY9yqj279ASlP2TR49syBwnk3Bc74He++3dPSw==", "9108fe4b-f2c3-4b3c-9655-db5a6f05a9f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf73fcec-1400-4ed7-a1c7-a4401ebd0f88", "AQAAAAEAACcQAAAAEKtoYEyZUTsG158icPGxxHZrzkqmm43SlLIV1DU6MwnI6c20Z0BSLOkB4fx/C0oZfA==", "bbc45d44-e4d9-41e9-ae9e-8dbc649f9cd7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14bdfb21-20e3-4e24-b9a3-039ebff4599e", "AQAAAAEAACcQAAAAELhpge7IMCYpkv99iZczcoSyLU8FaCaTsM1TFtTlxVH42mkyz3Vs5NGUuHn8ZfnM8w==", "f19238db-6a39-4240-ac15-7850b935ded2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "395ec009-d123-43b6-bd7c-ab9b90fa9d87", "AQAAAAEAACcQAAAAENSOdCIcj5JmXpYaRP4GheFoi4KU37wHRlKWJDzPf8gtl29D6xtsbkYg6LbwnxDSNg==", "ee2a38de-9224-4d80-8351-78b0183262b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f5faea1-2740-4402-8449-c377073a7fa7", "AQAAAAEAACcQAAAAEPKeNZ+PjkCQth5i5LGyil0tGNDoiG/J5Epdb/aq3m8r84cIy9m4zH8oKQP04E6Daw==", "d0ebb252-fc0c-4f89-82e6-c1f99c6cd5fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95697705-1b02-4e83-bf84-1f2640916241", "AQAAAAEAACcQAAAAEO9K1gOUTE5sUaRrsMCFEX8m/noQrwabyLKT3r+Ez9uGQs0HeexO9bpv1YQl7SCpPg==", "4afdc5d2-b1d5-410f-ad3e-f2471a138604" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2517bb07-63ca-40e7-bf99-787e1337e44a", "AQAAAAEAACcQAAAAEGyXcg+tuppSb/ZqWZUcIppy8YovAGH15GAcbxrI/RsreNicJHw0rC6tPrtDzG2vqA==", "a90e8316-d92b-4971-924f-7e785aa7f6ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7dc3247-60b1-4e3a-ade3-9284d4a69bd3", "AQAAAAEAACcQAAAAEKDDhbsLr12XGPAb0FQaS2hpJpg0WBehYXOZbyKvsJ5IB5q0jQ6pz54zmX1HrndloA==", "91fe19c3-a67a-4427-aaca-8a756b5e077c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8628fcf9-9595-429e-bbd5-b4019b94eb91", "AQAAAAEAACcQAAAAEJnsXFx3Xbcr+P/xcQn0dMtBRqh8A8V5bYrWzp0BUdsZwONfaE6Of6SZ7Rwg9+JxqA==", "59b21c3d-1c15-40e5-8a7c-3c70548c36e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2823e7a8-8356-4eba-bbda-0afd2756f871", "AQAAAAEAACcQAAAAEGJ7qqC+QcSAKqG0BVgeKWciWf+9WrSHMc82DKBblC9ykQNknfLIQgz9SU73I0ySFw==", "42a4fc93-0049-43d1-a600-df80711aa99f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5015e43b-244b-4822-857f-006cb172d40f", "AQAAAAEAACcQAAAAENWFqVhY/mrpkVJwjrGLI0QUyu/HKoy30VOVkdc3EMhQaesIl6p1LG4WdiI0z9LoVA==", "3ab2a65e-4463-4bbc-95c3-436c186efb89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47e1b7a0-410b-4b84-acfc-6a78ce1d4714", "AQAAAAEAACcQAAAAECcL8xFMz4IGGafJqRpLAxqkyHYYjpAbm+dLiFpjKZ9ngzOYwr/dI8MpK/OsFsR9KQ==", "38a8d77f-b0f5-4a76-8135-c6f72a63998e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e4adf57-e0ff-4e2d-99b1-25aa0ae29bf8", "AQAAAAEAACcQAAAAEF7YbwYgAAm2kBNloPInLRRCWFEClZt2Tyq2dU+SDRe3Ap7sXdjZ947ZAgWaJ+nnoQ==", "1d10554d-bc23-4869-a148-16bc7939ebc9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be1bbf13-4b6b-4f8a-b326-541d083ea418", "AQAAAAEAACcQAAAAEKMLlkG/vaKzaU/Jy+0fm6cvAdEIRtbhqWoVlZ1df9XT6bqoWOnZ4NHmccjGNL3BQg==", "b40f5686-27be-4204-8f35-4906f79df37f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8f01418-3d66-43c9-96b1-4940bc2553f3", "AQAAAAEAACcQAAAAEHX+LkJPf/ficgGX8vda1XluBeWRQXvLYQBeciZvOLdu+HJ1is0kcQ/Z6832d7MR6A==", "2b035bec-d675-4198-b8e7-70219c332e22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fef751a-143d-4bfb-84b4-500fe2361904", "AQAAAAEAACcQAAAAEGwF7NEOpedoVZtEeQaoAf0KzkD6ckMY2AAxImcTtfEZoXD6wFKdkIHh7v9VBZ3Tnw==", "5ddfcfff-49d4-4fb4-bb5b-8f09da1d83ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2745610f-d46f-47db-8ff1-c39b71c101be", "AQAAAAEAACcQAAAAEEAWvbC7cuW34qhnB5aDS7xdkL9oqirHtIyCW9nvxpG912N8FHQfndBbBi/rMdUFIw==", "2496b5a8-ebcd-4f04-85b9-63519fc7e9f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89cb5030-455d-4036-ba11-47bd11c2901c", "AQAAAAEAACcQAAAAEJBO+VjCHw2LO1IDhoaO2AwR6JY7SZ1XY0TQEQE0VcKRCPPZJ3fbrIboS3ua4gUDzQ==", "bc6da548-de88-48de-a2e0-bcb45204f000" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1c85ff1-8a41-4632-99e9-fc782a159b5e", "AQAAAAEAACcQAAAAEIEeBuFHpHbwYlxkt7FXbVeg5vttsVcJGTgY2rQRV00uu7j/g+GUEmjJBGK7uwXoHg==", "52d62d53-08b1-4a57-accc-1a8bb8ee119c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d50fd0d-49be-450a-bd70-41780f5c478c", "AQAAAAEAACcQAAAAEEfN24EOv3EbECflFEEafWmFlrJ8qfRev7/tEgld4VOtnOF8zJt/Mo3PnXsv4bt55w==", "9feabf71-d4ca-4ced-81f5-97918bca2611" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75cb396e-08fa-4a2e-a3f2-9a42edb7d286", "AQAAAAEAACcQAAAAEOazj8qDeqow/mflO+Im2qJUh9Za6fFid81FG/uClkYYy9U4k0eWO0pxsUnMZHa7/w==", "7c8b0477-a396-44d4-a09f-0a25efaf1777" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32744f9d-899e-4596-9029-dbc3740c14e0", "AQAAAAEAACcQAAAAEO4yZPL4udR/UjNspywQ4MX3nB+njEhpymkQFFQaswoE82Y1Lo39XqNDdNI+eoQDCQ==", "b6f28998-e6f4-4d16-b50c-99d57ab3633a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a79b005-040e-4667-a193-99887ea28492", "AQAAAAEAACcQAAAAENbKUBIWoKtYnQpmtx7PG9UC/TG3BbdW3TbmliJyINw1LycWCmAV9DOg79RiVPzmfQ==", "4200a449-5450-4af6-8463-fc05af2ea321" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2e98515-ff54-4172-beff-2b62d0b513f1", "AQAAAAEAACcQAAAAEFdE6XUsPy+7/ZHudf2ABH4+agZIIAwNYBwhRCVf33BN8yjTNfGv8/dVkYhnDFA/Zg==", "ee521f4a-3570-4423-98a5-e96a75a78871" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a968a712-8854-4a53-bff8-a188074ff21c", "AQAAAAEAACcQAAAAEEbUJCGH/l9GLY1W6Z4awYhH071XrPcgtqFvT2lgoImnLIKNyGa6KssEuj2bLsF6uQ==", "a55a66ef-68fd-458d-b912-696f4c30aed7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "335eb2c2-e477-4404-ac4d-71dd743d2e7e", "AQAAAAEAACcQAAAAEI+hBeub1tAuu0M1XJVOjRJKpqJy5S8QwPL+YwhMpUe5biasRCbtlUpAvTDOpYCvJQ==", "b57c9da4-ddad-4b31-a86f-0ea1ade755f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ca1662f-57c7-42bf-9c99-66fec3693d46", "AQAAAAEAACcQAAAAENk0As2N5cXDAjm1s5fq0YrIEeNgcmBQxlhAl8K8QHlaR3iEX/qlTizw6lmPICGpjQ==", "592aff9a-1722-48d9-a8f6-bae8f3244479" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f12163b-f99a-417a-9e02-1cb5f3a19154", "AQAAAAEAACcQAAAAEALzFjouLPY+Mmizf5kh8E/5WC0nrD0d9HFcKKYtD0fql/1xf5Hxcg80W4IQCqBUXQ==", "553cd38a-c890-4eb8-9e3d-c7f3a0d1a201" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c183b221-67c4-4d15-8655-4170a88a1a01", "AQAAAAEAACcQAAAAENMZZjse+BCpzTd7Ghce47bUEc7rJ5IajyBY/hj67nK9RDLQuu18JZXsb9PjdBIfNg==", "f9492dd6-0da7-4fde-946d-51c8e6392a51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33018467-0866-4d7f-849a-fed019f013ff", "AQAAAAEAACcQAAAAEOWdLlhx79qdOdu6edR9JpTrJ/CQnbRhcKDEaFIWHKaMBhD3IfUqC5xrQ8KEE7CWwA==", "96147254-dd98-42ec-9e02-a71380c57ff6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67c62c4c-88f8-4e45-8e7a-8711ac5e044a", "AQAAAAEAACcQAAAAECt9iERqXam5rsIi7a/V+nEBe+RkydQgQ+JPYPTJkoj+mjeLtO9+2l8spjEe7QdtKQ==", "ab9e5fb8-b2bc-4db7-8e49-a3d6151a42c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "502a3f1a-3314-4a0a-ac76-867e5acbbf11", "AQAAAAEAACcQAAAAENutql2HwDNh3vaFcQEKRuLXgWuYxY8DR7vFu6OKbzLvBTMxVI1pfSvIodgIN1JHyA==", "119182c7-8ec6-4e48-8c9a-e6c0d2ac582e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1af3aa2-72f7-4d38-8992-22cb626be9f4", "AQAAAAEAACcQAAAAEEonNH0aMYcnV0SwWaq83xe1lIgQCoUNIrqr3EsjC718kDNj8DgDvuic0IEg6lvKZQ==", "e5487759-8ace-4f6e-b727-83ba5f57dd1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59aa7fd2-90d1-4a31-a258-4fa3d1abf894", "AQAAAAEAACcQAAAAEHV8ePCHAp8/MPJgowsWg+BYbsNWZwz/W7oK71uNJfniDS25vzhJlhu3GbTyt2x1aQ==", "2b75b516-bc2c-481d-becb-8f95c0cf3046" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22a31878-2dc7-4eed-b8aa-b6b709aa11bb", "AQAAAAEAACcQAAAAEMmiWCcYYYc1MFTRSZET3IV4EloCnVXVY/3nVjsucYRC/Q+JBMJwLmDjnTLBMhTCew==", "79ef5690-4d3f-441b-9dc5-355ac8224011" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d60ef43-7700-440b-b140-06d235ae03f2", "AQAAAAEAACcQAAAAEIF7dzIJXRZcoWuQxkdsRQ8eaukZ9I4rCqOyeQGqdL0dE1MWzWbGOn7sWE8N06kQFQ==", "c9026b81-60bb-4864-9441-d19733cd73e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0aa9637e-949a-4435-ba55-0634d0939a2b", "AQAAAAEAACcQAAAAECrdwZefNZqyAbXDe1FH84TijxBYdGbBUoU9wLQ1YWUzbaP/snYAbBNFBl5Kxz/IhA==", "536f1ea3-7f84-4b5b-a038-6fe7ec8269e6" });

            migrationBuilder.CreateIndex(
                name: "IX_lessonLabs_labaId",
                table: "lessonLabs",
                column: "labaId");
        }
    }
}
