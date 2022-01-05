using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "teacherPic",
                table: "teachers",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "studentPic",
                table: "students",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "aa23bea4-e585-4cff-afda-245852dee491");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "9054f801-b92b-4db9-8185-a9815ee9caa2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "23b87f12-170b-43d9-ac1a-60b93641f606");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1912d316-b9fb-4cc9-82f3-3dd7eac01aae", "AQAAAAEAACcQAAAAED04ISWqjADxRi5dmfJmNU1C9IVzQ5uRc66IY5B2YFne4BUFx5jjwNxiVYKQ/nsD1A==", "c4332d0e-1a3e-4163-a9c8-742b0b5b0524" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdab9e34-b6e3-4272-a63e-bbd4acf3a795", "AQAAAAEAACcQAAAAEEboihG0gyGOftBbocu/PRVekkHyP2VGKr75PmrFznoGimyF5TfZhlEbXGnMALniqQ==", "d24e8397-18bc-4f58-8cc9-170010e6343b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "296518e8-a14a-4a9d-a0f4-84b1bba5bfe8", "AQAAAAEAACcQAAAAEG7Xj+SJf188Jsd3YecheDfz1E/6R7yOHJU53IaSGOihEjuyaZel3cgCdKrkGr1Fag==", "2018ed4d-efeb-4a3e-b002-faa9589b97fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f7eb3e9-1d7d-4a68-a1df-8aa49276585f", "AQAAAAEAACcQAAAAEAdVJPJg0lJWTW+AI4vKpfqh3m02srHuBaS73HgKHlk+LZfEBpPfHy1fkdahw7wz2A==", "ec4af896-65cc-4a20-bb81-d897341c807a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6a9d4d9-b85a-4fea-82ad-4f1644415918", "AQAAAAEAACcQAAAAEPdT1H0lcN+vxqs+OrZ2XAMUiW0nwQpZflvOjD4uDtimTOr9ewBNqKrJVhx5lSMJLQ==", "73acb203-815e-4b2b-bf95-3baeec502415" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b6ffb5d-bbbb-4360-9ee5-c94ed329cfcb", "AQAAAAEAACcQAAAAEHLEu51VCCuZLxbp2gtKDC9cIPGe95fb0UL/LWAcDGBJeLfj+S+Aa4StxvDLZzlGww==", "0a0fbbb5-592a-416f-91bf-f311732a437b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c58e395-b119-404d-b334-88e169e621dc", "AQAAAAEAACcQAAAAEEoY0isyUpKI691r9XQWMi89F3XytQRXjxm82kQJZ75t2yCjEiSoaqi0D9XsaewGCA==", "6c380747-2a9f-471c-945a-e5ade3aef3c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb4ef528-c881-4821-af51-a3ec4ab0d08e", "AQAAAAEAACcQAAAAEFfJuzBlAMqPhtgjoq4f5Lx/L9+ETdIkWOL0fDqztZnMl7z7CcDPMuwR8JeHlefEdA==", "d583f79e-5906-443c-9cb2-a8ee4fb37315" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6220a04a-93a2-4c29-beed-227725116884", "AQAAAAEAACcQAAAAEDSxUmSSqS2zgnmMp/TWQgscUwSpxuBA/7FaHAdFtymwnuhNlvVu+iCWsHCI6ym5vw==", "ac68bc80-7311-4a2f-bc2d-80716e04f88d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "teacherPic",
                table: "teachers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "studentPic",
                table: "students",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "1b6e158d-5e5f-4ac0-9018-34b43b8111c7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "44588590-b846-497a-a36b-e19882d9ee90");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "03f9ab92-07bf-4681-9e4b-931b6447b67d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efaf5fe3-aaf6-4620-bec1-630129eade01", "AQAAAAEAACcQAAAAEHfEJ2tLk0ITNezMmmJuF/sCxiUeozq9S+Pru2urfIWe8n01k/BXXMGifNhQ2AheuQ==", "64651029-9703-4f4a-837d-bbd5e34d289f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22bbee36-ed67-4b47-8cb0-b91267e1817a", "AQAAAAEAACcQAAAAEGgVg2QfgyIG5/rLrUnjkkH2rXNdYk3o1g8iBDHH1iFDuPQO0BFT8r7iK3ykvug+yQ==", "74943d9e-56e6-4df8-895a-1ffaa285b6b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5223b31e-ee7b-4d4f-96ab-7f3c2e86ed8b", "AQAAAAEAACcQAAAAEDgxCj4DeQi17miSiEPuGDebhWxcjKp1iKntS0m/dWCcBxL5hJWeYDf8pYdmwCsQ5g==", "f832b661-94cc-42f8-a425-3d9ebd049717" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0eddbf85-3ff5-42e4-bd7a-9951564ba063", "AQAAAAEAACcQAAAAEJIlu0WLcF1R6hu5HRKhPBdHfOXTk3YoBatI3XviWBtLWVdrBPZmIxGnlsCXdSNSQg==", "c7fd6438-55e4-4674-a58f-516ae89d7536" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f32322ee-bea6-4b62-9f3b-32dc4efacb34", "AQAAAAEAACcQAAAAEEFJSB7fg2rUWaDQrsRcJW+9bEShS13tOlyjPuoBOu08WTrok12TYasWSQbrYF7vHg==", "1a6a0e38-b97d-43b6-bb87-b7ea734b4318" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "721cecc7-8e45-45be-a38b-7493ea3900fa", "AQAAAAEAACcQAAAAEJvHXwrzYqsJ39OHkf+M6uYPYkrh6o5Bvt4xDW1kHyVJgUjpRHZPUBg/uwFiZPOk8Q==", "9aa518b9-1ab6-4052-9a2d-b33b42ee2501" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9bf3e22a-db01-49e5-ae11-3404fd8b17a9", "AQAAAAEAACcQAAAAEEMJiDTgXvdatti8LEShC3dMvE4qnhNy6S1qPVaSq3v/FQ8uQlER+E8hpaccYyTdtw==", "09c2e816-0b3e-4b39-a6f6-5d99568da4b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16b7f76e-3175-4b54-b4f0-240343828488", "AQAAAAEAACcQAAAAEKcE2b5h4h/uZhGmHhyAJTlwm82QMNmDudu5oRiudMc4TXKKbw7dTLEp8nzYZqxHtA==", "af845009-c96b-47af-bc43-b73456f283ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "689e472f-cd9c-4ac7-82d7-46ea2b768d05", "AQAAAAEAACcQAAAAEP2ekKoJpuSbQQY1lSMZZm91LpZc18Lz0tjoMuYMVQ5XaOMO4fXjaGnyTS4nPQCQQw==", "5b44ee10-0960-4987-a775-3153e948d04f" });
        }
    }
}
