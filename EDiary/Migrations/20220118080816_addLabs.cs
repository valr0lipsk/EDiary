using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class addLabs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "labs",
                columns: table => new
                {
                    labId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    labName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    countLabs = table.Column<int>(type: "int", nullable: false),
                    studentsCount = table.Column<int>(type: "int", nullable: false),
                    subjectId = table.Column<int>(type: "int", nullable: false),
                    teacherId = table.Column<int>(type: "int", nullable: false),
                    groupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_labs", x => x.labId);
                    table.ForeignKey(
                        name: "FK_labs_groups_groupId",
                        column: x => x.groupId,
                        principalTable: "groups",
                        principalColumn: "groupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_labs_subjects_subjectId",
                        column: x => x.subjectId,
                        principalTable: "subjects",
                        principalColumn: "subjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_labs_teachers_teacherId",
                        column: x => x.teacherId,
                        principalTable: "teachers",
                        principalColumn: "teacherId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_labs_groupId",
                table: "labs",
                column: "groupId");

            migrationBuilder.CreateIndex(
                name: "IX_labs_subjectId",
                table: "labs",
                column: "subjectId");

            migrationBuilder.CreateIndex(
                name: "IX_labs_teacherId",
                table: "labs",
                column: "teacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "labs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "dc24268a-627a-4174-9fe4-4d431732bbeb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "8cd531a8-4dbb-492f-a07a-9c33171f6065");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "b127466e-e520-4f20-92dc-12cf719b3f8d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "3a62f436-ae83-48c6-a561-9aab6efe2a87");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "467742f4-eaf8-4a63-83df-2d4585f643bd", "AQAAAAEAACcQAAAAEGPrBD0H6ZvMfLfRYSAKaDnNkiLHeEFeotnQPYdeg8r2lNtmmpU9Gi1S156iV91LNA==", "146f327a-de0d-4ace-baaf-633f6c82ec1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d49df96e-af5e-46f9-b3ce-e9100a04999d", "AQAAAAEAACcQAAAAEBjB6jJEFC5yHwrOxXps2khnXNJnrAXknn5SoTprZmFbuhp3Ybe9Za2GmoIOEaQU1Q==", "bb78a0ae-62da-4287-a62b-6ea0e25ea458" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a56dc14b-23df-409b-95e7-84088aa0c18a", "AQAAAAEAACcQAAAAEFBviHFuKw2zoZjIGEGiqkIjQ7LpUc3hewEUtA6GR6d990NgmC39MQ9nPt48KuEdpw==", "f98ae045-9162-460b-bafd-2292b3b4464c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "921fa8f9-f184-4976-ba8a-b1ef169f57d5", "AQAAAAEAACcQAAAAENn2a4SAMxTDS5Ru1CkzohA2/7y7GyZR7JpBG9rdaOX/n/DDQlNG6GXuq9253bDNVw==", "c491d5fa-5326-4ef1-8e5a-db03ee10af37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53bbda11-de9d-44cd-8663-29ddd224f0f8", "AQAAAAEAACcQAAAAEJi6fbRs+K6rGPl93oIWrSh8kD3VcG/XCpiAqNwJC0CKc/mOP7JiPB3a4LnsNh/Y3Q==", "295c32ee-c551-40d9-a96b-fae651edb8d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f552830-ae66-41d6-aacf-08da54bb5690", "AQAAAAEAACcQAAAAEJfox93ac6TobCHcCI82jOlkjNE+A+z5QrvyWOJJuK5xvHIHdUaa4shY5mm0hGvQzA==", "4c3e7fa7-30e2-419b-a58e-5a00db2717f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac49be7e-6639-468b-a0b3-f00710066397", "AQAAAAEAACcQAAAAEGNFTc609m9pONSRjJz40FX1FhfbLNaTPYRLVtDn0vueaz1WnF7RabBk/cv+zafKkQ==", "7d47b8cc-38c5-4546-adcd-ea473c2fac4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f40ea69b-0bf8-4c40-9e30-3e224052fd35", "AQAAAAEAACcQAAAAEMAZjXn1SQ7BwJF8hiw4LeyNoHY45PGBpHkl/svieQEu6yt+9IRWn8ySWFCd5mCDNQ==", "34c84afb-ea03-47f3-8a6a-b0f8f0ee7283" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb73e2bb-f5bb-41e9-be10-fe184e435b78", "AQAAAAEAACcQAAAAECcon0+4x4TxSnnOsG7mnV8A3ocZxcdun2Dwn2cyhnHIQ5z8qqvOV4bNFAyztnqPVQ==", "14d2e371-2dd7-4f61-a08a-17093d90fab6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94f0b837-c6c1-4b9b-9fde-b1caa5fadd10", "AQAAAAEAACcQAAAAEJwANywrfKWRqNoRMnPoDdFAsQ8EOyMw9g9XARpgutkQH2HHtWy4EtOliJh+PeJX2g==", "99900d38-3852-4898-88b5-dff5881588c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e29f03ba-b13a-43cb-8ed4-9c572845ef31", "AQAAAAEAACcQAAAAEM6OycJ6oQ17NwLQDkksGbs35mqugGAn0iTBIAah01uN/tPTaAdFxX4uQK3uOcwV9g==", "17315b5d-c1b8-4450-ac09-fc547887cbe7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7366406e-423a-437c-ac92-7046d30ba490", "AQAAAAEAACcQAAAAEFS+e2MpJqVTyhH2YZeGXL/d1tGUPIW2vM3m0JQ9IF7eWfc5DTh2+sDs4z0xr5V2Xw==", "b01ca4c0-52a3-41e4-9cb6-8e4280b50cf2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58de0420-c49a-4b43-a785-1af979523545", "AQAAAAEAACcQAAAAEC7/9M7PgCgV4Y5Cw93glEuskoMOgvaj/vEE46/psGo9HUDy2j5/tshz6MOGTO2Z5w==", "7f81efae-ca00-4b6c-9ec6-2669498bc7c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15ea3a68-aa84-4cd2-898e-6af84a0af07b", "AQAAAAEAACcQAAAAECepAwW0drAwKAN08GswYhOukHsIJY7qUMpdcga1/I2doVTjKD+yoq/HI48NGIzLdw==", "f801f91e-0531-455e-8e64-5f6b401decdd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6288aa92-7741-4132-9deb-fc9c3cd3c8a0", "AQAAAAEAACcQAAAAEB86xlQ2VyGznpeGTDOmzkSwhDn7fZJHo6u4lDFCU5Qa0pWmaIeDzCPfVQB1egt8KQ==", "0b893c47-227c-4236-94d1-30c1b4cc6510" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "309dfdfa-4914-476f-926c-e8529c038e80", "AQAAAAEAACcQAAAAECFMWgEvETsqRaDuS+yXa678PA7XrhfG/05fWRI0dXGzvTRvlbWqerxYOwNiIDxhvw==", "7eaf0c63-8434-42b7-a35b-96e48826d486" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73a9b9f7-89fd-48a3-a08d-30cf1c71ebc8", "AQAAAAEAACcQAAAAEEtiN/SpAEiRo8JfYo2Fgi6YBcGaZiGdlAnYUQVTi1JX8z7R6xe6dk85Qs0TqnPs6g==", "dd6942fc-3560-427c-abbc-fe1cb1728778" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2133acb1-14d7-430a-9d03-30675d779056", "AQAAAAEAACcQAAAAECCXEOz5qBYFVVTEqTuDLax/i6EaQgOAfsVmXZ9gzvZi+IO9l50gcae+HofT2epLuA==", "75d7c086-4f0a-41c9-9f69-e2b5fee65b53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec36fbf3-dccc-4882-ae5a-3df2d533e151", "AQAAAAEAACcQAAAAEIIeWo9Eix334PYK8/0pcpahZhXLMZC/16QDGEhNXX32BZRHjppt1YOVTbGk6kKXgQ==", "1bff38d7-6c3b-4cde-8389-0a4af31dc6a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9cba8fc-a723-4c78-a5ee-3ad93fd4cd99", "AQAAAAEAACcQAAAAEOZrz9sm2vn+FtsOcF9Mc+f991v3BdYrONQs7EklqLxbvMOfNGpc5xsj+IBoGNByNA==", "e22542d1-6e78-44c0-83d8-76546d28edb6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02b8a4ab-2109-409a-afcb-fdd2a7789a1f", "AQAAAAEAACcQAAAAEJdfy6Iafc7mf/UtCmpkJuAPwlt5ek5jtv64VNAN5c0OljGFzACpV9Ix/mgP05ggSA==", "08c15f59-19e4-460e-a83b-bb47024db26c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c389e39-aabd-4cc5-b1dd-b3a7b68fd7d6", "AQAAAAEAACcQAAAAEF3OymexBDEuBqJLHaBbsqt2A9l6ij/Fb8QgzZllgfvBGqUc5cFpadeyCnb9GFm7sg==", "3e2c34c9-93e6-439e-8641-3b6de1ac8ac4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1889d36f-bca4-4d4d-a329-2e3f4c2a2d4f", "AQAAAAEAACcQAAAAEK2Q4SMllnJDr9BUSta2vplMZSB/HGmD77OjNsjqBlH905+jR3gQFMCQCRo8GfuTJQ==", "c71a86ec-5673-438c-ac0c-8db470816409" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7161173a-fa4b-4dac-9da3-c33838b46895", "AQAAAAEAACcQAAAAELRFZ0ZIv8wFuG37rSGtmQGckqPr7TJTpBRMqiAKGz1S1Zf9IgZyskZpTA8ETT0ALQ==", "cbb9927f-5ea6-454d-9f7d-2a0cf255af1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eebde0ba-aa68-488c-a375-8875676c66a3", "AQAAAAEAACcQAAAAEKgec1RbsxDDVP5sOwDghDjolFbYLVMaFhxKIwSDbJva3DjSm9m9S2THrYwPBA5a0g==", "ef7f76c9-813d-4b96-a495-969079577727" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bca0882f-fa47-4329-9e50-0aba8920e731", "AQAAAAEAACcQAAAAEEDjvxj0MU8FBxKARJtxaiVm9Fv+lxfhwW2QLZVXBpgM7lixWXiDQl+zbw32WlSnqg==", "9701200c-f176-41bc-8a0f-4105f847bfad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83783be9-df5b-448e-b580-3ad1308975ed", "AQAAAAEAACcQAAAAEDhTjNCGQm7wp4ImUP4nRVgvfFq1Re4MI2/FyUYQDS2QCiUCNfmOlpnc9L1O63UWpg==", "663f8a95-0835-4b7a-8abc-cf2fef455dff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ff91e95-471b-4832-807a-1d28f7a9477c", "AQAAAAEAACcQAAAAEKmhNBNenBejUVLMbqkb2ckAEWNxUEPEY/vLrdjfbyEEcg2FfQ7+0zkAzfM06smTjQ==", "3dccde10-7409-44a7-a77d-f88bd06020e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "590cfdc7-5a57-4266-b337-af0f44cc26c1", "AQAAAAEAACcQAAAAEAGE3xCW5j6PbbGFbiDmkjzpFM73DtNgAIZsM3R3EZbEJUbQoKjN53Sto3Q8aZe+Yw==", "040355fa-630f-4104-ad52-54562fb4070a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a1f6683-977c-4cc5-9472-e61b95043f16", "AQAAAAEAACcQAAAAEN1wTbM2hWDHitke33qSTcfohWr8J7ZM29RL7K21cyztXIBXol6ApjCrxhSZhp20Eg==", "4116139a-6cca-4cc5-ba37-61051e5b0a41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1174317-f6bf-453e-970c-7b1bcfc7aa17", "AQAAAAEAACcQAAAAEOpAmXZ/r05UjLKki2hgFepzDPkIUgv44koh5PdHEx3AIN9ANdnaiXQqvK2rOCf3yw==", "af768f35-b200-4b89-8074-43e89c94adc3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "915f30c0-4ec1-4e74-a283-6ad797f84643", "AQAAAAEAACcQAAAAEP8Bkxtk27GoCCP/oaz5o/BELCab3iNpZem2eARcE49irN8/DdHb9aNFn/I6lwqwUw==", "00c16e7b-c06d-4b64-83df-e3daef0b7c09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4147f637-5024-4965-b5e4-4a5a4e5785f7", "AQAAAAEAACcQAAAAEM222CP9ccsB8omTzIWiTKsFSmfLoZuEMafOUrFb7FZ/lQClN4Hc/8E6CXeNeWw+Tg==", "5a86da4f-8b4b-4d1f-a528-1649037bdcde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba51c4ca-ca97-4f08-a7ce-6fc382e31fe6", "AQAAAAEAACcQAAAAEAuAdqFfu31Tu0eyP+VkQrY+9AVnIfofYdR4sWymTKSKERAy5BXzVqBWzTblICFeFw==", "0ae82b97-a375-4e56-8801-766d10c50828" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df486a2a-2330-4496-b670-39d5885b25df", "AQAAAAEAACcQAAAAEEO3vBTYKNWpwcteAtzZxG/31bCYfCDrPMSID61ADoEFniwmqy0o/N3lIgg+PE7NEA==", "52b2bee8-37b5-4228-8dd6-776181cc7689" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d51066c8-b1b3-4d5e-a709-64b3299d7ec6", "AQAAAAEAACcQAAAAEAHhBF2zsjaBKrU/Ra7KDVMBfUujGigCl/+F0DkS1IUW+2pOY/Z8mV4iJFznW1JGlg==", "b1595c44-7037-4495-a15d-e0b539692233" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c27f075-a788-48cf-af71-0cbf37b7e508", "AQAAAAEAACcQAAAAEOHwtiabCcLc8eaRG/X3HQoGtPkHFeKa34DcHXuA780MCRO3YotT7TDY3qtIBx6UDA==", "2360c58c-aab6-48f1-93a6-9c73afc26004" });
        }
    }
}
