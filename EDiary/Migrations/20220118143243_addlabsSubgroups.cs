using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class addlabsSubgroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_labs_teachers_teacherId",
                table: "labs");

            migrationBuilder.DropIndex(
                name: "IX_labs_teacherId",
                table: "labs");

            migrationBuilder.DropColumn(
                name: "teacherId",
                table: "labs");

            migrationBuilder.CreateTable(
                name: "labsSubgroups",
                columns: table => new
                {
                    labSubgroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    labId = table.Column<int>(type: "int", nullable: false),
                    subgroupId = table.Column<int>(type: "int", nullable: false),
                    teacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_labsSubgroups", x => x.labSubgroupId);
                    table.ForeignKey(
                        name: "FK_labsSubgroups_labs_labId",
                        column: x => x.labId,
                        principalTable: "labs",
                        principalColumn: "labId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_labsSubgroups_subgroups_subgroupId",
                        column: x => x.subgroupId,
                        principalTable: "subgroups",
                        principalColumn: "subgroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_labsSubgroups_teachers_teacherId",
                        column: x => x.teacherId,
                        principalTable: "teachers",
                        principalColumn: "teacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "83f632a2-d822-44c5-ba78-c168bf75cf04");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "94440ee2-f402-4672-bb13-b096546a9623");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "bba67196-1a77-4ec4-8c1b-13b837807d89");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "bb18c331-23c4-42cf-ba26-a1b1a5bb7113");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80ae9ff5-4a59-487e-963c-2ec1a58591d3", "AQAAAAEAACcQAAAAEKEyTMBuNc71lHB2aMlnQrT6u5wE/vjwFlKyuF4ENOq9gjdw9o4SH3H1B8iOy58EZg==", "386a2dd7-5381-4395-b179-9a62727f7478" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97dc0b82-906a-43ad-a40d-cd2ea1210861", "AQAAAAEAACcQAAAAEH0sGtpP1u64+ghPfcbUYi5XsWzYyUzqaxD5sTwDDcChFtiUNVtUFlsrpKquUOZZZw==", "beb8dbff-9846-480f-8acb-8a644271d01c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb85411a-2807-4492-a409-462f49e0d65a", "AQAAAAEAACcQAAAAEJSR1JToMe2RjBmY2rwPTmL0ucMKh/efDoB3IGCD9th9mtt03DATbGwUHEkcGCcBVg==", "8b36c888-dc51-44ce-96db-3b58c1b8c778" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37027afc-dd6d-4fe3-b0b5-77c73dd93196", "AQAAAAEAACcQAAAAEHMNybBCxcHXmhRuLJcOEj2eS5F+FXCst/1ZyZjQ6Dt2uP+H3J8HvYAlAHYJwLfbzg==", "5b1c6bd4-6ab8-4fb8-9559-61766b8d40c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c32ef6c6-177a-4ffd-bc4a-5f6acf87b6d5", "AQAAAAEAACcQAAAAEFT33xzJVj7cvIeGdtFA6bAi8tXFv+ZaOkvIZuq3kgPycwLDJHFcbjFtpEBsVftvQw==", "09229d6a-1427-4f6b-92ca-c32324338add" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a5d817f-5ede-4a5a-9651-b9c47198fb91", "AQAAAAEAACcQAAAAEK+WHnq9RDYefBf07X4CDoMRHLjRx9ZjtiQRji/+X/C3lbPvkzHHzMwYP4S15VzQmA==", "090b7077-2d98-4abc-b4be-d5bc111b6492" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55001a23-aa9f-4e11-a221-6e34cf2f00fd", "AQAAAAEAACcQAAAAEAeRym1tJzFVBm8UF3JqjlatC8Z+BaLFPY+u+8cL9hZGyY9BcWtR1CHV+nNLlfTeoQ==", "757066c1-621d-48eb-a646-6e0b05ad1a99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4e76be4-14c4-43c7-8e77-e45fbfc272b2", "AQAAAAEAACcQAAAAEL5aWp2LFOPpq1ygd1GtH6w6F3+28OJFVEx/AZ3L2lCwFA+/7v2Y5Q01u8FldcTWfg==", "f7fe31e5-182a-409c-8317-8394c7620375" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6babdb0b-e575-4a4f-a7f0-b98f57cb560c", "AQAAAAEAACcQAAAAEBOlogzghqQ5+vQlXR8d7J0tWXQKJNllMQ852Zt59nsILN4VvNizc2gYKGWJ59d4rw==", "04fa3124-30fa-4b34-9915-7c5dfd68b234" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8ea12bb-9492-444e-a4dd-e9f08c44767b", "AQAAAAEAACcQAAAAELQ0InpxndBsipVxYg00ttqGHWsAMN2RiysxfC7+UM0WFT//1sBs0WCwGsOiEdOl+Q==", "fc0a9f85-5b9a-4a24-a694-e9d3868ab824" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1bea0d2-3e25-423c-9729-e35fb825d4d2", "AQAAAAEAACcQAAAAEGiiOY63JNOqY2ElzSJSS+gNFypfpKU7sg6oNav8OyTxPuWQL372k3bC93BRI6Et1w==", "d3f7c9a5-f25d-4252-87bb-4cf57d91a4d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef7bfc66-04cb-40c7-bcc4-df306d01fc2f", "AQAAAAEAACcQAAAAEPKoFBzieroF3FA7RJfY9UtVSdU0Us2/eqCfjBoSNdahrFj3kvcI+9nAQ4JV1N11nQ==", "57d31585-1ddb-46b9-a78c-07c8f8b5920c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ebd16d0-25ef-45a6-8c6f-51568b228a73", "AQAAAAEAACcQAAAAEIRBd4Al0Qp69yiMrNY1xsnI11L8cVTDRKm+dJ/RAMQmgAHqqBlGkpaUwyTCPUjPqw==", "29ae99b7-5a8b-46f8-bb06-e28ae919bb54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c202c989-fe5d-49c0-89c1-7382b82fcbc5", "AQAAAAEAACcQAAAAEGQXZV5jj3UUsvn8IvkmB9ggKSKOxrc6ea3WEdI2ZeDT/r1JbMOEaUL7JfLgLEcLyg==", "1fc59582-8eb7-40b8-bc88-3fe9a7b1da10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43107145-3140-435d-85a0-0b63c912b3e0", "AQAAAAEAACcQAAAAEAmU6VGckqaXoE9Y0TSld4Q0AwNsU3fwaQaZViij8cgKTMtOjmO6cBmTP50bPJC1Rg==", "c32cc95e-0f19-49aa-a2d5-62a1f294a76b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a19b1631-e50f-4a7d-ad82-173dbba6dfb5", "AQAAAAEAACcQAAAAEOkIkj4pLxH3stG4IarCBYz7gDVCVGp6/Oh5omn79+WlVrqPCiVGOLkaVsPLtWjTBw==", "7c2f95c5-84c7-4001-a804-1488c057e76f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a704f30-8417-4fff-8d5e-ded29535939f", "AQAAAAEAACcQAAAAELR0b271TInBq62WsTy4naez+WZvzS/hBAg1h4rmGRRT2qT8wkUa2fcBoQJq3anqUw==", "a0b478f5-dbcb-4d1c-98e2-273b44465920" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad192de5-14f9-4858-b2f0-aea1a78e41bb", "AQAAAAEAACcQAAAAEMYPmP2fh/LuglJmPcJwtELS3UXbq+O9SqbyNJ1kyVPnOvxCz74zyMfFETUa3Mstbg==", "688b9fdd-849b-43cf-9921-af85be4f408d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0356f754-eec8-4e5a-b38c-f163cba398ef", "AQAAAAEAACcQAAAAEMtjXwwHa8hf7OaCfGhRH4fn4QNLG6liuhUxrNe72GCIA/Y8wDGN8YkwBbGtFpdb7g==", "591bbdc1-fc00-4f3e-97a2-832f4e611020" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f1c99e8-c086-49d1-9820-8c7c81508db7", "AQAAAAEAACcQAAAAEGwu+w4O4vf2beK1t7P2xnuS4A1K/ZpT3gHgorxOZ0CMhEvOGtUYcmTIPH6LErWK6A==", "7b8c9f3d-084d-4340-921b-a36f0a026316" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52b661e9-a2bc-477e-9c9a-99f8c83a207e", "AQAAAAEAACcQAAAAEPDBB0n9PGFwwg4EDhwQWjyLmCR1V3yLRGnTZ3kL3j/caPzFLc2K0nptp6gPM0Su8w==", "be78c97c-23f1-4942-a281-66792d03ca1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65c254a4-5964-4589-b99e-e855f5b3fcaf", "AQAAAAEAACcQAAAAED8yQztvKRFBYl2GfJknjJDgdaitF/oWiRL3KDQcr/LfDoKPz5uE0HgcmY6c3kDUrA==", "e8d43879-7293-44d5-8323-edb1aaf1d850" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f29d9121-53f8-4616-8c2d-0b359d69a49d", "AQAAAAEAACcQAAAAEPTeUA9mOO2dEBWw/6U+C1B0umfr4C/pfmXbQtcGNDQXlciN/BSKyiD1v1Hv18yk1Q==", "24385c66-78c8-4bcb-bcf7-7cdbcaf0beb0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "608a28c2-b503-4838-9371-c755cbaee17a", "AQAAAAEAACcQAAAAEGfoHUgPW50sNAKkCpItw1ex2544rXIrIjkfHU1nePlfseViOrI0YOZb0G99bdT2TA==", "d042f8ab-8ba3-4bca-886e-9808f91681d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29e2822f-c8c2-4aa0-ad5c-1abbbe839ccf", "AQAAAAEAACcQAAAAEFzx1l9Tdykrw/FvWtmQLxPG0Fir6i8DieXm0Z6MgPpPsLB9iUuRM5T/g7S5u7Ktnw==", "5061617d-4cca-467c-b606-05baaa257f53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d427acaa-9cf6-4351-ac50-8fdfd21b9b33", "AQAAAAEAACcQAAAAELRlOMG5xq/RJzJ5ynrURQ9ud4gL8eFoCtK/b8uHdX9ncryH0o2c97kVZ/hR211Qaw==", "e11b6771-ef9f-46cf-ab8a-dc1999ccb8f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48cab279-8988-49e9-b80b-c36fe7b286b6", "AQAAAAEAACcQAAAAEMl6rq/k6jn5ixy0YjQDCwV+KNU55SU4Rp4UdLIzraVbtb9VTpeQv4tURAVCUeU8gQ==", "22113941-0e59-4e83-b0ae-7af8d0a57930" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54b84307-1c6f-4bd9-b315-a38f288acf4c", "AQAAAAEAACcQAAAAEGEJU8OdsLgo3x/LLBCnEY64kXhE+iQjd1a8sXn1eYh3STuub2McUZdlUrBsa+FJlg==", "5818a6ab-db5a-4eb7-ae46-ba3749755f83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd7bbad9-dfbd-4cc4-9095-4eac2eeec2ca", "AQAAAAEAACcQAAAAEAKhOXYmVHZxqogms7tbPU805SQor5+R8Vu+kTW6BEf0Aa3OGdK5APdKx7VFMiGDWQ==", "cb0bfb58-ce74-46e7-b3f1-b9eff23171f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "862bb8fb-faf6-48d9-b569-ec5cff424eec", "AQAAAAEAACcQAAAAEPsaHBcf5rZYsgu3TZSSn4p2SmeN+lUNn4tlHW1aNKZQ1iYZGNnGizN+f9soA8GyKw==", "ff33c8e9-8e1b-4d48-a66b-b75ea9200e7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d2b2466-3a0d-427f-8259-23f36604204b", "AQAAAAEAACcQAAAAEOm2Ud1rHk17fmyFhs+bNBa6yds01qGlVzRXJeTTGfDnPD+iGoTt+PNUokRP2kbwbA==", "87f0a944-b02b-4b5a-a8df-c1b924e24a80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87ff49e5-7cc2-47c6-b68b-bb632c671e3c", "AQAAAAEAACcQAAAAEFdGAYj8EjZwW/Kljwgi1OfDitrkE1v77zOCboLSsaPkbTouZxeZHSMxjXK7RubwcQ==", "7c73b56b-e93b-43ac-93a6-ce32f1c258b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "187e48ac-da98-4963-b094-7da19533c0fd", "AQAAAAEAACcQAAAAENqyBi1hOhQJ57+64l5Xh+w96RpxGwcGerFDTEg7+CFgGPGVbHZcE2hFrHKS9hSTpg==", "eff6fb0f-0489-4e83-a45f-82f444ff79e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "178e60bc-1fbe-4b55-9451-643022693f9e", "AQAAAAEAACcQAAAAEEXEmNo6deSMmNN418aVTzNs2mkvfrAvKvDfFKPjOtaw3QC6dux4Eq2SRk5buxH0/g==", "c03d7706-fa3d-45b8-a53a-02f92cc6de48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c84e3efc-35c0-4f6b-a693-96420773c891", "AQAAAAEAACcQAAAAEKcJ1ldE0UTIKH4dGdhtKTzMFfSbIf3SSS7iXf3suYDJpxkmSzmsRa5ULRouYqCkwA==", "df9ce113-8031-4514-86d8-f6f1b21274df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b1110a6-bbb8-4ed8-9d5c-3482356572cd", "AQAAAAEAACcQAAAAEBhGwBaa67LMRcNhjlnXyEIjsDqrdpmnnbrXBdN0jATqDscJ0Ka1wHoIA5zSVGugFw==", "22e2db5e-e581-4a0f-8777-c808fc575f67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56b59d5d-b3bb-48f0-87a4-eb04c20154c5", "AQAAAAEAACcQAAAAELqKYxszg6krZgHpXhO+NjnQESRMYwMHXqpLGTlujyAqHPpmaI6mqARoVLcgmYctPw==", "98bce002-dd39-462a-a88a-a52a30b0689a" });

            migrationBuilder.CreateIndex(
                name: "IX_labsSubgroups_labId",
                table: "labsSubgroups",
                column: "labId");

            migrationBuilder.CreateIndex(
                name: "IX_labsSubgroups_subgroupId",
                table: "labsSubgroups",
                column: "subgroupId");

            migrationBuilder.CreateIndex(
                name: "IX_labsSubgroups_teacherId",
                table: "labsSubgroups",
                column: "teacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "labsSubgroups");

            migrationBuilder.AddColumn<int>(
                name: "teacherId",
                table: "labs",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                name: "IX_labs_teacherId",
                table: "labs",
                column: "teacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_labs_teachers_teacherId",
                table: "labs",
                column: "teacherId",
                principalTable: "teachers",
                principalColumn: "teacherId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
