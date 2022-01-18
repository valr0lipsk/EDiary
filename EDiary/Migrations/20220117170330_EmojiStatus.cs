using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class EmojiStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "subjectPicture",
                table: "subjects",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "emojiStatuses",
                columns: table => new
                {
                    statusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    emoji = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emojiStatuses", x => x.statusId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "bd65cf3e-9317-4e13-86c5-67d695f0b83c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "01cef9ea-c422-4766-b178-dba496252ba2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "703b1e7c-bd1c-4892-aecd-3c888b85676d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82882bc0-4102-494c-800d-8ac8ae31e1c8", "AQAAAAEAACcQAAAAEFCPU1wMDKJK9DrgC5yk/tiqjgCZ7/XxoXd1v4zKZlufCMuNyWpC3Vzf9mFTf/MWDg==", "9bd5900c-ecec-43ea-8ae7-63ba1b7a51e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6560b64a-037a-425f-b39e-ba2697720db4", "AQAAAAEAACcQAAAAEOYgKJMJfRCMFEDwX79GbTmwgbgKHFoXl5WpJvlzmOKpqVDye6D4Vgdo9l0XW7Z5xA==", "c24d9c96-19e7-4e5d-b3e6-676db29eec87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "259d156f-93e2-4e2f-a515-9fb427d48ac6", "AQAAAAEAACcQAAAAEE/WGYNP5zE4G7HFV/LvV3sHqj+OF/LuxoYVjZzRum0r+M7pD10U9E7nGvJGpsuJOA==", "586caadd-2864-4537-ab27-2f14d109f59b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0c0a7c0-053e-4995-9574-a2e911de0289", "AQAAAAEAACcQAAAAEOhBSsLKbfidnmWRGcRzk0FgyFke1B5T5SK2an6O9dRhHI40pHl5okAaV4kNz0SPqg==", "08cc4b7e-b5ba-49d4-8c2d-787e0aa72f0d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "181f0cb7-fd13-4454-a03d-2933f4671574", "AQAAAAEAACcQAAAAEA4pqGZ+4sYBmvTC2m29OFSB8Qwudq5+JNP/7s48DQgWIBpt+x+zbJH9Jo/bAubCEw==", "999c55a7-4bcb-41e5-88f5-a48c3ed94753" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40852a01-bf1d-4717-b788-15e6a822a16b", "AQAAAAEAACcQAAAAEJRTtz1uSVVL87DfryT6c/8IEEZgQDDiYtWpWilRAARFgGxeWqUUxg+zJmCjMLIkDQ==", "399f57c2-b15e-4cdd-8656-473886588e48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e693f4a-4008-4735-b384-121add77c7c4", "AQAAAAEAACcQAAAAEIoy767L5eA347wU91+6a1u3G/6qexkkplqG8ngPCO29FWig/dTtpXnjMp141FQ9vA==", "ee6067f4-0d2b-4849-986b-4db998398382" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8782bcf9-d963-4d63-bd72-cc2d3dc916e7", "AQAAAAEAACcQAAAAEC79sxZILBwFcoIQsbd+skAfBCmDX1E2HxDi/fBrmLHIF3qwRhZZYUdEoYHcZ/XE4g==", "13820e45-d1d6-4cc9-8f31-9537c55d1806" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70440bc6-8aed-4ddf-8135-433ffe5f3cf9", "AQAAAAEAACcQAAAAEKz5NAjMVfM8DRfDAww/M/EqpaApGVznbaE4++b8WH94eQ+DRRueai7OTix8ZrE9Eg==", "92474714-a102-4096-a3e3-e32169558f04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21a94b8a-d078-4b2f-8f16-8e57621f001a", "AQAAAAEAACcQAAAAEN+pD0UpgoPEawnAVqw7t8ebSt296/Q4rjKF/v5Nwj75gN8slmt6t/+lQu9edXzdJQ==", "0025152a-fd2d-4a1d-875c-1e7b700dcc84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12dfa226-e230-4128-948a-9db0d8989d48", "AQAAAAEAACcQAAAAEKtMF5HfHbzrRiTJSjgVKwCjLavNbcD2ltf7li2nObZEJ2+2C33C5JXpjYMRp4W6cg==", "6b849db9-efc6-43bb-9ec5-727a62ea0917" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38583218-fa70-4047-8adf-69af9f3c594f", "AQAAAAEAACcQAAAAEKBuXPwe4Vhdntr8qouTcdToacTBglnOI6YvouwNCafoG3E6w1KrgAr6IRpN6nHPFw==", "61c402cb-8845-4398-9301-c88584204d8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68c09128-6036-4d0a-9f75-4a5bb5b8a239", "AQAAAAEAACcQAAAAEMkubuqRHnRWutTKmrvjihQIJASR57C9S58U3Fmp8YUCKD0zI9E0YLA/DbmjZhQlYg==", "36db7b9c-37c3-442f-941a-b6339f81c28b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "194e9b48-fdf2-430c-82a9-85b5b0cdc087", "AQAAAAEAACcQAAAAEBocSAf5fx+0zsePr9lSVdDrLXSNBTMWhEI2uFx88+Zs9zD2xIIyKKaTF7tBYKbnig==", "827cc613-d7cf-4d1d-9340-61c675ada821" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97fb06bd-6d0e-45db-b85c-f4d41820329b", "AQAAAAEAACcQAAAAEONTa4L+BQ+Oic79I6ePs8m90qgCVXL1Gk+EZfUWdcAN1xvkIIUgd0ybAo48Cw8gvA==", "40445cb9-dc8d-4895-b459-508cdee00da0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e2f0283-0fd8-4eb9-8fd8-5bcd68d232e5", "AQAAAAEAACcQAAAAENJsygkqDF+rGp4HIYjdLRvupEz1sKADBIgRM62F1per8NdZI20bWurvM+v9Jl1H9w==", "e967d64c-d702-486d-9ac3-f6f3ab775d6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c89766d6-50c5-4f26-880d-4a44efd53ee3", "AQAAAAEAACcQAAAAEGDdH+VxlUXKowvvuj+4NdL7BVxiz64hwPxIF8sZbUBfSNEVtPwS4szh8chULF9nRg==", "df989fca-146c-4454-ae10-18a1497b0f85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35ba62d9-94da-431b-b810-3434d54e4ddc", "AQAAAAEAACcQAAAAEM54nZ8lNPPPac6p8IBNbe9gMutEMj4kaTXjTt36RpjLHATVcIQNDh2XTqHTOBBXVA==", "43f30d61-d831-49be-a37a-1c335a0d6429" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a406a4e4-2411-4d49-899d-a80a55d29bc7", "AQAAAAEAACcQAAAAEBq0GbbTJyMOg/5Se0mYhz5c7SzV9Vlk5lOzS/XL6aplbbMwaqty52xiSeXRvGQOVQ==", "e1eb993e-2ca4-4667-a8ac-0b342db5458a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a67e8f82-81b3-459e-b62d-2c69c50a630e", "AQAAAAEAACcQAAAAEJ01WNROa+lSMTu1aYbRX5aXwCPL4qCbIFS1WLxx+vzMhXDMFZM4M+xNkRHv+g20wQ==", "47c35716-7e3d-472b-90d7-65628b170c05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a258f98-edb3-42f1-8e50-e07042c2f6f8", "AQAAAAEAACcQAAAAECgtgt1ClQIQflO9xYrqruN7MwknzbJcr4XJOw24e5ryuPHevcub4LGVzap1VzGQYg==", "4de89c0d-17ed-41a2-bccd-af1f1cbeb255" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1aa11e66-7f6a-4c85-860c-432149382543", "AQAAAAEAACcQAAAAEH8Vg0nDLjsT9sXN2lbCOR5cBqmAhM0BGTB3Rc3MlYF2PLP3swFff5iN0LpNlLB9OQ==", "9281578a-ba5b-42b0-abcb-af36c3f94fca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e21d1f8-a0fc-43fb-af15-e4beeef71ddd", "AQAAAAEAACcQAAAAEDLh8LyzkAAL50983lvbipFKbHnNDroJwcbLPr8Ul4Qd1Z0Ftg3KaCmYrR9X2SESQg==", "541cb129-ef2d-45d5-aed1-956e808f5294" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f120558-e3a4-4552-9d2b-eaa09b81728a", "AQAAAAEAACcQAAAAEIeVxpdPafuZL/Utu0qTXiliLccTMVbtNiJPXEtSPjV6D2aq7vYoifo6g3dTH9hgnQ==", "86aa45f0-d508-49ae-bf59-55b75b89f33c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "437c8236-7a45-4fa0-98b4-36d4e4ab38ce", "AQAAAAEAACcQAAAAEKe2DQtZmcteeLTIjIrUoZxYparWI/+7rcP4G3g53eYE2W8FYhrHRtcKeN97qGVCkw==", "c6d71556-5321-414f-91dd-f16d6f584a58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16ea5d38-2668-470c-9c0f-926ead0cc9c7", "AQAAAAEAACcQAAAAEJl+TPotB7Rtmkrmxf8Uc0YQxcyLO0kZebql9dDSJ1T08OtNnqqjStprRma0r+Ntdg==", "157496b2-49bc-402f-8a67-de2c4d8a130e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d85f406-0e25-4511-a963-cdf10ddad6d9", "AQAAAAEAACcQAAAAEI8pNVeLJQkO0/ytOF7/kdM5QJUWDLnt622+ueE8Mz046KX62lvz66WT1EvCQLGvew==", "ecd3357d-a1df-4c3a-ad17-5009ae7347f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb2799ab-d300-43a4-9394-61d769594d23", "AQAAAAEAACcQAAAAEK02uHBcikxWrgIzy5MDpzXGYen7KFEFLG9oQhPOdXa7eDE8Se0e7nclOZ3VhvYT2Q==", "f6c649e9-ce2c-4dfa-b67b-4996a180de7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50349add-e6ce-4d29-bd20-bc2763290c3b", "AQAAAAEAACcQAAAAEMN85gxPzer4FrPCKFNebk8y1R5AB4q0S/Sp7pjpPv0Er9KZx1qN2MI7wh7gfU6Izg==", "e0bd3e3f-5a45-4c5d-b58d-c7297e5c1e89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70e87c7a-1548-4fdf-85db-641ea096d1f0", "AQAAAAEAACcQAAAAEJDiKKBdqc3ekIIN+B2eVkE07GAZ2HX88fWEpl0tQliAmYlr38aEdNsWjtg1ok1mWw==", "6915bffd-7d86-4112-b3f1-aecf727fe132" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aab7c5b1-6441-4a95-9550-4b0d019d891f", "AQAAAAEAACcQAAAAEKNwmlT45tcV5qPpwRtXfSpFhH/3IRrdC5LW/TUdrFKSpgOQ/nYBZ/JwUsRI8bpnTA==", "285f22ce-ab25-4ac0-bfcb-f592d37fef4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c536518-dd5c-465b-9c0f-d8c762eac98c", "AQAAAAEAACcQAAAAED8xXRikXHBddB5dY8kv+D3ZcUD8A6YNi1ceBsFXM7hgFrdCgjoVu3tcbrRdajAJlw==", "a19cecf5-79e6-46cc-a3b7-c6394f62f3f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d79fff00-2c2a-403d-b0f7-9582321b4b34", "AQAAAAEAACcQAAAAEKd9Kp/R4EZcOMwNTKYCjV43bUA7cn08WVRrOV9HMeHZuLIfKdSKYhPPDCqqj3U8lQ==", "9f283891-a6a3-4da7-b9f2-8675ff6edfb4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2512f76a-294a-4475-8bad-ea44b4b93bd6", "AQAAAAEAACcQAAAAELAoIMj8/dC1kioeFCrUdPhmkRiq4Odg6yb9yiA87Iztb6WJEGZC6pZ1JA2VQIRQrg==", "2eccfbd4-aa56-4025-8b6d-4f43efa8be53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac7c40e5-3884-4599-8d72-fa64d4d0f09c", "AQAAAAEAACcQAAAAECpHIEmkEIQCXmhXN6nWpf0ZnoU4tgZdpeAq+/reXXxkaQ+ckXwK30cr1ASflHtjUw==", "00ce25f0-6659-4843-b9a7-e3484d50674e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffa5d035-9c0c-4eb7-aa67-509d92a1381b", "AQAAAAEAACcQAAAAEKy96bjz33pvWvRz27wL4L19FC99y9eIaiyFdwAkCAgnx8GTtxgQk7xydu54Qty/Mg==", "d96d109a-8a29-45c0-a4f6-5406b007d05d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca38d6ce-51e4-4851-bbc8-0e56bd864fa3", "AQAAAAEAACcQAAAAEM6Rrd69OpnpY4VS/cg9cNQoF/1aN4wMNYwfjE9CIsURoh99qJbnMX7YjGhX5ksNDQ==", "213dd03f-89d8-412d-afdb-4fe35c67e180" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "emojiStatuses");

            migrationBuilder.DropColumn(
                name: "subjectPicture",
                table: "subjects");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "cc77eb55-7a1f-455f-a09e-d21d36c15839");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "e7a92687-2318-40b3-a1b9-49bab6a24be6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "a0e2e849-908f-4fe4-ba1b-59a51b737ae9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de9089cd-30a6-4168-a892-ae1e2f6bb429", "AQAAAAEAACcQAAAAEAzIyuiirfTh5CWwsP54j7np1wscrtWZEpLtNT/tLK2eOLGx9v9JMhxCuPDdxs96oA==", "3bab945e-aa41-4897-a7cc-467357b0429b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9a742e5-e672-40d0-90e1-9d6dee5c5251", "AQAAAAEAACcQAAAAEBUkC2d5OebZLtWWrbhgkODOkwN4bSlhiN2zXgL3/+mymm5njVro0NtBJvF8/8Yoow==", "f77c85cb-f5eb-440c-99af-51b312a57e7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69bfff23-ce06-4252-983a-8ce967a82eb7", "AQAAAAEAACcQAAAAEAfkTW9XpGjZqKrJwRYA7nIoiR+eYQnkE9rqEmCItPXmCTDz7D4OnPdgA/600H28Kw==", "acd68dcb-d810-4c6d-ab94-1032e3c77ce0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "025e72db-d360-48f3-83e8-ae9c21ce384d", "AQAAAAEAACcQAAAAEPyoRxZG57eDkHeTzvTZ2XT+C+M5S6YBf+hFa9TbU7TxNiLbkDua9ebXdJD7O9UmXw==", "9a72285f-07f2-4dd8-9437-70465881c239" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f18d402e-94ba-418d-b626-df13532cb615", "AQAAAAEAACcQAAAAEFiNOezKiEVhvwASlOafLiVbq51VcPfo3osl2DbROGUihB5AXn7gIt/wYbDqGRWEPQ==", "2852aeec-6ac9-4dd1-bd25-215e8904f004" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bf7d944-aa2b-43bd-b9eb-74e53974a937", "AQAAAAEAACcQAAAAEHcQm7fzZ+wuWhYKgLPljTyHDj8V/Kg3wM5E/OdbTRyGxwqW60EQrQbe+B4zrihsHw==", "0edb448a-fe54-4e9d-ab5f-203f1b0e04a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fee26eb4-bd2b-4d34-8699-d02ad1212336", "AQAAAAEAACcQAAAAEOQBNvqO8+59qcoay/W2Jtfg8k8HQfyF90qBCDgVjqJU5YlVq0udLOm7XaGXov6TsQ==", "6ff06005-b810-4732-9c6b-1bfa5db2fe27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5f979a1-728a-420b-9a2c-e6dbbd7b730c", "AQAAAAEAACcQAAAAEOXnbj2Hcj9u4AU3urXmw07tH3yRXU1EQg1QGziFFVbPAAyjte+X4hZO2cmswOha5g==", "0302fb97-fc31-4306-abdc-fb1f44bebc38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7f341dc-8afb-40aa-8dc4-8f3ab759df78", "AQAAAAEAACcQAAAAEKcIWiXcrUd77VMlrMcobMeQlCHOy6u9VAnnqOZqxYXawns/hB5M24zOZfF2hDfjGg==", "edc460e4-f91e-4775-b76c-129509d58091" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bb6d039-03aa-4830-b9ef-dee0fb97c62f", "AQAAAAEAACcQAAAAEIjzAb1sxzvSkXRUdYUVsBNcmdg9m4M0OpX0GXZxkaNJbhn1boe+bDk07vlCtEmY1A==", "140d497f-167e-4a0d-8344-c11138ddef6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a3eb042-16bf-421d-b881-8d420268f1a0", "AQAAAAEAACcQAAAAENT5fMROkLt53iPALvbIl4pvxGXtcSt4rvxgkCBBEa6LvjoipK/Nn3qf5EuVX1DFCw==", "f72df55c-3736-444d-a57b-2efeb1fd1405" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66ab3ce0-098e-4bfc-b165-dacd4878b4d6", "AQAAAAEAACcQAAAAEGhPMGN3xNnsmPIBS4bvT3TA9j0xU0kcQl2vnv0FU078d3Y8bwFLdLjuHvXVphSk+w==", "90fdcc86-0401-4c8b-a85e-efae85143bf2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "122c3b1d-2ff5-4c68-b626-a7e7a85e0954", "AQAAAAEAACcQAAAAELexlvVKfy6/gt7Fm7vJmdiwRO6evrsze0QhYol/8LThTU0ytJ6SvSPq89diT0J2KA==", "65c821d6-c55f-444b-b464-578aaaf8529a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae2abf37-9213-4dcd-bbfc-3a2735e82349", "AQAAAAEAACcQAAAAECBVtKB/qWqdTbAMqT/RtRBkpXqa0LVaI00+o+O9gTuOfVKKQNuqK+R3ZBC0Xn7SkQ==", "387e8740-f0dc-422d-95e5-506d89a380f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2827f95-fa43-4e0d-a8dd-ce5a990f7fe6", "AQAAAAEAACcQAAAAEE5EsRmDztg/zhoww9aK8cw+YDJJBUYlAhwbPv6Vj5XnZHE3bg1Bis622HvSFgyHfw==", "0a8e96dc-0691-4d71-96bb-4909cde4d9ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f023f653-4b5b-4e7f-b180-c9e9c383b481", "AQAAAAEAACcQAAAAEHDObSlGhwo9bZqwVqqh3eqNnkYGfu3i2V4Mml1oY2HLeaijhJ8Wz3RrFzMXQoozLA==", "d0153c32-627b-43f3-9c83-b929f2d4e6c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "608be831-b8fa-4151-b69f-a0de3f57724c", "AQAAAAEAACcQAAAAEEvOCu9MNHltwvrMNfMKFR0uO9WwG/6TnxJA+y1DAJCN9bWxwmMv5i359nU5avf6ZQ==", "d5fdfbab-d6f2-4c57-afc9-a0add62ae53f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1c621bc-2609-4cee-9bc5-a55ca4b774e4", "AQAAAAEAACcQAAAAEPvCXMkt9MfLykXAfMEigTRlOHEZIjVfjk09X//Tj9EWmxEcS4flUlbN+sqIS7INkQ==", "b44bafb3-93db-4cad-b94b-f02e3f600c57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c35a1e8-21fa-4bd9-a48c-ac275033dcac", "AQAAAAEAACcQAAAAEEjt73C0r9jUzYOqPxUTp++bjlGro6EwlAVDuXLNzD8hdsEYkKpDolH8BZXI1Ko8xA==", "a99f855a-b7d1-4706-a4ae-e8ba90b74f97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c87a902-1884-45f1-9cca-587e667a2abd", "AQAAAAEAACcQAAAAEBQjalhRXVuXJErz208lDzDCTCIQ9mniZYttyMBcNdwMyP0HLTPRzxfUwN6TwxceYA==", "aed8373a-9558-44f0-be52-7b3b27caa74d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01fcd3e4-31a4-458e-a72a-46365e8c411e", "AQAAAAEAACcQAAAAEPYSxe2cJXE7YR9ELGfTAqfbFawbVZmWs68Y9wigLDGjzypV595ywqUY9wck2cDGzA==", "06102d89-5a46-45e8-a7cb-5dffaca2f742" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f1557f9-829b-433c-a317-38a79c57afee", "AQAAAAEAACcQAAAAEPH48gbP2bej13uWqF0wS2iiaek4VZ8tdspg2pFLCbjt/7eLjEyYH+WPSWEBAnWtQw==", "e1415148-7bb9-4d50-8ab8-5060310bb60a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4673af13-b966-45c5-8e82-f98ebe2de8fe", "AQAAAAEAACcQAAAAEP6QLk/t4l4zbHZkZTpmwxpWDNeBd5353qlgszQbgiTqIewW5s17YKJ1RVylFwwrJg==", "fad1e364-1ea1-44ba-8ab0-0a2ca0142993" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "873b1450-e71f-4ba7-a4a8-0075b2443b86", "AQAAAAEAACcQAAAAEJHbuZnQGuIqccgoWMnIIEQH9WHCTAPYuZ77k/DUMP0W1cGmpmXwdp9Gh6kTn9fryA==", "86156020-42b8-4b03-a2fe-4b7f03c45e11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f352702-86f0-482c-8b43-1cc1d1011cb7", "AQAAAAEAACcQAAAAEKqiqQfBys2MLuaLmDk9c97wj645HaUxwUQV351HdnHsu4PaoBruXH3WaxuBsY48hg==", "0bd4d5f3-23ef-454f-8283-e8b07d4560f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2c1944b-04f0-49bb-876a-64268964d272", "AQAAAAEAACcQAAAAEOTnMj63Hm9AKnx7snNp/0Z3tLUZYtHjVhaOvV/gZZlUycoP+5WZj4H3CL43WKB8dw==", "447c4a33-4276-4411-8e6f-1793be755676" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4586bbf2-093f-4461-90cd-c61721400beb", "AQAAAAEAACcQAAAAEL/wcguYceAij2DqJ/SDgHRRkH9QeugkSPXlHm1ONQgQxiBOOBJS95HMZk8OpJoTEw==", "0285b88c-55b7-4ee2-b6fc-cab526620d4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43a4bf31-d992-4dcf-bdd3-f804ff0cccbe", "AQAAAAEAACcQAAAAEAO+gubosFMtrfEIrZI5WC+t0jjHMQp++7L7VBX9Egieo8qqPqZnFrF+UORrtDoYLA==", "776e31e5-93b5-4715-a293-b695a380f3e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13057708-9389-4374-88fc-8d1febe1112b", "AQAAAAEAACcQAAAAEJY1HSVXpVCEQxE6svS6DKUcjAWACPAGRPXVnMkf3y2Dmp7yj7GW/Puzr/g3+PHqdA==", "e27e1a6d-0961-41a5-b0b7-ffd4061ba0c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af3b4411-1f32-43d1-8f07-27c538687158", "AQAAAAEAACcQAAAAEEy070n5Qvg2dMxUSOdA4859I7/wRD0C495sJl+KlK5uY+JwTGcYVVjBpOwcQWD/Rg==", "2e72ffaf-5bc8-48e9-b09e-7f89cf44e8b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6b4a902-fdb8-49cb-a998-3ddb95d87f00", "AQAAAAEAACcQAAAAENn833Fd2M0ZBaO9vtdq6XR+px46UW0HPMQHchx9egdw83HVQ1L2hbk3jxVuM08wTA==", "87bc3ec3-f0f3-4456-a5d7-8a61ce8de3be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3ac8eb7-9064-49ee-8ca8-e21ef005b485", "AQAAAAEAACcQAAAAELUCfa0y939Y7Mw23e7wjGpnNY9jFEuTksefm3i6bDQD8QVF1B+TvVlOKQrAidZk1Q==", "1327a97c-364d-481e-be5f-677477fb8277" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83300ce4-cae1-471d-a714-feb37068b7b8", "AQAAAAEAACcQAAAAEJzpsmCllqw+FkF8wgTeA9mavag9NOKdRdRX5XOjzqhKp8KKmQfhsqxOp3OT01D+mg==", "3a88e637-159c-4b1d-ae3d-cf5a4b9a3d35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a20dfd74-2035-4674-bab7-82e86cb854cd", "AQAAAAEAACcQAAAAELWU1miSxhElUfATjqaOy5A9/tqrDd0X6GZnpdbRgnADdVIDt0Q937uWIOFOl2FR4Q==", "ac9a3c19-6ba9-4cc0-9076-e7e7fb62d6ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f42c6b8-0070-4696-9351-458493c4bf03", "AQAAAAEAACcQAAAAEFfV841bNwhhkEny2xWjLvdOdEZmVhAgCnlNDa3OHZNUb4SLaQgsOAYJHju9Yoa7MQ==", "557922ce-2040-4e39-9678-d7c08ec18dfd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89c439f4-da2a-4103-9350-214dfa1717b3", "AQAAAAEAACcQAAAAEE8w8SkZAz85PZ3Tvc81cZkR+MxQORouqRPk1A8kEAWolMXz1HyQEm0Sw7hi3dJXuA==", "a219ad4e-2cd5-42af-9b1d-841e896dc7d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6ebe06c-8cd2-4ba5-ac70-c2b0ebb0b7b5", "AQAAAAEAACcQAAAAEKc+HCP6+MQpJ6UvrNMhCRDogLm8DR8oG20ZMxCXpKWSjiPibXmXGQizBDKZ/H4VVw==", "540b8eb7-3bdf-47ec-93c3-02c266315ca2" });
        }
    }
}
