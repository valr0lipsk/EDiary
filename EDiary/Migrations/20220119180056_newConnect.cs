using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class newConnect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "typeName",
                table: "lessonType",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "8564fa31-c254-43fd-bb54-f981ee438431");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "ba616f61-db84-452c-9207-3373a9bf2ab4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "1b09e68a-cd39-4aa5-8aed-30792eef850e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "b5b0f8ca-11a3-4b2b-b728-07e57347f1d0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b18afc4d-2274-41ef-81b2-bf6e58d2ff18", "AQAAAAEAACcQAAAAEEDyLSZQMvArL0901orR4P8Bmsam6V2pTMWgmWb+Z4gFXoYc/ET9ezDNyLhetwCYWg==", "8d0b4952-2d26-49fd-bdb2-9a614bdb7218" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8497938-df0a-4d4d-904c-436990e21687", "AQAAAAEAACcQAAAAEMSBH/FPyq7UgX67UCEKI3syWBpfD+xq8Uf9k/YigaZnktp4YLt/WIwIaBAoQDkg9A==", "2310b5e9-8ecb-4968-b622-9dd8f366bd19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a5ec8c2-3ab6-400d-9772-ffc37e17d72f", "AQAAAAEAACcQAAAAEKSadNNi/HoIpxrsnZokNXvlpLzay9wOmKj186O+PCp5reUMnIvzwJMQaolIluSLfQ==", "128d1ef5-6352-40b0-9a7f-b3ee9c61a760" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f14fe32b-e02a-45bd-bdd3-145ccb94e738", "AQAAAAEAACcQAAAAELWUwLZh/CP9Zb77j4zhPz5WkHeVtVXEi5C9buyw/kDHXnf0GUlav7w13jNCgdb2Sg==", "ef1c14f4-5e10-42df-8f31-adc36ebbb5b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80bfee0e-a6d2-4a93-b880-914e5807e1fe", "AQAAAAEAACcQAAAAELlqnAHXZ76awvlbA2JCzbgANbGFmt1x6PYtSxmTRocx/HHe4u47luT6jjsK61yskA==", "80a9d587-baf4-451a-8a4d-7a39c5c94c92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c47e0e32-7ae2-4b73-949f-a4385f0a4a26", "AQAAAAEAACcQAAAAEEqHVoaz9fC85Yed+4jYr9rdskmoHd7IR4sf+6IbQQ9xynDUpwOb9YKRWdirf/I8tw==", "65ae3117-c1f3-4fcd-9482-dc56ab82edd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d91ad514-9f82-4877-8665-aa1f08307d2d", "AQAAAAEAACcQAAAAEAbEz3zTe2+ulo6sP44BpKSU2r2YHOmZvMN4ncwXE9sF67leAsoNQl0DeqKuZG7U2Q==", "c19abed3-54d3-4dcf-b7cf-22468b7c8611" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d299806-6cbd-40f7-8b1e-aff30a5edac4", "AQAAAAEAACcQAAAAEAoyGU6EY60O3FxKvMo38WFpSnWBsYgEZ95EqMOolq38zGFKgdA7vqRyX7R0UtXDRg==", "de2527bd-c81d-4271-8693-f8686c3fc102" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f85971a6-bc37-455b-b6ea-dfe279652826", "AQAAAAEAACcQAAAAECOFyckh2WthVPuO8iZ34N27gk+2wTp7F6MkRoeO8y3Nfn6Ui9RC5dIWjJyKyib5AQ==", "fe2e5ed8-9eac-4e53-aa92-8ef1269d56e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "878c3975-bd3f-4c1c-aad1-122221a46408", "AQAAAAEAACcQAAAAEE6mfcBepgqODKEjG698uhmA/nQjRNmPoBjHWlyH2N3vypDklY9zqPU7mpsK9UpPAA==", "c8bd6928-6a6f-4141-81cc-3de5547639a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34acefa1-c6cf-4288-9d3f-f2645c172406", "AQAAAAEAACcQAAAAEHunwpHSOmYy269ujsIeuV0Pn5p0rg6sxAiPf+23DuNVtbl8j8HwK+SRr2qRFnZFkw==", "c66301c1-9aff-4c30-b7ed-cc5cc5d5d03b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e616fab3-6b3f-4a04-8d31-707c9e881cee", "AQAAAAEAACcQAAAAEG4k/R7WV5+rj7B7hmSsPU9TomNn26BvxK8PtaYxHx0rJ70eecYqXwe6018vfLol0A==", "6c7e4a06-249f-483a-8d5d-b77cf99beae9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18ebef17-e65f-4fe2-bcf9-f158833113fb", "AQAAAAEAACcQAAAAEEf4xcg4EfqdRTkvR2rEozHtO0ixRc+m7Y+e3VQ8scIDLGp4xA3ZmEr/5WN7yiovQA==", "581425e3-420f-4da6-b310-298402c8f68d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11797a06-f12e-4c62-a8f1-1ade628f45f6", "AQAAAAEAACcQAAAAELwvtK4KAvqnL/rtT0P9SSeu1fL3uSffyawkyq1+W/S2RKoYQja6oF0fLq851nF+3Q==", "d133513f-c27e-43af-8aa5-30b8b9ef65db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fa60d81-5dc0-4eee-8226-6f9b8f2eb617", "AQAAAAEAACcQAAAAED22JI2apYpqoUdJEANaXSXpGmEndKRbHt3FJrYL/xlf6T9st6tPNbWPET862jIALA==", "9f905d3c-a718-4dd0-8463-283164c28e76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efcba6b5-a4ae-480c-98ad-d74019c90e10", "AQAAAAEAACcQAAAAELhOYiobAGEPQGTYSxRgXKxXkHPFYbFQAR1Ug3Qfww6KyUTfg3YKvMfB9dHaNIrRCQ==", "cd04ee77-c69c-4872-b7b5-6c11b0e087d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2568ac9d-9c28-4574-8550-0e53caf18be1", "AQAAAAEAACcQAAAAEG35pkbxdJBCQ+2Rf2GLsR5occbu+NsThHPwL/dqJNb1zQ2uZ7LfgFOcD4PsmUERHQ==", "88492273-c96c-498d-9118-c21fde18e3b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70cea2a5-7c90-4dd5-9b75-8e5dc9ac6ffc", "AQAAAAEAACcQAAAAEE/hJpi6IwPDg7z3X2DCPOjdo64svHaJuCC55jfJQ7vu+7779gpn/BjoI018BQihfA==", "e2552a6b-cadf-4837-a223-309c4e1aedbc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33b7ba9b-194e-4153-9427-409e706928cd", "AQAAAAEAACcQAAAAEKJivX5Jf3L/o83FEFYk2VZOGmAai9K/x+vEz1Ldr5vOLA3sKYdRuHvb4uTeaUAEOA==", "1ee7237a-6e3e-40c9-9dbc-7a9255c1285e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38c9458b-5402-443f-b8a7-0e121fc76ccc", "AQAAAAEAACcQAAAAEAu2CAARTDgfpmoBMnDwuZPO7fEPczTYrIGcyMkRPt0aMq1RKYJyHG9kym+nrTkCDw==", "8cb75b5a-02d1-447b-8cde-0eed25e9871e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2cebfee-a419-4885-873f-9764b5b5d8a6", "AQAAAAEAACcQAAAAEBneiWgxVgvC0iRXfaCxwPSb7k8gezdh5pvEQPG7n8NWgVIF7ucBALSSTiqs4PKfmA==", "eff2c48b-4fb3-4dfa-84ce-6dc4debbbfc5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55b0c608-f95a-43d3-9153-26f4b6070c0e", "AQAAAAEAACcQAAAAEGunyi6TdxXnj8et4Q7O3uyyMaT2f0e0vci8a5KgF3HDLroT6YAb0uCzAM5b6/Ba7w==", "01272ace-4c2b-4e59-a1e6-39a8aa9d4d39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81141bb8-30f7-4f33-93a3-247f8fdab143", "AQAAAAEAACcQAAAAEJmMQG672XtC/Wd+bdXBxR1RFj6C5PCbd0q6xAGEvn+85Kw5U+02IzwAUL5U9/KT5w==", "ad7f87f9-01f6-42f3-a0a1-ff0286b5fa05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8eb0539b-569f-4d23-8515-de7ee24b871a", "AQAAAAEAACcQAAAAEEkUQKquBVDMlcRMqJd/YNZhT03q0UT7BJuIu/1aXQ2MVGonPjAW1p8v1YKu4/Mx9w==", "19e866cd-92bf-4bc1-8ade-3af66304cfba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71e564c6-bf53-4e08-bd91-677247d06938", "AQAAAAEAACcQAAAAEODu1uDQ7WdOqhauBnwzmYCIzQRoD1qkg8M+X4yOqTGVz/Uh2h771iyf2zxGj/OAlQ==", "015da427-a2ea-4789-ae0b-cea6aceaa73d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5f96a8f-748e-4f53-8cff-0caf211b1050", "AQAAAAEAACcQAAAAEMNGOq4OOKgsR+7dSJv+nqAiS0t6F5+eyeZs0FvUXhBtijLNqD3PJQyhx8fr6vySGQ==", "857a1eb7-adb5-4e80-8b4c-536e02f363fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44b3f88b-6839-4cbc-a004-db7674b0597d", "AQAAAAEAACcQAAAAEAa1D5PJaV5JhGrtSDW8KUOJfzpMeaMYhgu5M2nwQ1AfOB684qi6o12UZ+xSzzBHWw==", "a42aaa89-b32c-4b71-b2fe-98c4dd64c0e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3ddac0c-a47d-4d0c-ab58-0bf43969726a", "AQAAAAEAACcQAAAAEOtJsdZm+R2urcP47pX9c5WpHi/SEpIjuuP5JU/IoKpBFW/ffTKkJ90wW1HzDH8WkA==", "f079f3e8-7c9e-4b4b-9d99-cb8f91922527" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b19ce479-c1e3-42b5-bcea-b8e473ba87d7", "AQAAAAEAACcQAAAAEF6lYyvP1BeDmTsqc/OldnigYZJEJQeag7qWiqt1Jj58Tvu+j3icxgabnj6qOE6+Ug==", "afd7e47e-118c-4261-8b83-bc0fc69eb317" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "122bf9de-8a73-43b5-81c7-41814b6a2469", "AQAAAAEAACcQAAAAELiGgbjNONzCkbk+vO7SqDWmP/P+SUok6sVxJC0Ccj4wDtGneTUlzRF89GGZccc6AQ==", "1d8bd3a3-480d-4ce9-b43c-fb199248fd11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebf0cf92-fd37-4ba4-b68d-3c48c9cc0c52", "AQAAAAEAACcQAAAAEOHPvmhH+rnm+fOl4FTgKaPZT35X0Ass/1KvBT+7MO3J9uf0VPZvnI8ZZcwfPVsOPA==", "d3a1be14-6b83-48dc-9640-85e9973b7746" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fabfd61d-ea6b-46f7-a01a-8a763080f043", "AQAAAAEAACcQAAAAEEGFbuRVA3hrR4MUYcL6DSQMx19tb+OWbk7/e3UwLeAOjBZnYCKo6kCEYnGg6hK91A==", "1005b9da-c2e5-436f-a375-aff19fb28308" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "714885d6-6152-4572-9feb-f8b9a69939c0", "AQAAAAEAACcQAAAAEDU5hOyYe8vSC5His8zqWeMHSC34o8V8wfdf9WRDzlxZ4/4/FsyYQU3Gw0LXB1PQIQ==", "93d923f5-d1f8-4c74-8043-5a86f5ceb93c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e9ee8ed-4aa5-41b7-b952-aa98ebfcd5d1", "AQAAAAEAACcQAAAAEKuyclPO/ASV5uWHephQmEa/TWtvzrst7ildYUAAdD554RpMFl6y2gqpLj3YckOLgw==", "65f43118-94d5-451e-b12a-5cd6aaa21a23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "910a6329-b996-4ddd-9e23-5e7ba7dc1027", "AQAAAAEAACcQAAAAEEKRMlH7Pldk2hxDi/YTd4bPUz6laWH1ryPPi0gRVNqROh3Kk2gAIJa+IL/Kjucaig==", "c8d1515e-3042-444c-bf59-fddcf1e336a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "850d83cc-a86e-4bd5-8566-986e123003aa", "AQAAAAEAACcQAAAAEIIvIEhotKsUrU0KJxpOAtbVrCeEtG7laE48o33uz7Yk8LTzRaYPh7/mP3FY1u4E6A==", "fc787df3-50ce-492e-8b91-51a8d21dace8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f31be2b0-c908-412f-8134-6bcf08af9a86", "AQAAAAEAACcQAAAAEFlhNiGl5F3eh/OfM70jObcpVbwBECSEcd6b93IJIGCEiobM/zumKyLFzXdB0RdV6A==", "8c10c80c-a5de-4ff4-a332-e181834e553b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "typeName",
                table: "lessonType",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "04379e8f-9e05-4f1d-bdd1-27e0af96e708");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "fb8c1055-71a2-49b1-b083-6083a02d9d68");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "4e8ee4cb-6e94-4bbd-a431-8ac4cd89c328");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "6092a27e-9124-4277-ac3f-50805b36a064");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f25b0ec-6399-4b38-9c06-1725b9df2738", "AQAAAAEAACcQAAAAEBaPgwE8jtODTN0JMyzxoOMjd3xkCg7KQrWK+cL9MgDc8Lr5XdUjYQOMNVOXHnnh3g==", "6fe26b66-c75c-4ca2-bf1f-d3a5aa5ad1d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c44689ee-2820-4279-a9cb-98232fda0f00", "AQAAAAEAACcQAAAAEDFFXmMFsxZPAEF1O0mCswK+xqeHv2WsknNIm9PNHEJjzhe+d8atNoX0d42lT8XS5Q==", "d51161a0-b930-489f-b262-e48c41ef3b7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8b56ea9-75ad-46d8-8d83-f82a0e97db49", "AQAAAAEAACcQAAAAEADp5o2wv9gY6OLUS00BrHjDVkaIaeigL6CYMLIU6iVRX2ONUKQnxtSW7b+n6If/SQ==", "01216ba7-f911-4fa0-9c3d-97d78c2a40c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bafc881-249b-46eb-83b8-8e911cae0e6c", "AQAAAAEAACcQAAAAEDfZmQaQPCCqJMwxhW+us3+tn8rksfE1mbXuyT0N4oNKAnzVI1/M8lcHWZhkAXdUYA==", "db5bf509-a34e-4fb2-9dba-880e366effb8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78cd6461-59ec-402a-b53c-48ee01a3058b", "AQAAAAEAACcQAAAAECg/v57Fd9H5UEtVUGOGw5g4THXJykKMDj3X2xONgYRCYozkefrVRpkG8voQCjtf6Q==", "a53663cc-ec3c-49b9-ace3-83583c3e9810" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0b5b591-8989-49ae-9098-2f801620a25b", "AQAAAAEAACcQAAAAEM2RpUSK/3Mok4VMQ4Ey08NT4KuNFt/0/LIA+Pyrp0zvocC7iILPxkPtCYMTYpo+Hw==", "472072d5-611e-4345-9e6d-082e2dacb525" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2effe7c8-5c08-4c39-a6e7-0b8bfb59a20a", "AQAAAAEAACcQAAAAEDiG7fAk4Ncf5vgG0ExyHFzOn5SZvHeetpS54Vi4rZ4m2ISN+0h5Ve56yZJXdJDt9Q==", "d06f5325-6d8b-4727-afa0-4128dd166efd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "502c03da-3d11-4772-aab1-4b2d152acc6c", "AQAAAAEAACcQAAAAEHtJYZwvHEsvp4v+7mymOwXk9Se4eMRqA2ASmaGs6qmbncqHtisEz1GRHcdSjMIKXQ==", "1b6626ce-adc7-4a93-b5e5-5a64d14c72e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "339256fb-783f-47a6-a288-f6399298b0c1", "AQAAAAEAACcQAAAAEIygqPy74D5L+KbkaPg72vEUdH5k91ly0mrv4DK/n+e/XuaHeEMhyglhHIrlIP1hLQ==", "cc100229-4d3b-4f64-b7d7-ae95b8cd49a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b359bbf-4bdc-4acb-b2be-452cadd27add", "AQAAAAEAACcQAAAAEIHWLRcKfPADL4tmI3VsPFaiGcDLE6DAXofdEyGoqo8AQnbfcYdl6pWv2f07PC5ukg==", "d10c72d8-d5d2-499e-8b75-9827333ffedc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee56a950-3033-4d10-8786-73c9507f1585", "AQAAAAEAACcQAAAAEJS7PfZh+CAGSSUMote9A++KeFuL4+VgPrrGA6EK58OTtxSnGDQGoUTqy3Br6OVnYw==", "4f388c5c-4f11-45cf-bd72-553bb7797250" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a55e7582-54a5-4809-9b91-1b85d291a3d3", "AQAAAAEAACcQAAAAEGhdKfLB1KxV3hV2mMzm30DdOci9E3IIciMcDQiAdPKNXy3DtbG9/rhO8YDj/1JN5g==", "2f7632ee-6a61-4392-9daf-bccc8144d413" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee362d8e-6dff-4d53-9048-c04d23d3b239", "AQAAAAEAACcQAAAAEJBnKWQWucdbphN6LILgRC0S/7wRGvYzDGeMdmDizH9VsnfsxqScHuHgXl0USM/pyg==", "ac703b21-6527-4c83-8b7d-db6389ec4635" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "091fa954-f5f1-4693-8aa0-fcff97b7b1d3", "AQAAAAEAACcQAAAAEFKoxZEQbj1s4IeMh4gV+jl5+qSWjNyHptNZrYTn4LcLCHaqtw+Tnu74i5RS42bK3g==", "58b23431-a86a-4100-bf43-48439b5064ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8d2e68e-4c4e-445d-9e12-cba93dc84d9d", "AQAAAAEAACcQAAAAEG7sYqDqHwytKcyO5arEnurzUuLJM1my7TpLNv9Nt+SnD3u/oDLnZLaqyFaFR7uR7Q==", "a10bd8ab-9587-4046-81cf-c51ff9aec357" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b87eda11-7a40-473c-aa12-7a631c999c9c", "AQAAAAEAACcQAAAAEJ4ejTLD8Jw3R9319AgHyp8GmGdschp4glA/hdThtR875jmkWSFYdjONuGa+rEmeQg==", "f6f680b4-7594-4bbc-826c-49cffbc7cb3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d01a97d8-62aa-4028-a58c-7dbfced14d04", "AQAAAAEAACcQAAAAEOemz9bpnwSPrGQZIDP2RZ78my1v15bONlPQVS9urGQr15yp4nSfHJQS5P3BWdxC6w==", "825f98f1-4dd3-4ffd-a0c0-88df11b05bf7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dba9d4c6-d5ea-4e3b-82f2-0c7125523179", "AQAAAAEAACcQAAAAEPWGUifRR2eoZAvW2C61J58YvKf/Br0P15sfXSVsA4KaZiTaFYakrZIbdpiO3aeW3g==", "044cf6a2-3f08-4ccb-8784-fe628468717a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7d68059-959c-4261-8a29-e6d1c3d7eb21", "AQAAAAEAACcQAAAAELZ8WQkxk8+aT1hJkIGrTfjfh0r3zoYfyGtLIi1aqI3bwKExbBTw7PBgAZUO9GBTmA==", "7ce093ef-1b04-4bae-a86a-0d2a70a624e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2400c70c-bff5-4014-be29-bff8f511b8ce", "AQAAAAEAACcQAAAAEKAX9gzjWXH2P35RPVNPd9xisKIFGeEqaZuMdI2j85PJKG1yTSonrtMSsJPZ2lp9UA==", "8517ff1c-a84b-4848-8c78-40d923575fc6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46af8c05-97b2-40aa-923f-ad9f3fb263d9", "AQAAAAEAACcQAAAAEMojqXAH6RdqjcgL8vHJdSUg/3+vJfAmyvZ/szzVSJCq7J1Qzz/8128uF5SvnbrWUQ==", "faf6877e-293d-42b8-a690-a96108206761" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91e597e3-8c32-48f1-9516-1005faee8998", "AQAAAAEAACcQAAAAEMB9YwR638zpz//OfiC69/pbT5/khZZT7JCDAMZB8LBkqgMH9mbv/YpSc2f3LgMLDQ==", "c18632db-eacc-4473-aa91-39afc45871df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c92c387-231f-40a2-951c-0a3cad5117a1", "AQAAAAEAACcQAAAAECJ0cxmedfHbVCvrty6lOYMncteHvAdUvXn18DVyhh5nGKAEfM7BLRZlo3NkH3g2Ig==", "ff2fc4fb-9ee3-470c-b462-3a13a688c84b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6b571cd-d9b5-468c-96e1-14c1d711a8ba", "AQAAAAEAACcQAAAAEJLvghhAqVuiVpby5Hk5iDPghlwASg+EDlMldFynrhiE0Ofr7mhj4fKm6PRn5mVlIQ==", "815191e2-34b6-460b-9e5b-3d372dc4eb78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "306722d6-7e80-4e06-b3e7-d4dd929ac287", "AQAAAAEAACcQAAAAEGEWA1Jxkqyb6wE6YJ0JeB65DYlz5yAi/c+GgYfElxvrKUVuTBkVXUz1krcw5/vOfQ==", "85080fc3-6338-4dff-ac91-df1703be1fec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0266be4-f042-4068-8d03-3d7db17c6d2c", "AQAAAAEAACcQAAAAEDNftLQcqGl+SlTY471gYiqpKytPRiepZWWRxh8p1P14MQmJIU2eOwmoa+23V5TU6A==", "aa608bdb-0a31-4d8f-8a71-ef0c6191e12e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23b10754-3b0a-4214-9c8a-d88a939c1176", "AQAAAAEAACcQAAAAEHGND1tvPMQtoWtJ+zN6WBms5FApoVqxJ3u2FlzuxanvTEfRCMZiRwyGfPAv/Yy3Rw==", "a06c46a6-8524-4299-b499-a89d3b7d9e3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16fb9e86-d4b0-4eaa-89d6-10cfcbaaad84", "AQAAAAEAACcQAAAAELJXE/CxmEumiVzJZWVgxeuuFmIystORcMAJOfC9MmoAJvEyDgd8+iPsGZo+WarHLQ==", "788a88d6-5855-4c76-8f67-8dfc5be5ec10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30f9171c-0554-444d-b24c-346358c727e4", "AQAAAAEAACcQAAAAEPKbf8qHltVgdeBdWhF6mGJ9KgJ3dKQTRgEHAYh1+VBp1+q0asp+A5GjHqUnDVNSrQ==", "6dbb9b6c-1c33-41d1-87f6-f2d9f2af0ce1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a322241-70d0-4024-8205-70b9e465ca5d", "AQAAAAEAACcQAAAAEOqZ0F6rXlI8Bzusyc9e6Kinm+PB2Pz/HJiM7xvMChNqJMTvimZLXm4n8SukpBqyWw==", "58c97e5a-5e30-486a-a703-e31a51ffff67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e0f3307-236f-4a64-bf7e-2719bc3714f2", "AQAAAAEAACcQAAAAEGmKqYRGIHstXErnBErM9JLhZkhLYVu8duiiHmkLurdP4B2k86azHVHGsn0u8BmOSg==", "c54b8423-4eae-40de-a2ae-eb21d05434b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd2fd92f-661f-4230-afc2-95ea32daf108", "AQAAAAEAACcQAAAAEHr9XVSaUvNn8jiya6ccn4g7KJ6wTlkzMdH7dH18NMj4gn0f2+w2ZDqsxTVhMgmOLQ==", "8d323ab5-bd34-48a7-8112-132d4477a58d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "516152ec-0a9c-4f4d-8d6d-3296374e37b6", "AQAAAAEAACcQAAAAELk5UUykYuLCfvwSvciHti86WKtPI9BgVRR6T8jnZoFntHtv17G1mjKy5/Es9E6g5g==", "08d36aaf-01e1-4801-9024-d567ab418a74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0f9e4d1-39e8-484b-a76d-3a45121e0556", "AQAAAAEAACcQAAAAEETjUrsoEze32HiwMVitw+9fwY5a1mWHjba6OJXJ3ZYS7PtXQ1OoTZQ48rg9wf4OWw==", "b6df4570-1a70-46d9-8d6a-3070369058df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0e65a15-50db-4864-a72f-61c3b989e5ca", "AQAAAAEAACcQAAAAEErEmhLMaCo1oUxMB5QAh0oZBZY98hR8PXQBXBVr6klrZJXCxvxAUfWNqNBX3SnuFQ==", "d344d366-c159-41f5-8bcf-727a60da9261" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8608caec-2d45-4800-9b05-4312830d9169", "AQAAAAEAACcQAAAAELQLGlm5vK0ef3rbTY81ibdgAGPIuVg+CjFdnOOVgzYv6ExrjvXaioIJI7cifpVjFA==", "79b96e68-84c9-4a40-9d7b-94fd268a7a07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f18dcad4-2194-45ba-a7a3-e9eadbca3f65", "AQAAAAEAACcQAAAAEEgBMlvDgzxeuHwDkKmN383V+tun9rGVVeZvRF3esKmveQVaeKstAnLEdtwtAdMsUw==", "5cde6364-facd-4b12-8976-2cb27c3aa83c" });
        }
    }
}
