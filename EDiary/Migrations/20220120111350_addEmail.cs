using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class addEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bc3292b-c128-47c6-957c-4679e4a3e7af", "valery.lipskaya03@gmail.com", true, "AQAAAAEAACcQAAAAENMVzxB/3ZBSERyMye5i6ABxumoizrNRtCJrAOvZl3X3QsEuZvO88+YW/lAuN4x8PA==", "7446515e-e557-45ff-8361-f420dd464c87" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "d099ad9d-6605-46a4-acc6-c8b22c3e3613");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "4a168c40-7ef5-4d41-9d4e-52465391e841");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "2a507d3c-519d-4749-9777-054041e5b565");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "1ab8e1be-244a-4512-852a-ec451b02c57e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f22da9fe-c4bf-46be-8bbc-9c43ba6f8e78", "AQAAAAEAACcQAAAAEMjl0IXapY+pTZPCniHf/h5ilSXasMSN+OiT341FK43EJCru3QqSrnpIKre0LMQpBg==", "bb6268fb-2805-45a7-bf26-a55f77da5713" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6debffed-43e0-471d-b6eb-09087a0fe66c", "AQAAAAEAACcQAAAAEB1WDg5L4e3WS+jK/hyYFEhKnGQgRN7ts9CaIh0duVPpimn6hHMcclgYdbwHgibYKA==", "d04c0b12-e968-4ed1-a79e-29f20fe8cd65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55dae6ba-cf0b-4bc9-9592-b7616f56899f", "AQAAAAEAACcQAAAAEGaBU/Wzh4l/M1uZBn2Qs4c2foxpZhNFB6T1ZAV9Xh3W+yVVLU9vh++CDDOBQnVpCQ==", "ee3dd434-9ca6-4bef-8198-8d23a8283a65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5051cc14-c633-4f41-b6a4-27b47d9faf6c", "AQAAAAEAACcQAAAAELwHylx3V8wbH6En/bz7JUlvfB1rpkXaIFyOXB7IgLtIQBE2i9IWE0tm+IgqZB3PLw==", "1390fa72-7cd3-4615-99d8-41478b26f14e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9d5a071-600d-4e3f-9f67-170f1fc8d92b", "AQAAAAEAACcQAAAAEEulCoBTW5wA91uvaTk5qlXoriRCjcqYz9w+Lhlk8DES+HwYpiQVwQk6gjQa4ILHKg==", "389a6010-5b4b-4206-9735-69a6d6e9069c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4547af8-601b-43af-8876-0bf14e6d00e9", "AQAAAAEAACcQAAAAEG1cs72ucIvHLdHipozi2wTsTYGpIf/yUIchFmVga7saQw3oRXG6Fbz3h9DY2Te1ug==", "831fa12e-2053-4cf6-8816-6562e0c8424f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce6e8939-fcd0-4b61-923a-62d144fd9c20", "AQAAAAEAACcQAAAAEAW7ao4Jib7lpCe4tpYRQP/siLw0RMt4GXgibjQ3k3bqaZ2Nok7ZtWMJ+hxQ2VhD5g==", "42b4714d-5316-4807-904c-2248275f34ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c6219b3-2a0e-40ce-a08a-551b7eade8f4", "AQAAAAEAACcQAAAAEHt6xm1dGoX9URFbcLhUMhaVNqW0OXnFopHdi4IXwJ8IBunFkvesQLyorXsfW+WNbA==", "69fa78f7-b066-4c78-8500-cd4815cf6b3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6533fe61-7740-494d-835b-2a40ca193163", "AQAAAAEAACcQAAAAEK9/TbAped3TubfuvRURcE/4qTy0aGen8L1vCchFe2RJE9vnA3b7NMYc7FfdHCtxKw==", "9b146b4e-595a-48fa-9392-0f4e3a076db1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6ffc68c-949a-4b15-a7c6-2965c4341424", "AQAAAAEAACcQAAAAEKLqUgBbFCuOGd/8nZPPW07G1HU2OkJN6K588nR50kW3dZ3nSrLVxtnXHcLFnH05Iw==", "4d5a313d-cd2d-45f0-8e29-780e7c387320" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec1c98a2-135e-46ef-b8f9-8d814724f4b5", "AQAAAAEAACcQAAAAEKPpE77EufjuFbdRFmIuSr+5yaue3mqRXXw/WB4zzkz0cjJMOwBaV3T8CCIWMsNPWA==", "d27975d2-5be2-4b00-aacf-f0cded630cc0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35bc4c06-b34c-4769-ae5b-5f11c3297b13", "AQAAAAEAACcQAAAAEPlikH5N85w40GD1+Wgl9/4nnghC+gVwD1DFMOADc2T0YLpg5XxznwhvXQnGCVpv6w==", "5c623e37-4fe7-4019-af4d-cf45e0dd756b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "069e135f-3453-4db0-8bc8-458a7d17916e", "AQAAAAEAACcQAAAAEKZyZL7P4E/fbEZe3rt5b5m6hXnGqxKsFdEROCnyYbpGaPQmEfIcRYqVLnv2baFBGQ==", "67556327-9ce3-49b5-a9d7-6e427ffa41cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbf09817-5d37-44c0-8b69-da695b4f5b70", "AQAAAAEAACcQAAAAELoOQr8lp7QO0+EPtxaiKev8WSpJfwiI0pahrByuWtJRB39FIjqWyirNpZ8z62C+QA==", "ab8a2582-047d-4f03-9685-7368060d0411" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f899711-31a8-453d-b673-b25ebbdf3ae1", "AQAAAAEAACcQAAAAELbJ0vk89XHCXpD3yD0SSj2+wFC0x1rVeJSbTNuWfF2UHGm3d8KPAfOC4Rrakm2qQw==", "56a87bd3-3bb4-49b7-916c-80a6d9a7b738" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ee02d3c-5138-42e2-b41c-90adc248c2bb", "AQAAAAEAACcQAAAAEOOsGXrrj72WgCcNxnu0hn5Qhx+YPzEPIrHBWaNnvBgECsuXCl0ECO4RWYI6x78Hiw==", "04405b79-eb1a-4e56-bf2b-17e25172d2a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "945643f7-64e9-41bb-b6c3-47d43b765077", "AQAAAAEAACcQAAAAECIpczPje1791QZ0o01ze13p5yozKLZBqm8vkVKidYGvPbUECDme/c0tjMEwviO6Hg==", "f959bc64-cd12-41ef-abb6-a91bc327c5cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43633bd2-88da-44f1-bcc2-22f7a7242de8", "AQAAAAEAACcQAAAAEHeBYuO6b/OVrvM1UwRmBFAcFQJM8dem7aVANkpNm9hRAkcpgr9Kahes4NepRYtPAw==", "715d48fe-f41d-48f4-aa77-0681879bba8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83384014-4d9c-40bf-9a82-259de68498ab", "AQAAAAEAACcQAAAAELOPH5ZeLPt9sAbd6kZpxXhPWZ768gvHhW8Pk50O9fcpp30jUJZRjTi5EkdvEPWZpg==", "e6cf11fd-96ad-46bb-a785-887e3494c52c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2c7305f-2528-425c-9b22-b0d43c5b5111", "AQAAAAEAACcQAAAAEFDSeBbF1vxA/qz13JeRmPmmBbUMmiC/tF/3Q0+NkFi66N/S8tY/8k0ZIygMyIHTXA==", "f3782988-dacb-42df-a953-1a15cda604bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d538a85-2420-4408-8593-78276a81c3c1", "AQAAAAEAACcQAAAAEFYQmNPmpShmAry3I/hktpWXigDyy3jGXp7P2YqrkzXt7WcLIaaemUFYWJgeJ2F/Fg==", "0365a605-ec45-456f-974c-279722fa846a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5eaf5c89-1e1c-4c4b-9b23-8ddb34c942c2", "AQAAAAEAACcQAAAAEJ/rv7O/NUHoa0SNMVanGs6EeifSIBXmQl/Y995BFXM+ipko1ycrmmATnBss5y9FPg==", "9d49a6f8-6b8f-4872-9c08-39a45f989aeb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59acd5d5-afce-410e-b88c-848eff7368ed", "AQAAAAEAACcQAAAAENC5rIf7CtgYGoIbsTI50Jf/FJB/3gz5PIN9aJjd70TzhiD6tkgLLRO7qk7QKHYCuA==", "f24706e2-d459-4eed-b105-b8bb7efe4c32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c844361-86f7-48f7-aeda-5ff1ebc0c928", "AQAAAAEAACcQAAAAEMG0kFpqB6lwLV4FBuALAtQuvW6Jpp/UJS1FEwvenKkPc7GApX8MB8yRf7/vXpDCDQ==", "30ed311c-0ca5-49ad-b49d-631f51c28f68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cec0bbe-83af-42ec-8d58-46edee5c3c2f", "AQAAAAEAACcQAAAAEO9VtAYj8z0ANIhZJHtXJwN99eJF8eaGNDXKOZX4BAjSVeh085Url63Xs969gUErsQ==", "d16e62fb-4eed-45a9-9af2-a6a10834d578" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45a27585-65a2-4100-bb1d-2bcdc40868d2", "AQAAAAEAACcQAAAAEOBf0Ih3sVyA58EbHvd/MG9Uu1plBFlkkFeM94O24qzr3DGZmnP+tyxJ8udPiij9mw==", "fed26f37-a94a-457e-95be-db29145d85ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "baf7c3f7-8c52-4473-8d86-4153a454b531", "AQAAAAEAACcQAAAAENDREl7J6tT8SttqfgiUjTvqDcHgF9dysJtac+mfr7ygCaw1H1S0Mk0Y1PxVaQA4eQ==", "2ebc255a-cfb8-4788-9a90-60e8b2ff2070" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72aabcf7-f142-40a4-8d42-e71803294599", "AQAAAAEAACcQAAAAEMoBvEYq34BCm4yNAoa2hBzMkzSw7u3ER9f0TlyAfbdcJgWlUWG6PK9+VNDNJ/r4mQ==", "1f80eb20-59b1-4796-9bc9-00af1bf138c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5313460e-5327-4d34-a3f8-878710ab5e90", "AQAAAAEAACcQAAAAEJLiziifrLNTZQysj+3oTivdqpta0tMAsO/mWHdMSQ0SfvsyzG2v6Odb/xxhIQKjhQ==", "d2ae1b32-6ab0-4f41-acb1-652444a8fd61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77d649d4-e5d2-41e0-9b4d-70b623660c2d", "AQAAAAEAACcQAAAAEHgbagAkycZVLTPX0eoUWKn0K/JqcR7Qd+qm797lkIFYyfoQm/Pn/784giQ3Lp/p3w==", "db9f0cac-6d8b-4a35-b06a-474b9392756f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ddfe3668-c858-45d1-a82f-e1886e1a624b", "AQAAAAEAACcQAAAAENbfWD8PEkqb9XovjLatI9q8iawxqb5AFKMmAH14RCpWl74HsgWgibLZzl1lvD9UXw==", "9fa112ca-a428-4205-8f46-0751f631f19a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8aaf6ad7-741d-4a84-8c8b-61002a5bf5aa", "AQAAAAEAACcQAAAAEFt8ArgDLpwM7JbW2RvdqWbQ3GDWbIsfQUbjTfXiEOw4RxWqlDu99yviewb+bw6rBQ==", "5371b463-8548-4855-98c2-506f5426395d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "054a3a6a-58f0-4142-86a4-f394f1dd5faa", "AQAAAAEAACcQAAAAEJkI0q8CHSZP+6p2nyYW+NRT2fw2D7Ce7E3f1oZBXUj2hV9FJmRB/hKbtetfBCKTgw==", "5a91382c-8a1b-432e-a9c9-03aa2d75c211" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9f7f4c3-e8a9-49cc-904b-007ec60d328f", "AQAAAAEAACcQAAAAELwtSUqFy9RuGirj4439GRNXmbWlNESxFPQ4/ttIBgKhQeYQWHCDIqlMfFESr+Mqtg==", "db964aa9-d0a7-46a4-aa8d-ca77e44fec4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0014e61-0668-427e-bd5c-a6436e4dfa2a", "AQAAAAEAACcQAAAAEL/RnSmIBY8VrzzWcw5ZQPvF43XynuxEFMUrS97T/1kwkgGJyJLA9o5SHgNMUkat9Q==", "d03ce639-937d-47e3-b00c-e5e3cbd72e39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd33301f-3bda-4ab7-aacf-83e0f92311e3", "AQAAAAEAACcQAAAAEIvxrVhWZHyorXJ+LrREZIigSwgWNR2WG6xx0npzkdgkMjqebX1Bj6bGrDf0OVydjg==", "80e55fc6-d0fd-4595-a216-a4f42bd2147b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2cb100f-6107-49f5-9c69-0b04d06aa2e3", null, false, "AQAAAAEAACcQAAAAEAXSoVNSdFM35gzmOiA14gXYnWZN50W3PgnK0TbUq0Sd4y3dSkVcmJpPpQokYM2Smg==", "8fc09329-a6f7-407e-a394-9c28422bfc5c" });
        }
    }
}
