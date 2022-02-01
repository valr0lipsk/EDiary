using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class addFKIcon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "33fc75f4-8ccb-4c27-a840-4b4d18651f2c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "646619a7-2db8-4642-810e-366e14631ea7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "5a7599de-b5dd-45f4-a6db-a5838a81c76c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "81eb8527-df30-43cc-99e9-8c70767abe86");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dfd3c37-6e7e-4614-851d-8af1965fa5dd", "AQAAAAEAACcQAAAAEDo2AuNfF7tuSpsaNwznzfSsZcLNwmRXW4Rba0hwhowvD/r3E5rsMHYT+ILQ53KtqA==", "15550eb2-db73-45cb-b55e-78caf94237c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c382b901-0210-4b01-a535-a2cd4c2ef80e", "AQAAAAEAACcQAAAAECF1SqwYAOZ4VHCwp8FFQVc3qIrBo7aItgmTr14EJdsTkEfbJvVtJM5sxbVAzddzLw==", "a080c420-9e96-44fb-828f-f28b2559c904" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95d2a0a3-cfb1-4596-b66f-0ca796e07d56", "AQAAAAEAACcQAAAAEEL7FGpmus8dHCASfRbmOyTqgE+mSXLS38fbCZcggtR4r2lWT6jCxXouB731Puy9Yg==", "254df10c-5cea-441e-8020-2df5e4d31f9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "953d6773-17a3-4f80-9f73-7903b12323a2", "AQAAAAEAACcQAAAAEPjChxUWameIl5Xoj9WISIgqp0ydk7BhMWRSuTD0x9+jFDiFKzmLVVHxzFQclflHMg==", "7f5ee7c3-05b3-454f-a5b0-b30328edc76f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7978354f-d1e8-4861-9490-8e74646b6d4b", "AQAAAAEAACcQAAAAEPnZLZbYSn53xWlyuYbQ0LuOCAHi4uRoZBzpz2ug6dnpFtctQzvz/eF1RFdmL6/ZQw==", "d9e0be85-3755-4c7f-ae3e-61569120dde0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56c5fe70-5969-47d7-9151-bd7011213377", "AQAAAAEAACcQAAAAELlIF6Bzoql2vyn/CXXhi8+hH/kzqOAFv/v8nxYggbEogCWbI0sogBUD+Na1I6AwXg==", "88eddbdb-90b0-41cb-92a0-d6a9f86f79ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0652418c-aecc-4004-a5dc-7e1cc22fad3f", "AQAAAAEAACcQAAAAECIKQ0du7QuY4aXKo7FuroobCehPRbnvna1gPnUDBArrewXQKcBIOtQ5FIO2UXl/oQ==", "6923e419-e2e6-4305-8234-8fe228993095" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d8d7297-942a-4cb2-991d-2869a979d15d", "AQAAAAEAACcQAAAAEBqRlBn7qaReGwq6IUmxGFEuKp0xyjixhO18sHbJugZH8EA6wWYxA3OFCqHCad4+Ng==", "37ae8a4e-65e1-4e1c-995b-2e785ee174fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91dff2de-3fe6-4e88-89ec-6d205047f937", "AQAAAAEAACcQAAAAEGNxERWMpe5Es2TN4HMORm2YS+4J6tkYJp9WrZdSBFHjZMZcgwMdk2yue3lwXYBbkg==", "6aca1d49-9ec3-4bf7-aaa2-861d0684f648" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98ad7641-c1cb-4d68-bafa-c0c8a2bbda5a", "AQAAAAEAACcQAAAAENAVd7Bqr/f2gM+PabP8aMVCoRc+hmEQByng8UQeIiSFmuRAngzzsWO0ufDv7Kxx4g==", "d3d7310b-844c-435a-b494-045c0f6231dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebbc10d2-b587-4cbf-be2b-44e4de8e9fd9", "AQAAAAEAACcQAAAAEPnswPV67A+jdOGZaL5h/5vjvvsWaDlr2cMIgwfv9wSIH0V288TcPDHwl2Rc+nxOiQ==", "1897185f-fb90-44d5-87d2-eb408ac37ba9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a851bab-1019-427e-92cd-7283b0e85689", "AQAAAAEAACcQAAAAEIyBN+2hR9IGLQDhISUQv+7ruapI3WPxdpyqQKPKGUBWTpblAX4WisdFxyi5LPL5LQ==", "4480f9d1-65f8-4f14-a67c-249bf6ba5260" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bee0034-aef0-42e8-b5be-a1b63c33a170", "AQAAAAEAACcQAAAAECa+uou3sqOXZ1KP9Wa7VZFzhhp8uuWCUBIgq3+6D4rOgt4EpunRzVSZ+iR6ueTAgA==", "abef7cf1-48c8-41aa-94ac-0b89f92bccaf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39be2e55-06c6-4dca-bd87-170c59bf856a", "AQAAAAEAACcQAAAAEIpJBGL3xL4hKkPFmU+f64pnjYkQU5tYREg+0zP/N0s10Ju6wiWOOcXTPDcjja6jUA==", "39fcfbe4-506d-43b1-9ecb-2fc2e3ec6f42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c244caf-937f-456b-b10f-9c9ac4f9bb53", "AQAAAAEAACcQAAAAENO1WRqINfyzWQ6cgNelzTVEtFAMpCxpYCKaIYhgJTCy8tyjvcc90kKr8CmvW4DhBQ==", "d33bb293-588a-4a01-acd0-cc477be1a467" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66c9ff0b-b14c-4dee-9a96-3cd970fc21f5", "AQAAAAEAACcQAAAAEMARX+SANHs4bp8YvkJdNQjp4ckDBqv0w3bDMtCJJ++HaQRYG6tkuIOekJQJBQ/nuw==", "f694be2a-c868-47ed-9769-85cb8199c888" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e20dc424-9868-4590-ba67-24499f62b4be", "AQAAAAEAACcQAAAAEOkOnE8ste30UgaSCK/SYIH7c0AZhzIWMe3E/TagL8I7onUiYXP2D/GB3PSYcn8geQ==", "360a216a-faf7-45f2-8cdf-163701b3fd8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64bde4d7-f2c3-438d-9af5-b2e8047c70fc", "AQAAAAEAACcQAAAAEKy6HAeBp4PXoC1G04qHQX/U/QMCyrCAdxi6FcVy0z8svh+jAYIdVdNEIcEH9niTJw==", "8ffa69c6-7664-449d-904c-ea372f421c47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c0294c0-96dc-44b3-8221-a4b80141907b", "AQAAAAEAACcQAAAAEC3CJ4PWn/vQqHGDO1cA+IEL2xjUum33I+/RVsm7l68wC5gYIHW/W8ot7HPuwP4RHg==", "c3707902-a2a7-40c2-8cec-b649ab8e4c9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fce4f26c-d2a3-45dc-b2c5-bc4d171f0fab", "AQAAAAEAACcQAAAAEFzrDI3JhGX0U/aHUjgPcOt1UmIQGuNB7Aadc4Zh4Byjio4poZ4VIVW6z7545BloTA==", "155895a0-b223-4983-b433-3a2992591274" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c147d07-41f0-4496-bf61-ad17ba083c6f", "AQAAAAEAACcQAAAAEBzWF5VJwzXLnOYm3PERxmmPM+CEamQFuSEoh0Q8gQ09Rgy3SLnnmKgwYApvAK1uUw==", "d8ec5d2c-d024-4a87-9090-39bc4bdaa48c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dadc9d0-e778-4ef8-a49a-650efbb9a402", "AQAAAAEAACcQAAAAEAaI006z/Q+uk3Y4guMAXXFiu4bX8w4Gi7lDITtD+j7pwvAFOEDJqobRjzLeNr5+KQ==", "528419aa-a00c-4ef6-ad8d-5cb23e3b5432" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "070fa6ee-c48d-48d6-8499-aeda8ce35c8a", "AQAAAAEAACcQAAAAEP+LOcxCITFe7GRP64qCMdRkIVavaCZFHrR/bujEeRGS0vC4LRlxvL+9znL+cCp7Qg==", "6cb67c1d-f1ab-4103-b7e7-99c4a8d15f86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0434c79b-a715-476b-84e9-87416ca03f9a", "AQAAAAEAACcQAAAAEPA537EhkYSGKFHkfefuE6IJoY1UphPP7GAiC8yCNiUQy0/Gq2qltxmh7NBZEW7OEw==", "4ee7f87b-6abb-4c5a-95ff-db079febc7c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e68b1b2-3175-4b47-9a64-825ce300481e", "AQAAAAEAACcQAAAAELnx8HNrploiwqK48SUYxah7Na3kZtSSWxGbz1qzh37f+srtLpCVTx29zBPmzgjEnQ==", "c80cfde8-f516-409e-9354-02b2e73c08bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fbb1661-e956-4622-82a0-9162a6384c92", "AQAAAAEAACcQAAAAEMefTr0CRoZk/7df2VmgP0Z9i5Q7U1EeWILwUWcGtf9HsLX6Wv7jAIvec5iHFDdYsQ==", "af946c64-4762-43e0-bd8e-0359cae7b4aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f4dc7ce-dd4e-4a72-b915-424aa448fa25", "AQAAAAEAACcQAAAAEKZKv/fOO1IojakIpKf/Q8oeTg/ChjY3CD91FJpKimi6NZNqkk0hY6ewycdect7qKA==", "67e94bcf-a506-4ac7-9981-1ffbf9113165" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72f1eea4-e00d-40c8-a973-e0f0dc0238b3", "AQAAAAEAACcQAAAAEHdcB3mzx7MQ2jgiU7XpFwVaxmVuJ4j09u1VzA9ccy0gS0f3kjMsnyzP6EWkDNYIbQ==", "c6baff31-dd36-4c72-b41a-e6aa60fbc9cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7cc1f55-911f-46f1-a0e2-df06b56c70c1", "AQAAAAEAACcQAAAAEOfRMsSfCIbm6TJo+/xWUcgAEVIm5H80Zb3ggIQX2vjjJw0tRDNNhsbJel8+C2FbrA==", "82056120-ec5c-4ece-a598-0536abe763c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff9862ce-4fbe-41c4-8ffa-8523a7448174", "AQAAAAEAACcQAAAAEAVAvlvd79dNup07b0mxawgo09ATX1NH2cPdME8MKnY/3GTt+ZJ9KGzGHP80yhrEzQ==", "50c104f2-bed4-4a33-9f6f-e65218353846" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17bcdefc-f489-4d2e-95b5-354c5c13b867", "AQAAAAEAACcQAAAAEOTKtZa+/GkknHBeFB5vLL77PiglGNTKOTR6HTlrjSXSudJ9v2MP1CjsFP8NCJjmlA==", "aa9fa1ac-6375-4142-aeef-cbfd90ce7328" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "516be58a-bc0d-4610-8747-426021a7b776", "AQAAAAEAACcQAAAAEBGro3iN3wsnS0Ls7yXG1DUQANUMlNkLmxlqSGBCdbQWLGl4gFxEId338aoNQs7vPA==", "f282dabe-e9f3-4089-a003-fc20428b8909" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db9d375c-4912-4ad6-8a3e-e02dd5d2f3e4", "AQAAAAEAACcQAAAAEB9cJuQn91y6Xzdy6tEevmmMO3PZaFg0S+f8keUuMflI3SsRzffQULA2MgoeBbSoEQ==", "a2eb393a-ae66-4d6b-8229-e09f7bacf80d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc885d28-b202-4aea-9e28-31f015947687", "AQAAAAEAACcQAAAAEHJZtgauL8JeiwyGY8n5NR67JJUL31Hso9hVwaPyl4sTV/qyzoIC2ZfgDbM7d+JQtw==", "9bf4919f-36cb-4227-81e8-e8586b8cefe4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8404594-dab0-444e-828d-aeccab1b9fdf", "AQAAAAEAACcQAAAAEOSAxLrDjLdmIdX7Mu28tpi2Y1n9SM8vKr5jBPU420qCO/9KQV0p6PdwtapRWfKamw==", "5a90e395-087e-4456-b8bc-0361d327e545" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14c91536-9912-451d-aa9d-761ede8ef35c", "AQAAAAEAACcQAAAAEIZqmIhEfJ8CMAZ0UiI/WFChU0gQ/0zI2B1D164rZOXL+VgoWAY4PQLiyknwMbncLQ==", "f228a8a6-866b-4253-aa83-668fd608c18e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d557b9c5-e858-41ea-8fba-9d8335362055", "AQAAAAEAACcQAAAAELx7DEScHU8Uu7ba+uX4xQ59+j/rpdChIDjeLFhBRefpkBoZL4j7MnavtqpXZQRP6A==", "3957e557-af2e-4991-ad63-a347250cbe84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3a6595a-1527-4d98-b840-9621b4539169", "AQAAAAEAACcQAAAAEHc0N9xGPHTl6qkfvkOf+DC08n7Ay1gUc7d6M7Bed6f1tsbJJoIPKqgBpl0y9o7iZA==", "f5646b9d-d590-4f7a-9e55-86c59a0ab899" });

            migrationBuilder.CreateIndex(
                name: "IX_subjects_subjectPicture",
                table: "subjects",
                column: "subjectPicture");

            migrationBuilder.AddForeignKey(
                name: "FK_subjects_subjectIcons_subjectPicture",
                table: "subjects",
                column: "subjectPicture",
                principalTable: "subjectIcons",
                principalColumn: "subjectIconId",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_subjects_subjectIcons_subjectPicture",
                table: "subjects");

            migrationBuilder.DropIndex(
                name: "IX_subjects_subjectPicture",
                table: "subjects");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "56eb695d-acdc-454c-b6b8-4f638158edaa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "30b1b732-af92-4ecd-acdd-95c110aa7c3f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "a284eaed-9132-47f9-b91a-de0285257551");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "d44831eb-9d57-4a6a-a003-9477cbeb3a85");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a0a6fcd-603c-464c-90a3-6119a9f7e848", "AQAAAAEAACcQAAAAEN5KU/JU4ZqRbJEe6tDpEfyRgUAw0zlbWjPT4xsYo2/VAjsvrDkAwuRaAfpnF/9Yzg==", "7c27ba48-bfc7-47eb-b298-7f46d26834bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0f66711-05c2-4ba4-9453-aae578775c14", "AQAAAAEAACcQAAAAENGBcRmf/Qp7irQ91XPonbUxeKSnubwVpdfslLt6GHDS1l0xbdnoZJaB9Q/m8yszJA==", "9baaf369-3946-4a64-a8ce-ee764ceb0eaa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4c15118-12a5-4619-a264-057a7e7e5825", "AQAAAAEAACcQAAAAEFuzRxx3phYx6g6FKskqyMnf+2YRPxSPNN65zBTTmaS2ddldVGJVX2A34TfIObU4eg==", "128ab5ee-c8a1-48cd-8b7f-76e813b3eb45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d32108a5-b345-47be-bec3-709861ab4587", "AQAAAAEAACcQAAAAEO71br1tIi/aCBb8w+u0Z/a38VtgyNJtRQQM2Z+uJoI3q39nf91oxWvXhfZ/3TXmlg==", "20eaf2f9-7dea-460d-a464-cdd3ae72628e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "446a2baa-55a3-40d8-8b4c-73b37d752a83", "AQAAAAEAACcQAAAAEJUZBhf5nzf6Md7sRRe40k6pmLDuXqkt+Pt54RSYcuIrAPua+bAk/DGmnUn6fs22sw==", "8352b47c-1b44-419b-a067-e898c8c17464" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9deca7e-58df-4c12-a91f-2235f19ec29f", "AQAAAAEAACcQAAAAEG/uBbX3diqpkc+t4MPHbXj2PJ0Vf/45Ckks6oQ3eh/0Sm1rk4/9mGywz0U8hBb9Qw==", "de4e84ec-4fd2-4526-897d-5d28f810fcd7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f5dba59-128f-42a8-928b-dca118133960", "AQAAAAEAACcQAAAAEOET5+IV2wKQhikiChBGDQs23ihMJrL0rgznTTu1QilAPiGZ/XG10Rtmii+GhQsrxw==", "8a1279c4-6839-49b9-bb45-75275da686c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10a18bcc-eac3-4b8c-ac34-826202e31f79", "AQAAAAEAACcQAAAAEEx7tL+9k6MQX2DbS3MzF+Sl9i12A/KAWUNc/U5S44AFn1g9cF0fGA7eU29B2FEDUQ==", "df17f07d-44d2-44ca-872d-360734dfb147" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b089586e-53ee-48ba-8208-70e1b30f6286", "AQAAAAEAACcQAAAAEO7zcbZYe6nlJQEjqD9UoYiFJXMPRrF3B+RLIC/GS3uw9B80XHUXZwW2VPUDCR9g3g==", "f865ceb8-56b7-4165-bab7-2d16873cb7b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "595d7f0f-f3b9-42c3-a4c1-67e38de77074", "AQAAAAEAACcQAAAAEBBywuvGSCJaD4SutfyV62xfki3uZ/6bYow/zeQA7xuADplOtfVQhCYvaoA0YwoV2w==", "377faaee-6bf4-4387-bd0f-c688f9c05bcf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09e9c015-0cbe-451e-88e5-151502848e38", "AQAAAAEAACcQAAAAEEm3296q+TmBfjYF7VqSUmtd5nGf4KDLulcALKnYL1NBCt0j+jA8qJdY0VbA2o7qDA==", "400fb31c-277e-4107-8cb0-712265baf560" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40e1abb8-d044-4378-b05a-1e0e990fb5a6", "AQAAAAEAACcQAAAAEP67sTYXvqkA3X/vPD4ZuVUZqcLZqoKg0jTFZ6+OYqAhYDJKPjUNxp6D+c8v18Furw==", "68c6ad4e-3e06-4233-93b5-3227b9a890d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbb355eb-30ab-48e7-860e-deb72a120924", "AQAAAAEAACcQAAAAEAfaIwofXWdYjM54SJHj8FDG/auLzuQ4VAoUY6+KH2Zh8Sh6tFA2bTyFfj6RdYPaeQ==", "339cb5ac-18b7-41cd-8513-a7ba82662cef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aaacd9af-3f09-4413-a534-80d9e91a9832", "AQAAAAEAACcQAAAAELDcfT+gwGcO1BnSBk+8vEcuaEkVhjXEnRkGq6yY5MauGhSa6iMpQSUXel8kj8i5xg==", "9fd67cf1-4146-4a20-877c-fd7057903636" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cc7adc5-7227-4017-8bb1-00427b473bb0", "AQAAAAEAACcQAAAAEFDuA4bNYmU4enirM4cd9m8r6yhO1Fv55kxEygU7qUX6LS9XxgA5SCVtiUZcT/qDOQ==", "8b07c729-9de7-42d7-8cb4-b545bb427552" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e1705a6-906d-412e-bf47-754198a6a8a0", "AQAAAAEAACcQAAAAELdj2C+z5qw8sOjSMrV20cjo4klqT6DjGreWplipH/1nrLMR4+eYS8LsFZjn4+Z5WA==", "462447c7-fc03-4627-8bb3-77bed22a3a20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f6372d8-6a42-47c2-970c-eb6361ae747b", "AQAAAAEAACcQAAAAEGZShxlraRcf1WclNkEcrlcxkzv8aMpG0YRlMgIcbcF014rJzRkBU+Xg0L1fGUOkLQ==", "247b5c87-1f11-4d1c-85ef-7aa833581839" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6d96d1e-237b-4889-aa28-45019dad787b", "AQAAAAEAACcQAAAAENrdDUq5d5N7ZnkqSKbKVBDwc2E0g0uNztHuApjramyWBw/oRhL8CJuhhWTudbyjfw==", "64c20098-5eef-4e91-aff6-6890c11aaf12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e258b8c-e840-415a-824b-3a30434ef7dc", "AQAAAAEAACcQAAAAENQo1/ZkYX/ZuXqd3Hh6alXEDQ+VTpzBUDfyUl+aD1awQLOEBd+zK8fRamn/8GImOQ==", "1d9e1868-fceb-42dd-ae82-0dd0db580700" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2e12193-1577-4092-b72b-bfcec21ec7e9", "AQAAAAEAACcQAAAAEJh/h4StlgK3/7GiOBPavUBVUxgR4RTt6QW34fDBe1K4mUXvvkY5ePiZEZ+drSg6Ug==", "e3406897-95f1-4845-809d-a0358677189c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f36a76ce-44d3-4ca3-b2eb-1590f84c1f68", "AQAAAAEAACcQAAAAEJ396AT56I5O3geNhxe2SeZvcJpbJYVZeaT/ToqF3jC7Ym5tmIW3wLURBhFFzAlXyQ==", "e46de855-9ae7-4310-bea0-5097698922f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f723746f-ebe5-4458-a086-fa60417356e6", "AQAAAAEAACcQAAAAELXBCjMwWlJbKne2dJJvZr11BBqrIWY4HjdoSEmRVJTnV2wCKwPYqNkf5/LnWu9N2g==", "e05e596b-0241-4b83-a84d-c2e28839121c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f35aee18-6217-4332-939b-638c4f3b25e1", "AQAAAAEAACcQAAAAENidRH7Hxq7UmkSWurXdQd8yNw8znva8I1AIMPsZz7C33jsyPanlUrBear4stptnRA==", "64e3b37d-7c92-4fc5-9250-17165ebe76e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd36dc1e-232b-4cea-9682-4b753a092df4", "AQAAAAEAACcQAAAAEJthW8qRogMX6CzSkvQZGhKoSO4s4RiuJ//oiYC3O+GY6VpO8PIPGJltQhCk1Zlvsw==", "8209d4d3-22bc-4ed5-9c6f-26906db15d63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afbd51a6-f10a-4658-981e-a33093e6a69b", "AQAAAAEAACcQAAAAEDlRzXPnc/yqOh5SXllGwPrOj7rOiq+I3aQmcXHFohnHCRFVfhvxzSodBRCduNCe/w==", "c6a7f174-d85d-41e2-a216-23e308214ab1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f35cc81-c4a5-4642-94b8-25f7ac5a5943", "AQAAAAEAACcQAAAAECYH0nPgjT8BpG1SdN8b7AbDZOfmripoxNPJJrhBT5k5QyDyKX/CmJM3v/Aq+TMAvA==", "d02f2bf1-61c7-42c1-aa5b-a12ced05e4a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc3853e4-866c-4bfd-a6d6-3320bc98ae03", "AQAAAAEAACcQAAAAEDfKHSjlvPCoi5I5++ED+rx+fDrqEygvrl7UGvgb97HWxmFTEbbj7JGFBhXgH9Mxhg==", "5e7f6172-b294-49ea-b8a2-08aa59bdbd03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "546cc22f-38a8-4c69-aa69-c255c7adf248", "AQAAAAEAACcQAAAAEJIO2JqrbSOmYPW1mi9+qfhOjSiTCRXAXqLlGoMSVtakDkp2lKgqiI96aX+n7i7q9A==", "6be353be-fa06-41c2-90a5-fd1b3faec74a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9b8b079-42fc-4e40-bda9-4842f5570097", "AQAAAAEAACcQAAAAEF6jWqT1AdFtpHiTzY5/WatFZJz0R+PN6BbKIiczpLGwipA8ncp0tbH0sO+Y1DjUcQ==", "5c829a35-9578-4094-b932-c661e6cf7d45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87b67f5b-f1c9-4e50-a1d3-35cadbc92a95", "AQAAAAEAACcQAAAAEI0bmofec2HT87Flbt2yc1R2ycJH6LeNWyGHvAKUAow7jH6q6NcUOGYb3mfzBAIwtA==", "c4c64511-fb55-4f30-9bec-7561de3a8379" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "696ac168-f54a-4773-a789-f55ba4be1db1", "AQAAAAEAACcQAAAAEEb2NlPLyhLh+JMgy8sJjHS2dR1l0C0eK+XzZ2nnP9GkQZX9tMCVbJj9lDNYNGq2pg==", "2300b64f-d322-4c97-8f97-7ea49ccee5e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b03da2f-49f6-478c-b1a6-75e1f53103f2", "AQAAAAEAACcQAAAAEJcqpYRBIN3tPzYWB3UYJEFfbBrXAklhCeDhVIpHW7hcpZ96GXUkyicutgGojnpxug==", "6b30fa15-7809-49c8-aff0-967e05bb638e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "756222d8-6439-4acf-9896-6e5220b7d3ec", "AQAAAAEAACcQAAAAEPJOE4YmKcH4HN3VrV5ipxrh356eUudbaoGFhpeLob9xJgR1KDOgvAYdMjRdoPsJZQ==", "04967159-362a-4c48-8f06-0b8c8cb8c1c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b239985-44b1-4903-b313-340bd46f9a06", "AQAAAAEAACcQAAAAELQZSTtx24kglPaTlbO0UA7NsZD9zvzmW3DBlVMwpGUM19IEx2xJ16oNOU7SM1p7vw==", "c42db7f4-2d71-4279-8e11-e3eeb7c3fca3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "708319ff-d3a4-4573-bdac-034956b89c36", "AQAAAAEAACcQAAAAEMMaYbfbiT6tnWEMTMx57ZB9PMFhnQZ1qK4c4/74ISlax0rOb0V37fIA5gzSw2D1yw==", "e6ccf873-b1b9-471b-8229-997851ea343f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf6c5c44-0968-42c4-ba9b-3467a4da88a5", "AQAAAAEAACcQAAAAEMPdZL9bzUPfYLf9J6NG2eP143zTFlR7QVnjb4qZvJ+EGnbW2GjjGLCC8ol82BDOLg==", "33136607-58d2-4890-9d94-a1dc9a1fd7c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0514c56-c678-45b7-be28-9c4c16f6cf31", "AQAAAAEAACcQAAAAECOfjFhRsGU70Xrt/NYxF+jT06GK/u9KSdEbJEPgrkNugw9ASLgGuVrjwrtGj8gA5g==", "39824765-8fa4-40f3-8c19-567de3d9193c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d358c213-4b14-4dd2-95f3-25c8c47e0e84", "AQAAAAEAACcQAAAAEA+AKWwSprwHIZdbtykgzt2SQ9qhM+WukqLaV3+BUY+ikAqlB7ImINskDYitVIp7Sw==", "442f7b02-3567-41ec-bcff-d4cabdd5fe25" });
        }
    }
}
