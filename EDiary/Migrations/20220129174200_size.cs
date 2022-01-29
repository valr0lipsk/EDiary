using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class size : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "teacherSurname",
                table: "teachers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "teacherName",
                table: "teachers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "teacherLastname",
                table: "teachers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "studentSurname",
                table: "students",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "studentName",
                table: "students",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "studentLastname",
                table: "students",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "teacherSurname",
                table: "teachers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "teacherName",
                table: "teachers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "teacherLastname",
                table: "teachers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "studentSurname",
                table: "students",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "studentName",
                table: "students",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "studentLastname",
                table: "students",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "a803107d-c3f2-4613-8b00-1ff776f8a847");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "18a61623-869a-4929-92c2-0497a73d5341");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "c8805a4b-18dc-4894-aa76-5982a9614623");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "b6e3f8dc-3d69-46ad-95d9-56f0e5bb3999");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a05b9939-a041-4aca-ada7-77d8d5db2d9f", "AQAAAAEAACcQAAAAEJGx/y4hvpCnl3GQJ//u2LpDZHsHriWk3ybiE8ikxpnPqKPvmWU19WMRD+hV6fw0hg==", "051d2dcb-b6d9-4c38-8882-49e75789d2e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d72a77cb-70fc-4edd-80c8-521ecfe201a3", "AQAAAAEAACcQAAAAEH2916s9ur51e3zAL0fYYJ0I3COamVw9ozpqCx482xgqZO5HmfhU2PtwxneyWQjtuQ==", "6cefcc0b-5007-413a-96fd-5721646b4899" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8901d8b-82a6-4bed-9a63-ac8b24d65b6d", "AQAAAAEAACcQAAAAENtkjeJLOJsJj9NSltBCAmOWeina12JWVrNAHI1jxuV4CTeX7bTKSFAP6qhprU3cbg==", "d7de0ddf-02e6-4721-a825-3a876d88e6dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18a718dc-1eb7-40a3-97a2-480280dde7d1", "AQAAAAEAACcQAAAAEL3Q/U7ZZWkfwNyfVrA4OB7iUNmOT7ZEvB3nd94r8IsBEyYVxzEHAgG5MpYwdxVTag==", "2dcc00c0-1a4b-42b2-b1ca-bb54c960c511" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3de4d0ac-fb82-4b41-a253-2ba3a714d22b", "AQAAAAEAACcQAAAAEDN6xfPIhs/YWbPJtsfSk9V7jhQCCMZO4KJsgQ56LxuuZ6m0T0wSF9M0LnbMiUg25g==", "c9ba2b18-d118-4adb-b9f3-2169f7e7cbce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce31266c-6cdc-4ca4-859f-7c1c433638b8", "AQAAAAEAACcQAAAAEMhzGogSPjWs432ugCwm2KDSrtLQbCCuimBhjOTuBQkP3nD/YSlg2qyiIG0dDhxtfw==", "18650875-f14c-4844-8eec-60589df54af2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf1ad985-1f8a-45ad-97dc-e74e5e9396a0", "AQAAAAEAACcQAAAAEMpZWIM/8ruPeUv6dEXI5/ESq4yfOxpGXqJGjOJDo7Kuw6U2zWYnXl6lByfvD0jAKg==", "b6dfd63d-25f5-4d95-83e2-d1b762dd67a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "185245bb-74e9-40f9-80b1-208ae14fe292", "AQAAAAEAACcQAAAAEAGC3+oG4u6j07b6IVZgIMeQyIdqz9GAmoGhKdKwbeNNscXj9cOCK34EyHB6tDs2aA==", "f7f2e39d-deac-4133-a081-cf61fc242930" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbfa5da5-75d8-4727-9d47-8a5f9f1ebbe6", "AQAAAAEAACcQAAAAENwMZa7Jz8bmBxUVdO+E+QvNyVu8Pm1nwDAxo5uSxqaU04ctGaGpDvFMtyt37e7z/g==", "d097467e-afe8-4427-b3d5-d1be8712c5c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb4578d1-a5e6-4314-9c64-fcad59ec3dad", "AQAAAAEAACcQAAAAEF7PrbBA4/Z2V72PZFTzJ2C2S99P7frcXxVPey70e1AyTlFgOykVBDEv9WF5VGyWVg==", "5fbf6bae-d08d-4247-99ca-c57b175178b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab170a63-eb01-4fe8-8ca8-cfe3ff9e59d7", "AQAAAAEAACcQAAAAEMdExXzBDsgOtBPzbEof3fCYiWEyYxVf+PoRZjN1AnprZkcQVzQ4CFuEufvlHC6w5g==", "9b971894-f3de-4af8-ac66-877becae1ec1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbc7c334-0659-4073-a1cb-747c5b22ca94", "AQAAAAEAACcQAAAAEBM7EmxDDwsd/1lo9pZXY1MRqfNxO62MeYnauE7JLVXDdHoTl/Yn5Z1WFv7oqJClWg==", "61db97c7-248d-4e5f-bb5c-551c2b76cefc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48fd670c-edab-4c6f-a790-decbf356e04d", "AQAAAAEAACcQAAAAELOrtpA8dP6In1zgSS4w6iFau+i9DAsO2/ALEfMZw7GgZeXjmFgMDWD4QDG/yANI4A==", "4d82f806-1451-482e-ad18-541876c8087c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d701f007-a93b-45a3-b894-9c578a8f0fd3", "AQAAAAEAACcQAAAAEF0/c//qa3cgrt/hgn5KQL/qc/ca+03iNcWNLt8FMV0vWSDJ4DmFWcMOZg0UGwL+cw==", "6855b696-0d9b-41a2-9e5e-cdc27e82810a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cb5511a-87b1-4d15-a72e-e88b54c31dae", "AQAAAAEAACcQAAAAEBw14OHlO2N9UrH5gW2L11QdwN6HYBU8u2jZCiD8RSpDlk7RgRbjuWS4guZ3uOwMBw==", "39ef2e30-3692-46f9-beec-2220ca1b5825" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fef8328-7575-42fa-98f3-774cb3613745", "AQAAAAEAACcQAAAAEFQO4HoWfE/vwOaWKS/Z333K3TU7cW8Q+Ypce2Sp3iYxHSJ0D5gVqZ3x9v+NdovxlQ==", "21cdecfe-b8e1-4dcb-88e0-17915c4cfc8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "105d6a22-d6b4-494b-8286-259677ab7992", "AQAAAAEAACcQAAAAEGPYq/68yBe1bugIvW+dwqtlgSREXJpH/+jDKH3xTfR+Gdo8P47TxEPTBJGUK1LCdQ==", "92ee05d8-90a8-43eb-90e3-2ce8f7257fd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9cc19b8-9d8e-4140-8f6d-df8be6b0ee00", "AQAAAAEAACcQAAAAELYaE5fEKpFX6TVVBwuxpXgVmo2Ghl5XNt9nZD/hr/nTAKZw4zHLrMPz/aQe37MoWQ==", "ac795487-55e8-497d-930d-7b812413fa0f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81183354-b861-4f62-a0e6-4b9f06e2fbff", "AQAAAAEAACcQAAAAEHX70BY8+IU0wsxi7pS1kyDMoc1JgEIfhJpfnHHoCH2DG4yqZgsne5GgCaHy5CeqYQ==", "e2dbce09-4c88-4adb-8150-e125058d23d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8dc984a8-35ab-4199-950d-c0effdd98ba6", "AQAAAAEAACcQAAAAED8FR7oQ4426LvgO0MYQId/1MNGA7mi0Jt7ciHB+n/nC5ycgwmBl6EDbeNlsmGglUA==", "9579d77d-2785-48af-965f-bcbece0a78fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0839d51d-fa2d-4d18-9dc2-d1e57a703ef0", "AQAAAAEAACcQAAAAEND8aFxRoRsLcGCRN6oVqOGhNv8PoTJVPDv+B82NJG7+fjdZFqSI+4F1OrDrqZyr5g==", "acefc8d4-6de2-4956-bae0-826680e33641" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e5f9088-6868-4d30-aefe-054c9eae25d2", "AQAAAAEAACcQAAAAELIaYY9wtF3Yjx66tCUEaEdIaicpPSMpNP0o6YmenWGlVARhi5F3caBF772SYC5y/w==", "7dfcb171-f360-4e0e-b454-0cc19f9a2b68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3eb802e-f421-4548-b350-78a50d448711", "AQAAAAEAACcQAAAAEGdGjDbhgFzNcarleEFL2Ovn2CKs1ZzWM/pmg6Xl3QkuGL58VEUGqEL8lBgCDFRQcA==", "b37a9091-711c-440a-92f8-3264a107c3e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38914540-a06f-4afe-8311-20dc4d2749fb", "AQAAAAEAACcQAAAAEErCtcsyKiqJn6oVpgjLKHxnAWMpzG/DNNRfcBek1snkGPvjTUpeB6l+yfhEu5l6TQ==", "32680f07-2145-4059-ab9d-1186b6de83a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fac4c7fa-72a9-4617-951c-c60580ff10a7", "AQAAAAEAACcQAAAAEEuV0zrhGjBHX/iKwy0WzYZF/l8iPEzzFKE2bVMByYBzBhQwgc5CLuUEpeJeS5pWLQ==", "f3183fe3-6bad-472c-970e-bd18949e10f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce4db4ef-93f0-4dfe-b8d5-12a4ceda41f4", "AQAAAAEAACcQAAAAEJ7WAzG7YAn9dqWorOlqcB28ox7mJqB62643G+Go0it3rF4cNIylE1stSSeWFufb7g==", "c9ebfd40-2201-4c58-be88-dc4eb8a82ffc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3e31fa7-ca53-454d-90d1-94208fe99a24", "AQAAAAEAACcQAAAAED+UNNepmxMahap/K9GATV3EzCi3dsGLb3/3jbriGdepJ49j0CtTrdpQpVCjQV0h5A==", "ea60e0c9-c3c1-420b-b84c-bfe06080dd22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d4e1cd2-2a0d-42aa-838e-62e5db832d7e", "AQAAAAEAACcQAAAAEA+C/sINM0e6OT50Vn4JFbmh3CilzDpybUnRnSa2xiOWLYTNlpp1FudUFsAqdaN9/w==", "de98f0b5-7544-44d6-a28b-e712e3e72c2d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fa30466-789d-45fb-897e-3a95cf88f6ef", "AQAAAAEAACcQAAAAENZkuYbeJYx/I0U7SzKps+Do7ezgZRTovha3X8gcsFDPWSvvoDEZzUxhr4U6Gk3q8A==", "704a7f15-805d-4d3c-995e-ad677d736509" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1baeeb2d-41ce-49a9-a7fa-c86d111b0656", "AQAAAAEAACcQAAAAECvwDu9LXXn3cTzk1b2JyRbthLcPQinLeuuDhlZWqv8KN/Lzw1ehU/zLBEICJS4IFg==", "443910ee-504e-4174-83fd-b22b644bb2da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3191743f-4a96-4cdb-8588-2a4a9181e77d", "AQAAAAEAACcQAAAAELmGAljLxMdC/TXCkcu3WuN7oRJB7SKLcvMx8DPGRcCeZf0QotsEl45y1Fim1Yu0Kg==", "b71353c2-8a5e-4a6c-8d4c-0f42d9e6efca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e55f399-77d7-4d6c-8720-fbf4f5995ce8", "AQAAAAEAACcQAAAAEAX1z1wkXGWMujfvmBvohCysDlSnn8nxXULbbHhOA/GIdROxAE+nX48EaV/PCv44GA==", "dbe0e07a-0d44-4196-9b2b-82e832842abf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a291b1ba-1c1a-4258-b569-e0a1c38fd698", "AQAAAAEAACcQAAAAELzK69nXZcKtrLglCyWZBU4BBSmViM4tHaIujLB79fYVJxA821vNaF7wCvwavXKk6Q==", "6bc07c92-ed55-48dc-a5ca-a1ffab6f22e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fad5f8c5-4b62-44b7-b4a3-eaffef01c0bf", "AQAAAAEAACcQAAAAEKpCLcurgz9yK46nYh6pfbQvjVMPVtxniE45QLMHgjAFlM+tNrwvFDJUXsrF7cqEEw==", "d47dd405-9bcf-4ace-ac55-ca3bb6c56875" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e90b6c4a-c62d-46e2-bad8-5d4fb58b91c3", "AQAAAAEAACcQAAAAEF2Fxg0/iP+9kvFXd8sWt7uCrxZ99ydPIFlcmrcSuUfOSNayzWKtiQa4xTSTXqLk8Q==", "611720c4-6b1a-421b-b799-3b48feb27eb6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f09d1e2c-9b32-4b36-a924-a9e54a719026", "AQAAAAEAACcQAAAAEHOzshsN6v+woD/ElTi1zc0zCF7dgZOnmYsh+LK0z6VfG0sFqYZlrGiK3y1SPBy42A==", "345c39d1-d1b1-4b2e-b4d3-2787f0f05b2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2ae5b0c-2fa9-407f-92e4-38ec94b107b7", "AQAAAAEAACcQAAAAEABWdXyuBYXeoc/1NMP7ENQH8gaRTeSf7N7UE6zv9Wmyct3J3boloX2eYz8RV9mnpA==", "f08d914e-61c3-414b-b806-8ae03d405485" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5254db47-95bf-4fa0-9675-d10287f1c8cf", "AQAAAAEAACcQAAAAEJYBvKFW0XLSKBfCFLC0Fx1FvlbzfnWmwwIAB84K9y3DGD8kWlwmqXdZBwzHKIuLoA==", "e8630d4f-48e7-47be-ab02-0b8e90a10412" });
        }
    }
}
