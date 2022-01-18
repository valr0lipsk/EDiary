using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class addLessonLabs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "lessonLabs",
                columns: table => new
                {
                    lessonLabaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    labsDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    subgroupLabId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lessonLabs", x => x.lessonLabaId);
                    table.ForeignKey(
                        name: "FK_lessonLabs_labsSubgroups_subgroupLabId",
                        column: x => x.subgroupLabId,
                        principalTable: "labsSubgroups",
                        principalColumn: "labSubgroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "43ec252e-719a-4519-89b2-7f8dd720bb0f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "1a4baea4-52ba-4142-81e9-5767f74b43e7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "8e0d5b88-4604-4cd7-9ad4-4b937c04a527");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "6ac35026-1dac-4464-8553-beb218730a47");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6edaa3e6-1787-4018-a0c7-580865308592", "AQAAAAEAACcQAAAAEIUHafngnoCRvKwq6ajYR20wpI2R0LqL6kggFVlfDJp9P2wWDdBCxHj+6QqaNYF5ow==", "039f84dc-f66a-48b9-ae84-e16e62795e0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49000e03-2adf-438c-829d-f90cee9e50e5", "AQAAAAEAACcQAAAAEC6cubXS0PCZC5GKNneLITfVnaPyhCCho6FV+HQQ5zRbkfq4F4THa5LytvaVN62HFg==", "21162e12-1992-40e5-b961-af148cafa0cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd306846-a5ff-49c3-921c-5f8a73532eae", "AQAAAAEAACcQAAAAEFpNROI1zN7Mf5UcNzl1tZex3FRDvA4aEnZzUaroEbB54T/SZu9kISHHq4GSmZeUhA==", "2b50f12b-a86a-4c5e-b22b-878d7b2cadcf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87b04d1a-6639-479f-aa5b-1d60d117abe8", "AQAAAAEAACcQAAAAEBXmZjHncXLSViW7keKSYL06U+Zy9qHzRDt3yUL3Id4VPhdfnUzCvwe3ABnIyoD3iw==", "ce425399-762b-480a-952b-5657b6f2d46b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c706c45-8454-4abe-90dd-9dc427181bd4", "AQAAAAEAACcQAAAAEOHVeZsBqPX8dlUnxLZ5a1iKUGwmrxqC+xMK/8fRsK2zeacILoS7IFauwPOFUL4IYw==", "076832e0-3b19-47c2-8dfc-41394d9e2d2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0395985-57c3-426f-90f0-64eee5ef3de4", "AQAAAAEAACcQAAAAEIqW7qmoe8bEr7MQkQGkSzz2XRrFvL+P8o9znS28fVa/7VGkAi3b1WlT6B/Az8JwGw==", "690bfd57-4946-474c-af9e-a9c23d33bc04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d08fb488-106f-4272-8951-7ff8277046b9", "AQAAAAEAACcQAAAAENTHCNSCuXj4zQk7FNLvfj4euFTTiDDtF2xJkXER2rX+a7j7i5kyraEXl3yOZWvS1w==", "26b614c6-51c7-4034-abb6-fc8a3ab58232" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27513e86-77d0-4ae5-b6a4-7674d59c9d3d", "AQAAAAEAACcQAAAAEDGIwCLIp5FJOvZStAD+uePj37rIuikJ/MSFLtuEZax0VKNq65JapbHa2Ykue1p7/g==", "9d249fc7-fbbc-4b7c-917f-e1498b3cba11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0b01138-9d9a-477b-99c0-9c5d9dc76d14", "AQAAAAEAACcQAAAAEDeZhM89Bxalhw1ceexkA1P81o/SwDk4pYKf82LO6dsCAbDzo1W1ydQHO9UqSE/EhA==", "6aa31e49-44ae-41ed-bf4e-a88fd69f5b8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f82517b-c73d-4f63-83da-cbae2952b5d5", "AQAAAAEAACcQAAAAEE7z4Euc5WBiNJjSWY6FR9+gyEZ6df8l/8F+wtxJ4mIRBUzVhLnAu9zAbTLibGAlzQ==", "52389418-5867-469b-bf9a-b8f27b534ce5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ddc607b0-d480-4aa7-9f69-c73f40095a27", "AQAAAAEAACcQAAAAELB0T8BLlmNRaZCgr1zxPvnN6klAbz+q1KogLVbKvTQDGxrCFuXwNidG0HqUS4QKnQ==", "642201e8-4f3b-49b3-b9c7-63d7d91e8f46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3be7f118-fbb8-439b-9fe1-8de618ac6d07", "AQAAAAEAACcQAAAAEOCIK9J3yjqWOcfzJVp0LKQcjrotZNGXTXtvafYz7Ne2xa0IAjzAyLiLT5kwApIUVg==", "10338193-237e-4363-91b2-4f47f4c2c010" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec8c21e1-a192-4b44-bc6a-d86f0c86cef6", "AQAAAAEAACcQAAAAELN8+vjLAP3efNOO3i2fCnWNsVUAxL+vtqLTPyIy8uU88h4RcZNDsuhPqKMw7Hg6bA==", "37729554-0ef5-4f19-acb2-f8286d3b601f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e72e08fe-af72-4531-9f64-30b2b48d04dd", "AQAAAAEAACcQAAAAEMJR/hotkRtRwf5S3hLQgIHfxa9GeoHccv2msGewg0UcFU8fQHoQsLCpAmLT7vVLOQ==", "5236d53e-44dc-49dd-9bdb-088549ec488a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe9a729a-a969-4001-be82-1c20c9893a50", "AQAAAAEAACcQAAAAEKOf022AjT1A5kvGkvdF1hZQ7T8zjAZmT85QOw3ysuZ5hnKRkh49TjmdEtSd8WM/dg==", "11a63288-cf81-4e61-a69e-4a83c33efbf6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b62d25a-4fb5-42ab-aa11-7dc90fb6d7b8", "AQAAAAEAACcQAAAAEHqBIVGx/DzSGrBZVGW5Y2MdguZ+sVKoOTa+wZYUlNDmG6vLabfdnJb97IweyNJ3xg==", "08e0ea9b-a89c-4fad-8050-329a9d8dd806" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0fbf611-7e40-4530-8a0e-652c0e9cb04f", "AQAAAAEAACcQAAAAEKx5Q8+AnNN4VW2nwz2ll0vVC0L1ocWlAychP0VDfIWz9CaqMzbOKwBAiEN/HbzoMA==", "ca4b534a-f07e-4d71-b7f0-d6afdbbf917d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f0c447a-99cb-49a7-be31-08a90b1ec003", "AQAAAAEAACcQAAAAEBSneGMttngTdQ12WwMcJQ0F5EkSXtQRu5O+Qzmu17f4gZFsvzOXxBRn6MqW2Ilpew==", "ff4c6668-e435-4661-8294-4b66e34c31dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5375226f-5fa5-4782-810a-151ce86fca6f", "AQAAAAEAACcQAAAAEBD6PtqIg5OsK74rHP92Civ4owzbfBalFwKywcg08Nev5gYG+4bBykLvHXNciNzMog==", "1daec10c-82c0-4ad2-b984-9739db05fd1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c3c0859-5714-4630-926a-5870f6bdecf7", "AQAAAAEAACcQAAAAEPxzoBi046eJ5xENMCX7xO0qddwNPP5wMs+KJT7MPhBf+QwcH/BswAzEwPv7UGfGUQ==", "68299783-9158-422b-99c5-4f3295d4868b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f628bae-31b1-489f-a3cd-dbe5f392955c", "AQAAAAEAACcQAAAAENdKR89W53AFlY7fTbzDFgfc8l8chLsrn0huR/uwUTr5NzOfPBqUYUp7m1EDgIJ/ug==", "7c98aff5-548a-4651-9481-f2dd5b628cce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3c8b633-e4eb-4358-826f-2da9c6fa7897", "AQAAAAEAACcQAAAAEO7yJjzP1yNCJlYaB6KXjipKhneqeragKfg5agpM+SA0o1s5iQM2auPxF1PM3y0DVw==", "14622696-348b-470d-b3df-a90fab462dd1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37498521-5740-4b88-8c9d-6a3c9adcf557", "AQAAAAEAACcQAAAAEG1Tg+YNpB5sfvo9BErKGhskrKwdVEX5g6MZDjAdjaN1JhmiH9axznExR/6lE1QmNw==", "1d4b1b01-943b-4fff-a71a-915029bf49bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66fc20f0-a3ca-40e0-9333-5233b8d1d631", "AQAAAAEAACcQAAAAEDuGhar09KZTExA67JtNGCq+2A0ZccDmTj1zSmL2RrKQs3VwpqQmR2BxVL/9GzN4eg==", "789cb30d-989f-41a3-94b1-d033103ee12b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fdf2050-4ae0-4259-9261-63975c0abb8b", "AQAAAAEAACcQAAAAELx/w7SKXvTV7XgX7/c26eZFoPMcyKmYxeqO5o2tcHexc7yFvVSgaDquAYCNmru5HA==", "fa4399a4-d34c-4a36-9d4f-068d708c0149" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db3cbe50-94c7-415d-afc5-af98d5918bf4", "AQAAAAEAACcQAAAAEJV7Su4jNABFiNz4JOMjbu5E5qApAnR/otNXQx/mvbGitX76Z6Ip7BKRKOCHBzqs9A==", "08ce72d6-88ed-4d17-91d8-ae9b5820b135" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff4ae7b8-8f2b-4a43-b6ff-730dbb7be6ca", "AQAAAAEAACcQAAAAEOjuqcwkBPxp+wMjoAUq6Wm1mdJ96I2NmLCI3JqAEdxroYyyvuEV37wPRmjNotG01Q==", "2e5d12b5-ee83-4cb9-9d6f-e6f3c3ad90c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f5fe9a8-fc35-4c8a-a825-feacdf3e5e53", "AQAAAAEAACcQAAAAELEOfej9mbOccuBd2bt/fblXBPtdkcipTsTgPEnk/cEL1u2+8ws5/YvxV4oxETI5aQ==", "e8637f50-0d5a-4186-b212-6a2c5feaeb56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97a2c661-ddfc-49aa-8b3a-5adcc6c68c3c", "AQAAAAEAACcQAAAAENo4p9clmnFMz1UNnFWrHpREe9x2zeo24Z40QYEfYgBuTNb6Mdq2ibvn+e0c+i/mCA==", "42465e5e-8eb5-4aca-a950-b29cb5257450" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c372f8a-ddaa-45e6-bff6-b89bbdc66090", "AQAAAAEAACcQAAAAEJgLv5P8ZI2WD/LVk7bD7PoTb2KMka1mEczcJPEatDLC5TwB++2BFEIONenYniDOmQ==", "f15ecfde-3b9d-4d67-904d-9acc24e10a2d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73d3c896-c811-4deb-8f7b-39dc4cd2daba", "AQAAAAEAACcQAAAAEIz+enaVEUorP+hKnztizSyp+DiWitHWfBb1oSdaZgJyg96pmr2yZAE/i+AF4Yw9bQ==", "fc036d6c-330b-4971-a756-264f1395ec3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa2defd5-7733-4ebf-a887-2c75b46c29b1", "AQAAAAEAACcQAAAAEEk3B88+ZODBMEYPLy/bUrxWXBC/ZSPLnuAeS4/sRge1fDWCKG0cpbnFx7RUrUpzeA==", "2dd4bd6a-95d9-4c77-84f2-453a43e608c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d63a6b4-0ed7-4e8a-b92e-a2e9780edb91", "AQAAAAEAACcQAAAAEMdAZNDj7EecPWMdGaLr614nKoNsr87/BTBHLu1ASpmIm0ZG2OchkpkA0UkiT7899w==", "811af58e-d042-44f4-bc09-026b397a88e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dec05b1-13fc-440d-a4b2-31e7e3fabc21", "AQAAAAEAACcQAAAAEHbDYSlhRZRPeInFhcvs51bYEzW+kKtyU6A2Z9EL6SlvvBv03+j+PshWCV6X1BJCyg==", "1aecfb53-2b7a-47f2-9bbd-91b58f68dbbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb5c77d7-0497-4ef9-8e88-ae2c216dd698", "AQAAAAEAACcQAAAAEIIAPxglFw6hwPfLik5NW8l/Oz6caiobjOl8tzC6h2UOPy81zH8byUtlYq752RCgHg==", "19537d4e-187b-4061-bb0a-4f7f14cb9c5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d0a5280-856d-429f-8c93-258b96f4dfa2", "AQAAAAEAACcQAAAAEPrkU++nMe9RB3g+8jF0PuJAohDnlf19WWX9q27kc2TNxdKZJsZyjaFdnwzhv+K5pg==", "68a6fac1-be4e-47fe-bd32-8f140c68e2f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3506d33-f4c3-4038-b9d2-170087aa9856", "AQAAAAEAACcQAAAAECsQ9pCu6X9l0GkcKnHsjbQ1DGHutlaE/OlNdnE/xMQz0D4hFOpPHsI6MgugNZBg0g==", "eb4f4a21-4e1b-4eb6-9b4d-e3202c8f2f0a" });

            migrationBuilder.CreateIndex(
                name: "IX_lessonLabs_subgroupLabId",
                table: "lessonLabs",
                column: "subgroupLabId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lessonLabs");

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
        }
    }
}
