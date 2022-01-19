using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class fullConnect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_emojiStatuses_studentStatus",
                table: "students");

            migrationBuilder.DropForeignKey(
                name: "FK_teachers_emojiStatuses_teacherStatus",
                table: "teachers");

            migrationBuilder.AlterColumn<int>(
                name: "teacherStatus",
                table: "teachers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "studentStatus",
                table: "students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2cb100f-6107-49f5-9c69-0b04d06aa2e3", "AQAAAAEAACcQAAAAEAXSoVNSdFM35gzmOiA14gXYnWZN50W3PgnK0TbUq0Sd4y3dSkVcmJpPpQokYM2Smg==", "8fc09329-a6f7-407e-a394-9c28422bfc5c" });

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 1,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 2,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 3,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 4,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 5,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 6,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 7,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 8,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 9,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 10,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 11,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 12,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 13,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 14,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 15,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 16,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 17,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 18,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 19,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 20,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 21,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 22,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 23,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 24,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 25,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 26,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 27,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 28,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 29,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 30,
                column: "studentStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "teachers",
                keyColumn: "teacherId",
                keyValue: 1,
                column: "teacherStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "teachers",
                keyColumn: "teacherId",
                keyValue: 2,
                column: "teacherStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "teachers",
                keyColumn: "teacherId",
                keyValue: 3,
                column: "teacherStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "teachers",
                keyColumn: "teacherId",
                keyValue: 4,
                column: "teacherStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "teachers",
                keyColumn: "teacherId",
                keyValue: 5,
                column: "teacherStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "teachers",
                keyColumn: "teacherId",
                keyValue: 6,
                column: "teacherStatus",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_students_emojiStatuses_studentStatus",
                table: "students",
                column: "studentStatus",
                principalTable: "emojiStatuses",
                principalColumn: "statusId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_teachers_emojiStatuses_teacherStatus",
                table: "teachers",
                column: "teacherStatus",
                principalTable: "emojiStatuses",
                principalColumn: "statusId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_emojiStatuses_studentStatus",
                table: "students");

            migrationBuilder.DropForeignKey(
                name: "FK_teachers_emojiStatuses_teacherStatus",
                table: "teachers");

            migrationBuilder.AlterColumn<int>(
                name: "teacherStatus",
                table: "teachers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "studentStatus",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 1,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 2,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 3,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 4,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 5,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 6,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 7,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 8,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 9,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 10,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 11,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 12,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 13,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 14,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 15,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 16,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 17,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 18,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 19,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 20,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 21,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 22,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 23,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 24,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 25,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 26,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 27,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 28,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 29,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 30,
                column: "studentStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "teachers",
                keyColumn: "teacherId",
                keyValue: 1,
                column: "teacherStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "teachers",
                keyColumn: "teacherId",
                keyValue: 2,
                column: "teacherStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "teachers",
                keyColumn: "teacherId",
                keyValue: 3,
                column: "teacherStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "teachers",
                keyColumn: "teacherId",
                keyValue: 4,
                column: "teacherStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "teachers",
                keyColumn: "teacherId",
                keyValue: 5,
                column: "teacherStatus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "teachers",
                keyColumn: "teacherId",
                keyValue: 6,
                column: "teacherStatus",
                value: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_students_emojiStatuses_studentStatus",
                table: "students",
                column: "studentStatus",
                principalTable: "emojiStatuses",
                principalColumn: "statusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_teachers_emojiStatuses_teacherStatus",
                table: "teachers",
                column: "teacherStatus",
                principalTable: "emojiStatuses",
                principalColumn: "statusId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
