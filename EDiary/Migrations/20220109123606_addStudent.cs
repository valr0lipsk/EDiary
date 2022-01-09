using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class addStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "7d414aa5-dac9-4289-a97c-d75fa349c6a1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "9688b048-a770-428d-8ded-8fe3832c6bd4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "6a339c76-eb44-4075-992f-589bf019d192");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c67e3ef8-0221-4014-bbed-dc7c2b7ab0be", "AQAAAAEAACcQAAAAEKxshtzEr289ADehRAwHIkxPauK8xiW8oJAIO/Mb/q8Gs5Fo17Tdmq92yVoGeRpzxw==", "0c2d5eb7-f8fc-46ef-9d4b-3000935dc0fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19a8c810-08c8-4a0a-99f5-2ef5e997280a", "AQAAAAEAACcQAAAAEL85+csghmXReWHQ4Xj/MsqIyFWofDhB1QdlZxBYmhernOIlQkrO4oJi6hG0FZtkQA==", "59f877c2-d813-436d-9104-046766c4115a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2650a5a-1493-4052-996e-1f9215455e91", "AQAAAAEAACcQAAAAEBU4KZJFdORkVxcAg9AboKluStfAmtmpmgouCgDotIehW7AJ1vATzDQcF6U02ou+aw==", "c171bb02-230e-4276-987e-0f76acefe4a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "439a88a5-ebc5-485c-a797-6f641afcda81", "AQAAAAEAACcQAAAAEJqyh9YtJWdfOzzpx14F4WO0bHPsVB5L8yiNk1Xq7RoU2KV0yIJLYgOp5A7thhGP9g==", "b887ce99-2065-4ec0-b0c4-8b16810eb253" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5072d095-da9a-488b-b6fa-21b67da63686", "AQAAAAEAACcQAAAAECVrHDmBMYHASJ7lkfhRL1ob871C7KTbQQt+2N6Dy9p/2nPoKLTln7TNnY9pLkowvg==", "6733d4a7-0184-4619-af08-f32367c9c3e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c483eb3f-ae2e-4b83-af77-dc0a35285385", "AQAAAAEAACcQAAAAEGg84VmYVrGghwO1vua/BEljMXieaIOxXpp1dugXHYX/9pVHI3BMfAh1XEl2QvDd/A==", "0efe2d34-13ec-4893-8381-f02171389b29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4f0cec1-753c-4893-b2a9-301b518af7d2", "AQAAAAEAACcQAAAAEO6IvcsPUo+czq9wRX0M3L13fZZ/PIiEOj/RXpo+XHa3HaGzxvT5tkET0sXhLuUu2g==", "a2e318cd-dec6-42d0-aeaa-479e7bb0be12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f664e97-ab6b-40ca-a75f-ea3e0993b468", "AQAAAAEAACcQAAAAEC9HsErR6PKlTL1J+JihLYTjxcxg4RwzOVgjVJBQejeWjgbETSzQKpWOZRo1teuZPA==", "e1f69750-60ff-4661-8390-bc8141899a4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f988af2d-6573-48b2-8374-cc0d3cf63330", "AQAAAAEAACcQAAAAEDFsTi6kTBHxCw6i871KFyaVpctOULP8ynjaTkkqJNxGNkVvgMFM/nFpU3agZYq4WQ==", "3d23c635-d432-49be-ae32-f609e28e3e84" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "37", 0, "0867d5d0-cd96-457d-975b-5d8098eee53f", null, false, false, null, null, "ST000030", "AQAAAAEAACcQAAAAEENIMCd3MFTKDCCxc09xj8E3mR/G0s5oqi2dO5V0QAtgffgMivSmAJDiutD0VlVR+g==", null, false, "b6c226a5-74c5-4071-9e44-78171f31b61f", false, "st000030" },
                    { "36", 0, "34d08df8-2a26-4ac5-9f53-76428d697c95", null, false, false, null, null, "ST000029", "AQAAAAEAACcQAAAAELVD2dbIPrmb09679M6tMXR6jnl3wVdhvW5LqJUqGRRH0ZP1lbMgTIhznZcmXdYIGA==", null, false, "6ab12e4d-32b4-4f82-bcca-2c45aaf582b2", false, "st000029" },
                    { "35", 0, "dfec322b-5bd7-4cd3-9fc3-a818725a081d", null, false, false, null, null, "ST000028", "AQAAAAEAACcQAAAAEHYF2Yxg6/qTsOpB5UxgHNmsFo4s5yYP00cZAAQvpZzohToCEaDfHOxKWRpcD2HIbQ==", null, false, "fedea50b-2694-44e8-97de-e3af4a976908", false, "st000028" },
                    { "34", 0, "f583f53f-e0f2-4160-89e2-8538faf9cbc9", null, false, false, null, null, "ST000027", "AQAAAAEAACcQAAAAEALr4sE0G33bOh3tYSsLdYdX7Ow24Tnxg0bF7d0PLY1Af0OVdXKJ9hXmyKh3x+kHaQ==", null, false, "2e00545d-bf9b-49d5-889b-de20ecc81c5b", false, "st000027" },
                    { "33", 0, "2d80abdf-bef7-4bc2-a5c5-a19590423973", null, false, false, null, null, "ST000026", "AQAAAAEAACcQAAAAEFKDJsNLQEAXPhHIxlM7ZRYwE1mfMRduadgaCoVCJs6OFQ8ARScPSOQ+Gy84gsJwUw==", null, false, "0e8f2bd1-9b1b-4dc2-b8a4-c047a1ac6d69", false, "st000026" },
                    { "32", 0, "66654a18-63d4-42fa-ae2d-320973f951e3", null, false, false, null, null, "ST000025", "AQAAAAEAACcQAAAAEKfnS57/pgKL0j3htqJIiKQQb9xbjvRcbrOI5u9CCJcWThuGSJASMcgWipegMQyWhQ==", null, false, "ddbfa1bf-a0e3-46cd-80a9-163a3d6e17f5", false, "st000025" },
                    { "31", 0, "bc0abdc5-fe44-4108-a051-6bf760d10084", null, false, false, null, null, "ST000024", "AQAAAAEAACcQAAAAEAbtIB0KfEXYg9Fh0nYxLzV92hYecccT6tucWv0j9ioi4e84XYtVc2VuRFPZELVwjw==", null, false, "6b01fd8a-604b-4777-9c57-d83fe39f5995", false, "st000024" },
                    { "30", 0, "e9335b60-541b-4814-8f73-5547b1faba68", null, false, false, null, null, "ST000023", "AQAAAAEAACcQAAAAEAa14jXW4CrwB2aF7GJAFE0fkbqcpgqp78jac8GVf6ayPzw3obZhRzSqr7mG4UsWAw==", null, false, "e7d82396-5db9-4c26-8283-e1f90e1d9bee", false, "st000023" },
                    { "29", 0, "7f8ef1c2-64ce-4ee9-8f45-15875b9f034f", null, false, false, null, null, "ST000022", "AQAAAAEAACcQAAAAEC0L5cgbG72TyUl3ecklJm50LHtkvOX8AV4CmiRPkSpliKQ2SbyAm0soZeonxOJjTw==", null, false, "51d865d9-d1e8-439a-8c16-207781b4d3ef", false, "st000022" },
                    { "27", 0, "61916daa-96b9-4af8-b486-58d79721209d", null, false, false, null, null, "ST000020", "AQAAAAEAACcQAAAAEDIMZTwCbPoBNuPgIzA60xt9zBB97rx6puAn8CaFzfgk4gTL+CYA/ctySimu6GXtWQ==", null, false, "fd6860c1-1ef0-4236-ae48-596834e080cd", false, "st000020" },
                    { "11", 0, "5648858f-152b-4f58-93fd-0b264badd054", null, false, false, null, null, "ST000004", "AQAAAAEAACcQAAAAEDtpKsoT27lNe3iwAU6v8M9lhJmQnyQrnu5KK84bdg8igi5YmOzZHOeEQXanRuofqQ==", null, false, "81290a24-0120-4460-ae24-c9cba9cc28ac", false, "st000004" },
                    { "12", 0, "a1d54701-f391-49f2-a1cc-cdfcce3a7e4f", null, false, false, null, null, "ST000005", "AQAAAAEAACcQAAAAEFX3PpaPaboQm0R5/GjQx9EuNslQHG9XgAR7zguUBK17T+ObO+57loWUC8Yiy6jLdw==", null, false, "81cb020f-2822-48b4-baf0-494a1f9be741", false, "st000005" },
                    { "13", 0, "ed35400a-19eb-4eac-bf9d-d0db2c106fef", null, false, false, null, null, "ST000006", "AQAAAAEAACcQAAAAEJUOJ7pF4Myl6j5paxU1bn9CiJR0nIhTutUy9sNkZ/VBN7sfNAQzBdmXLFHpJWpqrg==", null, false, "4883175e-1a62-4af3-af85-add31254f9ea", false, "st000006" },
                    { "14", 0, "a22c93d3-990c-4601-a8f7-839fe3d400ed", null, false, false, null, null, "ST000007", "AQAAAAEAACcQAAAAEE7U6vbyDFv5ls8vqn/N2pk1L30/XG+WLjbJMB15uLXhgtjwc5odCpdWDhyahz/dTA==", null, false, "562706ee-5680-473d-8da2-db9b8e5afdd9", false, "st000007" },
                    { "15", 0, "dd1d55cd-8618-4c66-b8d0-d5ca2f72ea07", null, false, false, null, null, "ST000008", "AQAAAAEAACcQAAAAEHbYy2S//an0ZoWTzI6D5hCm2+s9s8A9DGMbOauPH3z01jzVoxL0KVMmywAmN6WCQQ==", null, false, "4eba1e38-0f77-40d0-96b3-b4d40c259376", false, "st000008" },
                    { "16", 0, "b28f18e0-3cb5-4c81-9d5f-bb94441c4cce", null, false, false, null, null, "ST000009", "AQAAAAEAACcQAAAAEMEr7lUUL7ob2lUTzqnGSXH+7PFkbH93A90zlwE9IYFxT5ivChw5zTelNODLyOo49g==", null, false, "1a4e3bef-250d-4919-941e-35f922b474bd", false, "st000009" },
                    { "17", 0, "b10f8031-02d2-41b3-9727-b68225a1b495", null, false, false, null, null, "ST000010", "AQAAAAEAACcQAAAAEPrcO3W0RXrUlUkO8bUGvdx3e/h4VWDZD3Y6678uXIIWBW0KNEL8EcfWCFbXADhW8g==", null, false, "7bd9146c-9ec3-4396-bcf7-b0eaf01c3ba3", false, "st000010" },
                    { "28", 0, "d01f9825-ba79-44d2-9774-58c99623a2f1", null, false, false, null, null, "ST000021", "AQAAAAEAACcQAAAAELyZSGIYpXf46KnQ7nAVKUCZacet0b8f1ODMY7bJlf9rW9hkb+tFu0pRnFRV7FiJ4Q==", null, false, "fd68866f-9aa0-4e03-9f68-1ae4a148e4d2", false, "st000021" },
                    { "18", 0, "a696f8bf-fde6-42d5-83ab-5b647dafb6a7", null, false, false, null, null, "ST000011", "AQAAAAEAACcQAAAAEG1mx/leuWoH1Bcog6trYP+ioZvw0UNxm4tAHdo0YCbhOXfYNlU6pSGJIq7kIF0big==", null, false, "80e7320e-b6d5-45ad-8702-ddaa9c1210e4", false, "st000011" },
                    { "20", 0, "d7ef2cbe-500f-43fc-a855-0694c710fa5f", null, false, false, null, null, "ST000013", "AQAAAAEAACcQAAAAEG3BybzoPCiwPl8Tf6+B2Klnzlr26qpyDuMsxHa+Ss6QR4WxXDjbTe69H2pUJWR9mQ==", null, false, "70708257-b4b9-4a68-af00-cd0d3656b38b", false, "st000013" },
                    { "21", 0, "01acf754-dc01-4a5d-a32f-88b093c7b740", null, false, false, null, null, "ST000014", "AQAAAAEAACcQAAAAEA+BUNujKF7qXiXOgbEmFrcEwMbSnpawbwoPOzq8DOP4o9+iWCD6asGa/6NDZLGYHQ==", null, false, "831b67ae-f1c3-4739-a21a-aec1fdaa9c79", false, "st000014" },
                    { "22", 0, "8740971f-b96d-4e23-af4d-dcefd0656b5a", null, false, false, null, null, "ST000015", "AQAAAAEAACcQAAAAEJL26eY19hFnmYL0JpxKYw/Evn01UfOEfLq2+pV00YYiwncqEFKUWe1uYFlHyZPn1Q==", null, false, "d744b728-c008-4fc7-b75f-373c83df4689", false, "st000015" },
                    { "23", 0, "36a71c1c-7824-4281-80e4-4ef122847ca9", null, false, false, null, null, "ST000016", "AQAAAAEAACcQAAAAEFDgPOrwOUUIVQtT8isPHdUaUK15wysRfUP34P3b7FST7os3gmCPURkGX+6eioc8RA==", null, false, "c9dccd57-f269-4fba-94f0-0784d079815d", false, "st000016" },
                    { "24", 0, "b6bcf4ee-00aa-4dac-a05c-1fecbf0a4f1a", null, false, false, null, null, "ST000017", "AQAAAAEAACcQAAAAEIkIyEVAUTqYJ0/wh4JNQtjd+eAP7pyNyTw4h5NnsNGhk1vc7CYbBeW82dfsp1tLjw==", null, false, "19ad13fa-b0a3-4e82-a192-1ac7ae5fc466", false, "st000017" },
                    { "25", 0, "07470af9-7290-4ebf-9880-6866c31862a4", null, false, false, null, null, "ST000018", "AQAAAAEAACcQAAAAEAlcdNL5l29da2PCABe+yijC51uAeWB4cmZCkzocv2N30xJZeZ0TYDHZ/mXFqUu13Q==", null, false, "f12dcd5d-e91a-4ddc-b02a-477755850616", false, "st000018" },
                    { "26", 0, "280e5abb-5a2d-46db-a58b-af2b081cab3e", null, false, false, null, null, "ST000019", "AQAAAAEAACcQAAAAEJOTiHSB+sp2YgNL+CHxz/RSZo9a0chsxaBpB/GLD/T+ZIxq5u2DEhRKEoVGkLv+VA==", null, false, "1020b9ad-a41d-4e25-9bf2-f05a7c273437", false, "st000019" },
                    { "19", 0, "75be18eb-e605-4719-953f-a17e9753f78f", null, false, false, null, null, "ST000012", "AQAAAAEAACcQAAAAELw7DB5H/CBJHg15KSSCZpej76L4Y7UijrhAk8UmCWX63ClnB8baWKpsLoW6UZRLOg==", null, false, "97ae4a9e-17c3-4f1d-b72c-21840e63957a", false, "st000012" },
                    { "10", 0, "c7cf4fac-7e9f-4941-8cc2-821e5af4b8f0", null, false, false, null, null, "ST000003", "AQAAAAEAACcQAAAAEIEonkLvk2jzH+FxOBZgCoNuG5+OIUohbbhoPAtz5ZWlk3nwJlCVkZwruayhAsXk9Q==", null, false, "c85b1428-6368-4fab-9e91-85fac4516970", false, "st000003" }
                });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "studentId", "studentGroup", "studentLastname", "studentName", "studentPic", "studentRole", "studentSurname", "studentUser" },
                values: new object[,]
                {
                    { 3, 2, "Дмитриевна", "Анна", null, "student", "Бичевская", "10" },
                    { 28, 2, "", "Роман", null, "student", "Чэнь", "35" },
                    { 27, 2, "Дмитриевич", "Максим", null, "student", "Францкевич", "34" },
                    { 26, 2, "Андреевич", "Кирилл", null, "student", "Францкевич", "33" },
                    { 25, 2, "Аркадьевич", "Никита", null, "student", "Турута", "32" },
                    { 24, 2, "Александровна", "Мария", null, "student", "Тимощенко", "31" },
                    { 23, 2, "Вадимовна", "Анастасия", null, "student", "Соломевич", "30" },
                    { 22, 2, "Александрович", "Егор", null, "student", "Селюн", "29" },
                    { 21, 2, "Игоревич", "Евгений", null, "student", "Савельев", "28" },
                    { 20, 2, "Святославович", "Иван", null, "student", "Мятеж", "27" },
                    { 19, 2, "Олегович", "Сергей", null, "student", "Ковалев", "26" },
                    { 18, 2, "Сергеевич", "Даниил", null, "student", "Кобрик", "25" },
                    { 17, 2, "Владимировна", "Ксения", null, "student", "Каначевская", "24" },
                    { 16, 2, "Леонидович", "Никита", null, "student", "Казачук", "23" },
                    { 15, 2, "Сергеевич", "Никита", null, "student", "Иванов", "22" },
                    { 14, 2, "Олегович", "Константин", null, "student", "Захарчик", "21" },
                    { 13, 2, "Владимирович", "Антон", null, "student", "Журомский", "20" },
                    { 12, 2, "Павлович", "Иван", null, "student", "Глушков", "19" },
                    { 11, 2, "Сергеевич", "Александр", null, "student", "Вусик", "18" },
                    { 10, 2, "Сергеевна", "Екатерина", null, "student", "Воронина", "17" },
                    { 9, 2, "Дмитриевна", "Дарья", null, "student", "Войлокова", "16" },
                    { 8, 2, "Андреевич", "Владимир", null, "student", "Валькович", "15" },
                    { 7, 2, "Андреевич", "Николай", null, "student", "Беленович", "14" },
                    { 6, 2, "Николаевна", "Мария", null, "student", "Барай", "13" },
                    { 5, 2, "Сергеевич", "Артем", null, "student", "Деревяго", "12" },
                    { 4, 2, "Андреевич", "Матвей", null, "student", "Болтромеюк", "11" },
                    { 29, 2, "Сергеевич", "Захар", null, "student", "Шибаков", "36" },
                    { 30, 2, "Вадимовна", "Ксения", null, "student", "Школьная", "37" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37");

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
    }
}
