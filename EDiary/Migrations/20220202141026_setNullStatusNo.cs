using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class setNullStatusNo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "05b44268-073a-44ac-8bc7-e61919bb1abc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "3d678c09-4935-4c42-810b-8c416f87ca45");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "af5d84e3-5b1c-4dc5-9559-01c9e67c4a4d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "e4de8019-dcc7-4c71-8a96-b392956581a1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "618f833c-4cce-4dcb-90b9-aba2caf0fc57", "AQAAAAEAACcQAAAAEHm7S7XgWD+a6bMpvMMxNy0Zl1FgAXSEjoRyViFiyQbUdicYUJYo3RypsjdT7XUMmg==", "d2ea4215-0de7-42da-b625-ddde2509207c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf2fc7da-d53b-42cc-bcd3-ff75768f92d6", "AQAAAAEAACcQAAAAEJeBOIr11Odl00bMoLdNykcTxCWD1XMI9Y+e/r++PA/f0xhFLo/qxprAX5z/uiqthw==", "2b6b9b4d-ec07-4df0-9d14-447279c21a28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b55fc5f-ac61-4c90-9cea-eb89ff754a7d", "AQAAAAEAACcQAAAAEPxVdLIJXjKxibyj02dRygoroODjNU5Yf4G4jE1foy6SHTMCEpk7ezLGd06F033TTw==", "f3a1f660-38fc-4714-a845-2f1825103c00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "786bc4d0-928f-4a9e-9463-f0059e09dd48", "AQAAAAEAACcQAAAAEJ7j9zh5yBk/tW03aBiOMyPX2fpEiqqCmeZZyeXe89+bn1PZ6pwb9RfdMzYynA8hSg==", "ac6ce6ae-4af1-4d63-87bf-2767c13ed398" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bb041db-969b-41d0-8ba6-03e115fd0497", "AQAAAAEAACcQAAAAEEjXZndFoDZ56Q6gRKv0VMgyigdR5+UMxiJn22MFPjoxBcOmcxcMoysGIyBXi738aA==", "cbcebab9-ab2b-4c71-b0f9-5196103d95b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1880a172-b0f7-4eaa-b590-9adf3d75584f", "AQAAAAEAACcQAAAAEG0pFep92pRiwLBPWUe6Iwq1DKWNCdqqR/DpMrf5nhP2/mrCGhdv2SRl496ptGxN6g==", "3f8ba561-14a6-4616-86d9-ed97ee570bd6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "931b61de-919b-4510-bae0-b5c864c132e1", "AQAAAAEAACcQAAAAEFU2mINJw6pZyTDBYn1c8MXK0GNZUtWjudq4lRqyUlnXjgn5J4f6+LaxOmg88nPSUQ==", "18087466-fe80-4568-b65d-c5aab46bec90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b452081-c3ea-4552-9ded-b6ece572e5b9", "AQAAAAEAACcQAAAAEHreCUfk6lkqHp6HVdqyFDDZnyHZLYsWB5Mr6dxRCiesrkcGYNUXs3YvU8TRcRHyBQ==", "078becff-d36e-468e-b25a-7b4a96d0231f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77de28ca-6ed9-457e-839a-5174fda32f92", "AQAAAAEAACcQAAAAELBluS1GwnUjIIe0F68GZFRGIdgDPy55GkuDxmE1yAXunZ486dUNS3tTY0ZagP+ZOQ==", "bcec33cb-c070-4a9e-978e-c955bb9e6175" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2508ed5e-c709-4152-a63e-1edff253f935", "AQAAAAEAACcQAAAAEFaw3+ffQPYgln1pAotETzOVpMTreZvoYod7bUtLv6pKgBRJ6KCRK4iOg3uOff2O4Q==", "3b3cfaf0-3bff-463e-9370-edbba0afc32d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b03519af-1f67-430f-ab88-92a7d52451e3", "AQAAAAEAACcQAAAAEDEyk/lnYizZVdLp6xCOqdaiJwlkwILi5646XOjlHAdn/nH81iC3w0gE3m2KIrEFjw==", "efa8e015-623e-487a-b48a-8957f68107db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "698983b9-5319-4ad8-b3cd-bb6767ca0652", "AQAAAAEAACcQAAAAEJ5Gn1FQgQkZ5247g2p4QdWvkxE188+G+2ogftReheVbZbL0sZuqH5uMm15urOx5Ew==", "a5d5c71e-9ac9-4418-bed3-46227880e925" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc956e51-8831-4f35-b430-8a96f743148c", "AQAAAAEAACcQAAAAEC8Kb4cmknCjAmfLOVX44L1DeCpiwmnbfb82lKCxNUsMrdhwIjR6uE/g61VNz+wzkQ==", "8d84b36f-7010-43cb-b489-36d0d0a9f566" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc3052d5-598f-4cc1-aac5-77638453f3db", "AQAAAAEAACcQAAAAEKAtt/cQ6R/NV4lOFuDY3f1aQrUv1mAYHEcgrvO2Z3mTyNfy+mhGRAK0HE7hWMtmuQ==", "0804efd1-d61b-4172-a0e7-f80b3be1e5ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ca70317-23f3-4e39-9d94-ea30d4dba9a9", "AQAAAAEAACcQAAAAEN8GieuunWhK0WCKFLg9lJj6LppA438aIWVUg4n82bhQAswFarf0sUelNO7mY/Dt5Q==", "92b73998-55e3-4c9e-acd5-7743bbef1953" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fcca2239-96aa-43b3-ab6b-98b01796c48d", "AQAAAAEAACcQAAAAEMNxtLSaL8aOsZCbgDaTJvxt2vpv08akqcCti078LgdyGySG7NuAF1XIVs+jnh6Wxg==", "4226dedd-d3b2-4993-b346-2a8c869352a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69655e9a-6ec5-4627-be50-0d4d48299e09", "AQAAAAEAACcQAAAAEL2+05JZHCNG4rOGoPe3IkyCQLP2d3EIynV6ix2lgE4vfntuVJaFSJS9s9c6utYu9g==", "8819c439-e0b6-4fec-9db7-44040ddef4e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e16d6b85-adb1-4969-b3b5-47af49b73073", "AQAAAAEAACcQAAAAEMUMDbSBeCvn2yT6T29wABJ5qzJxh3HkqIq1Ou2EV7EZOZsgsnwRi4FfYkflx649zw==", "26ba92c0-d27a-4fa0-aced-4c7b148853cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd86e545-5bf5-41d5-b82d-7c4fc7ebae95", "AQAAAAEAACcQAAAAEA0P20vjl5SWGyGn1d0v7iSvGfL0h7UThCZ9KJ34P2sTKlpLdqpW8ELvWXBctrWkSw==", "34b343bf-1487-4b8b-a87d-c97e4b0bb0b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbaca874-050a-4d92-9adc-c4996e22daa6", "AQAAAAEAACcQAAAAEAAztU6Yhpm1SG8RHS4LS585KsoTiVt7GTMq/DO/NO9IyvEXItaQxs6ll4vfN4Yl3g==", "78b6c214-9da1-4fc1-b503-c0f32ec004b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffd760f5-33c7-467a-8e84-a049561afed2", "AQAAAAEAACcQAAAAEJJhKCS7B8pVLLt6STbl5DJOJ8c4MzpbO90Vke3hN9GcF32RWcc6TLnuIdAJn9MzAg==", "5873dbc1-d3b3-480d-9921-40756c9e368d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c1f9549-d287-4cbe-bfa5-e0429fd13386", "AQAAAAEAACcQAAAAEI7+tWiudbRiyG+u1URUXJ/WIl7X4c35EblDPpaD3bG/xDDW9ZjnispvJMP/GmLSOQ==", "bbcf4c65-45ca-4d8b-b97d-76e1da14db4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56511aa9-3ed2-4351-b233-35ef4f323f50", "AQAAAAEAACcQAAAAEHSHHDOj/BkfFqTeLzwBDVpja6Xtn+SqPiB58LKwCIlO0YG2ms6ZbO4vRUx8tn1x7Q==", "7b78952c-0b1a-473d-b4a6-4def666e67a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b40fbd39-2907-45f0-96ee-7d69ad463192", "AQAAAAEAACcQAAAAEKKZs3l6O7ZXFbvYOgWlUeoUuoocq6lW6LveuCH4hTMYaG3OICQ77w0Q5Lyt39ON6w==", "cf92a870-7d7f-4fe7-8d77-0988fc21d9aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85948ca0-373f-4571-91c4-1dccd22ac066", "AQAAAAEAACcQAAAAEBf901SnYa8ijqrOHY/Q2Z9GDdfIvpleeVxBf3FBuzOtU40irM6hUhhl/f7laClTqQ==", "b502eaf0-71c9-42d2-9ab5-ebcb5546a5eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58cbbe49-aa8d-4df0-ba30-261562d11d82", "AQAAAAEAACcQAAAAEAdWfLioh7iiP3kenjPNZjYIJoR7tb91FhQs/oymD5qW51TST1ZGoqjlvfiN3QduHw==", "751b2c92-8cf2-49eb-b994-4480f6979877" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f1c9083-28c8-40d2-86af-7effe0d3373a", "AQAAAAEAACcQAAAAEH0QDmZ2lTTEeyicYnhH0PqgRfRPejCD5mz2hPQdAgoRErhpaNZb3gmJT6VOFTNu1g==", "1055556f-8253-4c50-b3dd-58f4c6e78fbb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "460d1f6b-73d3-45a9-b0d0-bd5824f8b07a", "AQAAAAEAACcQAAAAEJNrtpRVt+Cv/OMJGUPgdDmDfK066qXE3LC1LGFv5mOp6DhNb5nu/r468Az5miFYFA==", "29f731f3-73d3-49b1-8cb6-0c761268174c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff7dc2e0-04c6-4138-ae06-40eb2f91002b", "AQAAAAEAACcQAAAAEHnFrfqenAPWoyl7YpwGGZh8nVF5OLwohRf7sTZxJFr9m9zL53JO+az3CYPnZJT8hw==", "41976fab-7dc3-4616-87d4-0f0c71e469a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f5275cf-cd9d-4ba1-a284-f4db80ba39eb", "AQAAAAEAACcQAAAAEIjuwx7QaB+TvZV3lNkByCIo63fwkZMyyVEpWUuLOHo3RGXyyTLYhYHJxpGcz/nUOg==", "42078c1d-4d06-4714-baa1-43cfa51d700a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62ab8e24-7739-45f7-87d5-6d032b6ef28b", "AQAAAAEAACcQAAAAEA+Ejzm9uy1I/mUg8XI6hPaGxWRrUxoDmvYNP9WtFGT6N+1V2biTqgoUTC+LVUHoRQ==", "5d239e4f-b565-469a-87e2-410839fcb91f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13f9a4ca-f2cd-423d-b349-c759b4b622d7", "AQAAAAEAACcQAAAAEH/xgZ7PWkxZa6I/ECwl6rTXn39MafQyb5XppKhg9TBoDbCalpCESKpL73EvzFKQig==", "ce670c2c-2210-4d1f-8b28-38f66ec43d00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ffa68b0-52e9-4aaf-bcf0-6b670e3302df", "AQAAAAEAACcQAAAAEPJbzB+Q7NMMi0D6lCUB7cGjzROxF/9SvgluITIup9IKNtBJ5f/O1cohqm0y3ysFYw==", "72e9fb53-5abd-4efd-a859-9ca2110c30cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8d3726c-3078-43c1-94f6-2953e800195e", "AQAAAAEAACcQAAAAEAV84O1g61JXhdfXuKKofBAeJ9hBN1lSDVwfsGbb5klChNCeJTqPjxPbcICI/BSU4g==", "7658744d-a43e-47f2-aa96-d67e07439b84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b695bfd-afa8-499f-865b-8ea101ae26b4", "AQAAAAEAACcQAAAAEJ1xBWQ7yqSDE25/lWUv+i9D1Amgk1n1WSQBNAzXRskGWhjeATpc7oBImWkXpo5g1Q==", "6a88d56d-6c95-45d1-9f83-ad98d7febae3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f1bfea2-3e9a-41d6-bcaa-c3eba4135c7a", "AQAAAAEAACcQAAAAECWQULP4UuBCZvORBx7/voaDfNVLBTJa4jVjlcAOjQFKtTNwiUHH9kzHKbvi1eAUSA==", "5d74e897-27fc-49ab-9f53-b7146a8fff11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8de7fd68-076c-4770-9117-02a33aacdac3", "AQAAAAEAACcQAAAAEIVSU/vOcRSKJ6deLYm1H5itmuD+YLWjoVZH3BB3VU6eu6Nn0F1iHU9RwDucrh8lPw==", "0a817ba0-74e4-4553-acb5-2025a7060296" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80ec17fc-e144-40c4-a345-8cee16a41165", "AQAAAAEAACcQAAAAEO1gk5XjZpfVtPgGBXuJKkitTUv6vbNOee5IazzgK02JOU38iom2kU0W59G/t4oJxA==", "2a6b745e-e61a-4b16-87ca-a0ea0a70fc7b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
