using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class addLabaLessons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "labaLessons",
                columns: table => new
                {
                    labaLessonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lessonId = table.Column<int>(type: "int", nullable: false),
                    labId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_labaLessons", x => x.labaLessonId);
                    table.ForeignKey(
                        name: "FK_labaLessons_labs_labId",
                        column: x => x.labId,
                        principalTable: "labs",
                        principalColumn: "labId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_labaLessons_lessons_lessonId",
                        column: x => x.lessonId,
                        principalTable: "lessons",
                        principalColumn: "lessonId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "93c1e50f-dde7-4b88-88da-a47304cf24c7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "ad1939c9-4ee5-4ddd-9d26-652d68b9856f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "d3c9ef5a-34b3-4a05-8d14-5b56a0bc86fd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "cfb2de11-b7d8-4385-8b73-c2ca02b3939e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee14e867-983b-419e-8dd7-5a7941f4c5eb", "AQAAAAEAACcQAAAAEBotrkK/NjD4NMx426YKrAKkYMlw6XoeMefxU8F9w2d+FtQ63/BYr0Lz3wW2Uj0dVA==", "c5930c59-ad8c-4e1d-b01b-a5a48745d9a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b16c847-02b2-4ce6-b062-5cebb665a67e", "AQAAAAEAACcQAAAAEHJaujxQ5mrqiTWBdS8Mix9HFfI5PWx9Ya2GM2lTXRq+stcCb5b7K7P35a/NPMIPNw==", "c9ce6dd9-79de-49cd-988c-919379a3e84c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8698b06-327a-4f3c-8386-be159036aa3a", "AQAAAAEAACcQAAAAEHntcOYhJ+PUYBxuXZ3OCf9URqIIx5EOW0O47zBYmIoBgydy0s5paorj4gRBMJaPjw==", "ab5c8314-16ee-4303-a34f-e8677b0edacd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3c55ffb-3d52-4495-ab59-4c38967e5f7f", "AQAAAAEAACcQAAAAEM9t5UgvVHa7n4EQuiFkB5oNi/kUUsROErX5tK/ZY//aizpEJGqo4lHbGIbSr1J8Vw==", "8da1593e-f431-423f-9ec7-4cfa0148930f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ec8b96a-3232-4e86-9361-3de96d01c404", "AQAAAAEAACcQAAAAELEbgPwCNNMAN8DhbpP17jpk2nsCfofkiG2Mdkw18Q3+J06bbufltS/mEyUvB1h1JA==", "2c88bea6-5014-4f20-bf0b-3d4b9d72017f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be040f6d-8cb1-4979-8125-5592c9a5cba1", "AQAAAAEAACcQAAAAEM7Qj7/38XzgfupuVstxoFiz01upaJ3jpX8Z+skzx50NLT+a7ALLnBzWjLRkpliugg==", "19dc97f9-6496-436d-a59c-755f472f7d6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58c695f4-313a-43d7-ae6f-f8c5c804bf2a", "AQAAAAEAACcQAAAAEEHoxQU5ijUJqFXV4HrqwtU64i7SVB8SlOLkxBlFjZrDpx90oAb93A4lJN8dmbI5Jw==", "a4cec7af-77fc-49fe-a69a-4674ae64acb1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e450b9fd-770d-4ae2-8fee-2891d6d8b700", "AQAAAAEAACcQAAAAEDv8FfCtGTsr9e5GTb3Ox5xZoFpHLrXpvFEqn1m1lbiuvFsoMTQXltlfToCjoAy2IA==", "4de97fe8-f762-4d61-a75e-fe9c443171fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f05bacaf-d69b-4910-afda-ffc28a20db55", "AQAAAAEAACcQAAAAEL1KGSmjQyXU/K5tejFb+YjzjmNE/qEFdNEV2AmySWbxZYuEPYYyl48wW3auXMR1sA==", "c322a80f-c120-4b68-8b5b-7aa512bce45e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97191813-03d8-4182-b332-5cdb43cc7798", "AQAAAAEAACcQAAAAECpAVO8cVgx6JY3RYTw7Z39xp3sn2skk+9DCIF/k3IYa+Qczc03dm7T3Z7ktNAf+AA==", "f69962a2-ed8a-4228-8494-157f9ea0f616" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc483d82-d597-4ff8-b399-6e680da15c0f", "AQAAAAEAACcQAAAAEJvQ3alolQYmdMa9z5YDzAZ4z0H+UQGtcgPlQwTFUlPkRzTg+HMCE8OQpNM6ynnOHA==", "e5c6d5c6-a8e3-4daa-9b66-405931caf35c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a8cd34b-e1b6-48bd-a3c9-d470c6f17503", "AQAAAAEAACcQAAAAEPfKnYhOgKCNf3oo3Mzin6On7DDnLpZEMa6+kX57VDmJi5GM2NWriT3IZCiwsMfytQ==", "d31c33c9-2079-4067-ab95-b71a8d5fe765" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f6161dc-86ca-4815-8a6d-e653d6bfe1db", "AQAAAAEAACcQAAAAEAsm7y4/cgsbrKZO6OMzj/zXBy3y8lDaXWSOvNSxdA/ETufC8RyoU2t8dr7Gf6a4Fw==", "e1ed26df-f51b-4a55-81c2-0c88134b0dfa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e117d60-c044-4894-8062-0fcb2590f98e", "AQAAAAEAACcQAAAAEDkFppTx7CIPW9pprmqGPQRXselC0Hp/9PeeJgoNEUIDghUupIURqTYl+CynQHq5Xw==", "71365174-a2bc-43a7-bd25-576f9db4beba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1cd9d64-06e4-4b5d-94f7-09abc86d7b28", "AQAAAAEAACcQAAAAEGvZfpycMJdpSOkKw4uAdc1wo+9k+Gs2NVd8PzxYntVKGMSD0s+Txb5rVCcbBBv05A==", "153931c5-3c24-4757-97f6-51be96c32664" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28032d7b-5d72-42a3-aad6-70022195477f", "AQAAAAEAACcQAAAAEFhG1JNfFo7BXdkIftpGZZozdM2lRipjEVIH0gVnqsns6gmF1OoENkLiecKHZ/8jMQ==", "ff5b7ecd-3f14-4a0f-9903-460007f7a591" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03758b6f-7a2c-4026-b0db-f15c8be9ab4f", "AQAAAAEAACcQAAAAENI95PFpX1lPInnhd2vz+SsUADsjl+VO++Q/33oNm8aX3n6TMIVuRZ0JjcC2QuA/wA==", "2169609e-f4d7-4388-ae88-5962a6e6c115" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5aeab7d2-6528-4182-91b6-dc3d5b838eda", "AQAAAAEAACcQAAAAEAsCyiikROwSFtKSPUhGfXfeyIi39LDesxEdhJdYfp7w6ZsgfT+ExpUgERRwhuozDQ==", "12feb7e0-3aec-49e4-ac2d-b7b2e0b724b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72fdf86e-a54f-4513-a491-de3b9205a628", "AQAAAAEAACcQAAAAEKfO1CjxOaVJiA3o4x41xP17dowMKAE86F6Tud11Wc94Z+rSTPoO80cial4bxPITVQ==", "b3a66837-adbb-4456-9eae-5a8ec47eff73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2520ff33-75b9-4fb0-ad08-306db4db8a44", "AQAAAAEAACcQAAAAEDj+EDbVhI/otDM0SI4S1q78SrnMLwi5ACPvZfHv/te1axwI/rFJ6c9M3kZn2+yFmg==", "b6401108-4e75-4c0e-986a-42adadfd79bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0eed05d-dadf-437e-aedb-3b52fb397ebb", "AQAAAAEAACcQAAAAEG/Pm6K2kHDy3spCsHqq9xUSdMN9rFJpsTAgOBBDEN9yng6p72BtyuBuyGiSe6W13g==", "31905e5f-26de-4048-a6c6-dc48a6c8f246" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd48434d-ae6f-4f9b-9381-3859a62478b7", "AQAAAAEAACcQAAAAEMu63u/BtEYdZGw2qfIG9dKTnQ0vHVDDs5iffWuaiR94ca3Jrp6JZaq3lgLgt0e3PQ==", "70b40946-8abe-4180-bee2-928997ed6bc5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc013291-9070-4522-80e0-eb33d2520b36", "AQAAAAEAACcQAAAAEKouvEAZMwd5kro/l1CSnbYipOn+Vh0hVIYxpKydfaMJSvcBE7LCaYa4pHSvZicl/Q==", "74558db7-1bed-4273-9999-f0a9f179147c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96c1a1c7-75b5-4e81-89a9-b12c60a03ecd", "AQAAAAEAACcQAAAAENGbFG4OhB3NXpkZRl37jtDA0O4i4P6iSwFMfYr1TJRe2vZmpfTcYGxxdUxCJWvtAw==", "59246432-2881-488c-b780-37dd04280d68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ece32ed2-1c41-415f-8264-c6bab66aa3bc", "AQAAAAEAACcQAAAAEOWzUgNVxXCq94XLzPvFOs2/QZV3Bp4mbtfK7coNhRf6VPdEn1j6txNdRBJlo+QJeg==", "e4c94823-13b3-4337-8975-bda1c1cfb6f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3452403e-d780-482d-a581-044e821fe234", "AQAAAAEAACcQAAAAEO0L8l4IQew2wPJ7eCW800+tb2kEC+sJi0htiHXYHPFu8Y7w5bl6V1BaNJmmycX0OQ==", "a1c7794e-5da0-4386-8ded-728ec9e500b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fc6df54-b0cc-4fdc-8143-d5e394bd1016", "AQAAAAEAACcQAAAAELaEia4e0NcLkrVz/ue7EwBORyqIJ875dsSO3IB2vdNeaHCFvYbY3B3Xhn9DmcT1LQ==", "925c2c70-89cb-45c8-82a8-86d82886c791" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bfc2a4f-c649-4b2d-89bc-f7537a1747b4", "AQAAAAEAACcQAAAAEF9oyBZ5OAcTpo+Toq2hBhMIxiKM/ibiYmeBiUOjVHudHuFy0GENnZ2zb7jvBg82VQ==", "f354e442-3d41-4f0c-bcbf-d988786858c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "062d0799-4b9f-4c63-9a2d-29ccba765c9b", "AQAAAAEAACcQAAAAEBNLk1BPtzjaIIg9r3sLoQVi7MOQ67fUMXRr5/+Bbl6uXuGzUyo45K0dH9TIyzPhyA==", "c618692e-f5f6-4149-a57c-0fb838d041d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac7db78a-f332-4a32-b89b-041b7cb8c4a8", "AQAAAAEAACcQAAAAEHUwUmUuoglli0tIF62wXNpt62CGcaQo+u9pMg7PXI4FMXxfW47HpXrYbRHu45p7cQ==", "e328d097-8093-4fb0-8822-1b76edd3833a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5dc88dbd-1e77-48ec-9440-cdcd689e98cf", "AQAAAAEAACcQAAAAEN3tdIsodbbKVp6QmK54nov6eixiPlvN+yfwLBzdgc87uUxuqFTvwU2+Q3Fiv7VIJQ==", "24c2716d-f75e-4591-88a1-2709892ef105" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "faa8335c-e849-4709-8bd3-063b5b7012ca", "AQAAAAEAACcQAAAAEGAIZWcezXNfHTG7yTr5aD84tTcVmlICh5BMYQxxWnUmbixhKo4NLTKWQc9h5m/cEA==", "60973ddf-ea3f-4931-8864-68b0c3afa950" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "400af7fc-b2fe-4e44-915d-40254d824f60", "AQAAAAEAACcQAAAAEIoHDeNUjcbJY+6Ya3edU26C2jYG1ziqjKpHsLiNGlnkKS2+M8zG9TcMC3zQlsjAPw==", "f08af644-0fc8-44fb-b6b4-63c9bf15fed0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5cfdf41-f6f2-49a0-852a-b35c2eb5da67", "AQAAAAEAACcQAAAAEJCzoKeSboS7W3BxfeZf8Tyoj7CkIC0KFFOU9CKEvE80W7r9MJ4PDYhFqAg250+c6A==", "bfccb71b-30fd-4dba-acd1-bce0497a7541" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e59f553-e91d-429d-8eb8-cb1c1f9dbea1", "AQAAAAEAACcQAAAAEHMav3c7iNxK47Yd0C9/xW+Jah4UqFkNIMseDafEZWsB5Z3UnGJTOKXaj7sAddZ7AQ==", "6296bed1-aaaf-4493-96f8-8eaf28b85075" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97425315-cc52-4ded-a60d-3b181312c527", "AQAAAAEAACcQAAAAEEo/AP9guHfXUM470SWjPjzebasM3KPAp3c1w7T4tTUg9sltaZHLv3dXR6bJvmWLgA==", "2bab2c04-a365-41d4-951d-cc8985b859cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad2da286-f43f-4fed-b466-d2a6a6228c3e", "AQAAAAEAACcQAAAAEOQPzz5PMmVJPVx/+dcyp+v7E/h7b4yfhwgXSjHmtKH/PPWHxoLKwYIhoWKFIAIRuw==", "fefcb4ff-158f-4f3a-aa11-ccbc5ff59844" });

            migrationBuilder.CreateIndex(
                name: "IX_labaLessons_labId",
                table: "labaLessons",
                column: "labId");

            migrationBuilder.CreateIndex(
                name: "IX_labaLessons_lessonId",
                table: "labaLessons",
                column: "lessonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "labaLessons");

            migrationBuilder.CreateTable(
                name: "lessonLabs",
                columns: table => new
                {
                    lessonLabaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    labId = table.Column<int>(type: "int", nullable: false),
                    labsDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lessonLabs", x => x.lessonLabaId);
                    table.ForeignKey(
                        name: "FK_lessonLabs_labs_labId",
                        column: x => x.labId,
                        principalTable: "labs",
                        principalColumn: "labId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "84104525-a4c0-429f-b036-f9a3e4b4e78b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "a4b539f5-399e-4d55-9bfd-76769721d2ce");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "f3d6be97-d1d7-43bf-8668-d244274477df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "6e4ae1d7-a066-40fd-9044-3e43d9d9e193");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ad015a8-068b-438d-a024-77d79d33e9f7", "AQAAAAEAACcQAAAAEMbAlsJKPwOon7nZof++robQh8R4HK3LTYEMvdsABfWWyNBYvCSKds/zVBqHWEmvlw==", "9fc0d4aa-4531-4d18-bbb0-eea633e857a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e155878-bbfb-4e56-8584-251bc41fa9f0", "AQAAAAEAACcQAAAAEH/3qjgiYPQrLjrMhjau84gkv1cO/LnJoDcT/Z3lPp0a+nV95lw6gTTxEbWQ6/HjnA==", "199bc94c-5006-44c3-8e0e-7e1213d9ef8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efeeadab-6f08-4d01-a15f-863f38d03e95", "AQAAAAEAACcQAAAAEItYXq7nFxSN8gd6P0EGJejPUz6TRAhFDTbLjZ9ZyIDzTI6vtuFMRuPqJ3KvbJpd7w==", "e0776a44-9e41-4038-92c8-41638570a249" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cb93429-c463-4ad1-a821-f9ec88700dc4", "AQAAAAEAACcQAAAAEGwKrFFtPg/dLrSLsw6g9I3i37SEDYBLrUafdwHwuJVM8XDY0DT3B00hV4UKdh7NVQ==", "6baf70a9-77f9-47c8-8956-f5989f53bdf7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a13381e-e090-4839-b9ff-68bb5cabe922", "AQAAAAEAACcQAAAAELAVXLWgB2zdQ8U32HL4VmS7dlGBS+lD0kQFNEAne8fn/E3stBj8DvY3wkIyyXZuJw==", "5af98b1f-37fe-4f46-8687-db557c9df92d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "727acec4-8243-4a64-b4ae-f8e78d0d1270", "AQAAAAEAACcQAAAAEFpTJ27GW81Me9RWbnMjE6LI/LEFtAhEkRvm+6VX2b24phzZvrmh9kNH2ErghrOABw==", "b40f0954-f2e3-4fbb-80a8-b233933dc9d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bd04413-b038-40f7-873c-dff3c84d0305", "AQAAAAEAACcQAAAAEBG1EKqY3XoMtj1W76rDbseNqgQ7tFgYATh91P3S6CAVPWyZOwdNVjYjoiVGQc4SNw==", "5b6d78f9-e4d9-4725-b72f-e599b63238a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed308e38-ba79-42cc-99d6-c01fa9c67599", "AQAAAAEAACcQAAAAEHVHkQmprTgpPiSVw/ArfDIS2Io2I8DxIbasDezMbvwRCiXMoVVH8pNfzHvw99/jRA==", "aa4f5100-0129-45ce-a706-892a2b2a6b47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd08f843-812a-4bbf-9b52-362ecb91a20a", "AQAAAAEAACcQAAAAENchyIey2jChAsxpzj3+IiKkAGZvleyzpKN2cBCfZjpKHuSWfiieFznwKnkUrGn/nQ==", "11fef003-e03a-4c91-89f6-2f5f7598b7f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "191da90d-da92-4ad9-a55c-cc2d1a4dd49c", "AQAAAAEAACcQAAAAECOOcFISkQJ6H5JXNt0mWSaLWxKAQ3FobGP3vJvTNpqg1R5cIo1vGy6yIIKgZkDBfg==", "e4580371-fe11-40d4-aefb-76b297e96b6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c65c788d-ca94-4a42-b06f-3587002451c1", "AQAAAAEAACcQAAAAEFoeHMojs82Jr+Zaab7W76nWX8ZZuWvs/ZPps8v2gmybBAe5QuIit7bgnJ2O1XuUcQ==", "ef941017-4c5a-4e33-b4b2-b5daae602778" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f1f683f-5991-48fe-80ae-d3368165ae6e", "AQAAAAEAACcQAAAAEIw3obVtbT4Nwtw5ndW2PtdO5nmvRzWbr+yBwP/NOs77IE8hSWv4kUy6y9cIYUDbqQ==", "0777b168-c802-4f5f-aaa4-1e9a019d616b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c061f755-e2a7-415b-a62e-b97ba772a35e", "AQAAAAEAACcQAAAAEMfyOE91UuuNX6NfjC/yqraXQmjrqsDPSFcQnMmbkZA6DyguuruLN4AIps3zeXs0HQ==", "f014fb06-0923-49b8-9b7a-2deb228c75f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fdc7d62-ff13-4c13-93e3-c8139c078ac6", "AQAAAAEAACcQAAAAEPSMoCGBfV/DRIfamsRjhRc3i31VIjmcgW4VbT+eKx31Gc1UBaJ1tJlNJ4tvMXlFAg==", "4af21c95-97cf-4df5-9e4b-95eafa84eab3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40776f47-c381-4df9-91f4-b6fa8aa70426", "AQAAAAEAACcQAAAAEED1vZxwzK5N6y8M3nL/zG+kKKgmAFSQB1VXeHXly6/8RKCsiC1BrTYTumSCDNupnA==", "57701222-df28-4493-add3-c4af7b7a3041" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "971e53cf-ea18-461f-95c5-e8003d007605", "AQAAAAEAACcQAAAAEFv3E1lxEmwvX1KUEm6GmdoH1COTK3RWEqH7h4hoY4eCGZDp2MaZEQSj78/NqzGadQ==", "70e5f909-e498-40f5-acf6-b434bdd23d16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e46d157a-3681-49da-8652-5f78cf3c532a", "AQAAAAEAACcQAAAAEMzTzN3xRvYwbn0kxEGL4NVIJkuckzZA+Ph1t4kyAQWQUUWn+MbanqGje2q4OnjRKg==", "5975b320-613c-48de-b34b-639669e4a607" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a459d0b2-e011-42e7-9ed8-cb41b847b802", "AQAAAAEAACcQAAAAENPrH4vkFgr4I37036Fn8THsKhIVh9VFmhtLCU5Zt97CTT99gC/R3WPjaZN9lJE92A==", "1df16e86-7e20-48ad-8ab3-a46c8268ecec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb91160d-0e84-4ae2-bf6b-a83cd95b048e", "AQAAAAEAACcQAAAAEANgobXMHf/wEkFHhjZmU+O92pTLUSwRCpp8EvlcMhVpjIet0MGnXmBNGpBnQv5CcQ==", "9db5da6f-e7e9-4031-a5ca-24f1d0a562cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d90d76db-2871-409c-8106-35faf75abd2a", "AQAAAAEAACcQAAAAEIdQnuNKNOWGYfYf7bS4CZSlhRfUaN5qh5VjpGRyXdqk/AhhXNSkEo+TiQZFLqTXJw==", "3b5847c1-693d-4577-b760-6521614e7167" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "520c451f-3fbd-4a04-8ec7-d7ae1ec73416", "AQAAAAEAACcQAAAAEMTCMRVQIwpZ3wpOBLd30IVmX+HB/8pG/x8riWMwwKTBN9jaYq+YHALDFPh94Oxmig==", "707a4490-63c0-4b80-8c74-4bad4d2e7f30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4600d1c5-9027-4f08-a1e4-59a9ba7dcdd4", "AQAAAAEAACcQAAAAEIDByxMAMqAVgRUHkTuNYRwEz8QH8YGiD9rlgzLpdJtSaAW2F/zoAL8Lmmwdbe7b3g==", "5618bbf9-4973-4322-91c0-cf2f30483cad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c873fff-23df-4f7c-8323-f266fa6feb8e", "AQAAAAEAACcQAAAAEOFMKwnLdNpnqthj1Xk7aL36WpLYFB33lUOLD6j/3S5ZhTLQMp7MO+7X8nGvxH6b2A==", "799dbe41-328a-4f52-8a1e-869565779b17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5232d5af-8098-428d-b751-896be5e65760", "AQAAAAEAACcQAAAAEDTQvMbqrqjFqkFFU79d6GhrtzVKxJN7xYfkxlp3QFnpVo8mmWcDFOpBw2dMoKRBWQ==", "3b6a38fb-3f9b-4bf2-970b-d2fdb755eda8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40e26bda-4bea-409d-a336-e41b30b54900", "AQAAAAEAACcQAAAAEKSZmC+fwQ0HOylwnnywpZbjLJe26332qPv0blt7iKEdhUxNhBo5Y3V3C/tHlXzGkA==", "d2a46738-8f6d-467d-b5e5-2b771f1081d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48c3c810-7af2-4406-8b57-5aa5d196d016", "AQAAAAEAACcQAAAAEC2/9ZcgtPXjsnDX8ED+0bfsxT6e3+n5yC/FfV1BoaxyPsnNpcqQ99D1q6oP0vAZLg==", "66bcbe8e-f530-4107-9c18-41c578ef29ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48fa7ab5-f0c2-4620-9849-874cb2d2db1f", "AQAAAAEAACcQAAAAEPxLSG3kU6pCuN/e04PJwtVQLqA0zpGtku5+Y/sGEuZL5JNBM7hZ+dmnfpESJu6wfA==", "3b9af0b9-eea8-4e1e-8737-83e3a1900e0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b41eedc-5c28-422e-a10b-71be65e70d0d", "AQAAAAEAACcQAAAAELe0S2bCIGnZlFkaqBczGCS+RD1/AO4TGQaqMkY5P7G2IYhfABtCQFj28/oe1X211A==", "2d9be3c6-95da-403f-bb6a-4306dc6dc315" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71788b00-2877-4c7f-80aa-d5577900ba05", "AQAAAAEAACcQAAAAENpP1GQGhNWv4v/oJ0R621w4RCF9ImuIvOYK3Al7Zell5DM9C3EqLomdYJVSZqJezA==", "bd894542-4ec7-4234-80b2-f5f855b5f678" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8557782c-a8a8-426c-a110-447d3209a4c8", "AQAAAAEAACcQAAAAEFSytUoAKVQkqtEAyIvzO9XsI1zDQQ/B0cVdhtXfYI1V4kRXYUOfeEBDhC8mMSx+3A==", "307fe9d5-2bd8-4ca1-9f77-503cc10cadf5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9b79eac-ddc1-4601-9244-d690aa87a876", "AQAAAAEAACcQAAAAEJyKZnQFihipcgZo7cG6dizD0CoPHtFw6oSzjG+yYl4iENzcDwIG4pMsPl6pClQZ8g==", "907f84b2-86c8-429d-9f92-ef64c9a376af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61ff9f20-92d5-4e08-aaa7-7fefc71b5a82", "AQAAAAEAACcQAAAAECm6zHKpkjl57v/Zp9oSwJGjF0GDwAgzbp348hvIla/lzNzn1XM93kWSSRrU5xxNwA==", "d579c684-65f5-4a88-ba51-d60e976f3fe7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ea4fc51-7476-4d3b-b519-bdd71012177e", "AQAAAAEAACcQAAAAEMsrteS+UDhFGnWOQe2B1sXmejl7U+P+4gyURksj2BOG0sLtyooaR8XubXZdtLPjXQ==", "be9d3ae5-2f93-47a0-90da-30b984d4f986" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cfeee95-cd29-43bc-b294-ec8da07ea91e", "AQAAAAEAACcQAAAAEFkaP3DppzG0/AWvjnd+UOYzWRi9HIO10paBri0wy/fA2iQgcOTDXvncDr6UK3Q2sA==", "f911135f-a8e7-43f9-9ad3-b9ec22a125d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94c09a3d-943e-44cb-b8e7-8b697b90d972", "AQAAAAEAACcQAAAAEG3quVXYDn6XbO2heGoDqapSZ4IA9gnwhPqkGvG5nb2fy8N1T19HWN+vovL1I/XVcA==", "b4537851-a26f-4b7d-9a73-ff44a197147a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4125a28-a7e6-4462-b4d8-f7e54a313e29", "AQAAAAEAACcQAAAAEHsr8cLk7sdWHsKWaOW/so6QJLXn2r/CORf1ZSsjwt477GS/kNyjT+VaLFG5QHgUUQ==", "c8aa0f76-c15e-4639-9b5b-ec82566802f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "215b75bb-e31b-4deb-9877-822dc0c6c543", "AQAAAAEAACcQAAAAEKEtcfOZ0U24eJm+kozoiBn10CKxQhA/wj74H2IGP/oivFM++MuJz97AwwlUeT0EHw==", "0228ffcc-03fd-4a39-abfb-9c9ae96b2f83" });

            migrationBuilder.CreateIndex(
                name: "IX_lessonLabs_labId",
                table: "lessonLabs",
                column: "labId");
        }
    }
}
