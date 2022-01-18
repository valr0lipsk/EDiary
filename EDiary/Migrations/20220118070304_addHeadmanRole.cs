using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class addHeadmanRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "9fbae94a-e40b-4a50-a4da-6da08307a4c7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "ba16866a-5390-4188-b53c-6674b2263a8f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "d02de12d-f16e-444d-a886-692c4354f421");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "headman", "161300ec-93cb-4724-bfda-90dc5d9cf5ac", "headman", "HEADMAN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a18c6042-992e-4736-a6f1-62716f718cc6", "AQAAAAEAACcQAAAAEN6YgnLJRJIweZxoGPqe2fsP7QOcykPDVj06k7s3IhFOyy5eMlGIw7Nuew3Pmo5A5g==", "36afb35b-2ae6-4c8f-9ce4-f8c5d79f5368" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e369e18c-ec9c-42b4-bb48-21a2d1e66d9a", "AQAAAAEAACcQAAAAEOkfgA2EkujtvxdZc4sDoJWuvO1Kh8YP4Ve3oUWywmSCa7u0a7sSydhwKhBL2sz/4g==", "babe750f-7337-44bf-b108-223846c5315c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7204853-2177-43aa-9be5-8b644d79c5ce", "AQAAAAEAACcQAAAAED0gFaEGcRJzE46P1xYgQVdOfa5Msp7bL1fPQKSxIWkA4ncyZ038l/mDxXap03lt2A==", "ea2b951e-51c9-4ba9-9a3d-ba1c424e97f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e45fab17-65da-4f4b-981d-13c7acf2457b", "AQAAAAEAACcQAAAAEFsxRpg0aod77gWuzD9m7Q/t9xtd8GX2wR4nivyh9C11Hb8TEiUgo2f5/aiHk1wiiQ==", "4728a384-824e-469b-96fe-3a7ee74d719d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0439e78-351b-4bce-ab52-86d02449a766", "AQAAAAEAACcQAAAAEB1xAe4NtIO2ljv2KqM++VyiYAbGbtMDwRwcpOJSRyna7SuPvcvrhO8Ngiz3H3ftlw==", "b809644f-8ac3-4ef3-b445-d2dc3d0be054" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f95299ac-bd9f-47e6-b5d2-c76e5342fa32", "AQAAAAEAACcQAAAAECK4fXy8TDSmpaC+QhPBi5T9PgF+vczee0IoMNdzWh8bVENufZvRIGFw0cwxHiphgA==", "5d2e4fb8-d2bf-4051-8d89-df46254fbf23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ee4e285-48b4-41c5-9497-e3a2b5222a14", "AQAAAAEAACcQAAAAEEDLYub2ns/QsN9v9jp33zkjgv/ETIX6ue71sQeEcs0lty6d3hFxjdF9+0r9JVV8Qw==", "c196fc7d-d601-407b-8d15-03916fc2332f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "537c4f08-26c4-4835-8cbd-fdd6db47c6ca", "AQAAAAEAACcQAAAAEK1p4aHnfTYu/jM5Retd8oLq+BBBlHMqb18XHWRdwClXEYEEYw7MXgsuCp39OKKlaA==", "47db71d1-1762-4a3a-9bac-b8a578cc3fc2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd58911a-25b2-4deb-b574-63232c490f89", "AQAAAAEAACcQAAAAEKdl9RwGwWrg0h5Bx+cYgcul7+FoLGYw/m2FRPUWkSpY7E5rhpWzsIGxs3Ls1ap60Q==", "773ed746-e023-4e41-ae6f-55be9f1e193a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b481ab31-2aff-4c9f-8b93-5d62f899319a", "AQAAAAEAACcQAAAAEKuF9o3argvqZ/WO/JcFl8eBz4sGZPIv832onz3I1xer/oQkIxOB9tmNUs6NwJ5lmQ==", "1ffea079-3c9a-4e7e-bffc-cac8887f6514" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10597a1e-877f-491c-9857-103aff9e6f57", "AQAAAAEAACcQAAAAEML3DU0TpHB+KYSZRYOCfhDo2w8SR3MiFaQuG4Ll2fKdCgFMT+70BdVKifcil4Awuw==", "9e8c5541-bc16-4f7c-9c2d-ec4875ec56bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2cbb98b-ed53-4bd8-b7b3-2459f0fdebe0", "AQAAAAEAACcQAAAAEAsXQFrG2gTcVIDQc+9KBSQAzAOFu/QoP6rK5Baro9+DXm5eh6KCCFPaVtz/IiAL6g==", "0bf8704a-da90-43d5-88f8-35dae56bc917" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3877d4a0-62f4-4a99-ae86-5fd079abef68", "AQAAAAEAACcQAAAAENQDDrwXGi1REnG2OacOseiJ6QSEAsoHk5PirB52g/K5Zhis6y87yzodxoshmSr9mw==", "72af1a45-3c8c-4fb5-b3c0-17728d808e0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b90c301f-02c1-4ff0-bca6-45d255863ecf", "AQAAAAEAACcQAAAAEJQZlcvnpFNIfMIWwsOAcBdj8KzpxcUMmha46iBGLNYPsx648uo17S7BFznMP7rOLQ==", "5a604c4a-c00e-4041-a585-be425551a710" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10c4333c-ff39-4ab4-ad16-6f9a1a6357a6", "AQAAAAEAACcQAAAAEOxSJQjAROC+MSZmfDkRUuKE4ZnFvlCsrjDu3FmAtSDYdoNK45MoW0yA5uobtrRitA==", "4bab554b-efaa-4b51-83e1-90c27aa030c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78ed7859-4f07-4cc3-958a-e058db18ab59", "AQAAAAEAACcQAAAAEPtf/zJj7C0x9j9OeeYiZgq0FY0TZMm4YIsOYsG+SQv/HOrRtAihnyDclCKjeI+oLA==", "68ae9412-a242-4a4b-9cf4-51db98e82215" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f53bef7a-31d9-4487-9f5a-86b029459b42", "AQAAAAEAACcQAAAAEIArz4KtI5+F3YwWeJf3x9YxppSNoiiRli7gpcVOiutS7uxnyyCdkc16fdBKzfuncA==", "016a8a49-2026-48be-9f4b-9d17e612a597" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2d5095b-e35b-4e99-b924-db8d8cdbed07", "AQAAAAEAACcQAAAAEPof2eqBUVKbMICzcChU0cymVr2qZqAxEqAPhvQeIYWZd0tetlE2DeYJhXZGM+em7w==", "633b257e-b5f5-4b50-8dbf-43c317e39341" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b983d2ee-2df5-405b-960e-0fb068ed2eb4", "AQAAAAEAACcQAAAAEGQWt2ytb7hXZJIhTODt6a2o6VHskSAhYEX5kYBV37iIBHlpimZS/Rb5ShuGz7pikQ==", "2cb31c7b-d847-4c2a-ad4e-79ac636e2f75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c821133-44f9-4c0c-8aa6-a60fa02dff77", "AQAAAAEAACcQAAAAELcWwwmSMrETSvUQaf2XrO3lPF1y29q2/7YIlTaWOMnhOBe1SehvSdqiNmFucp1B+g==", "8288296a-c899-472d-810b-28f6e27ef952" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91589d5b-1e13-4ed6-9b94-5f93826cc8d4", "AQAAAAEAACcQAAAAEOj6NwU6gbRKQhfS+8KCDZAhZHdbfkrt+JxXsU58Pgocv8KfTEuusI1wiK9dXf4XVA==", "ddfe20bb-a7a6-48d1-83f1-60bc4bb1ae80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57c9369a-3f18-4d6a-8770-7b0c1db0619f", "AQAAAAEAACcQAAAAEIF45wi0OLY3pXgDr5lTi7QxXQo2LtxqPyb9kcobsZCW+G9eG7ufsG4eSzpO6kLkiQ==", "f023db7a-5965-4bc6-9691-fa7e4e416563" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8860d8d5-6460-46de-80dd-ac614d2ae5ee", "AQAAAAEAACcQAAAAENs7ZXB/T8VFXROdv/tRDy7FJBT5m9Yc//yK1ak1KDXNQr/V671YzcvZl8W8fo4qAg==", "1d4f0dda-cfd0-47e6-b9cd-6038550f68ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cea2295e-ca5d-47c8-8c7d-147ddcfe166c", "AQAAAAEAACcQAAAAENRLj8dY0fn8Q+298dvJ1ZnCr9vV4B/5pNySkscN+Fad8SdIoI8MxwkW2EqPzhXvfQ==", "37212a14-35b6-4115-ba55-ea8a98ba4d06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48ae3877-6435-4be1-9c6b-2bf27cab89c8", "AQAAAAEAACcQAAAAEMoum5hnvcADTK9FM0ml6YmtZqLCKwYORR+Q9+jr8DlAu5TTuuIYSsEkFeqxTQcXuA==", "ecc3a8c0-d3b6-4172-acea-248e0ffc0c8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "052fa503-640a-4a01-abc8-4b1dc94149e2", "AQAAAAEAACcQAAAAEKF8SZf1uMGGGNkYFeS3qBI6VHIoofDI6N/q2pC6Odb9NnuGPMmnWpOT+Ynb6UAZYg==", "b84d702f-47ea-4bf9-ab9f-6f39c6f133d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39a51285-61ef-4634-b46d-088e8d2ad239", "AQAAAAEAACcQAAAAEGIe1Ird3et3ChS424OMdfL95VQr+t/N/VxLB5RGyYS8B9gw4NRfbBgNuAJe0zeLIg==", "3e5efe5f-498c-40f2-841b-89a40ecb1e0a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4229a599-9e4c-44f0-843d-69df4c82debd", "AQAAAAEAACcQAAAAELMrbXppdjbW/14HwawPcW0lvT10HXaTZx/4PDAfTkvuJhw+ALjKhgggBnZEuiLDFw==", "029496c4-b72e-4e9d-820b-8228d7eff048" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2af530c3-ad89-48df-a6c8-36275fe3d37d", "AQAAAAEAACcQAAAAEMLt3kSGIR8kx29dex4niEv5tH2ZzWu41vLJUfeZI5NgzkunNgenZGzk0srodJIOfg==", "ed44e948-063f-4e2a-b51f-33d7bc020dbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c42fca08-f3f1-4b1d-86de-01d30bf1b660", "AQAAAAEAACcQAAAAENPBdH+pi0Lbh6gBTdQDv3OxHKek5I7uFo8NAzS38+oun2sGESykHTZpYjXpnWrB8g==", "502df237-1351-412b-a37d-4f9d40d06a58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f2262c4-1fe7-440b-9dd0-ec6e86a00265", "AQAAAAEAACcQAAAAELQuvayhUAUKiah7uPK45Fhl3RV+d9tqdUD8jG4B4U1KbbZNsyAetJAjeNcbZqCV2g==", "fa2ef31b-75e4-4c7b-b5b2-c8070fc4508f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e9ece7a-5090-4afa-a6aa-cbb0e75becad", "AQAAAAEAACcQAAAAEOw+NKX1/0OAp++g+uLqC4d0nn5hEw2qo/Empz9wLSR30GGziLrDnkTi3maCpBIKMw==", "5594efd1-302a-40d0-8990-41fea173d567" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22a0ded5-ce5a-4ef7-9eff-1e531ecc8d48", "AQAAAAEAACcQAAAAEJQ2jXt1B1rNbAcIgeFMs1ncE99t440vVtPZ82XN322q7H14C+flsPUgPOsnJokucg==", "e8c1fb73-3d0e-41a1-ae52-207364fdbb9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "436c4fd7-416d-40ed-a26d-bfe97c9d8673", "AQAAAAEAACcQAAAAENWB/y6ptAL1ryGPJVMjnaFumbGQMhW/T8C5M1c+ak49cEta6S/K2KHQVVQhn/YogQ==", "98db2ee6-83fe-4fa3-9191-5557d6b552c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9721d14-8d85-4118-88ed-79f315a006b7", "AQAAAAEAACcQAAAAEFb7cPgGGzZGEzCWwseTHOp0KRdm4MXDUc7GqESFEg8jRWcYGs/2hK/hMyL3ib448A==", "95f01e98-d6bc-45fb-891d-574c4ebc08ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4df8e9c-6800-4038-9c36-2ce5b38eade9", "AQAAAAEAACcQAAAAEEHv1gKEPW4H7RIdxAeXVUBZFuwwMSX43as0f3yH3zHQT35MDIFSkKdZQI6aUQ2NOA==", "86c03fe6-b575-40a0-9bc5-e554c17bd4f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "276794b9-1a0c-4668-aaba-d30e5f2cb78c", "AQAAAAEAACcQAAAAEJIXHZFG4gPsMem+vnTHFJOVJZbvtO5qfd2U8nrO5Oe5inmR/I9PSUejrTrKrmOdZg==", "177084d9-9fe0-4bd4-9984-c0c9e40d762f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman");

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
        }
    }
}
