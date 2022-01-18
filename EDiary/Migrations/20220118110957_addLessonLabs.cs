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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lessonLabs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "7adc4b4a-6283-4fe0-b52c-b14c1607dd22");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "0ded8fd6-b6c2-4708-81a0-55f2c7e16b52");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "78e1d2c9-344d-4c16-89fc-f6ab32dee22e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "64a7e35c-dddf-498d-b042-541e09da9b15");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df712a45-2fd5-442e-b515-0d9fa61253b9", "AQAAAAEAACcQAAAAEPLnvWoso6Iz3mmImjZ3IHvu3Jcfnup67QaQl4LESYR4armBFWqNWzdEKAspPN5VXQ==", "be0784f6-1079-49ae-9a03-fa8d4c7816b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d326a278-ce64-4935-be5a-e6f7472ba1be", "AQAAAAEAACcQAAAAEN6w4hjpCPR64XBtRjj3i9oet/iQ8IaVwwC+zIrv+YvVo9TRUfnwebBubB19uGqSWw==", "18426a45-02e3-4e4a-a948-98608f6c3236" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b136189-3e05-451c-bdc4-2b60d24fe9a2", "AQAAAAEAACcQAAAAEJcfPpvuxymizTazmCm/bWNNmdkhQwucnSUtegprQNnTRmECLB1sDHom13gY2fhRIA==", "3390be29-b417-4b9a-8c37-7c067d5052ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d589d63-5ea1-4881-9da6-83744d4b55b7", "AQAAAAEAACcQAAAAEOOlVqR/J1AZPQ0wWgoEaSDmce+hopplazwouHphk0Yg/erBh4V53el8V6NlnI41UA==", "73607b3e-fd38-49c3-933e-dd93e8ee2729" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "282d4e9d-a77f-4ad0-b08a-13a736048026", "AQAAAAEAACcQAAAAECVt/Hizhsuieb0emW0TyhCxMwi9JVq6IjZR5IYG5yslUSgIxcQjHDTYkAbBy9OvVQ==", "ca31e3de-5a3a-4799-96a3-d2a6cb1c1aa0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "208ffc87-7770-49bd-a4eb-d370cc42e645", "AQAAAAEAACcQAAAAECOU0o0QhN7cVXltWBTHdhHC5PjU0AJf7u4BPeeVJDQPGev1AL+8aqFWYIEv45v1rg==", "447e0a1d-2a57-4b03-b54a-85f67c925f13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e0a652c-e502-43c0-9f8b-9749c9d86078", "AQAAAAEAACcQAAAAEPLVyZrl4/DasigQcEZW23Q+86NO8jeBy+fFAD99Vz1QCGFrNw3RiGPUxhoYFYpKQA==", "e14f5429-0d3d-4f55-9951-8391b6f67266" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "daf79e37-3008-4d94-8780-bd68aa1baf7d", "AQAAAAEAACcQAAAAEALBO2ksAPJAUWEHb3ISf4AtLpizUGcU3aSTnd77O6Iy8YSD+ag+V7wqgptEZFp14g==", "90548fba-578e-4abb-a30e-de278493a85a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49b3d864-a5f6-447c-9f65-5a32b732269e", "AQAAAAEAACcQAAAAEAd4vRF+k8ROAzF1Vn8zDa/bVcM5VHe1+h6Kfj9DOK8KnXP3/bd3ZaCbLiMLPQxHww==", "40208e2d-6bc6-4a0d-9a41-0e8bd473646a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e897558-5c6f-48c4-a56c-9374f0683ef9", "AQAAAAEAACcQAAAAEPoxb8HcVKjVUuAIt7UnW7p70p6g1+M8neI6J0ST168gr0+F6qM8QfDIQJdxG7m1HA==", "b9c7c3c0-1d0e-4504-904c-5ebeddc871a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d5ced33-3d6f-4fd9-ae62-b75ea543b6c9", "AQAAAAEAACcQAAAAEEl/oTTUvFfH4yRzSYCHnrHGSnnxqH5TVo/kk+5tpnKi7JVNxOfCWCun0PewGm8/3g==", "3d8f8688-e551-42aa-b164-cf2d83ec8b8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4a67ce4-9492-45ef-b8d8-bf0e2fdb0ac7", "AQAAAAEAACcQAAAAEBipJHvkgeHZt2/p50sDjOM/WAeujQEWXLJ/BEwAuNV4sbf2Y12ymPHmaP3cOApUeA==", "8e8b4d66-c31b-4d20-81ee-058fa37c0f5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf0dfb37-b89e-4768-bfb4-84b5bd9eef5b", "AQAAAAEAACcQAAAAEMI7hBj9RDsldH6LwOn0NF1fuo2x0cZXiZ28VuJgFHMsxSLygrFVup4eX3xBL9QA9g==", "7b7ceae7-ad19-40f6-8d79-cbe374a79124" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8906dc52-8353-4e32-94ba-a09af1c84f11", "AQAAAAEAACcQAAAAEG5ZFWFXzSDKzgBP7TQR/MRkpSShhtH+ByF+yLj73NoVrgSJYrC6ayJeXgtBi8mYLw==", "5a489692-e638-4832-8c07-46ccd96f3d38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ced1e848-5df7-4b3c-819b-ec68455ca6ee", "AQAAAAEAACcQAAAAEAeNZU0VT5ehmojwHeCVy8XzSg27giB9af0hWubvX6Ww/SdiTnOFfVtb/kOF7c39Rg==", "79b08e98-bbcb-4a55-9cb5-1c5caa7be235" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66e7d96e-e9ca-468f-9982-08b77b8cc51f", "AQAAAAEAACcQAAAAEKILEkhOeS3M5sY5iS/6U3Suy/0T5eBW+iaO9zs6Z0ii2BhNMC9lFBpnmeoua8sY/w==", "3e49da14-d96c-4fb3-8cd2-608e754da375" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe930179-bf3d-433f-a7d9-417aad02547d", "AQAAAAEAACcQAAAAEPIkc67RxkzkPWarasZWweMnEk9NDX9yj9t9tI0H669c7yGBEZvLE0/HuYxB2+YVTQ==", "9e072ef6-2b4a-41cc-99f1-abbe58ab20d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75457b03-11cd-44cd-8a51-9c6a08cf0860", "AQAAAAEAACcQAAAAEMPxa3+ZcoKVXCP4FedH71GX4m8weq7OuOzA6ameyhVijbKpwCAHfxBiyeamm9fQAg==", "26b6d6be-deae-49dd-a90b-511c2c39062c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "195fb3fb-7bd7-4c3f-a268-f1686497fc17", "AQAAAAEAACcQAAAAEB3217jwbsiLEL7SsMyLtCv9Dul3x/DdpOyixBQVb2rLEW47ihfl6nUW9cLON2xvLw==", "b400f8c5-925c-4ee5-ad57-899940da4efd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd4a7d3e-a5b5-45d1-82b6-0a7ddb7d882b", "AQAAAAEAACcQAAAAEG5ISKxWwMnpmwhdbY44D2eHo2K+t3g6qmsU7f35F0chUobjaeyLq3AguqzPul1dnQ==", "435b3f84-ed3e-4451-b2c3-fd0c450e1a94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e94f197-470f-4527-9817-9fd8b69492e1", "AQAAAAEAACcQAAAAED4asMmXP0Zwl0d87ZTMCtzUUqyerQ+pcebHnv/OpEev5cVbXjYea2XIUB0l3v3D4Q==", "3d59e128-a733-4fa6-a5ab-73050c1f6854" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f144eaab-d3d6-4f77-9f66-0dad5c919819", "AQAAAAEAACcQAAAAENKQq6FA/OxY7te1SnKKZoM1eDEqRBc9JKf50xWIazdQmWuu9mopr0h/gKtmuxLbJA==", "6ae9d8be-c401-4a06-8973-cc6ba168bd8d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66498cc9-6c4b-45a8-934b-89b00a9558cc", "AQAAAAEAACcQAAAAECYyqJ7Vylct4KkNpsc6ekSFhT5RoKwocuDF59y7LggPgKgeMkkcU1nsJMEQmzLl2g==", "28f581ae-d6ef-474b-bf21-1fc6db671bb2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf9d8e5e-d438-4f8c-b91b-56e8c58afbff", "AQAAAAEAACcQAAAAEEy8MgOMVzyuQib08+JbCwJkoESGrKUoJmypsDSPG6RdhDWd6IgPKFPP1leLil81yw==", "d664c7e9-86b3-41ae-9c0e-a921f8637afa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b78aee5-32bd-438d-9182-8dbca3d3506d", "AQAAAAEAACcQAAAAEOojqKnPpbP/zfCnY7McvN4CDksIvGilsysz3cIwC52u5Cfv38ozJl/9bD7afeKoVA==", "2fadc3e6-7820-4881-9ae3-856d6199b48e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8faef87-d85b-44a3-b4fb-d9e216376f27", "AQAAAAEAACcQAAAAEP6KUwpyZxMx/Dt1DdwiEDY1WfgIfzPyr9yDjpRtwp2dYedPsRYrDcP8OIVleWEu0g==", "ecb88549-c45d-4b2b-a564-1c4a5b705a6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fc2a4d8-54c4-42dd-84c0-66d9b72eceba", "AQAAAAEAACcQAAAAEE1WspBoc3VVrkfkSga9w3dYIlWoI3+oEk7I8rxpKWH5H8ID1ZWa7FTt33KOGLrVGw==", "beb0f1c6-1729-4116-a10f-ae2794ca19b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a790784-8d3f-4c19-8695-0bf6fc80213f", "AQAAAAEAACcQAAAAELRcIgMHN3JIT2Wm63QxWEDzbILWGe0qM706f0hwNgSMi4tK5bl2lE2YQCISuYr94g==", "6a7ffc63-7041-4668-9406-6312ce677f8d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76dd7d15-7418-4087-b0f7-569c5b3fa29c", "AQAAAAEAACcQAAAAENNR5UfwD2pilayTuRmAUe2jYwmwqe/D2qWqKQ42vSdltu7dEQglRGMKUP6pt9jbYQ==", "4a3fe050-203d-48b0-a559-39ca15047b5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d0531ff-ffaa-4c61-8e46-169adfbd82d6", "AQAAAAEAACcQAAAAELgrFAPqk1fNb3UbxqkyIBrX6KYM046CHO5cTVVdOg256OTVZkPy7qilxyLub2JiRg==", "1052af17-b375-4337-9af3-883139b28a1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "377b6add-830c-4e35-87f2-4f51b17c1578", "AQAAAAEAACcQAAAAEPWY/BZblD/yEhs+gJ8jVfYrvLqDkDUP0jYTlXGal2dLrUoiKzq/tyOm1Q3kwKsL3A==", "016c9b42-5e8f-4e0b-a79c-a48a6d5ff991" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5be1759-f98d-4c7f-827d-94553c9d7d8d", "AQAAAAEAACcQAAAAEO/KS+BW+/O3n/PZ4Qc6PZymYuG4uVr6M3oomXdgSC/Ir1tKQzDuIfC4EXnxIaeQGQ==", "f91316f8-21cd-44d0-8a58-167e5dcdb299" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf5d166e-9062-473e-a42c-151c8d9acb36", "AQAAAAEAACcQAAAAEDSLlqW7aYgl53GFhiFk60CcQN94O+XheyW9On27py1yfaZCKjqDg2kX0z8m9Mwziw==", "f867fff4-9f4f-4ba7-8da2-ca3c2ba85295" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b5a4fef-a76f-4440-954a-d9b5eb6f5a64", "AQAAAAEAACcQAAAAEIRw1xo+EwpUxk8aK1457XyKINRxRAXMFGC4JRJ8EbwujKLc4kCeOe5c/y7CQlO9og==", "9e85df78-4711-4466-af62-5a68f2ba66c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f86b7050-ce21-482c-b9bd-d517dcebc141", "AQAAAAEAACcQAAAAELSQ0vbWs+7tBDBeBQ8tatleG4HH1XoDerjOdX4bJdl1kndne35pnXq0JSgEMr5HGA==", "a0d93a6f-e618-4e27-af40-a13557df93ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e49e694-c8c1-4d2b-a8e0-73f628781bc8", "AQAAAAEAACcQAAAAEGrsq4HkzbTfz5sB/OqAuMsN1esYaQrSRTyLfa4UA/QA5cbCyk9r3LvSZo5aJCeCeg==", "c747aa00-6b80-4125-aa1a-a7f6bd6a8f23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b88e4f79-ff2a-45d6-af8f-f5de7908cb30", "AQAAAAEAACcQAAAAEHqHq1/6q+3DYGV/eLVZtyDnjI9UCCcOiQ0xPWNHEF44DMdeoUr+GYPNem74G7AaGA==", "3331918a-3d48-4b33-a6a7-39ff83efdcb7" });
        }
    }
}
