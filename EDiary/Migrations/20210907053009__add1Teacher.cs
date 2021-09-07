using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class _add1Teacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "dedc3378-c240-4b89-988d-314625ada1e0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "180daf08-e96b-4e1c-be89-5c528a0c1c22");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "c37ce22e-0117-4409-9642-03b9aa072114");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbb0bc76-0d7a-47b4-807e-79913e0cfc01", "AQAAAAEAACcQAAAAEDVfh9E+lCyI7sc9B3qhxX6O6uULHw3t9cFl7BvbaSeDnq1huuJbsmIXbWLD0OwSgA==", "303f2502-6efe-4fc6-87fc-3f2befc37bf9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e842c87-1852-457a-a944-c2a869c43cab", "AQAAAAEAACcQAAAAELQu4klvU595z+iK+K5mZOPA7rz0vIhIP2W3ZR8x2DnVoYpFU4hPqUXzlyAOb4phlg==", "3af7b840-796b-40c7-95ef-12bb8568e3c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db17d58f-e136-491d-a557-bf19d477219a", "AQAAAAEAACcQAAAAEJCcRK2gHINBzhDxNLmP5Nd8sPa4tEu1NRWb+mAwOc9uIfRK6sHvvBg3Q3pAOJGBIQ==", "5a8c4912-b3ab-44d0-a153-54a843570fdb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c669e6a6-7c61-4dd3-a359-50beaed9d0df", "AQAAAAEAACcQAAAAEI4VlJvdZG9ZN22L3P7aee3n4TMNOUjTj5zLsVT5uLoRFDySUrd28XzzfH93zY6ueQ==", "10ca4cf4-b26f-4f07-aa47-59d6cadee89d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb8c6dac-7096-4b3f-aa4f-a6404fb6a012", "AQAAAAEAACcQAAAAEOyprttLddUOZYbUXatiSmp6sTHl41XIqgKF7pqHvHYnwUnQBZ/BLKW6J+66dlEN+A==", "8e8af905-48df-4e5d-8508-903c7d37f2ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ba29958-18be-44b1-a015-88b764a7d10e", "AQAAAAEAACcQAAAAEImEsYe/gWoWdjvhFfLvJjhohx87vfeJy9u3RIPAGS/U/KAYtYciepinO1H34OgbZQ==", "6c9e1461-5e38-4f24-9744-af2ed0dab7a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9fe0716-2b9c-4bcd-9b8f-fcad699098a2", "AQAAAAEAACcQAAAAEDo4GaxJrRHIch9exNRUDz5u5ku+oDu1Yq0gIScyuVS1TlUXYnM1yO4d9zHVo1poag==", "eaa27151-efc2-4f7f-9268-b4f1ab7b1134" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8", 0, "132cbba9-ad8c-4247-bfd2-b94b7640ce62", null, false, false, null, null, "TR000006", "AQAAAAEAACcQAAAAEB2ducQI7qnQoe3Pi9FQpYrva16VRSfMAVTDqzVfI7NK6YWve6p0YEUzaX211rF9ng==", null, false, "dbe6df84-d45a-4622-ba6d-9b906e81d097", false, "tr000006" });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "idUser", "userId", "userLastname", "userName", "userPic", "userSurname" },
                values: new object[] { 7, "8", "Владимировна", "Анастасия", null, "Гордеюк" });

            migrationBuilder.InsertData(
                table: "teachers",
                columns: new[] { "teacherId", "teacherRole", "teacherUser" },
                values: new object[] { 6, "teacher", 7 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "teacherId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "idUser",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1adacb74-0fb9-4b9f-8bdc-f9d7c88704c7", "AQAAAAEAACcQAAAAEIOPcsy/Jzfo0WcYmfM+0GMttuo0SEX3Sc7sBIZcJLXKVx8Cd3N6NTRO2Ya4eCP7HA==", "391728d1-a343-4188-88ac-efd575526764" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8257089e-9797-4962-9fae-57770c9d8ce9", "AQAAAAEAACcQAAAAEOXxbYnc80TLMigUUkEdfKUrJLlrE0dXYr7oMxoLm4sBNxi1fJK/uTuL0tC0rrrrXg==", "7ce9c4b7-14c4-4d41-8e17-23d3ea45a3ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cace8fb-9a9d-44e6-b0aa-a743719d93d4", "AQAAAAEAACcQAAAAEG5Kc6JFXkJ6egB7UxtWIlcHqDlK6Gc1XyGkrA8FXD6c1uksz6gVaaK01wpTnMN61A==", "250ca85f-8a55-44d6-a471-2bf8dee8b0a0" });
        }
    }
}
