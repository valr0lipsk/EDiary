using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class setNullStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "fd9f9115-de34-45f3-8c19-a8fd447ca478");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "0bd400a8-e0dd-4e9f-8657-ea5f68a9cd16");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "0c0e06a9-6b1a-4c08-9bd7-a40ff8bf5e3a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "a8ce2b27-a099-4a5c-9f3a-7e52c2a50f2c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb21bc34-a7a4-4391-a910-e12091137252", "AQAAAAEAACcQAAAAELSqGJCy+WpyNQo61IfhXaB36EwtbeGHGM0DzEhTK0RoiT38IVfVDB/P8zVrc8jZkw==", "713e3b0f-6687-4087-97b8-2fc4638670fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90244075-03ea-4b8f-8216-b585a9fd4572", "AQAAAAEAACcQAAAAEJMGxZoP8dAP1ONOJUQuMrTylEwAQLWHLbVEvjKdbzZsguYKE1CLB5WvchHmRQ+GHQ==", "1c81430d-1f0d-4d41-88a4-662483a6cba0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "525301d6-fa1a-4efb-b77f-3f065068cd05", "AQAAAAEAACcQAAAAEBE9T4n7/qfthXMf2rk53ZGNPB74CeqKNG5D7Pf8kts+HOWC6KUcz02TKkeCnK3ZGw==", "360f0ece-f33e-4621-8e1b-a0060cb77b50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd59d94b-6e07-4069-8e17-56f78990d70c", "AQAAAAEAACcQAAAAEBK4a4RJbbFe5QxB/niY1dTrNEw44Clyz4w0ivMGTOY2z4gXJ8jwUMiM4sByjxRixg==", "290c8bd8-0ed7-4f25-9d29-139b309edd4d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1a88daf-bbdd-4f3c-9371-95324e495da4", "AQAAAAEAACcQAAAAENVQc2CdXwbWc07sIE+ZFfjXd7Fxg3y7oEkj3e1tXaO4i2ZtAs0366LCYq0VugPMOw==", "e3603c3b-a66b-41a8-8c0b-d423c2d96d73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d788757a-52fe-4e06-acc4-4c8f5ddf3b27", "AQAAAAEAACcQAAAAEOv55y6A4sFnzPj1EfqmkBuL3YYSRbZ4IjkAdvn07wToP8ByvzJzEL3TMk0T8WIKdQ==", "e79d6e6a-b424-4038-b57a-915a7747e825" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b3093f5-cb97-4d6b-b5f0-472d13213ae8", "AQAAAAEAACcQAAAAEM4df9+NK4YV4ngraX2/LbprogYWfV8hpmC9uuveSpc+3TRpsi8kuTnvUGz2KouX/A==", "ce28574e-bf8a-4af6-a329-285bc48c0389" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42bc5c5d-9ffc-40f8-829e-48342fe3ce7e", "AQAAAAEAACcQAAAAEMXDhn1IDdqnt/uX3fULjeJuG/hTJr8HDv2JL7e7Z1kOrPtGTH4zd184O4JJUAcBrg==", "f27e15e1-9597-4466-88cd-550c00a85647" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ec91e20-a791-45c3-9903-8d04cd2a7425", "AQAAAAEAACcQAAAAECsA7eyI6WyYpmIKIIRLXyvc/TGshmxA+svzjl7fYSiZSAs6nWMmbp0y7oqDpvZt5g==", "8f41cf2f-8683-4389-8742-c0fc01d7b5e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e1988e5-04be-4e4d-84f2-6e19909b9d66", "AQAAAAEAACcQAAAAEJXU1vRFc8tNKWtELXOaqqX32K59S2xW22gZWmyyerH1Qp0BZ1XhF3x6nz6veTVQhA==", "5e86aa7e-0a14-4c83-842b-af7e8e28592a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58a0a4cc-0284-40c4-bf08-1ae5e55fed86", "AQAAAAEAACcQAAAAENomNT2q89zi+Lb+vCfBtk/JhzselakyYGqywXyoo/LhI2mcMiibdOGTGgc5BnKHvw==", "39607435-c355-4756-814f-d26f63923bb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59b04e63-bbac-4fb4-a4b3-4e9faa604469", "AQAAAAEAACcQAAAAEK3XPdGo2hhPE+xzTJd5wrLWFEihI42OzSWFQHGQHRgNhaJIQy+cVswLII3RcC0wHw==", "1308d853-5abc-48e3-97b0-500f092f4f49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43bbfb56-73c1-4405-a0d5-e89a547c043f", "AQAAAAEAACcQAAAAEOkP1IighEphf8rf9kLdvoS2UkhNtDhhcxHvlAhxstSgs1idDsTS2ME+xl9Cfptcow==", "eae08a56-9d67-49ac-8dd8-f61317749b07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4399ad7-4560-4198-89f6-4677779d6755", "AQAAAAEAACcQAAAAENNdW0+1brK0HzbUz+AlunDwGhfWR7+0si9oK+AKLnLEeoA7dU9zrc0rhFU+HNlEdg==", "9a84054f-86e5-4a47-81d6-3d057d199afb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08453d69-7d3c-4f48-a4b2-9db4c464fa2a", "AQAAAAEAACcQAAAAEGKrpHaFKRwN/4pq3A2nC6bLoTQPN77tBIWvJilrZnczBy/JLB9nPeWONB+JdUvqVQ==", "3f245b3d-8107-49af-a65d-dffc37053362" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b50a3d1-6acc-4d20-9c4b-1887afb60df9", "AQAAAAEAACcQAAAAEABOZeZCTfLhtfFhsF91WQNlJmDBPP8N5olT76FnN82c6f6ChrW6ruTzXmY5XD9A/A==", "0ef906bf-4b08-4a66-9eca-e97a9d89b60c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "000f3a26-5cf9-4542-b96a-d8963427ff0c", "AQAAAAEAACcQAAAAEDD7kozOeuC68+W2hyQ3B6qZHbjVG4sFVK6seuwLXHhW5x9+oswlGP5+n6jzqDf5xQ==", "a863814c-4341-43f2-a66a-d306b2bb4a5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "deab5bc1-4d73-4536-a3e0-9cc65cd6554d", "AQAAAAEAACcQAAAAENhsOvbt3MXWkO35xIaXl92grDY4zUoow2pAoUzVmQgRXcX2M1pKK5RU2JkV/uGN5w==", "6b7f398d-33e0-4539-8230-f95ed9e86ae8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4dc187fe-75bc-49ca-8fc0-139d10156a17", "AQAAAAEAACcQAAAAEEsK//PpFv3XrPdSIWYeT7eoon/OBhuE5hQBPgDP5kqUVpXuNJBZMOpSyBZxzSxV6A==", "c4caae95-4439-4477-a5ea-c0ab8c38eda9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5f6a87b-8381-45bc-970d-a4359d304f8c", "AQAAAAEAACcQAAAAEJTpzkxW6zG/AwhPcx9x0lNGnQvYsOqihsy2obdwjd5Pk4A4mwQXBDG9BqdI7V6nbQ==", "21730af9-d195-45b4-91fa-b0654fd7b3cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fe52346-e135-4de3-838f-e0526ab95455", "AQAAAAEAACcQAAAAECnHA9ialZNT7CDVGf2eF4/ijYpVfQ5LeBHnCcLU+v9oyZkQErcw5wbo1usuwJRHeQ==", "c589cd2d-3e68-42dc-bf33-101d988077f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6d98090-9f69-4c14-be84-16477371aa81", "AQAAAAEAACcQAAAAEIkLEIe2+QudjVR+oqdUeH8N0E2Yz/5kNdd/Qe0zxwxvIMQUj/RxysCmmJuzYPQErA==", "30b3658b-fb51-4179-9f75-c33a234cbf66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2021fdf7-9a8a-4a6b-849a-5386befcd7cc", "AQAAAAEAACcQAAAAEDwomkoYXIzXtbGEOYO/cas5VU1iMAcTuzH5FPbb5jC5TbSNmny+/iO/RBvsYiXplA==", "2d0143b5-afeb-456a-87e6-d55205c095fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c4d8c0e-0c82-44d4-9d9c-1e056f1a3418", "AQAAAAEAACcQAAAAEIfFvEpx1BaIt7uSgk9roJHGd1ZRvqAqybP1pGo947jBloPXbScWWC0AZjKLmIkTig==", "833e08d8-f87b-493e-8e97-d06ae76ff67b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad368ac2-02e9-4a33-8bba-a3fc90083837", "AQAAAAEAACcQAAAAELTiYgLqDtYuPwBbPK7VIQO76OZRpaeM1C4bx1BS1i6Avl+Iegmq/l9UzHKCI+aQ9Q==", "c400f2dd-a3bc-4e35-be0d-5a29167bbd6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb61c729-7645-401d-aa6c-657c2ca49e95", "AQAAAAEAACcQAAAAENY4JuLBloSRVEXRB0pU3P2KwR0INyExD590uEgRrqBCxtHEXljn7of6eGOsPvikgw==", "c0cc6f4a-e7d1-4618-91eb-015369ec7269" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a481120e-edf0-441d-b22a-c781238b1792", "AQAAAAEAACcQAAAAEA3sNNeKWGJr9hWyFYtHpbHqsb+Pxo4QutAaziGVGVfWPmwKcSpK3mm6TXymOPSSpA==", "cb8d13dd-ecd1-449b-bc7f-3afcb075e888" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a15db2e6-2c6f-41cc-b58b-0f06cf9a5452", "AQAAAAEAACcQAAAAECJqQHfnKmtkOehpGlJou8Z7vY9kpQjdgikh9y7/EvQ6jfpSLAtvzHCJUNPGc93lzQ==", "9a7ff735-7883-410b-8c26-73043ceadc57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb04ae20-c804-4152-beab-880e82e1ac66", "AQAAAAEAACcQAAAAEMXsHFgKzpSSyQK7tyPpZpubWxAxHsmwhR6VzUfoZXkyPoj+SNb3AAEASnnNhON2hA==", "25519bf0-4c12-418e-8ed7-2c74749cb2db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9005f3de-15ae-4ef7-860c-d3f287cbad7b", "AQAAAAEAACcQAAAAEHWwdPRfoubDodfee2fGG73/CnREexsyFEgtjdQZrNmlE8OiNa99Uz8TLWY98Ht5oA==", "5da43ea0-9094-4e68-8598-e49ec527c6c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ceaa8f8-af19-4732-9fea-388048dce701", "AQAAAAEAACcQAAAAEC0S3/mXO6i53VI8ukkdH0rIyvno9XgwPmD++NSWHDOkBdAx6TVnA8b19lbPn3/kuw==", "4e0ab973-2f0b-42df-8218-d28ced6034eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee75e3a2-bfe2-4c8f-85aa-95b2ee35182c", "AQAAAAEAACcQAAAAEGuzLwk9DKjn027qFfV/4EhVo3S4Uu66jxXprqZESa65fBnYllVi8xLm85I34ldejw==", "c703ec9f-1c08-48a2-8d24-83d77eaea287" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7793dca9-ad57-485f-9bff-86f3aa63384e", "AQAAAAEAACcQAAAAEIYhmWurRRMR9evIuej+NMC3xnK1egQqa53+rlHvEwnX7105q+f1B7VEnscbZhTCUA==", "87cff6d0-062c-41da-8495-0c0ec55c4268" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8955cd52-adf8-48f5-ac40-9b9ad9e91cad", "AQAAAAEAACcQAAAAENpEwwNhY76U1ibLVYGjMEL/iQUz9vZLt5xBLA4aVwPAhZClNhHLxlmAXe+QcVCVYw==", "7b44c394-0cb0-46d6-9ac0-c34be19b6075" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91ec1b1c-315c-4baa-82a6-a201a79b0834", "AQAAAAEAACcQAAAAEO2/SI9a0/ZtIJeb6GVTjhRg0ASO65ZKkdlqGPfvhgpujG4t5BtInd0/rG4eB09tCw==", "849ee0fc-8095-46b9-bd8f-5e30089d3d2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95cf3c84-411f-4246-8168-d9b7b12e8372", "AQAAAAEAACcQAAAAELs+4FfOM7ouYt3DqckyYIU+H/DSZfE2cIaPfyTCD5qXNS8YJLjt6059n3FhCPnWzA==", "85e619ef-c3dc-42c0-ba7f-89c2c269cf1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "556703ff-03ac-4c20-a1c1-c1c318b11455", "AQAAAAEAACcQAAAAEAshPoLE7l+U7092hO7zwJIZJV4P70hsGUr/7x+LpssIvaU4Sg+DXJPSgbWfYtgUDg==", "78eafbfa-e582-4546-95de-6f71613b40f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3ae3f16-72d4-4249-8ee0-55e12e1a9f49", "AQAAAAEAACcQAAAAEApzcATCeGV/OLB/UyvEgGI3+qmA9xhWUsUME3lyVceu9DyquE6DeP4fqOX7FUeeXg==", "0264d4aa-dd6d-4c98-976d-ba4a49b1365f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "946421a5-cd9f-41a3-af8f-3f7b2cafbb01");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "017dc60a-27d7-4fe6-8992-7f94afb59fcc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "9378994e-74dc-4946-9824-d6a18e87def2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "ce83c900-f6a1-4136-b515-3e0f95bd25bc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fd45c11-bc66-405c-b186-d62f58e360fc", "AQAAAAEAACcQAAAAELX70hx0rfuBq9HhwVbXUW3JBhUeF1qswz1T+z98pub4LlApKXOd7fK1f17l1DfGCA==", "6650efb4-3378-4132-b0cf-81e1cbc36d57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7b1b96f-b0a2-4b9c-a460-409b883e1638", "AQAAAAEAACcQAAAAEB6hUsU67L5cYndAis9TiDNQlZujPmPdW8QSuzTkEI8F7r9Pn8MZRJ8I/f5mXNFFSw==", "3a52aecf-b2f3-4a53-baf3-bf0f1d297578" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "598652c0-2625-4abb-98fc-6ebc62e7633b", "AQAAAAEAACcQAAAAEDcp0V7QW7vsO4/U91e30J3UX/gBqQi9N51lqKv9tS4Fd2hhLGAOxXi/ePmcp9oi4A==", "b6c48fe8-3e02-4fad-8d47-068d2789f58b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ce1b528-7104-4c12-8894-1c43fa1eabee", "AQAAAAEAACcQAAAAEGYupXW9U7bvlE1LShukFgLZo6Npe+XBRN3KknQpdSv+wvvlyfDRTM4B3yFnfBjHDQ==", "5f82b314-b8ef-41be-b1fe-7bdde51e17e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "429dbb38-21d3-436a-ba0a-df193197b426", "AQAAAAEAACcQAAAAEK+mvcisf2RoN5u3An9N6WDJGuEaOBTYzkp31dSQFyh68DlMVZZYaiX5LNPYtQyYdw==", "2ea90086-69df-4f17-92ea-e27a33a63b78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6851139a-90a4-4367-8875-d67f4163c1b3", "AQAAAAEAACcQAAAAEJ5pWq5Or+nCmW7d7wuVoq8ZFQNKQaZ/I7wmbQUKZBhpuoTTyjYg7nX+4R91CpGKdg==", "fbbbf87c-741b-45a6-8ea0-9803bf3aa945" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a445c9f1-b7fd-4e97-8dd7-b8299c0b0ffc", "AQAAAAEAACcQAAAAEChbNiu6RoURi4kM/RIYy//Ec4gReFp1OCgPmmaSAtP2m2abaWHNNfyaQl+310HGXA==", "87f2a0c8-4bba-47da-a6a1-fc6005c7e474" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ea21ddd-d498-4fbf-b9c5-e664bb11cca6", "AQAAAAEAACcQAAAAEHSuylB8S9AxXZeCfCERjuyu69FayBTR/mLuBVIjFdKbY1xrWYG7V2mdt9/5ZBtBPg==", "4a9c42c6-72a1-486e-9b67-4f445060a6c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80021f17-91c6-4987-bbbe-5aee81124dcc", "AQAAAAEAACcQAAAAEM3VG6hau6JDRWYv7K3i7/OszAQN9/mWitOCwDxguPSvby3sidSdKC0E+Fl8pVCB5g==", "170618ea-b075-4b23-b767-396ab18fcab5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca6cbea9-143d-40a6-b2e9-55ab6df05819", "AQAAAAEAACcQAAAAEAowVRL497nijfp3DOsJJPiJqcAWWT6pnZSfI0xS2AJFz32Av3bl+uWwvqMWc9/gSA==", "ddc9e5d0-7c0a-4b8e-8e9b-d1761702a89a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3acc15a9-00af-483b-9bce-ddb2bb36d847", "AQAAAAEAACcQAAAAEIsVMqRLz/9rGTaETvZoB8GRC2/Jcem1MNXHdp3Mvbdo/zEdbRe+6qMWyiGxn8r+Yg==", "8d071903-4193-458a-983a-c7cb0aa8ebb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7a3271c-21c0-4315-a4bf-45fcecad9c93", "AQAAAAEAACcQAAAAEGUCziUqOoJXcUKdr0JdygdqOEnk4FPMKmOKu/2qyWS1N4H16rb/nAHqFgShDizglw==", "71fe283e-2b4c-4f1a-b4fc-8db1a96c66a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "826e40f5-6dbb-41ab-8579-93d2f9ccb87c", "AQAAAAEAACcQAAAAEAa1/KY+8kDGatJBL5V8+6JGgr2cqe7Un3iimlwaVf4Gk6fK/vms9yMjZmDoouJQjw==", "adb1f78b-6e64-49b3-a3a6-77b35f02f69e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cdb6523-ae83-45d1-ae51-1215e4de2d88", "AQAAAAEAACcQAAAAEDK2DV4q58MXIEW+3NV+EQVr6pehyfDkI2WXaZE+hMSUbSMgX8BKgWMKKtgzj1VtEg==", "0e5646df-29ff-4d16-a1cc-a72187fb24ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "304f5fb1-1799-4872-a27f-c36a7030d763", "AQAAAAEAACcQAAAAEKjkWWjF/9vVvusKgt+5OJCWiXGwNIe0AfAIk6tcRS87EjLHpuJ4V/KbPExV/JzKgg==", "2505011a-adb5-4d79-a880-2cba1e9f9d9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "513ff1e8-e54e-47da-9788-5198c77588a9", "AQAAAAEAACcQAAAAELNp7ykObISOsW6lRIrIsIpV70+NxPc/51BtT9pnocbLn0UhhBoslveyxNkZhpixAg==", "3edbd9c1-cddd-44b4-a169-da720095f227" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07b3c384-3885-4155-adda-e7b9aacaf44b", "AQAAAAEAACcQAAAAEP34Ok2BjQaQzjopz6NWlyV6euHIlkffb1HklwsF/ljpCpFQg1IL2h3zCBNMfvRVPA==", "2309d002-c816-4901-aef1-28c60dfc0ca2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cbb5136-ce82-4cbf-b821-964505b3a664", "AQAAAAEAACcQAAAAEGUDSZbRTNfoxKkRBkLPgXdTnb4TrP4KaQ+9QDa7JwTAFGjUJ4x1bQiU+TAQuE/adg==", "5c0d3201-a861-4a0a-8a91-a14504c5eb56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "325ce44b-4486-4e47-ad66-3e00cf2506d0", "AQAAAAEAACcQAAAAEAxXA+PsG1TziBfkst1efyxA7890hvneErBxGJZjUybo4uu6e0+yi33+qAxT7xvtMw==", "4dd67780-faaa-43ae-9508-7510771f17b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d98ece1d-b6f8-40d5-898f-9d460f17fef2", "AQAAAAEAACcQAAAAEAsI1BZMgWvlZsiY7qbHCjZCQ3cc36GZy9YBabtz14YG10zf91QHwophDqdBB9ysMg==", "d3ababef-4d29-4fb7-bfc8-686ee920788c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "314562fb-2a4b-4b2f-8dec-0fd535bb2471", "AQAAAAEAACcQAAAAEO8Cy/93rEK6ml32GUK2PcC0WMsIguAH+Tggy86D+xWXM8nHMjwYucpUZ2LqIG8YVw==", "8fa0c3a1-fbf8-4b23-a504-1d21e0aa6b35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61bc883a-b724-492d-8e05-ed815ae400ed", "AQAAAAEAACcQAAAAEJb+WkakgHDVKp2B3noqGwscDbJMkwnH0ogftg21GDATquzxnfrxSyhILJjxPIvYNw==", "56991f2f-a4c0-4695-8b64-6c7fabb79cfd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bf3364e-d8da-4f79-a804-742cefc5c751", "AQAAAAEAACcQAAAAEJn83y7Gfrcpgw1IkzB3hW8PFPotMb+012dry6EPJDmAwNOeQttW0EeMj5UwfBu7ZQ==", "41f9bd3a-7a42-44a5-83e1-ab551a4cbb8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e71e8cb-d274-4907-9485-99addf115708", "AQAAAAEAACcQAAAAEPN+rATbJR9rD2fh6GRaFMkMLO0YYlUnc27VbNsfmyl1jp7pxlj71vJj64xm5XeCNg==", "62e9601a-cef0-467d-b708-d9815b6abfa6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "285ddb13-6a94-4095-93d9-b05ba00b2810", "AQAAAAEAACcQAAAAEF5kRdQFeFCJsi+va297V6lZ7pgXxVXBkhvxhAVvtxhKHv1eTZLZIyAfXvxM5qbIhg==", "3efa8a4b-c1bb-424b-9b5d-0fbf5c7fc7bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d3c7834-9c4f-457e-ba30-9d57a1095f18", "AQAAAAEAACcQAAAAEHOfeSNfKwfB9U2KcbkBZI2euTKTSGEJBKkxOqlc8YKcm9B7dTeazlcycSeGB7clmQ==", "8a3cfb30-1d9e-47a5-8877-b9e194aa50c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "407428c2-8726-4798-abd3-f564c6f82223", "AQAAAAEAACcQAAAAEIjnT5506wSdlHvq1SH0yBw22o5kvr8Wx6XGxraY5hNG+FZIQ8BUwyBKxnPRpNN6ag==", "72be757f-6e0f-41e4-a0ea-502e4014c5b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "373a07b9-e2ea-4d1a-bd45-1f0c446ea374", "AQAAAAEAACcQAAAAEDstspAn/Y/Do47twfs66ltF3+r8rAlzY8mpjKNml+MSA70pgzN0KZ98h0LTkf6LzA==", "e49914b7-7b3f-43f1-ba0f-bc98d1be9abc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "376f5a47-fe50-4b9e-88a3-adc5b29f8c43", "AQAAAAEAACcQAAAAEPZpR5a05y4hJhm6798PqGv6agyNXSoxJoLpJgtz+Wc5Qmc63EsPiUT5uBsbC6QikQ==", "84f64566-fb3a-4708-a52d-ad43c359a223" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc0a18e3-9889-452a-8497-ffc99e4b4f3f", "AQAAAAEAACcQAAAAEK5YuAaKGpJP5zYaCCSaAE5XrhgQLTAQp8hdJ2SNcRghvqo82pnVPzfS81wQJdztKw==", "90f969aa-25c1-4466-9d12-4c13e15638b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdc11017-db55-4717-85ad-b5ecc5c98e43", "AQAAAAEAACcQAAAAEOGJWSs8NHnveLJ9Eltfzi6WVM2hCUeNw2TyqwoaTTGfshFGA68j8xpoBQyO1NMIrg==", "b9478f0b-1b6c-44ca-b489-a21074b8ea7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf41fcd8-8f48-4365-980d-4f16165ae1dd", "AQAAAAEAACcQAAAAEPQoafdTmB7HgN0Hdcngbo/jEjPlUwUr5/Pvbcq4l295d2KSbrZ+jpRByBv2aUQoMw==", "aadb15a9-62ea-4787-a7ff-291d3ef2ede6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0050372a-7973-4c90-9bf2-9b91acbc373e", "AQAAAAEAACcQAAAAEGy5cAwff90rStWrX8PeksdgkIR5rUlyt0UMowaVp3u0FwHx564wRwJQckw+7zFk1Q==", "1859bb34-cb76-4979-8178-ad3fe95a3aa1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57b8c931-df21-4b64-8f08-629cceb7263d", "AQAAAAEAACcQAAAAEKPKuhKn06dCz7dm9OmoJShtbC5kBrQB9y5PcjiXSHTM8ILHFxEwbD2Yz/PjNORySA==", "13114cd4-13e7-4e3e-a7b7-039a250f07aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cf3a4ac-6b5a-4646-adc4-f74eddcb1844", "AQAAAAEAACcQAAAAEFu0Q5kUwzbwXPJEzooByWu5TzFjPaT0eN76HXwdf6ItcGZFx/qzh21RxZAqsxnkqA==", "e52d7793-63d1-4645-96e0-27298bbe6040" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdfc8c37-45f8-40b0-b62a-d8b6630569ec", "AQAAAAEAACcQAAAAEJ2ngbq9tXjsJykQQ6Z/cFoqK/wlACOl1RDvyj9DEcbdy2c4NOmQ1ZUrGLcZwNxTCw==", "a723769f-7442-4848-88f6-6eb916133859" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e1d1b07-2810-4e81-9f3e-78fe08e57249", "AQAAAAEAACcQAAAAEC+vxT9j7uhbmVLlIDqMKBG/rxdWkivMTLOGu/DYUF5vne9eGO29gT8Wq6hMMMbA1w==", "40edc61f-ba12-4884-aeb9-eef071b77878" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1729e8e9-5d31-47c8-bf2e-874b3d41a774", "AQAAAAEAACcQAAAAELmCvAg48MNiITjGlpzZAPPWEF3JuqGK6V4NX6fQSK7KgOdXAUue+K24UQL4ALyDyQ==", "7fce0417-06ef-4823-a894-5a61cdb83bcc" });
        }
    }
}
