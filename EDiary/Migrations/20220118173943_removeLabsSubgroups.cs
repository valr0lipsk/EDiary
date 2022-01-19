using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class removeLabsSubgroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_lessonLabs_labsSubgroups_subgroupLabId",
                table: "lessonLabs");

            migrationBuilder.DropTable(
                name: "labsSubgroups");

            migrationBuilder.RenameColumn(
                name: "subgroupLabId",
                table: "lessonLabs",
                newName: "labId");

            migrationBuilder.RenameIndex(
                name: "IX_lessonLabs_subgroupLabId",
                table: "lessonLabs",
                newName: "IX_lessonLabs_labId");

            migrationBuilder.AddColumn<int>(
                name: "subgroupId",
                table: "labs",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "teacherId",
                table: "labs",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "84104525-a4c0-429f-b036-f9a3e4b4e78b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "a4b539f5-399e-4d55-9bfd-76769721d2ce");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "f3d6be97-d1d7-43bf-8668-d244274477df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "6e4ae1d7-a066-40fd-9044-3e43d9d9e193");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ad015a8-068b-438d-a024-77d79d33e9f7", "AQAAAAEAACcQAAAAEMbAlsJKPwOon7nZof++robQh8R4HK3LTYEMvdsABfWWyNBYvCSKds/zVBqHWEmvlw==", "9fc0d4aa-4531-4d18-bbb0-eea633e857a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e155878-bbfb-4e56-8584-251bc41fa9f0", "AQAAAAEAACcQAAAAEH/3qjgiYPQrLjrMhjau84gkv1cO/LnJoDcT/Z3lPp0a+nV95lw6gTTxEbWQ6/HjnA==", "199bc94c-5006-44c3-8e0e-7e1213d9ef8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efeeadab-6f08-4d01-a15f-863f38d03e95", "AQAAAAEAACcQAAAAEItYXq7nFxSN8gd6P0EGJejPUz6TRAhFDTbLjZ9ZyIDzTI6vtuFMRuPqJ3KvbJpd7w==", "e0776a44-9e41-4038-92c8-41638570a249" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cb93429-c463-4ad1-a821-f9ec88700dc4", "AQAAAAEAACcQAAAAEGwKrFFtPg/dLrSLsw6g9I3i37SEDYBLrUafdwHwuJVM8XDY0DT3B00hV4UKdh7NVQ==", "6baf70a9-77f9-47c8-8956-f5989f53bdf7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a13381e-e090-4839-b9ff-68bb5cabe922", "AQAAAAEAACcQAAAAELAVXLWgB2zdQ8U32HL4VmS7dlGBS+lD0kQFNEAne8fn/E3stBj8DvY3wkIyyXZuJw==", "5af98b1f-37fe-4f46-8687-db557c9df92d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "727acec4-8243-4a64-b4ae-f8e78d0d1270", "AQAAAAEAACcQAAAAEFpTJ27GW81Me9RWbnMjE6LI/LEFtAhEkRvm+6VX2b24phzZvrmh9kNH2ErghrOABw==", "b40f0954-f2e3-4fbb-80a8-b233933dc9d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bd04413-b038-40f7-873c-dff3c84d0305", "AQAAAAEAACcQAAAAEBG1EKqY3XoMtj1W76rDbseNqgQ7tFgYATh91P3S6CAVPWyZOwdNVjYjoiVGQc4SNw==", "5b6d78f9-e4d9-4725-b72f-e599b63238a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed308e38-ba79-42cc-99d6-c01fa9c67599", "AQAAAAEAACcQAAAAEHVHkQmprTgpPiSVw/ArfDIS2Io2I8DxIbasDezMbvwRCiXMoVVH8pNfzHvw99/jRA==", "aa4f5100-0129-45ce-a706-892a2b2a6b47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd08f843-812a-4bbf-9b52-362ecb91a20a", "AQAAAAEAACcQAAAAENchyIey2jChAsxpzj3+IiKkAGZvleyzpKN2cBCfZjpKHuSWfiieFznwKnkUrGn/nQ==", "11fef003-e03a-4c91-89f6-2f5f7598b7f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "191da90d-da92-4ad9-a55c-cc2d1a4dd49c", "AQAAAAEAACcQAAAAECOOcFISkQJ6H5JXNt0mWSaLWxKAQ3FobGP3vJvTNpqg1R5cIo1vGy6yIIKgZkDBfg==", "e4580371-fe11-40d4-aefb-76b297e96b6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c65c788d-ca94-4a42-b06f-3587002451c1", "AQAAAAEAACcQAAAAEFoeHMojs82Jr+Zaab7W76nWX8ZZuWvs/ZPps8v2gmybBAe5QuIit7bgnJ2O1XuUcQ==", "ef941017-4c5a-4e33-b4b2-b5daae602778" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f1f683f-5991-48fe-80ae-d3368165ae6e", "AQAAAAEAACcQAAAAEIw3obVtbT4Nwtw5ndW2PtdO5nmvRzWbr+yBwP/NOs77IE8hSWv4kUy6y9cIYUDbqQ==", "0777b168-c802-4f5f-aaa4-1e9a019d616b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c061f755-e2a7-415b-a62e-b97ba772a35e", "AQAAAAEAACcQAAAAEMfyOE91UuuNX6NfjC/yqraXQmjrqsDPSFcQnMmbkZA6DyguuruLN4AIps3zeXs0HQ==", "f014fb06-0923-49b8-9b7a-2deb228c75f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fdc7d62-ff13-4c13-93e3-c8139c078ac6", "AQAAAAEAACcQAAAAEPSMoCGBfV/DRIfamsRjhRc3i31VIjmcgW4VbT+eKx31Gc1UBaJ1tJlNJ4tvMXlFAg==", "4af21c95-97cf-4df5-9e4b-95eafa84eab3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40776f47-c381-4df9-91f4-b6fa8aa70426", "AQAAAAEAACcQAAAAEED1vZxwzK5N6y8M3nL/zG+kKKgmAFSQB1VXeHXly6/8RKCsiC1BrTYTumSCDNupnA==", "57701222-df28-4493-add3-c4af7b7a3041" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "971e53cf-ea18-461f-95c5-e8003d007605", "AQAAAAEAACcQAAAAEFv3E1lxEmwvX1KUEm6GmdoH1COTK3RWEqH7h4hoY4eCGZDp2MaZEQSj78/NqzGadQ==", "70e5f909-e498-40f5-acf6-b434bdd23d16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e46d157a-3681-49da-8652-5f78cf3c532a", "AQAAAAEAACcQAAAAEMzTzN3xRvYwbn0kxEGL4NVIJkuckzZA+Ph1t4kyAQWQUUWn+MbanqGje2q4OnjRKg==", "5975b320-613c-48de-b34b-639669e4a607" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a459d0b2-e011-42e7-9ed8-cb41b847b802", "AQAAAAEAACcQAAAAENPrH4vkFgr4I37036Fn8THsKhIVh9VFmhtLCU5Zt97CTT99gC/R3WPjaZN9lJE92A==", "1df16e86-7e20-48ad-8ab3-a46c8268ecec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb91160d-0e84-4ae2-bf6b-a83cd95b048e", "AQAAAAEAACcQAAAAEANgobXMHf/wEkFHhjZmU+O92pTLUSwRCpp8EvlcMhVpjIet0MGnXmBNGpBnQv5CcQ==", "9db5da6f-e7e9-4031-a5ca-24f1d0a562cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d90d76db-2871-409c-8106-35faf75abd2a", "AQAAAAEAACcQAAAAEIdQnuNKNOWGYfYf7bS4CZSlhRfUaN5qh5VjpGRyXdqk/AhhXNSkEo+TiQZFLqTXJw==", "3b5847c1-693d-4577-b760-6521614e7167" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "520c451f-3fbd-4a04-8ec7-d7ae1ec73416", "AQAAAAEAACcQAAAAEMTCMRVQIwpZ3wpOBLd30IVmX+HB/8pG/x8riWMwwKTBN9jaYq+YHALDFPh94Oxmig==", "707a4490-63c0-4b80-8c74-4bad4d2e7f30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4600d1c5-9027-4f08-a1e4-59a9ba7dcdd4", "AQAAAAEAACcQAAAAEIDByxMAMqAVgRUHkTuNYRwEz8QH8YGiD9rlgzLpdJtSaAW2F/zoAL8Lmmwdbe7b3g==", "5618bbf9-4973-4322-91c0-cf2f30483cad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c873fff-23df-4f7c-8323-f266fa6feb8e", "AQAAAAEAACcQAAAAEOFMKwnLdNpnqthj1Xk7aL36WpLYFB33lUOLD6j/3S5ZhTLQMp7MO+7X8nGvxH6b2A==", "799dbe41-328a-4f52-8a1e-869565779b17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5232d5af-8098-428d-b751-896be5e65760", "AQAAAAEAACcQAAAAEDTQvMbqrqjFqkFFU79d6GhrtzVKxJN7xYfkxlp3QFnpVo8mmWcDFOpBw2dMoKRBWQ==", "3b6a38fb-3f9b-4bf2-970b-d2fdb755eda8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40e26bda-4bea-409d-a336-e41b30b54900", "AQAAAAEAACcQAAAAEKSZmC+fwQ0HOylwnnywpZbjLJe26332qPv0blt7iKEdhUxNhBo5Y3V3C/tHlXzGkA==", "d2a46738-8f6d-467d-b5e5-2b771f1081d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48c3c810-7af2-4406-8b57-5aa5d196d016", "AQAAAAEAACcQAAAAEC2/9ZcgtPXjsnDX8ED+0bfsxT6e3+n5yC/FfV1BoaxyPsnNpcqQ99D1q6oP0vAZLg==", "66bcbe8e-f530-4107-9c18-41c578ef29ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48fa7ab5-f0c2-4620-9849-874cb2d2db1f", "AQAAAAEAACcQAAAAEPxLSG3kU6pCuN/e04PJwtVQLqA0zpGtku5+Y/sGEuZL5JNBM7hZ+dmnfpESJu6wfA==", "3b9af0b9-eea8-4e1e-8737-83e3a1900e0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b41eedc-5c28-422e-a10b-71be65e70d0d", "AQAAAAEAACcQAAAAELe0S2bCIGnZlFkaqBczGCS+RD1/AO4TGQaqMkY5P7G2IYhfABtCQFj28/oe1X211A==", "2d9be3c6-95da-403f-bb6a-4306dc6dc315" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71788b00-2877-4c7f-80aa-d5577900ba05", "AQAAAAEAACcQAAAAENpP1GQGhNWv4v/oJ0R621w4RCF9ImuIvOYK3Al7Zell5DM9C3EqLomdYJVSZqJezA==", "bd894542-4ec7-4234-80b2-f5f855b5f678" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8557782c-a8a8-426c-a110-447d3209a4c8", "AQAAAAEAACcQAAAAEFSytUoAKVQkqtEAyIvzO9XsI1zDQQ/B0cVdhtXfYI1V4kRXYUOfeEBDhC8mMSx+3A==", "307fe9d5-2bd8-4ca1-9f77-503cc10cadf5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9b79eac-ddc1-4601-9244-d690aa87a876", "AQAAAAEAACcQAAAAEJyKZnQFihipcgZo7cG6dizD0CoPHtFw6oSzjG+yYl4iENzcDwIG4pMsPl6pClQZ8g==", "907f84b2-86c8-429d-9f92-ef64c9a376af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61ff9f20-92d5-4e08-aaa7-7fefc71b5a82", "AQAAAAEAACcQAAAAECm6zHKpkjl57v/Zp9oSwJGjF0GDwAgzbp348hvIla/lzNzn1XM93kWSSRrU5xxNwA==", "d579c684-65f5-4a88-ba51-d60e976f3fe7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ea4fc51-7476-4d3b-b519-bdd71012177e", "AQAAAAEAACcQAAAAEMsrteS+UDhFGnWOQe2B1sXmejl7U+P+4gyURksj2BOG0sLtyooaR8XubXZdtLPjXQ==", "be9d3ae5-2f93-47a0-90da-30b984d4f986" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cfeee95-cd29-43bc-b294-ec8da07ea91e", "AQAAAAEAACcQAAAAEFkaP3DppzG0/AWvjnd+UOYzWRi9HIO10paBri0wy/fA2iQgcOTDXvncDr6UK3Q2sA==", "f911135f-a8e7-43f9-9ad3-b9ec22a125d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94c09a3d-943e-44cb-b8e7-8b697b90d972", "AQAAAAEAACcQAAAAEG3quVXYDn6XbO2heGoDqapSZ4IA9gnwhPqkGvG5nb2fy8N1T19HWN+vovL1I/XVcA==", "b4537851-a26f-4b7d-9a73-ff44a197147a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4125a28-a7e6-4462-b4d8-f7e54a313e29", "AQAAAAEAACcQAAAAEHsr8cLk7sdWHsKWaOW/so6QJLXn2r/CORf1ZSsjwt477GS/kNyjT+VaLFG5QHgUUQ==", "c8aa0f76-c15e-4639-9b5b-ec82566802f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "215b75bb-e31b-4deb-9877-822dc0c6c543", "AQAAAAEAACcQAAAAEKEtcfOZ0U24eJm+kozoiBn10CKxQhA/wj74H2IGP/oivFM++MuJz97AwwlUeT0EHw==", "0228ffcc-03fd-4a39-abfb-9c9ae96b2f83" });

            migrationBuilder.CreateIndex(
                name: "IX_labs_subgroupId",
                table: "labs",
                column: "subgroupId");

            migrationBuilder.CreateIndex(
                name: "IX_labs_teacherId",
                table: "labs",
                column: "teacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_labs_subgroups_subgroupId",
                table: "labs",
                column: "subgroupId",
                principalTable: "subgroups",
                principalColumn: "subgroupId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_labs_teachers_teacherId",
                table: "labs",
                column: "teacherId",
                principalTable: "teachers",
                principalColumn: "teacherId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_lessonLabs_labs_labId",
                table: "lessonLabs",
                column: "labId",
                principalTable: "labs",
                principalColumn: "labId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_labs_subgroups_subgroupId",
                table: "labs");

            migrationBuilder.DropForeignKey(
                name: "FK_labs_teachers_teacherId",
                table: "labs");

            migrationBuilder.DropForeignKey(
                name: "FK_lessonLabs_labs_labId",
                table: "lessonLabs");

            migrationBuilder.DropIndex(
                name: "IX_labs_subgroupId",
                table: "labs");

            migrationBuilder.DropIndex(
                name: "IX_labs_teacherId",
                table: "labs");

            migrationBuilder.DropColumn(
                name: "subgroupId",
                table: "labs");

            migrationBuilder.DropColumn(
                name: "teacherId",
                table: "labs");

            migrationBuilder.RenameColumn(
                name: "labId",
                table: "lessonLabs",
                newName: "subgroupLabId");

            migrationBuilder.RenameIndex(
                name: "IX_lessonLabs_labId",
                table: "lessonLabs",
                newName: "IX_lessonLabs_subgroupLabId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_lessonLabs_labsSubgroups_subgroupLabId",
                table: "lessonLabs",
                column: "subgroupLabId",
                principalTable: "labsSubgroups",
                principalColumn: "labSubgroupId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
