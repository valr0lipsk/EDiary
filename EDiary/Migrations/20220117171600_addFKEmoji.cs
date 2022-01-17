using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class addFKEmoji : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "teacherStatus",
                table: "teachers",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "studentStatus",
                table: "students",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "67bf9834-5ad9-49a8-a5f2-b733623f8445");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "f3d02727-6777-4ead-a50e-205981339952");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "a23e9994-2b94-422a-bbf2-1f74c383c0ce");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dda5ac3e-0383-4c46-bbb3-678f5fb5836a", "AQAAAAEAACcQAAAAECSU5x0LkRcCqQtzoQXHmb84rNOUx5cvJxpc2fSeM2AAGb44UNVJhNdw6lfMgRBtBg==", "34582134-8cd9-4273-b8a8-a45ca5c1a3c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "756b9957-f2d9-4831-a33b-b6c0b23c844b", "AQAAAAEAACcQAAAAEPwRt6rv4Is7eZUoHAeB5rNAFOOLjtHpVEka3uUz/UJpa+SOo667P8HYHC+Qv8/uGg==", "a8c8cf12-7a59-441f-9e48-feea2094dd58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b85dea41-7dae-4583-9c1f-1d52c48abf82", "AQAAAAEAACcQAAAAEIBT3rP02H3lOC5JfqdhnlTTb/cfSBRrMV842ze4OvGqliDHDjpnbwxQqsMeR2rLWg==", "638ae43d-0aaf-4b2b-a6e4-b3ed5c9c72ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "377e6ad6-cd62-47d3-80d7-9152742d9fe6", "AQAAAAEAACcQAAAAENEr57/iQfvCDH2mUjzLqKirt1YsIlAkh/YzosfZMpd4Eex/3+qgM7hDNkU6NMqVzw==", "706dd0c7-3aef-4d19-82bb-cf05ce6f1393" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d74b7b5-c0a2-4a20-b4c8-704dc36c33ce", "AQAAAAEAACcQAAAAEBw7YqYmStDcpC+zwXv+iri7uCL2Q4kYII9dDvPe/vCYYO9P7RNnB7p4450yDb2L9w==", "0b6cef62-4b85-46dc-a5f6-dd3547202b76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffc4faf9-7a28-4a1e-b4d1-c583e638a7a7", "AQAAAAEAACcQAAAAELMw2nlC4ATl4zTRDzdSu66r5UYi0STUsTE4HOHai3xBvWOrWOxQnLuicGJsS+ufYw==", "fa33c286-a3f6-4bc4-a4b3-6a7895981efc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a882cab-59fa-4215-8030-de9585d1d7d7", "AQAAAAEAACcQAAAAEBxVx6HUEJB7/WhUImkvHMSiBoObZVzn7jKVR+KotH50b6JU6HXrcKI/F20mHiZQdQ==", "49db9c41-2959-4b4a-9726-6647b4ddd1a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49cd62c0-0de5-49d4-88f3-33aeed59add1", "AQAAAAEAACcQAAAAEM23d5mHzxewMGFWgt+W6XvQyo8t/rtTs6JCaHp/6vgZvam7X2eAb3GVBWqkzty+lg==", "71df3593-6fcd-4373-8194-11a84a895c4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a136786e-67fb-43f7-8efc-3a0adb024d29", "AQAAAAEAACcQAAAAEEbN7U56U1z0pa2tNvHVD/RVxLC9HHy15BN3Kd5PEI9oT6ruNrEpegl47SpMEF+KkA==", "40b0098c-a283-4507-9905-14f8df262684" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d899dee-4ad8-4a9b-b44c-a88bfd6807e4", "AQAAAAEAACcQAAAAEIGoiTS1j9CZ29PW77uJpr0BfXFi4Yz4vgZYenVsR89g6Rld2ekb8qVN7m6ja9Et6A==", "8b973b9a-5871-4453-bc68-375652a6d05f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af3bab9a-1afb-461a-805d-b90e1acddb80", "AQAAAAEAACcQAAAAEEkhdsMB/j6MTrkM0TXYg9fxL9wwPR20T6WTICmF+/1JLVMTV7DfXBKmUL4Ro9ke2Q==", "495da75b-cde5-4704-b835-b1706c34fa6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "776333e9-35af-46d1-8b9d-dfbb2fbb1f22", "AQAAAAEAACcQAAAAEAipqOoeaUOTbJilKQvywVaPVauxY6YCDXBaoo+aoz9muiBVm/oh25+j80tCDCjZkw==", "aa12a35c-04d4-46f9-aafe-06d326c27513" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f843e168-407b-4434-9d43-176a32a11c41", "AQAAAAEAACcQAAAAEJ19haOZ67tyXLbaZ1JOGorDm5hKp0FwfHol12TufPNLazAWeJD+tuEqYBcqAU2wqw==", "5bdadf8e-bfbb-430f-bb92-cf960401adbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09dff08e-504b-46b2-baa8-46276760f226", "AQAAAAEAACcQAAAAEP2olGE+AHwmKKOAzCydPrD+YTMuqgXCafJnJXWuNxgvmgtgsyGCXvfG78D4giyHhA==", "b97f0087-e288-43af-a5f7-c4bc378e0d22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65005d89-9242-426c-b598-aadb398fd133", "AQAAAAEAACcQAAAAEJTqPXMd9JnEOXtGhV/P1ooWgWdqhavzs9WzI0Etg9WBg6X4ahsD5JjXyfCiq1BuGQ==", "0ff74617-6b1d-48f8-acf2-5e8cd7d1a9f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcc96a08-97da-409e-8c68-ce4ba8c6fe5b", "AQAAAAEAACcQAAAAEIOKwQ0vVkzFmbnWna3ZxYlah7ZUTNgXhLQC7ubyW/j4+lvoBYlUWj4PLTWLSYv+NQ==", "6ef6d412-116c-4ab5-8bd1-f421e09278f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db2cdb20-d693-4415-9f9c-66ae03f34328", "AQAAAAEAACcQAAAAECafgFH0w8OIeWa5Cqa/6LGxdxK9/mQugMogqPsjMX/t7HN97BB+YVusC9BMV1bCUw==", "4c4f8120-3f2d-4b02-b6b2-cc9f6d28ec8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e9659c5-a2f8-416c-9213-3f783f29fcbd", "AQAAAAEAACcQAAAAEJ0oNBr8K9k1t2yIpO2MzS1VJchyCDb7za6Gvuu+t1gEDhVfX+4RukvtaifoNKOqmw==", "0f74e179-2bb6-4baa-be9d-00404f1d2bc3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9a0578f-b944-45e1-9924-527db3c329f4", "AQAAAAEAACcQAAAAEDP5uHPGearDghrsT/xm2qFzqgZkS28hYA7UKJKlWkUTV1OLZWTHD3XajNRAOovq/A==", "66c3bcc0-6ebd-43f2-abf9-11bf5d0f8b00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aec0af7c-d220-4f5a-afe6-f3e56fa3c83f", "AQAAAAEAACcQAAAAEPWlZfXfczm/61ieGyAFe2sPWnBcJgF3l3cFa9ZsKLOoDa+TPWKWU1EUTWmL8akobA==", "76828000-3f3d-450e-8ace-552831317fe7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f57498b7-ad57-4697-a5df-b65b925cb7f3", "AQAAAAEAACcQAAAAEOlsLMT4RTqvj22xSWTqMmCVPu/ODX9LCQHXSQPdDxaFjtTpwOI7Z41cAzUJrkXKSQ==", "ed18170c-dbfd-4721-be89-1f9515854bd7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7148134d-27fe-4533-acb7-a8f927a54e81", "AQAAAAEAACcQAAAAEEb5ayPKYEdFyai76d09Tz5GycZW629e36E6eAHAt01B4IO1KVy1BTrjsl9X1UAQVg==", "e6972e38-563e-431d-80a6-90a0d80bea1a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4def9e7-3a27-4808-856c-d32d84a4deb8", "AQAAAAEAACcQAAAAEMQ1cCVS2c5M4+3bpZu/OW/KdynoP4lOsIhc3R6pJr9vVXphorXMkYv2xqFMOM4iSQ==", "59d37ced-ef98-4170-9514-e86ae4f66c62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2de8621c-252b-482c-97c1-526262db0e3b", "AQAAAAEAACcQAAAAEHpT8iXGj5A3THmvHIMzF1f3ko1Is+Kvz1DXKdliz/qEn1XNVFgr0V+lgt8MjMio+w==", "307adb41-9526-451d-bcae-5c75e3da9f73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0399d715-ba19-407a-ab09-3cdbc7b74309", "AQAAAAEAACcQAAAAEP4snpc/qqA2dakx2u1ByjW/hiuK2hLczpl9+SNuMJKNIY5TEuey2yR7YYepHlI74Q==", "02c299f3-20f8-4c42-8dd6-1321d993bb1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c820254c-036e-4ba5-8a12-c7fe107e9256", "AQAAAAEAACcQAAAAEJBKHjK9MMmHnzgalZ1ZXY7WZg9aKpuIsF7I1t6fLm5T+bwD/pOn8A1QdtoiZQBVPw==", "8b91df77-008d-49d4-99b8-49612974b065" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e417555b-4637-4f11-a604-631f248fb0d4", "AQAAAAEAACcQAAAAENTj2abXcvTZmwy5ZoaAm8SnuI2y/V4kmYYi+UuOGQk6SZ7Bpa9Vafmx+nQcwnd/Lw==", "ed967974-6a3a-408d-a99a-055fbfb04b11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7744a8fb-4751-4510-9388-40145fe5eb1c", "AQAAAAEAACcQAAAAENkvOtDE+jY2TGbm0Ss69Wa9RwXk9i/h5PKHI1BZ8/SOXz4dl6iLr4sIQyAL8zwKcQ==", "315eb5aa-4dcc-4ace-b69c-4dd8dba120ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81b18899-de2b-49a3-ac86-9b926ab8bdab", "AQAAAAEAACcQAAAAEJYzQqFSrt5UmbQVqb1m1evydwcoRQLI2Pjvjndj+HOY8mPaRqo3XBiZWUx2MxCLJA==", "1b4f7a66-98c5-41da-a8f3-1c3ba6ca5183" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b68a03a4-2fce-4521-93d6-0918a14a3ec7", "AQAAAAEAACcQAAAAEF3VhXuxPd58FRI4He1Y+b6x0OTjw51L1McGIukO3Gi1lZOvvD/raLfVI+awDT7lag==", "8d8302f8-ad04-4f71-9edf-5e90aac7f469" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7d8762e-7ba1-4bc0-bf76-404e0cbe02ce", "AQAAAAEAACcQAAAAEHAXzOST6guoZTRDMnSlu3wLT33OSQF7bx6aE7uMKW0nsWbhD6FCdiSzSB6b7pwmIQ==", "753de835-f5eb-4644-a7b0-4dd861b8aa3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "942f32ac-2b86-42ca-87c2-9f854d9fb054", "AQAAAAEAACcQAAAAEETWi0JPXJxdjIoP8+JNaQ5n+oRtPD51LKZw4Tg9X4L64Pp1ulADjuPFZfBV8/Os+g==", "1a77d28d-67cf-4e11-9933-87bf0aca757b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1eea4503-e57f-4ca9-9d06-40618f7e20c5", "AQAAAAEAACcQAAAAEDrnDf5lOERXqZHKe8t8ReVS5OGf/W6uAHhrJiyDiBoBE03MK9F+O9jpixsIJZRNig==", "5403f0dc-6dd4-4f54-bf52-762b6b2e953c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22352dd1-320d-401d-856c-5821b708ad44", "AQAAAAEAACcQAAAAENFmhVdoad+dK0v9p0ZXMo6Ba4AXSpD07y1Va4bWW6Mx2v+AXkCUvA0lAQcZoPWa4A==", "f196b0a6-9edd-499e-8205-2200d279af2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90300201-bfc0-43c9-a0f7-52e22680f6bf", "AQAAAAEAACcQAAAAEOFKyP4v8XlS5IfHng26Qr52VNLplVNuHOV1ZLZ0Gd6tjShf9hResnRaQ6q9aMxeUw==", "38987494-72a0-407e-b9b6-b86f47debc33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60bf5a9a-8049-4a9b-b573-b7be68957379", "AQAAAAEAACcQAAAAELp7/XYl6NLFWmsEESV6tEJC+arwLoOlEEkkpgrU5m2wZmw5CW6TjzhBqdNuKSWV8A==", "789a2a8f-8d7e-497e-b7f4-286ec055f478" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee86a057-3fc2-41f4-9051-be636bd7c365", "AQAAAAEAACcQAAAAEP0rrEAfxGQbGMAr2nmANTK5OZdZpcgzWRF3b9T8oTRfGKCjY9hbRTJhnbZKLMLvAg==", "7f93deb0-7604-443e-9400-c9a561377b8c" });

            migrationBuilder.CreateIndex(
                name: "IX_teachers_teacherStatus",
                table: "teachers",
                column: "teacherStatus");

            migrationBuilder.CreateIndex(
                name: "IX_students_studentStatus",
                table: "students",
                column: "studentStatus");

            migrationBuilder.AddForeignKey(
                name: "FK_students_emojiStatuses_studentStatus",
                table: "students",
                column: "studentStatus",
                principalTable: "emojiStatuses",
                principalColumn: "statusId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_teachers_emojiStatuses_teacherStatus",
                table: "teachers",
                column: "teacherStatus",
                principalTable: "emojiStatuses",
                principalColumn: "statusId",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_emojiStatuses_studentStatus",
                table: "students");

            migrationBuilder.DropForeignKey(
                name: "FK_teachers_emojiStatuses_teacherStatus",
                table: "teachers");

            migrationBuilder.DropIndex(
                name: "IX_teachers_teacherStatus",
                table: "teachers");

            migrationBuilder.DropIndex(
                name: "IX_students_studentStatus",
                table: "students");

            migrationBuilder.DropColumn(
                name: "teacherStatus",
                table: "teachers");

            migrationBuilder.DropColumn(
                name: "studentStatus",
                table: "students");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "bd65cf3e-9317-4e13-86c5-67d695f0b83c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "01cef9ea-c422-4766-b178-dba496252ba2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "703b1e7c-bd1c-4892-aecd-3c888b85676d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82882bc0-4102-494c-800d-8ac8ae31e1c8", "AQAAAAEAACcQAAAAEFCPU1wMDKJK9DrgC5yk/tiqjgCZ7/XxoXd1v4zKZlufCMuNyWpC3Vzf9mFTf/MWDg==", "9bd5900c-ecec-43ea-8ae7-63ba1b7a51e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6560b64a-037a-425f-b39e-ba2697720db4", "AQAAAAEAACcQAAAAEOYgKJMJfRCMFEDwX79GbTmwgbgKHFoXl5WpJvlzmOKpqVDye6D4Vgdo9l0XW7Z5xA==", "c24d9c96-19e7-4e5d-b3e6-676db29eec87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "259d156f-93e2-4e2f-a515-9fb427d48ac6", "AQAAAAEAACcQAAAAEE/WGYNP5zE4G7HFV/LvV3sHqj+OF/LuxoYVjZzRum0r+M7pD10U9E7nGvJGpsuJOA==", "586caadd-2864-4537-ab27-2f14d109f59b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0c0a7c0-053e-4995-9574-a2e911de0289", "AQAAAAEAACcQAAAAEOhBSsLKbfidnmWRGcRzk0FgyFke1B5T5SK2an6O9dRhHI40pHl5okAaV4kNz0SPqg==", "08cc4b7e-b5ba-49d4-8c2d-787e0aa72f0d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "181f0cb7-fd13-4454-a03d-2933f4671574", "AQAAAAEAACcQAAAAEA4pqGZ+4sYBmvTC2m29OFSB8Qwudq5+JNP/7s48DQgWIBpt+x+zbJH9Jo/bAubCEw==", "999c55a7-4bcb-41e5-88f5-a48c3ed94753" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40852a01-bf1d-4717-b788-15e6a822a16b", "AQAAAAEAACcQAAAAEJRTtz1uSVVL87DfryT6c/8IEEZgQDDiYtWpWilRAARFgGxeWqUUxg+zJmCjMLIkDQ==", "399f57c2-b15e-4cdd-8656-473886588e48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e693f4a-4008-4735-b384-121add77c7c4", "AQAAAAEAACcQAAAAEIoy767L5eA347wU91+6a1u3G/6qexkkplqG8ngPCO29FWig/dTtpXnjMp141FQ9vA==", "ee6067f4-0d2b-4849-986b-4db998398382" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8782bcf9-d963-4d63-bd72-cc2d3dc916e7", "AQAAAAEAACcQAAAAEC79sxZILBwFcoIQsbd+skAfBCmDX1E2HxDi/fBrmLHIF3qwRhZZYUdEoYHcZ/XE4g==", "13820e45-d1d6-4cc9-8f31-9537c55d1806" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70440bc6-8aed-4ddf-8135-433ffe5f3cf9", "AQAAAAEAACcQAAAAEKz5NAjMVfM8DRfDAww/M/EqpaApGVznbaE4++b8WH94eQ+DRRueai7OTix8ZrE9Eg==", "92474714-a102-4096-a3e3-e32169558f04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21a94b8a-d078-4b2f-8f16-8e57621f001a", "AQAAAAEAACcQAAAAEN+pD0UpgoPEawnAVqw7t8ebSt296/Q4rjKF/v5Nwj75gN8slmt6t/+lQu9edXzdJQ==", "0025152a-fd2d-4a1d-875c-1e7b700dcc84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12dfa226-e230-4128-948a-9db0d8989d48", "AQAAAAEAACcQAAAAEKtMF5HfHbzrRiTJSjgVKwCjLavNbcD2ltf7li2nObZEJ2+2C33C5JXpjYMRp4W6cg==", "6b849db9-efc6-43bb-9ec5-727a62ea0917" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38583218-fa70-4047-8adf-69af9f3c594f", "AQAAAAEAACcQAAAAEKBuXPwe4Vhdntr8qouTcdToacTBglnOI6YvouwNCafoG3E6w1KrgAr6IRpN6nHPFw==", "61c402cb-8845-4398-9301-c88584204d8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68c09128-6036-4d0a-9f75-4a5bb5b8a239", "AQAAAAEAACcQAAAAEMkubuqRHnRWutTKmrvjihQIJASR57C9S58U3Fmp8YUCKD0zI9E0YLA/DbmjZhQlYg==", "36db7b9c-37c3-442f-941a-b6339f81c28b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "194e9b48-fdf2-430c-82a9-85b5b0cdc087", "AQAAAAEAACcQAAAAEBocSAf5fx+0zsePr9lSVdDrLXSNBTMWhEI2uFx88+Zs9zD2xIIyKKaTF7tBYKbnig==", "827cc613-d7cf-4d1d-9340-61c675ada821" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97fb06bd-6d0e-45db-b85c-f4d41820329b", "AQAAAAEAACcQAAAAEONTa4L+BQ+Oic79I6ePs8m90qgCVXL1Gk+EZfUWdcAN1xvkIIUgd0ybAo48Cw8gvA==", "40445cb9-dc8d-4895-b459-508cdee00da0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e2f0283-0fd8-4eb9-8fd8-5bcd68d232e5", "AQAAAAEAACcQAAAAENJsygkqDF+rGp4HIYjdLRvupEz1sKADBIgRM62F1per8NdZI20bWurvM+v9Jl1H9w==", "e967d64c-d702-486d-9ac3-f6f3ab775d6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c89766d6-50c5-4f26-880d-4a44efd53ee3", "AQAAAAEAACcQAAAAEGDdH+VxlUXKowvvuj+4NdL7BVxiz64hwPxIF8sZbUBfSNEVtPwS4szh8chULF9nRg==", "df989fca-146c-4454-ae10-18a1497b0f85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35ba62d9-94da-431b-b810-3434d54e4ddc", "AQAAAAEAACcQAAAAEM54nZ8lNPPPac6p8IBNbe9gMutEMj4kaTXjTt36RpjLHATVcIQNDh2XTqHTOBBXVA==", "43f30d61-d831-49be-a37a-1c335a0d6429" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a406a4e4-2411-4d49-899d-a80a55d29bc7", "AQAAAAEAACcQAAAAEBq0GbbTJyMOg/5Se0mYhz5c7SzV9Vlk5lOzS/XL6aplbbMwaqty52xiSeXRvGQOVQ==", "e1eb993e-2ca4-4667-a8ac-0b342db5458a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a67e8f82-81b3-459e-b62d-2c69c50a630e", "AQAAAAEAACcQAAAAEJ01WNROa+lSMTu1aYbRX5aXwCPL4qCbIFS1WLxx+vzMhXDMFZM4M+xNkRHv+g20wQ==", "47c35716-7e3d-472b-90d7-65628b170c05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a258f98-edb3-42f1-8e50-e07042c2f6f8", "AQAAAAEAACcQAAAAECgtgt1ClQIQflO9xYrqruN7MwknzbJcr4XJOw24e5ryuPHevcub4LGVzap1VzGQYg==", "4de89c0d-17ed-41a2-bccd-af1f1cbeb255" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1aa11e66-7f6a-4c85-860c-432149382543", "AQAAAAEAACcQAAAAEH8Vg0nDLjsT9sXN2lbCOR5cBqmAhM0BGTB3Rc3MlYF2PLP3swFff5iN0LpNlLB9OQ==", "9281578a-ba5b-42b0-abcb-af36c3f94fca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e21d1f8-a0fc-43fb-af15-e4beeef71ddd", "AQAAAAEAACcQAAAAEDLh8LyzkAAL50983lvbipFKbHnNDroJwcbLPr8Ul4Qd1Z0Ftg3KaCmYrR9X2SESQg==", "541cb129-ef2d-45d5-aed1-956e808f5294" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f120558-e3a4-4552-9d2b-eaa09b81728a", "AQAAAAEAACcQAAAAEIeVxpdPafuZL/Utu0qTXiliLccTMVbtNiJPXEtSPjV6D2aq7vYoifo6g3dTH9hgnQ==", "86aa45f0-d508-49ae-bf59-55b75b89f33c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "437c8236-7a45-4fa0-98b4-36d4e4ab38ce", "AQAAAAEAACcQAAAAEKe2DQtZmcteeLTIjIrUoZxYparWI/+7rcP4G3g53eYE2W8FYhrHRtcKeN97qGVCkw==", "c6d71556-5321-414f-91dd-f16d6f584a58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16ea5d38-2668-470c-9c0f-926ead0cc9c7", "AQAAAAEAACcQAAAAEJl+TPotB7Rtmkrmxf8Uc0YQxcyLO0kZebql9dDSJ1T08OtNnqqjStprRma0r+Ntdg==", "157496b2-49bc-402f-8a67-de2c4d8a130e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d85f406-0e25-4511-a963-cdf10ddad6d9", "AQAAAAEAACcQAAAAEI8pNVeLJQkO0/ytOF7/kdM5QJUWDLnt622+ueE8Mz046KX62lvz66WT1EvCQLGvew==", "ecd3357d-a1df-4c3a-ad17-5009ae7347f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb2799ab-d300-43a4-9394-61d769594d23", "AQAAAAEAACcQAAAAEK02uHBcikxWrgIzy5MDpzXGYen7KFEFLG9oQhPOdXa7eDE8Se0e7nclOZ3VhvYT2Q==", "f6c649e9-ce2c-4dfa-b67b-4996a180de7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50349add-e6ce-4d29-bd20-bc2763290c3b", "AQAAAAEAACcQAAAAEMN85gxPzer4FrPCKFNebk8y1R5AB4q0S/Sp7pjpPv0Er9KZx1qN2MI7wh7gfU6Izg==", "e0bd3e3f-5a45-4c5d-b58d-c7297e5c1e89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70e87c7a-1548-4fdf-85db-641ea096d1f0", "AQAAAAEAACcQAAAAEJDiKKBdqc3ekIIN+B2eVkE07GAZ2HX88fWEpl0tQliAmYlr38aEdNsWjtg1ok1mWw==", "6915bffd-7d86-4112-b3f1-aecf727fe132" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aab7c5b1-6441-4a95-9550-4b0d019d891f", "AQAAAAEAACcQAAAAEKNwmlT45tcV5qPpwRtXfSpFhH/3IRrdC5LW/TUdrFKSpgOQ/nYBZ/JwUsRI8bpnTA==", "285f22ce-ab25-4ac0-bfcb-f592d37fef4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c536518-dd5c-465b-9c0f-d8c762eac98c", "AQAAAAEAACcQAAAAED8xXRikXHBddB5dY8kv+D3ZcUD8A6YNi1ceBsFXM7hgFrdCgjoVu3tcbrRdajAJlw==", "a19cecf5-79e6-46cc-a3b7-c6394f62f3f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d79fff00-2c2a-403d-b0f7-9582321b4b34", "AQAAAAEAACcQAAAAEKd9Kp/R4EZcOMwNTKYCjV43bUA7cn08WVRrOV9HMeHZuLIfKdSKYhPPDCqqj3U8lQ==", "9f283891-a6a3-4da7-b9f2-8675ff6edfb4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2512f76a-294a-4475-8bad-ea44b4b93bd6", "AQAAAAEAACcQAAAAELAoIMj8/dC1kioeFCrUdPhmkRiq4Odg6yb9yiA87Iztb6WJEGZC6pZ1JA2VQIRQrg==", "2eccfbd4-aa56-4025-8b6d-4f43efa8be53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac7c40e5-3884-4599-8d72-fa64d4d0f09c", "AQAAAAEAACcQAAAAECpHIEmkEIQCXmhXN6nWpf0ZnoU4tgZdpeAq+/reXXxkaQ+ckXwK30cr1ASflHtjUw==", "00ce25f0-6659-4843-b9a7-e3484d50674e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffa5d035-9c0c-4eb7-aa67-509d92a1381b", "AQAAAAEAACcQAAAAEKy96bjz33pvWvRz27wL4L19FC99y9eIaiyFdwAkCAgnx8GTtxgQk7xydu54Qty/Mg==", "d96d109a-8a29-45c0-a4f6-5406b007d05d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca38d6ce-51e4-4851-bbc8-0e56bd864fa3", "AQAAAAEAACcQAAAAEM6Rrd69OpnpY4VS/cg9cNQoF/1aN4wMNYwfjE9CIsURoh99qJbnMX7YjGhX5ksNDQ==", "213dd03f-89d8-412d-afdb-4fe35c67e180" });
        }
    }
}
