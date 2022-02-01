using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class defIcom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "subjectPicture",
                table: "subjects",
                type: "int",
                nullable: true,
                defaultValue: 8,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "subjectPicture",
                table: "subjects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 8);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "33fc75f4-8ccb-4c27-a840-4b4d18651f2c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "646619a7-2db8-4642-810e-366e14631ea7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "5a7599de-b5dd-45f4-a6db-a5838a81c76c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "81eb8527-df30-43cc-99e9-8c70767abe86");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dfd3c37-6e7e-4614-851d-8af1965fa5dd", "AQAAAAEAACcQAAAAEDo2AuNfF7tuSpsaNwznzfSsZcLNwmRXW4Rba0hwhowvD/r3E5rsMHYT+ILQ53KtqA==", "15550eb2-db73-45cb-b55e-78caf94237c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c382b901-0210-4b01-a535-a2cd4c2ef80e", "AQAAAAEAACcQAAAAECF1SqwYAOZ4VHCwp8FFQVc3qIrBo7aItgmTr14EJdsTkEfbJvVtJM5sxbVAzddzLw==", "a080c420-9e96-44fb-828f-f28b2559c904" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95d2a0a3-cfb1-4596-b66f-0ca796e07d56", "AQAAAAEAACcQAAAAEEL7FGpmus8dHCASfRbmOyTqgE+mSXLS38fbCZcggtR4r2lWT6jCxXouB731Puy9Yg==", "254df10c-5cea-441e-8020-2df5e4d31f9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "953d6773-17a3-4f80-9f73-7903b12323a2", "AQAAAAEAACcQAAAAEPjChxUWameIl5Xoj9WISIgqp0ydk7BhMWRSuTD0x9+jFDiFKzmLVVHxzFQclflHMg==", "7f5ee7c3-05b3-454f-a5b0-b30328edc76f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7978354f-d1e8-4861-9490-8e74646b6d4b", "AQAAAAEAACcQAAAAEPnZLZbYSn53xWlyuYbQ0LuOCAHi4uRoZBzpz2ug6dnpFtctQzvz/eF1RFdmL6/ZQw==", "d9e0be85-3755-4c7f-ae3e-61569120dde0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56c5fe70-5969-47d7-9151-bd7011213377", "AQAAAAEAACcQAAAAELlIF6Bzoql2vyn/CXXhi8+hH/kzqOAFv/v8nxYggbEogCWbI0sogBUD+Na1I6AwXg==", "88eddbdb-90b0-41cb-92a0-d6a9f86f79ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0652418c-aecc-4004-a5dc-7e1cc22fad3f", "AQAAAAEAACcQAAAAECIKQ0du7QuY4aXKo7FuroobCehPRbnvna1gPnUDBArrewXQKcBIOtQ5FIO2UXl/oQ==", "6923e419-e2e6-4305-8234-8fe228993095" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d8d7297-942a-4cb2-991d-2869a979d15d", "AQAAAAEAACcQAAAAEBqRlBn7qaReGwq6IUmxGFEuKp0xyjixhO18sHbJugZH8EA6wWYxA3OFCqHCad4+Ng==", "37ae8a4e-65e1-4e1c-995b-2e785ee174fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91dff2de-3fe6-4e88-89ec-6d205047f937", "AQAAAAEAACcQAAAAEGNxERWMpe5Es2TN4HMORm2YS+4J6tkYJp9WrZdSBFHjZMZcgwMdk2yue3lwXYBbkg==", "6aca1d49-9ec3-4bf7-aaa2-861d0684f648" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98ad7641-c1cb-4d68-bafa-c0c8a2bbda5a", "AQAAAAEAACcQAAAAENAVd7Bqr/f2gM+PabP8aMVCoRc+hmEQByng8UQeIiSFmuRAngzzsWO0ufDv7Kxx4g==", "d3d7310b-844c-435a-b494-045c0f6231dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebbc10d2-b587-4cbf-be2b-44e4de8e9fd9", "AQAAAAEAACcQAAAAEPnswPV67A+jdOGZaL5h/5vjvvsWaDlr2cMIgwfv9wSIH0V288TcPDHwl2Rc+nxOiQ==", "1897185f-fb90-44d5-87d2-eb408ac37ba9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a851bab-1019-427e-92cd-7283b0e85689", "AQAAAAEAACcQAAAAEIyBN+2hR9IGLQDhISUQv+7ruapI3WPxdpyqQKPKGUBWTpblAX4WisdFxyi5LPL5LQ==", "4480f9d1-65f8-4f14-a67c-249bf6ba5260" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bee0034-aef0-42e8-b5be-a1b63c33a170", "AQAAAAEAACcQAAAAECa+uou3sqOXZ1KP9Wa7VZFzhhp8uuWCUBIgq3+6D4rOgt4EpunRzVSZ+iR6ueTAgA==", "abef7cf1-48c8-41aa-94ac-0b89f92bccaf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39be2e55-06c6-4dca-bd87-170c59bf856a", "AQAAAAEAACcQAAAAEIpJBGL3xL4hKkPFmU+f64pnjYkQU5tYREg+0zP/N0s10Ju6wiWOOcXTPDcjja6jUA==", "39fcfbe4-506d-43b1-9ecb-2fc2e3ec6f42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c244caf-937f-456b-b10f-9c9ac4f9bb53", "AQAAAAEAACcQAAAAENO1WRqINfyzWQ6cgNelzTVEtFAMpCxpYCKaIYhgJTCy8tyjvcc90kKr8CmvW4DhBQ==", "d33bb293-588a-4a01-acd0-cc477be1a467" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66c9ff0b-b14c-4dee-9a96-3cd970fc21f5", "AQAAAAEAACcQAAAAEMARX+SANHs4bp8YvkJdNQjp4ckDBqv0w3bDMtCJJ++HaQRYG6tkuIOekJQJBQ/nuw==", "f694be2a-c868-47ed-9769-85cb8199c888" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e20dc424-9868-4590-ba67-24499f62b4be", "AQAAAAEAACcQAAAAEOkOnE8ste30UgaSCK/SYIH7c0AZhzIWMe3E/TagL8I7onUiYXP2D/GB3PSYcn8geQ==", "360a216a-faf7-45f2-8cdf-163701b3fd8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64bde4d7-f2c3-438d-9af5-b2e8047c70fc", "AQAAAAEAACcQAAAAEKy6HAeBp4PXoC1G04qHQX/U/QMCyrCAdxi6FcVy0z8svh+jAYIdVdNEIcEH9niTJw==", "8ffa69c6-7664-449d-904c-ea372f421c47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c0294c0-96dc-44b3-8221-a4b80141907b", "AQAAAAEAACcQAAAAEC3CJ4PWn/vQqHGDO1cA+IEL2xjUum33I+/RVsm7l68wC5gYIHW/W8ot7HPuwP4RHg==", "c3707902-a2a7-40c2-8cec-b649ab8e4c9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fce4f26c-d2a3-45dc-b2c5-bc4d171f0fab", "AQAAAAEAACcQAAAAEFzrDI3JhGX0U/aHUjgPcOt1UmIQGuNB7Aadc4Zh4Byjio4poZ4VIVW6z7545BloTA==", "155895a0-b223-4983-b433-3a2992591274" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c147d07-41f0-4496-bf61-ad17ba083c6f", "AQAAAAEAACcQAAAAEBzWF5VJwzXLnOYm3PERxmmPM+CEamQFuSEoh0Q8gQ09Rgy3SLnnmKgwYApvAK1uUw==", "d8ec5d2c-d024-4a87-9090-39bc4bdaa48c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dadc9d0-e778-4ef8-a49a-650efbb9a402", "AQAAAAEAACcQAAAAEAaI006z/Q+uk3Y4guMAXXFiu4bX8w4Gi7lDITtD+j7pwvAFOEDJqobRjzLeNr5+KQ==", "528419aa-a00c-4ef6-ad8d-5cb23e3b5432" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "070fa6ee-c48d-48d6-8499-aeda8ce35c8a", "AQAAAAEAACcQAAAAEP+LOcxCITFe7GRP64qCMdRkIVavaCZFHrR/bujEeRGS0vC4LRlxvL+9znL+cCp7Qg==", "6cb67c1d-f1ab-4103-b7e7-99c4a8d15f86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0434c79b-a715-476b-84e9-87416ca03f9a", "AQAAAAEAACcQAAAAEPA537EhkYSGKFHkfefuE6IJoY1UphPP7GAiC8yCNiUQy0/Gq2qltxmh7NBZEW7OEw==", "4ee7f87b-6abb-4c5a-95ff-db079febc7c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e68b1b2-3175-4b47-9a64-825ce300481e", "AQAAAAEAACcQAAAAELnx8HNrploiwqK48SUYxah7Na3kZtSSWxGbz1qzh37f+srtLpCVTx29zBPmzgjEnQ==", "c80cfde8-f516-409e-9354-02b2e73c08bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fbb1661-e956-4622-82a0-9162a6384c92", "AQAAAAEAACcQAAAAEMefTr0CRoZk/7df2VmgP0Z9i5Q7U1EeWILwUWcGtf9HsLX6Wv7jAIvec5iHFDdYsQ==", "af946c64-4762-43e0-bd8e-0359cae7b4aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f4dc7ce-dd4e-4a72-b915-424aa448fa25", "AQAAAAEAACcQAAAAEKZKv/fOO1IojakIpKf/Q8oeTg/ChjY3CD91FJpKimi6NZNqkk0hY6ewycdect7qKA==", "67e94bcf-a506-4ac7-9981-1ffbf9113165" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72f1eea4-e00d-40c8-a973-e0f0dc0238b3", "AQAAAAEAACcQAAAAEHdcB3mzx7MQ2jgiU7XpFwVaxmVuJ4j09u1VzA9ccy0gS0f3kjMsnyzP6EWkDNYIbQ==", "c6baff31-dd36-4c72-b41a-e6aa60fbc9cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7cc1f55-911f-46f1-a0e2-df06b56c70c1", "AQAAAAEAACcQAAAAEOfRMsSfCIbm6TJo+/xWUcgAEVIm5H80Zb3ggIQX2vjjJw0tRDNNhsbJel8+C2FbrA==", "82056120-ec5c-4ece-a598-0536abe763c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff9862ce-4fbe-41c4-8ffa-8523a7448174", "AQAAAAEAACcQAAAAEAVAvlvd79dNup07b0mxawgo09ATX1NH2cPdME8MKnY/3GTt+ZJ9KGzGHP80yhrEzQ==", "50c104f2-bed4-4a33-9f6f-e65218353846" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17bcdefc-f489-4d2e-95b5-354c5c13b867", "AQAAAAEAACcQAAAAEOTKtZa+/GkknHBeFB5vLL77PiglGNTKOTR6HTlrjSXSudJ9v2MP1CjsFP8NCJjmlA==", "aa9fa1ac-6375-4142-aeef-cbfd90ce7328" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "516be58a-bc0d-4610-8747-426021a7b776", "AQAAAAEAACcQAAAAEBGro3iN3wsnS0Ls7yXG1DUQANUMlNkLmxlqSGBCdbQWLGl4gFxEId338aoNQs7vPA==", "f282dabe-e9f3-4089-a003-fc20428b8909" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db9d375c-4912-4ad6-8a3e-e02dd5d2f3e4", "AQAAAAEAACcQAAAAEB9cJuQn91y6Xzdy6tEevmmMO3PZaFg0S+f8keUuMflI3SsRzffQULA2MgoeBbSoEQ==", "a2eb393a-ae66-4d6b-8229-e09f7bacf80d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc885d28-b202-4aea-9e28-31f015947687", "AQAAAAEAACcQAAAAEHJZtgauL8JeiwyGY8n5NR67JJUL31Hso9hVwaPyl4sTV/qyzoIC2ZfgDbM7d+JQtw==", "9bf4919f-36cb-4227-81e8-e8586b8cefe4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8404594-dab0-444e-828d-aeccab1b9fdf", "AQAAAAEAACcQAAAAEOSAxLrDjLdmIdX7Mu28tpi2Y1n9SM8vKr5jBPU420qCO/9KQV0p6PdwtapRWfKamw==", "5a90e395-087e-4456-b8bc-0361d327e545" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14c91536-9912-451d-aa9d-761ede8ef35c", "AQAAAAEAACcQAAAAEIZqmIhEfJ8CMAZ0UiI/WFChU0gQ/0zI2B1D164rZOXL+VgoWAY4PQLiyknwMbncLQ==", "f228a8a6-866b-4253-aa83-668fd608c18e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d557b9c5-e858-41ea-8fba-9d8335362055", "AQAAAAEAACcQAAAAELx7DEScHU8Uu7ba+uX4xQ59+j/rpdChIDjeLFhBRefpkBoZL4j7MnavtqpXZQRP6A==", "3957e557-af2e-4991-ad63-a347250cbe84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3a6595a-1527-4d98-b840-9621b4539169", "AQAAAAEAACcQAAAAEHc0N9xGPHTl6qkfvkOf+DC08n7Ay1gUc7d6M7Bed6f1tsbJJoIPKqgBpl0y9o7iZA==", "f5646b9d-d590-4f7a-9e55-86c59a0ab899" });
        }
    }
}
