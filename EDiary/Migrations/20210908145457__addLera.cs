using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class _addLera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "6446b526-52e9-41c0-b850-1a5e4b99c381");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "1e422cb9-c913-4a81-9d75-8538667927f5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "60f9c56d-ce15-416a-8edf-ca5f0cde13bc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29ce752a-2461-4218-8116-51971ecb44c8", "AQAAAAEAACcQAAAAEBS3MRie4uXankN3S18pI9xDiCnW/cZkzAJyq1k2XGREMbyRh9vJTqfusRxcwu50Cw==", "2d7eed49-057a-4524-b04e-9646fc940b9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66a37de0-36f1-4d8a-90d2-5d468b92e703", "AQAAAAEAACcQAAAAEKg9UshVU5XTB+RNi9JqZFESscBe8UQRmpHZIqVQQOlUcpLlqdanht31tRdezNx5bA==", "8be80201-09e3-4aaa-b7dd-09d7474d4103" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67c26613-d424-4009-9954-cdc0a23b1504", "AQAAAAEAACcQAAAAEEJrksuRCfXUVRtIb7E8Ai1YDMC4lq2vRpSt7BoRYeCo4D7jt0FdFKF91giZ59eXaQ==", "ba2c26dc-6ec4-4997-bd24-64a889b29059" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fad3941-3724-40d2-9188-780235ec5a3b", "AQAAAAEAACcQAAAAEEP0nRxoj16gpr3cBCa6nRf1YCpRYthXSmFCUtiNic71Hov2Eifh1lztp1pzIWYrtw==", "14982564-74fc-4681-a210-538f95009dfe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2f888b0-24ab-42a6-83a3-0829cb1b41b3", "AQAAAAEAACcQAAAAECPLCKBZSJkRKWV6DHgxeiwPFsZmH8bwgk+HeVi+rKn2D1Sk/3RhEQCNF0YeaOeDRg==", "0b9176e3-fbe6-4ab5-a8d5-ec4a4e1a9da1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2eb8712-6e00-44d1-915e-cfc55e611edf", "AQAAAAEAACcQAAAAELsYbcyCxtlGC9kFIil5cwEzO6f/ug4HB9BLsZJpBw5ifAKM6GoVXIoQy+nOg5OwsQ==", "3e1c85d3-19c9-4ec5-9321-3a75887cf33b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bf0f56c-e21f-43d1-a221-51d2f39caaf1", "AQAAAAEAACcQAAAAELTSJfPVnYf4NToCJO5Z2vig68CKtmM6WWnjOep/R4PyNY1HGuNbcpN7xU7uESbMtw==", "b399542f-be1d-44b2-9154-cb7a6b7cef28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f52161c0-e6ef-480f-95b0-9105d571c0db", "AQAAAAEAACcQAAAAEE3a2HK3M7J3kU1Z5qbXErRDK8hQt16STbxe0Qij/A2KunEWDc7pgRx0iK4tuN8WCw==", "daab1e03-a0de-4d9d-a28e-41fc50791614" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9", 0, "e1f299cc-74fe-4bb8-9f13-83faafe5b478", null, false, false, null, null, "ST000002", "AQAAAAEAACcQAAAAEFPyvQIr3Y41+dEx2XcIMcS/nuh/JURvE62ZMhZZuQLMk4QQLYn0/X3lfSrmpfPIpQ==", null, false, "033fea3f-9d06-428b-b214-80f53958b3cd", false, "st000002" });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "idUser", "userId", "userLastname", "userName", "userPic", "userSurname" },
                values: new object[] { 8, "9", "Александровна", "Валерия", null, "Липская" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "studentId", "studentGroup", "studentRole", "studentUser" },
                values: new object[] { 2, 2, "student", 8 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "idUser",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "132cbba9-ad8c-4247-bfd2-b94b7640ce62", "AQAAAAEAACcQAAAAEB2ducQI7qnQoe3Pi9FQpYrva16VRSfMAVTDqzVfI7NK6YWve6p0YEUzaX211rF9ng==", "dbe6df84-d45a-4622-ba6d-9b906e81d097" });
        }
    }
}
