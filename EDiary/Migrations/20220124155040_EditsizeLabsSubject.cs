using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class EditsizeLabsSubject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "subjectName",
                table: "subjects",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "labName",
                table: "labs",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "6f87ee52-e382-4443-8317-abce3a730ed1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "92dee8bd-19b6-4808-a7e7-59d766b40e59");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "9428b909-9e60-42c2-9bba-b8f844ab459b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "4cbefa57-4ff4-4885-8166-3e3c92009412");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba08e13c-47a6-4633-86b8-ea08f523acf7", "AQAAAAEAACcQAAAAEDedPZM+JX6b9DhkDYkTTUcRWLLYr4wjN1rvDd3hx34wiOuaHskRH63sIRofRWdYFw==", "2a57e016-5926-4980-b8a5-cb8378707955" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5875190e-ca0e-4ea2-8c63-339625ee46e8", "AQAAAAEAACcQAAAAEDGcjZzgOmy1WIv2wh6aUgRxxkOinantf3+cZUBu7hRhXBqUn0EQuWUOMKC/ylvhxg==", "9e92e780-8857-45bd-9bee-5c4c467097f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d632ea3-3a70-45de-930e-7d551ddb9d77", "AQAAAAEAACcQAAAAEN8RTKpYb/sOs0AO32ih8gi3K4NSdPvxBY78kTo+CTk3nwp818au04pdhozikHWvOw==", "fda35a70-a1fd-4d8d-b19b-c59af7cd0e72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86083dc9-bbf5-435d-ac4b-07bad7b29cab", "AQAAAAEAACcQAAAAEG1wh/SmzkkK0r9ZBpVrOwAvL9xOEA0mHNrCA0eOFREQa2mzbRhSe+GdSMPAEClq0Q==", "cf687939-2aa9-4331-9cca-6716412274c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7bdafa3-a938-4045-997a-a808eaa3a6bf", "AQAAAAEAACcQAAAAEMixxVWKjJLRRZ9oCDe4/5M9q6f/dg1Fwo/YzZNZ5IqPgijuAG1J9Bx+Ku4HDettzQ==", "be6cc22d-5e23-413a-814c-92f1321f9d43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ee633c8-0801-40c5-ab51-f9e50925ce4c", "AQAAAAEAACcQAAAAEGdp0xPyecuroLYnllA1MrFyns1kM2PWvtnTUgRtJ+nERxmcazAsb0U3+JvAXFVSdQ==", "5bbc5d03-3f62-4577-98ff-b0f1cc5c0738" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2f997ed-edf3-417e-b507-bd3388dbc96b", "AQAAAAEAACcQAAAAECRtgRmN4djhxwzxeRB2r7PF3CZS9HSYoFg9DWha5VW+kAtvlYbifmsLSbdpya6kOg==", "b64655ee-83a6-47b6-be91-d03c2e8bf261" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bd0141e-aaac-49b5-afb9-d70da1eb4a33", "AQAAAAEAACcQAAAAEFG+050DaOFYYUl8EdCVn7vuKYjnB1U6SKhchXrjOXSmG2uspSZxcKXmQLKFRByVvg==", "6df2d965-066a-4fd3-9aa6-4cc37bb739b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f333e08e-c9f2-40ba-a235-cdee807fd3fc", "AQAAAAEAACcQAAAAEIszk/ESy0ATxbaGI2lMg0I4tyzMuHgmnbWMrgDywgS7o06KjkfRKBccE8J1kJ7sYg==", "5fb0e5ef-622e-453f-bdbb-d8648d3c298d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8838650-eff5-45ed-8f38-cb428e9e1160", "AQAAAAEAACcQAAAAENyA+5lE0X2gY7h6DR1PwsPC6i20QOQO+EslMDdkPLAzU4HxQTm8/HoyKDxGZXEg0A==", "9cc37f6a-cb7f-4731-a740-2079e75c535a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29e52281-0dcb-4fe5-82d1-5464c287d565", "AQAAAAEAACcQAAAAEOWzaA2svPr5zoTAl2faSg8tulRHxtg8dGRYtENi6MJg10FotkQ4Q/pQZ2K6NotIjg==", "cdf5d021-cd17-4691-9eb3-4d0ef999898c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6edec36c-94d0-43b4-a4db-faaabcd796c1", "AQAAAAEAACcQAAAAENxxZo4i1nl5PjVMccLgdJyEYZclOPJu6wNfQNmQvKQKQZSHbCxjrk2W9noLQO5nag==", "195ef823-3772-4fc8-9034-72ecbb19677a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6d6f786-171e-4679-9331-822e4d3b2720", "AQAAAAEAACcQAAAAEB1jsKpHzotqYnv5+eAFMe9guheX+ZPRfvBgSOTXs3LTAtDvbIXp3aI1kRd/c5JUWg==", "ec7a3df0-b369-42c1-b7e5-f12f252d88d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7110e55-815f-43ce-b360-a171dacb89eb", "AQAAAAEAACcQAAAAEEIGjQi9xPST93LYQBLgsxYsC7+/hz3b+QKEmZJSRbhRvosXYP7bVzQa00ZpbJ6HGw==", "d786ec03-2019-4ed1-b185-a30527f75aae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "343e7047-3356-4070-9614-6b445724f6a6", "AQAAAAEAACcQAAAAELJxb5FUbkCV1JUpXLcfiAgVfNG1CCrJ8rtMaxCWwTQd6a/2PXzibLGuA/BdVaJmyQ==", "cf716a23-3ddc-48cb-b3d0-795b150b8b6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "995fd1d0-04fd-4fe9-a7e3-1e46211ebf55", "AQAAAAEAACcQAAAAEHNzxWn/q5MQm+C21y8JfemdmMTtQt1sVNdgR7imHjtbp43k385Roh5edWPNe0ycwg==", "659ec4ae-f4fa-4af2-aa2c-5d0d622e42e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfbf6c4d-4639-4060-9348-5ab7bbdeb282", "AQAAAAEAACcQAAAAEAtLEUyuvNKjzV0BurjZ53YvEsG96rdrtAfXvaqteqo7PM9d4x7AVere2qYUPIRfBg==", "22c3781b-a21c-4d5f-b028-34d169b97d71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "468d275b-6dde-49d7-ad1a-f5b07c647609", "AQAAAAEAACcQAAAAEOGHc/WRKQBUnEgG+BuDdjw/svsensh1AgnwWt4I2U9Z0DSF4ed46/5DMV02OSdM3g==", "e223597e-fed1-47a4-8087-1df201851ded" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a2cb5c6-cb66-4606-996d-15e07d51c3fe", "AQAAAAEAACcQAAAAEOXJhrHCLFpvEsodorKkaLuCcvSkg9Y2rSIohW2YqGS117Qg/ydImfNpLzRxSprxmw==", "8f2c9555-d807-46f4-a383-475daff46045" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e8a2ed8-17ad-499c-a795-8be86d332b30", "AQAAAAEAACcQAAAAEJ/EAcmNQ8FvrdnLf0pcm0Q1n2+61KkiWq+bzy8mPXZxPfJnDgFodfmz/Q+L7KaU7g==", "e4c42c5f-0102-457e-b68b-ff0e7f99bd2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fb66e0b-7cdb-4273-88e6-5ad6b862b8ac", "AQAAAAEAACcQAAAAEPXixd3zvzUZqH5XfWj3T3L9pBMPS+DzNhIeQ2daWrUkKj63dqizDo9/6lRpSV57Pw==", "73c20794-1b22-4f57-880f-052d6cd4721b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5e81971-a8f5-4d18-8770-3d14081b548b", "AQAAAAEAACcQAAAAEIt6fh3Li85otIMdil7CgWq32VV33A07x5F8MFPiTWy8Psvj4EsmSu3bRyobjxNvRA==", "41d39932-b2ba-4309-95a6-ce95afbda0f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da8ff3fd-5044-444a-ae57-4d1e6a69d3b0", "AQAAAAEAACcQAAAAEE3yH24sqMv70tRkIMwbgIHsZR1FcoTaByZCQklU5YOzHrsGIrh/3AEwkKEPr5BLFA==", "b1fe1419-95f2-4292-8bc7-0a614ab6d0a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "359a1a45-abee-42b9-8a6c-61bd9ad5ca8b", "AQAAAAEAACcQAAAAEBNlS9zZvSZM/8PPZFrLh11vl6T7KRYg2ZkGAl034ibTuHar21el2fY8k+JdsuRa+A==", "1bff88ce-e029-4562-8c86-a7f2d9e74d7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5c85e5b-8f16-44fa-9afb-1220d7a63018", "AQAAAAEAACcQAAAAEJHoPE47DFziVfWyCKr2kbUSb2fOxjjM8kA3fp63NhHboVIbQMvFqWp158TWBvh1sw==", "d754fb5e-6522-4944-b7d2-68196509b01a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8951904-1f1d-4050-a700-115341a39e69", "AQAAAAEAACcQAAAAEBL00Ey12dAWRBaU09jMlNbW66ICuQ3bbOp0wJiXPod9yl3G9bQAzhrFXK461K+npQ==", "c2fbb837-c9ef-4cdc-89d2-63ce72b32bba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab473722-6078-4c0b-9d74-ac79710ae48f", "AQAAAAEAACcQAAAAECvyLE3rc9fydr4Hz3DDAdsKZe+o2TzOjSMPoaMcaJVx6QzmpWJqlelBqJMTufmyLA==", "26fcc945-b459-44cc-ad6d-35a65ae08ece" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "641379d5-36d8-4aab-b1d3-94fb9715ab1b", "AQAAAAEAACcQAAAAELnwlHUvq/PJ6YD34ZTjxw8MSgLnaV+Nndg7osQHCh+QcI+wSaeIHRcVoVV0hHRJzg==", "65f4aded-18ec-49fc-918c-36c8546c39af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45f934d7-8851-499d-8818-8e6f470128f0", "AQAAAAEAACcQAAAAEM9uaChilJRgOsZ65aQyqh+usRfp6OJEJGDo8dX6iVOc/CPifh2Lwy926U+27a3oEQ==", "5d3e240b-18d9-44dd-858a-44ab8a4c2cc8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62d996e5-fd20-47dc-84af-94ac907981bb", "AQAAAAEAACcQAAAAEIV8cFA8YGovIAr7Qe9vAdsMDKem9a6ZjkVUsUoyKzf6eAYSB1r2WRchEpcWD5ulow==", "49fbab6b-4fc5-46d0-b540-138c1a264e15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "749d47c6-f851-4cdd-933e-d81bd184bd60", "AQAAAAEAACcQAAAAELNS4sq7HWf9cqJxcqGKtz1KTWHYwrep70nRJhXZSkLb5ywrbXN+XPV+OUoSsMk/jg==", "2795c7d5-6ab3-4ab4-9c83-91fc93dcd792" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "670be615-1e0a-4929-9e57-3f6665d9e83e", "AQAAAAEAACcQAAAAEKj3qpSY041O2YC34szehmSNHYch9lUvNfHUerauv1jTICYgvdPMt8Zz9te+Z/nWyQ==", "a5523fc2-d730-4304-9a9b-62a3d8a3edb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9663821-c75a-47fd-958c-4dfc06bd5757", "AQAAAAEAACcQAAAAENAfMHFVduap+UE6JmdDQjdnLqNUU/dc48YMKxp0qBtfZX39OvhmtP3ZSkFnHiee8A==", "74645322-78bd-49ae-a975-378bf3517c8d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff7ecde3-c7c1-4858-aed6-5141c3aca5a7", "AQAAAAEAACcQAAAAEIxLz73rkmAq8+eTkYluU9+E6hnBjZ6IlVDXV9VmaMsxRmBikzrwrvX7+MvWYAqjkQ==", "da1c7bb8-c605-47b0-847c-78fe570dc62c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2b0fe50-e56e-4265-8e88-91d9e1d1292a", "AQAAAAEAACcQAAAAEEXd2dQhN5RNw2USsyJSQ/hEGXR9o/6NaG46+Hj27TlIAH1mL6jm6ISX48144oyXtw==", "d7dad644-d7d2-468a-808f-3e78a8a8fcfd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14956197-0378-4cf8-ba92-70fd3f80c91c", "AQAAAAEAACcQAAAAEEFeU7dbpMZX+jurww0+JYalMt9v2CVfgUJsYDFOMMxljmDvEsdLsQ0M+w9ftO/FRQ==", "c6e5fb45-abed-4c21-9df8-daf325517072" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b47ba94-dcd0-4ee6-b743-26d05abe9432", "AQAAAAEAACcQAAAAEBG7c2K5xrarIhAKNPJSiwfTMuOSXUKxMmOlC9LSb4nUvnAoYYXj3zBNso7fzO21zw==", "3388160b-3d5f-4f68-8c95-aa2808ae331a" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "38", 0, "9772a495-1553-4773-b2b0-ac4a782941cb", null, false, false, null, null, "TR000007", "AQAAAAEAACcQAAAAEB2L+q7KtfLQqrwjpDXvBIpCJLQ0gLYuo5BW6y2S+JW+GKPVlRW4TWzc+Kf7B9iZtw==", null, false, "cae760d6-e16a-4ab8-a9f0-1606c67e71e0", false, "tr000007" });

            migrationBuilder.InsertData(
                table: "teachers",
                columns: new[] { "teacherId", "teacherLastname", "teacherName", "teacherPic", "teacherStatus", "teacherSurname", "teacherUser" },
                values: new object[] { 7, "Николаевна", "Ольга", null, null, "Виничук", "38" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "teacherId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38");

            migrationBuilder.AlterColumn<string>(
                name: "subjectName",
                table: "subjects",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "labName",
                table: "labs",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "5d1a8cce-254e-4cc0-86f1-d2e316a8bd0b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "bd875869-ef4b-449b-ae73-e23788bcacaa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "46903c4c-27d9-44e4-8ebc-70ea68bc1cc5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "fbfc5188-7722-41f7-939d-dcf7d2e9c988");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5062e9f0-6d4d-45c9-bbab-4dd0b75f0b2f", "AQAAAAEAACcQAAAAEEPzoIGGz//sMl2vL3gpYD4EK8shJQZodeU1ZAMtBtehfopcYCZeUuHcdgeJTIjspg==", "5b4b6d85-b609-48fa-82b5-806acc1a8831" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cec6138c-c5b3-4656-b8f1-06907aad868b", "AQAAAAEAACcQAAAAELXvVeu9nMla8sbMsZmR5MPAGVWsZ/D9ekgcy1a4oDDTyuMaka5pMm/bXaTh4IBVqg==", "4f18866f-8b19-4f09-80fa-e7b5e064fa78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c16c28d-8f46-499d-a8b4-4fdaa3b8cf2f", "AQAAAAEAACcQAAAAEErQn9XV/TPrzG6IJ1FoJ4o3aQUyukGi371f7OSE2oU/otUKsIGcvx6ZnksyE4aVRg==", "59175451-7324-48de-867c-25680a822960" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c452f9f-3bd5-4779-9be3-62b7f9cd3adf", "AQAAAAEAACcQAAAAEDEcJtJL8bu7C0WpFWdUm7AXOJm38f5qGOc0+C/9c0n6uHSBmOyqxUsxPqhcFpqugw==", "7325ec53-df59-4958-bf49-18714969d61c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42a1e499-ddd2-4b54-91b3-394b8a195f90", "AQAAAAEAACcQAAAAEGf2V1GqLFS76rsSuhhOHglqYTcS3RQ0EYsDzPsuZpAiUg56pMdUesEZcEvS3c5KKQ==", "2e534f91-b014-4b61-a248-6055e851a003" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4168f7c-b565-48e8-b71e-57559af3fbae", "AQAAAAEAACcQAAAAEBar5LqIdZrmCMrhBDpARGWoOOD67Lt/6bqc7k1U7dw7baukX/b/Gw1CilPGKVQqxA==", "444c475a-e385-45cf-816f-f1855e42a3b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f8c1f17-4628-4a90-bb65-0ac553246c49", "AQAAAAEAACcQAAAAECQRkVWENysuKZFBwUG8bf9/A5x68kKXh/LPNjsSd0toqd3BNqoVSEoIkn49m5VcKQ==", "68152195-c391-4342-8dc5-dd297f998cd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1fb8ad2-26db-4318-b216-52e8d44d16c0", "AQAAAAEAACcQAAAAEDN+QAAaB9DAXyth3+kJa+0SHVQ8k8VQ3mxPRQ2Y1LLR0hLFm5dCBvfyVDEFhHiEyw==", "05baa360-d879-456d-9c5e-e195d66a2efa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f650aece-ebfc-4bb1-af08-4aa33f476b8a", "AQAAAAEAACcQAAAAEGLB66SjRtFiuqwu5JdYNjDTTinwB3LFp4OmkKbs7Oli8E8sbEXGjLkLRkz8oKHJaA==", "4d849f64-0354-4f31-8a23-41143bde0def" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b30cf114-3a43-4d8b-9b1e-00f6d7d1eb73", "AQAAAAEAACcQAAAAEOeX9gDueVtlfetbdFQVbNOj00KRF4kGDiiNIO8G6Ur6+A5hi6vjOY/7PgCrVRiBlg==", "ee0f9e0a-ccdc-4cc6-ba76-c3e3d665ceda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12f77731-00eb-433a-88fe-05c3ab940e1d", "AQAAAAEAACcQAAAAELS5opCvBTI+XF4XPxFcQMsh/uE6NpHttKKGpIuC1Rj+akIGoejL26LAeas7vFnjUA==", "c97b022f-34ae-46e8-9949-28d3b9f3fde5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4fd7e4c-ce1e-4cd2-a372-2d20fb7ecb32", "AQAAAAEAACcQAAAAEB7zaiD8tS20Xp24YP7yIFZ8QZusv+46PVl+EZlPEGtM0lTA3tGnXj6hTZUOE5mxvA==", "2308678e-3207-4143-b7f3-a89fa0bf971e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e22a7cb-d537-4602-8cfc-285c461bd6d6", "AQAAAAEAACcQAAAAEFtXubE/9nBgCo5uZixA+Hd6cCcKR5ffIAms9VJJPXLQUok+U2wBf71iaNyREopsHA==", "2ef9c66f-ce2b-40b2-9d34-8fd8697fef57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "caf5ad5f-10d1-437c-9e45-1c20fa1b64a4", "AQAAAAEAACcQAAAAEHKsxrbH5/+oGbJzbMzPs9JLqwsX/NUQ98FFNBXi28nUBT03Zd6p6CLkFDVBax5+QQ==", "5d931ab6-055c-487c-ac2f-f8924669af55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54e3cd04-268c-4c46-b7b0-33dbe6528f1f", "AQAAAAEAACcQAAAAEJeC6zMoqnznhJ7LTJ9L+wWSl4IQV4rAaK9R3NlRtR85CZ2MfHXD+Fpi4d/ghurHLw==", "8b47fdca-a98c-4c5b-a5ab-50bb1a76bc70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d010183e-c2c0-4aa2-9e48-71bb9878b0dc", "AQAAAAEAACcQAAAAEDcSSF9eBYP4q9wP6ib3+zNFbPCcAoCRv3L2qqCSIA45SWpNM4eEpEWu4hfig4rqWA==", "3bd16cf4-5544-46f8-8ddb-9d68b71f1cc3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fda0e8bc-9b2b-4429-85ec-e6c1acf1cc79", "AQAAAAEAACcQAAAAECzLLxBI7TRou2gc1arPllbi9xiwZcoQwdWffT7D3QJvIwbiqc+QeuNAgIxACkH53g==", "fe1f976c-2c6e-401f-bbce-b29d0fcf7d12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2d4e570-0a80-4f86-9bae-93f2a34fb2f5", "AQAAAAEAACcQAAAAEAS53KRkZRN4DXHr4fcwPU9adB5Frz0gcQe6AZH+wK8LGRQaLWc3670axZr+HoT5jA==", "961b0e85-3e2d-4428-b0d7-142ba6858e9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0851118f-90ea-4c40-961e-1021085b4dc9", "AQAAAAEAACcQAAAAEIgSZZcghBJs0Nd46ubHg6ttjxVW8jnpWDZMebwymjR36es7pBFhz7Ye8AHAdPCr6w==", "7fae1f60-b948-44eb-8b8c-b5334bb76882" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b02c52e8-0d6c-4f9f-bed2-d5b4524c1463", "AQAAAAEAACcQAAAAEIeh+Ea9vVjNxd3HyYyWJ748/UilGB+hHZkYzgF+gGBYJc6yxDmCETmZPgm24L9onQ==", "73c216b6-5e8d-4058-8e95-f26d9ca39637" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d19881b7-d2ca-45ff-91a8-ee774ad6f301", "AQAAAAEAACcQAAAAEB3cTOFIXeZtvGRmvu3es9THsjPG2IbTkPhn4/WLB9j5rbFcIAKowVhUwxr89DON7g==", "282a6cc6-d8f9-451c-9fb1-d2641496c15f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f075f97-04a1-4001-a186-f0183ec5a145", "AQAAAAEAACcQAAAAED4Aq/WS8WqQSwK6KlzW5q2fzHQIJeCnBRIYBO8MOkpy3rGW4TwsgzZ8IwK0d6WIsw==", "38230066-8fa6-4fa3-92e8-9fd6eb6b39e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca044421-b5a6-4fab-a6e6-03f807a20803", "AQAAAAEAACcQAAAAEHVIApffFqf9ALoH3kMNPq9ZpoFbHJe39v0aw0jwSvyBIbKKkWk5QNL+oudkGrPUjQ==", "8e29a387-ce61-4dd6-8a07-7b546047c5e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24407531-f54c-45b6-8f4d-8ef2b4ab1905", "AQAAAAEAACcQAAAAEIfP7QbHvQSCfM/kEWl5whnN3VFHd7EEMRH5qam2Ep4AcwTFfNukGj1TaknDhX7+/Q==", "47e5cab9-746f-4827-8cb7-6e2b36246bb0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ddd08f9a-9032-425c-a17b-9adc0f4b822c", "AQAAAAEAACcQAAAAEDh/2ToUlGXXTzSm9gntisWHCauc+b47r4342zjQJoamiHw9MRGGW0DGNTGoL4JlPA==", "a8bbdf4b-adcc-434d-8ddd-0bb104157014" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "071ee0b2-3a6f-4a49-aced-16187506c7a8", "AQAAAAEAACcQAAAAEHylmIpnhBjpNGInztWo/LLABXjZ0KM5hbi0gJvrXWFNppDQ3TrmZSoLSqLXe8UuUw==", "debe63b2-808d-4157-ba4c-62c3ebf328f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8aee48b5-3e4f-418c-9534-918ab0f5164e", "AQAAAAEAACcQAAAAEPd3At7D2U7uwH4ANzWq7G/iMYZ+OCds+zkOX17E/7ShXynX+9f41GUSilJXpeuUaw==", "fa24922f-7beb-4a6f-a5e4-64a80d05759d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd8363f1-c74e-4063-b1a6-0e903ccde384", "AQAAAAEAACcQAAAAEBzX9rOo7Tfh/E+houaw+WmGwAGGH1fX0MzeH19WNLiI/sKV4h1UMn2uxgUA786vtQ==", "a1303139-9be7-4098-a9be-c2dc5f808746" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39dedb61-d9b3-4021-94c4-6f4b6b6127dc", "AQAAAAEAACcQAAAAEIPsr/aMOtVAQyq9zo9z645ZaqHR5rlDYzba1DjzTEdJ5U09Qn/Eh5AAxaSuQePLjA==", "663164b2-8c0f-4a54-b40b-aba99641753f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9777f789-c605-46b9-9c25-9853d89df5bb", "AQAAAAEAACcQAAAAEPpKJXSEV7TOFCj2X80Ug6eqhsyF/9t5vI7EkSpU1h79ODmzRbIsh9nbcCxTCsH7cw==", "d829dd9a-8f6f-420e-bca9-b14fa031d804" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd9e6a0c-c4d0-4458-a396-52e200eab235", "AQAAAAEAACcQAAAAEOv8CClawT8wusDo2gsUmXCLvQ0T5mTKbDiCalwTNvs/gD6nOvVMJc7sGSWbpqw5pw==", "331b4d20-15f7-4e50-bc5f-96d477084720" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74339aae-af0e-4281-91eb-0801a334d5e3", "AQAAAAEAACcQAAAAED8A5apgJwJU3qEBkfY1r5itE0CSS2nrkfZDgAtBF2Q66o573LKQWcxdlk6aWPVVLA==", "c5c8954c-0ee7-4670-9f0d-0a08aa2c3e48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46d8561a-71c0-49a1-923c-e0f2409e863f", "AQAAAAEAACcQAAAAELKwN4ZR2c+rOGWklaVUHhQXW56HXEmVDrzrvae5iJefAs1V6elqUOB0LWAj7nF4ug==", "7bd51a68-491b-445d-837d-49a8175c2887" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3910b1a5-56aa-4dc0-9311-4c6b40715236", "AQAAAAEAACcQAAAAEIWyiYjuluHPNKCo72eSKYujuYeppzFvp8pm+r9sl5m2ztjlYcjN5rhz7ZcalONrPQ==", "e6884d76-ebab-42b3-b7fd-9bab697ec87e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a95c3a10-c0c1-4068-ac9f-a1b833ecde68", "AQAAAAEAACcQAAAAEAFhDE/zrrvMTmCvmmQlMteNsVs+RIdCEUn9IYtqSwEnmeSesUfA9YoQRKFHmIiRlA==", "ea0e588e-e8b2-483c-9ee4-ed85a5847463" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e34f141-3afa-4c1b-97ae-7774d5579b52", "AQAAAAEAACcQAAAAEMTJOtIm8ktOm1243iIOJuokB6L0Gz/KRf2oZg3MwyW6WeOZS0T88lhxyXwmp3WPlQ==", "df9f369b-d239-46d7-b12c-c24464198b7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bc3292b-c128-47c6-957c-4679e4a3e7af", "AQAAAAEAACcQAAAAENMVzxB/3ZBSERyMye5i6ABxumoizrNRtCJrAOvZl3X3QsEuZvO88+YW/lAuN4x8PA==", "7446515e-e557-45ff-8361-f420dd464c87" });
        }
    }
}
