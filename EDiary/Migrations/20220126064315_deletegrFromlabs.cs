using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class deletegrFromlabs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "47153319-0314-4445-8918-313421f976e9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "aa150e70-282c-4cc1-9e26-756fe267bc3c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "7fba2aae-5f7f-4a89-9ec5-4463ec9a3bb9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "55c1bcc1-8b49-49bc-83a8-45605a8eb00a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd607a1b-1128-4051-82ac-2e7b8bf7057a", "AQAAAAEAACcQAAAAEL46vyNN36ZngmdoZfUDgNHA2IvcLUnbI+CrbEX0JJm2XJeo78Cw/pSx6RUzw2ox0Q==", "3cf09e7c-efcc-45d8-9f72-c11e32a17543" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61c9d678-55bf-4b2b-936c-e483bf12dbe0", "AQAAAAEAACcQAAAAEBxEqcrQWNBuaL2OJHYFhiY4/WzFg39Y3xx5J1i6D2XLsXY5skSycW4KnCB7bGb2dw==", "236cb600-a01a-4f76-a842-9b5d189a2605" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1c0d705-7098-407a-a829-ed345c0b6d08", "AQAAAAEAACcQAAAAELgBIVrlZtqCLv7aXsbOnQCnrY7zuQOW8Xn0c0/7dpDGpPc1Em3qraOT/vUtvhFZIg==", "b38e21c1-0e78-43a4-8851-428f5bc766a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cc2de88-1539-4e75-a18f-4bae19cd2447", "AQAAAAEAACcQAAAAEH0sQqs/zG/SadaIY9QFxoNQmZzqjkLckIwV7XqgjeUB3Eo9kbyxpw3LzAF4wPsAmg==", "96b74fa4-a7fc-421f-8d79-e0fb15fbf870" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22f64ce7-cab4-454a-8016-adaff243ebf9", "AQAAAAEAACcQAAAAEJh9tV2sSDD8zgds3/ZaFPhkLS9F/Rbtg7emFHlqZeqrDxiZ2su6BlVCeCNFgcYLvQ==", "dd4038aa-7bd3-4000-a09e-e1ad478fe0c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b4ee0ea-4847-447a-b952-d7ae3b893395", "AQAAAAEAACcQAAAAEDLffXVPpWv3Gg7ay8KGPEvobPtUzFFN9hrcd6xljdwoG87zynbzambBLNBZHIDd3A==", "9668f4f9-7da0-4b84-b00d-6e7840f71c97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df7cb92c-bfb3-4e4a-8e30-2b75a9a9f46c", "AQAAAAEAACcQAAAAEEGaPZjuNBXOjnI+bdn5MA2viNF67hjd32b2RR+cp9STjJaX6lm9n2Pw340bJgmgqQ==", "d0ebece2-daa9-4276-b5d1-0b9fdd3e9de6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aef280c7-4b0a-46e2-a879-c3751783c780", "AQAAAAEAACcQAAAAEHf1oaPzYjXfgBBDP1MpX9z+gNBw/ISBIO9Zydic3zCFEkKDzhTRI9v7ixxzb6DdTg==", "247a2bca-b606-4f7d-a958-f2412fa8533f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "321beddb-f503-44ed-9601-e9a0cb30ab59", "AQAAAAEAACcQAAAAEAIhdRaM0kks072FKsnjCb2FGZTiYnUYIu860y52bbOlcM5E9kEs1G7Yz90yB6M5Vg==", "a5d9c260-53b5-4824-9e94-acb84d61492d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b6f90cf-c628-44e9-bd4a-64b763172dbc", "AQAAAAEAACcQAAAAEExecnCPnOozVwOyeqKRSMo3Yb+i2VzFrVonzplBzDvzTrIvZqb/vRUKpAP3gPbCOA==", "51e167b9-4815-4036-9727-453e9d6fc648" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8dd04777-51dc-45ab-89e5-716b8ba00505", "AQAAAAEAACcQAAAAEDDS3XowUejspdOwKMRBxVvlH9yzXfWpNA/4dVyHqnsFysrOJ77WKwmpxxnolqw6Hg==", "c8903fca-e653-4aed-9ca9-907e87be0936" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fded133-1f8c-4237-8de9-5eb6fad8597e", "AQAAAAEAACcQAAAAELGI/C8oW3qFBbPw6PnAvT3ChLgUJRC/S6e4RPelss6f15kDqFIbIEhVUqYwZb+Cww==", "2bcb43ad-a9c9-4a4b-aa95-c9cfda7ec5f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1821932a-4811-4403-a418-eb96384ff9e8", "AQAAAAEAACcQAAAAEBDYzOBrrfQmkhZwvY9w7kYz6+chb6VsYgHUAu1fz61KvGBBsUMuoK5CxECJAYim+w==", "7c50f056-9b30-4bbe-806a-30312a8c446e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d612ae48-72f6-4028-bd68-07ba61777a1c", "AQAAAAEAACcQAAAAEHQn3XoA8+Znwg7ziTYGoAi8zv2Q+gGI//kNqlDMsMvMYvg3TEawZqPRLiwIqWs5xQ==", "c197f4b8-99e7-466a-a9f1-4199203e3b00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0d2d168-56c6-4ef4-9502-11a3ea0d6472", "AQAAAAEAACcQAAAAEL27q5wGJPeMG11N3lownhqywTcf/s7TzhXtt1uYWqrNitCMRdO0iTYYg5GZl3pN8Q==", "25e73d32-9c13-4b4e-969e-47dfbc04e11a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9081db20-6ea4-473a-8fb5-ccbb801bdf18", "AQAAAAEAACcQAAAAEPQhFwXysi4PZy8gpCrhbd38GhTGVgWlymEP7NgLiA0tnbmkA+C+Mnfyqcsyu3Yrfw==", "19271f0b-d032-42df-9333-b985fc5b3931" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a76bac6e-918a-4ee3-9667-1c1ef887305d", "AQAAAAEAACcQAAAAECyrHYuxKwpmbBDF6auLjl8LjQI0+IVSzBQi6ItpEQ6HJy71wPn4gEa1QT3p3p9NCg==", "4c7f42e3-b2b4-4314-a285-e8d3f300828b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2a7a50d-325b-4bc8-8d45-ba2f5daf49bd", "AQAAAAEAACcQAAAAEBCxZBqzI4j9t1Fe9VH6XHP8A0NZfZbb81qJHO99cqh55ko/G3mR9mvr8tUAaFw8JA==", "a44989c5-7dc3-4502-afd8-543c81d0ea99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0bfa97f-313b-48a6-82d1-72adf4af28f8", "AQAAAAEAACcQAAAAENPJ5yAc7apyo4TQEmywZPZHKheEzRVkRyJshdDxDC7i/mECvmegKnm9CEZv+bOg4Q==", "d19ae507-61be-4e4f-83ea-8f24be98c19d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "422e79c8-4c62-4dc1-b415-5e8a4b4e0c95", "AQAAAAEAACcQAAAAEA9tY8JJpqtG8zzJTQ9nqwmXzZ92B9SqoO2T+AtZBcXOQ7BJtVtnRk/7+Ff7vyp3RQ==", "0b04209d-4610-4e8e-8e39-c3187ed5d358" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bede556-c28d-438d-b636-e9f8bfd7e075", "AQAAAAEAACcQAAAAEJNNJxysGJ93e+FtPKPL+psiBgqRaUyxGRz24QQrUS9Qi6WMl3A/gEH1LmSQ3cuu4w==", "ceff5168-a423-46bd-97c5-7de94df5fe63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92859675-306f-4b7c-b9b1-2af754e454cf", "AQAAAAEAACcQAAAAEE5Z24iyNB9K0pG4JmcrV4vJ7bKCHhmnxWWMjKCWwc4V/juJhJndC7M/w2ZXlWXJyg==", "a2aaa569-c713-41ec-ab22-6d68c0cd6894" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e2c7ae8-e544-4f5f-ac17-f1eed83b2963", "AQAAAAEAACcQAAAAEIJcXky4QVHuipwz0gc/Ax6urFCnoD4tW8V6+/0BUr3AZDkp5YmiVtPoQquiRdd0TQ==", "f5d4914f-8db6-437f-94c5-7400c5c6b331" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49b16feb-7bbb-40ff-85ae-7f37e389ab16", "AQAAAAEAACcQAAAAELbv99mYds3xoaO/A8Bx/nmOoGBk++yT+gvutyWHdqi7ov5HGrd7tZwkjQlGaX8+EA==", "95d74afe-0d49-4465-88d2-619e3ef28010" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9073881c-36e1-48a3-af8e-28c6a2e830b2", "AQAAAAEAACcQAAAAEKNYd04p74d4NOWm4ssdWZ2Wli/GPjH+c+z/pJvUDGnb8vasbt9BgM+UAXkzB6rQzQ==", "22d860fc-a997-4ee0-91de-c0b59773add1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bda0397-fad9-4042-8ee1-24920826bf85", "AQAAAAEAACcQAAAAEDpa1QmhbocLYPffCb+1cArNykt56B/3xfX8e2m6E1KlXGTk336xIFGGh0NrDeLslw==", "22454e10-9d2e-42dc-8fc8-46bf7cce19db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24495630-fc90-4666-86f9-8dba9003ecff", "AQAAAAEAACcQAAAAEAMo4aJRBgANini7+s45JfBm4OQnF6LO3Z25HbeqkgYLn8UfNMOEnfFgm347MnJ8Xg==", "78c3a0ff-2aa9-40b9-8468-03696a82fa40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3b47bb0-93f6-4d8e-bc7f-923ff7a79c5d", "AQAAAAEAACcQAAAAEOpiP4Qr6LKrfVGxLY7VQgr9eXqCHZMO5M1LCp5sKK1/MMjk7zhQE1KV5wjV5wh6DA==", "1c773435-6e8e-428b-a57d-61ecbf7a999c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61d8eb09-439c-4141-8f08-8eddc07ce7a1", "AQAAAAEAACcQAAAAEIHq2Nh83gT+TjPhqXxbdRmtGDBDgOKIRXAx9yEWV3CQ4wqhTXP8os7rSEmjSuyDRQ==", "ae07a42d-e6b4-4da7-bf8c-f27d5f5f5b7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d169cf94-3e41-4d03-b7fd-5d2525dc73c0", "AQAAAAEAACcQAAAAEAc0VFRPVhozBFcsQ8rP1SF/KU0FpmCPhqHPXIJ9ltsnVtt193y9YIPqT9d10w7wig==", "8449082a-0072-427c-b8ca-dc467c83d184" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28bdbf2b-0036-410c-8a8c-b503f55ad455", "AQAAAAEAACcQAAAAEPhYdvJNTZKCcfp6lXlHdCHSVFkROkp0c2c6hBtfJUn2tVpb6aD0bBsgCsSPFwwFmQ==", "719971d7-3053-47ea-9a10-b503c6fc1f56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60947c16-ef59-4ae3-875e-56834727d343", "AQAAAAEAACcQAAAAEAyf6YkFuNegVSEI3BY2FzqsZjSYTTG/tLP4ewmyJB3hjGtEbAWE848+EovAmJOrDQ==", "d1de84e1-9858-4a68-b0f7-0171a3714576" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22949ed8-2b79-4b53-9c0b-e6c4f43735c8", "AQAAAAEAACcQAAAAEHxtCrg8q2ft2eKkxpHQ19fNf6+hpFIK8A+w3q8rpx/x8YoGdsrdlGtyPcgSDx3ASQ==", "0be37f09-6dde-498f-a9c9-0060fe87381f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94f14733-d0ca-415d-b77f-b0a07bb18992", "AQAAAAEAACcQAAAAEBZI0Cq9gU9PhudRYm2vWWqPYU9f5fCTnn3fmpdDfCA5GKca3GeWLCDV0Et2h/KeMg==", "20859c5c-dc73-454e-ab7a-03f74a700b41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b3a23d6-24ce-46c9-a5ad-d3aa46ff3bdc", "AQAAAAEAACcQAAAAELaeOOmZMTQycLyQOxH9FoiDaZ3lDkDEPrXlRSHp+vWs/4LQbDM36vUOqpXEAN1tUw==", "b79b8240-1efb-4e2a-8575-d8dbda16ea96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d67b2a9-77c5-4fcc-92b5-5d615a916d84", "AQAAAAEAACcQAAAAEOoQhJzrweIiSqFQLCPI+7DhNMD2mmWR8M0VFClNwmMb27miYFx3haa5eACP/F1dNA==", "20b4bcd7-3ff6-4051-bf56-8ebbb87e0ef7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b56cdf22-9c34-4483-813b-d1398f223e5e", "AQAAAAEAACcQAAAAEKMXPdJQHHKaDWzd09klbSqtchx2+M0guLJjH7BLonmf/lwgpbKU5Uy5FMQdX/kRxg==", "9029973b-78a0-4bd1-b142-5eefcfe11943" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f36b7e07-1fcd-42c7-b0fc-e620449a3230", "AQAAAAEAACcQAAAAEASn3vjDyquJQhUtBq04ordwwPtFNCBfzZwe07x3q8Iay240r/63SF3bdY3HrWppKw==", "515c0010-68ac-4c84-b39e-5a4c7350bdb4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "groupId",
                table: "labs",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9772a495-1553-4773-b2b0-ac4a782941cb", "AQAAAAEAACcQAAAAEB2L+q7KtfLQqrwjpDXvBIpCJLQ0gLYuo5BW6y2S+JW+GKPVlRW4TWzc+Kf7B9iZtw==", "cae760d6-e16a-4ab8-a9f0-1606c67e71e0" });

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

            migrationBuilder.CreateIndex(
                name: "IX_labs_groupId",
                table: "labs",
                column: "groupId");

            migrationBuilder.AddForeignKey(
                name: "FK_labs_groups_groupId",
                table: "labs",
                column: "groupId",
                principalTable: "groups",
                principalColumn: "groupId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
