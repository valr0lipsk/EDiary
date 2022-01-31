using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class addsubIcon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "subjectPicture",
                table: "subjects",
                type: "int",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "subjectIcons",
                columns: table => new
                {
                    subjectIconId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subjectPicture = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subjectIcons", x => x.subjectIconId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "subjectIcons");

            migrationBuilder.AlterColumn<byte[]>(
                name: "subjectPicture",
                table: "subjects",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "60bb0bf3-2673-414e-ac51-05709d3f1f62");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "a3c0503d-8aba-4a7b-8be5-4e3151435793");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "5fe659a4-c8ab-44f3-a087-f01efce6ca8b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "8f02e6e2-e9a6-4559-bb52-53d92f91fabb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c2eee21-92f0-4e36-b105-0231ca462a22", "AQAAAAEAACcQAAAAEO0ZW2xRL6xNjzGoiIkjCHenGqKWZf3epZOduQh8Ae8JlhMhomxPsRW1nsmgBJejFQ==", "110e86fa-8e48-4939-92be-c5108c6da2d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c108778-1070-48f1-872e-b2af46a50d8d", "AQAAAAEAACcQAAAAEG8x+wuUfkE7BM4gyV480mPT0TnVytaFyx/IRQdXt0RYj6BJHf1dVBLnimhVlXY3dQ==", "2ce030dc-751a-467b-83dd-06a5ed19d6f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a869047-ef55-4de1-9192-f7038004efdf", "AQAAAAEAACcQAAAAEJg7I9s4wWNB5aZuZgt04Ce4/c2lDy4HIwQ5OdLfiyoNNDJSMyI2Pm9wlMHYfW5q5w==", "3440e9b4-fa17-482d-a29b-0bfcbac1864e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bee6f5ce-d24c-4a2e-83b6-2945dacb0ae8", "AQAAAAEAACcQAAAAEDsaYJyrpgjkGDh19MpFQqvJkywt7STIcKtlvINqzHFrP9h7ko1WI3/TX7hVpgoOgQ==", "c9110813-1a35-4376-b5f6-9e07568d8a05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b289c0e5-3c30-4d3d-8905-ddffd653beb6", "AQAAAAEAACcQAAAAEF/LRVmE3zyrx+ozaFZvQ9DZVz1axGfetMClnU0JX98524SaH6ac/oO15NBb70u8AA==", "75109aac-d9aa-426d-ac4b-17a6217fed35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5759631a-b7f0-49d7-a191-f98cef426cda", "AQAAAAEAACcQAAAAEPOIk9RaCSXbr3h3+wVJMbf4OxZfNlaxdo4wEVWIxtK5PpJxKyKkZQ8QERFv5DWg9A==", "8fc97e49-8b79-44b4-a3aa-0ab3d53b853a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa56b545-c363-4e5e-85b5-682d04927976", "AQAAAAEAACcQAAAAEB6Hd+++CzvBdOZFCcXIF8OeM0/8KUL+3d1/qP7xl4qZFtIC1pmZQjEzN28VCkTm8A==", "715dc74f-3581-472e-9e1d-118f7396cffb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a750a9fb-b077-467d-bd9f-7cae46fe9151", "AQAAAAEAACcQAAAAEAZiItQyu9cecoBCsTWJERN336MW48D6FdnRKU+koGkrN0MMc4LHGil3EF4cfvAhqg==", "0161c75a-0173-4e3e-8b63-8dfabd259820" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1a68b20-0eec-41fe-9d86-dc3deb8d261b", "AQAAAAEAACcQAAAAEDXNI7tV/YRRRdefKpa7tQd9DsBPhE2+mKF+VwAgPu9rkUFbq57sosqKGjoHswUY8Q==", "453e8551-4029-44d8-b79c-1edef7c1a2fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97761c33-856f-4376-a57f-620ceb932d74", "AQAAAAEAACcQAAAAEH6sqERWxf1ml7kkIT9JQ3Bw7YNMTSsCHBf2mqu05ufEVNaMyEgbwYHWWUv75JTzoA==", "540c5c50-bd44-4caf-92dd-3910523c9e90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "703e6656-ead5-430f-9468-2bde04c23e12", "AQAAAAEAACcQAAAAEGopdbayFMr9zaWe+kxOBMt6BPufG+sMOHrkiGRzc/qGFZSFYo5QNBhuqP5n2f/AiA==", "232b56fe-1de9-47bf-9028-80c86424d66d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b468dbb-5014-4423-98e0-b9bd52bc2b83", "AQAAAAEAACcQAAAAEIjiilDullZwWUqbn7IqYJaVRZryJvWQvCNRmk6DH5Ih06u5cx7fWeeHXVkv3Riw4Q==", "452175a3-6177-40b0-a186-84bd6eb6814a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "907c3253-805b-4640-a12f-7d0b857994f8", "AQAAAAEAACcQAAAAEOXh5ffQn4hhY8rrHPfn+VBuw4AoiUlvqrgCEeByL4Af0rs0e7mji3bvrTIOunrqkA==", "3c6c9c75-c5f1-4398-972b-592c44c89d21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffc3f4a8-a35f-4293-b13b-1fe7cc708386", "AQAAAAEAACcQAAAAEPGUvha5jlmTI7Sr1zHkzvB2zQR3DivyMX2fMTZ8ddr7eXNNFifgaoEeAY5EzAw0UA==", "484ba2ab-b711-49de-a423-5cab25a69983" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2ecd7cb-9c2c-4d44-8fb2-ca75d1785ae6", "AQAAAAEAACcQAAAAEI6eG0DHxCxc7rpmk7pCNrxPRAwcekiUvRLOBky/BHRMkoIrS4wnYesjLKQQ0tfbhQ==", "b998170f-8b7f-4bbb-af02-5acf186c4bde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eda1e7da-fe7e-40eb-a1e5-b2be383e620e", "AQAAAAEAACcQAAAAECTKGh/e4d3VzcTkaUnZOKScdSpclFJaSvDwDrFZJZW6L9dCB07PNF6r04gkgepo4A==", "38c0aaa6-da0d-4f15-9c8a-cf3869b1bef0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58a43ed9-4807-45c9-a132-1cfdedc981a2", "AQAAAAEAACcQAAAAEKfsNFt7KcL3ShMDZ4PYJ+2j1PB1Ha0o6gpgJX+xj5DmdS73YAb350mAbRvgiiqzyA==", "9b63e2c6-5c70-4b38-a285-81140e6e46cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c564612a-d715-4a54-931f-d817f2ea8d0d", "AQAAAAEAACcQAAAAEFuyTyH9p6c1rjhtG8IbmJtoWbOLAlPkexttT6qneCDwan4Qydd2XbRdyrM6z0RCNA==", "2865a01b-9766-45bc-ba77-aa9a2d142c8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "458a2829-3f33-423a-82b6-638054d85dcd", "AQAAAAEAACcQAAAAEAmnZFN3asc1EKOl+JneRtSvbaw1ffS/zUa4ApTXIAgcI8v3ZnDHSp/12DhnXDp1Gw==", "369c065b-aab6-4353-b7c9-673ebb3e2153" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ead9912-78bf-4ca7-9a6d-ef466abd43e2", "AQAAAAEAACcQAAAAEMp4sc70F53T4DS1isGEBpNAd6PaKbTE50L/HLGIppRqnzmSmzhyinWzgZr2lcoAsg==", "a6871c6a-d061-4df7-9da8-8db7287407a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cc37e28-79d6-40ee-b5c4-d54782ae85d8", "AQAAAAEAACcQAAAAEHCBO0zGkW9fXE82WPKyggNmKbRgbHgLdeVL0VqPSuKnYMRyiq7WlvF3EYOdX0LrCQ==", "fcfdb17d-b907-463c-ac93-39b528471709" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2523a446-adbc-4eda-bf30-189b7478dc79", "AQAAAAEAACcQAAAAEKMlWd+/tfwpyqB7N+m2D192vH61+ZhFZ+96Hbcry1S3XdGc5PeIjI/gAzMpMM8geg==", "c168aa6d-e0a3-4e28-a79a-092f4f36d8a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5508e232-f23d-4d5c-b996-6e264ae7f58c", "AQAAAAEAACcQAAAAELl3IHkCfF7EdNCFNEnCBPsMoKkdD0hkstT6+KkrJD3yKcPO7ulKZRLfSAc4A2qyqQ==", "4f2e9eb6-8674-4459-98ea-e8079e70a18b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2703dc29-015c-41ad-ac79-0b9d411c8ee2", "AQAAAAEAACcQAAAAEEPptxXR7QwSMjvH5pWROj1tFrHApGE2CIVNv1F7XjbXfdi87RouzdRXz44qoWsNRg==", "439c11de-2ddc-4d43-8603-7cefcbc85e4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02baf344-ccf5-4655-b143-7bad845f7668", "AQAAAAEAACcQAAAAEOS+VnqK8G6NU0K+QIgCBN9UnTPsMMXBJM118RSxLCftmOD1Cbwshg7SticEXzLlHQ==", "e54f0d4f-d341-4555-b0d2-7e23df4c6197" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a79bc2b0-8519-4af0-9acf-287bf1adee0b", "AQAAAAEAACcQAAAAEAAjtuMzHao0p/B5HSfCcvQ13JatqFEwEw701JHzStr9yNNsMGCFhZxbtIa80P8vIQ==", "55230c5e-e98b-4a9b-9e94-b5a8b2a00d79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3eaa89fd-2bc9-48c5-8faa-8a1ef982e8ab", "AQAAAAEAACcQAAAAEN/lU9NuyBmU7F37onxGgjTrvgCIw5oP3PAXqhHuDzHvPS6K8arYIqK0RMuqeohUQg==", "7b7930ba-5cbe-4380-98e3-e6dafade49e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d279257e-73f3-434d-a76c-2feef644f453", "AQAAAAEAACcQAAAAEO8qJLcCkGUnqHCJwoOhagOxwvvZvud+cKjSOWtGB5ytJFBRyqAzsvsq3tbWEl/A9Q==", "7252b574-537c-4069-8acf-45add7c240f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e991fd7c-5bd5-4563-a8e2-3a24ea711430", "AQAAAAEAACcQAAAAEDKoeJQbiUVW4Y/o7y2KVHNZY/Vtv4sEAuRUMwQETNGa7yqIz24/ztMpHJTJzLwW6A==", "f4763a06-d906-4101-87f4-374989c46415" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de39241f-7167-4e74-82d6-6bdf78858b48", "AQAAAAEAACcQAAAAEH+I9APxpGJhpiqfEt9slFkRJze9nuyBNhGNGb0JCTb0CaJnk9xypNG6g5uPX6L59A==", "68c497d6-6b67-45f1-af5d-d7a3cb530d74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf9cbde1-21ad-4c36-88e1-f91c68799fdc", "AQAAAAEAACcQAAAAEP0Xa7ehyDJ/JEUNvyYTxrNNvSGCaNCmcUkqSDlGgP07EORLp6LlQwJacIrhz7YdBQ==", "fa459af5-137a-4820-b899-fa84085da2de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdc5158a-2141-4a54-8de5-c91916a66a27", "AQAAAAEAACcQAAAAELWxmxrkYMEWB27ojWi85PuOSPliUep9KtqVmHmdYhDIqv7WlqGTvNOs2HuZ4MPdKg==", "2615f9d5-a12b-4553-b3ae-0c60f4c6250f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fcc3ff3-85f6-42a1-b016-35fa238b1458", "AQAAAAEAACcQAAAAEEesbBGlQYQRJO2c2F2fdnIBVmZdVh32BYcFKXY2EBbzibFaDWXlITgrFWhawk7gHA==", "d753367c-5e07-4d2b-b90e-d3d4bd883c4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a077bc9e-6376-4d9f-b343-a86647cfaa20", "AQAAAAEAACcQAAAAEHaUwEILZAwH4+AdBpTDb+Se5DPeKQ942O2VO+WgL5FLEASdK4SGBMIdCRsDVSlQnw==", "643c59f1-26ba-41db-a873-e556863f1b0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d32f7aeb-1a90-4d12-af09-2342a17cb656", "AQAAAAEAACcQAAAAEFnGbOTfRha4N3r1LwlzpN7ii6eF8+obGTjJidW/qFktxJLirCrdcvzMtLVp+iGElQ==", "d61c0875-26ae-4ccb-9fec-fabd7b0fceb8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83d11c55-bb73-43dc-bbf7-52cea3c4b27d", "AQAAAAEAACcQAAAAEJX/q0D+zE59qaLS1nnGtE72crVQ1gPbh8CQNm8Y4IA8Zs4rZFi5vAlzZsv58MDSbg==", "571b7426-7586-4a04-b580-3148326853b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "567b2e9e-504e-4502-b9fa-35a0c6111902", "AQAAAAEAACcQAAAAEDt/BSDd6t/BKhOaJhPNXkScycA575dv1HdMwpZ6acpnpMGmi6Ang802zQTq7i7B6w==", "df3e1a52-09c9-47dc-a4b5-02516e154e4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d88a4b3b-966e-44db-8be9-653fa9ce2925", "AQAAAAEAACcQAAAAEHcsBolXKb4lwfoBd9Qc6a0HNYGZVCNOMTQyKdgEtAx/j6/1qEzpjP5HVEavxr0M7A==", "45be5e01-48f7-4d31-a961-a14a4429f49d" });
        }
    }
}
