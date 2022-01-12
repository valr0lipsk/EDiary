using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class newRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_AspNetRoles_studentRole",
                table: "students");

            migrationBuilder.DropForeignKey(
                name: "FK_teachers_AspNetRoles_teacherRole",
                table: "teachers");

            migrationBuilder.DropIndex(
                name: "IX_teachers_teacherRole",
                table: "teachers");

            migrationBuilder.DropIndex(
                name: "IX_students_studentRole",
                table: "students");

            migrationBuilder.DropColumn(
                name: "teacherRole",
                table: "teachers");

            migrationBuilder.DropColumn(
                name: "studentRole",
                table: "students");

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

            migrationBuilder.CreateIndex(
                name: "IX_lessons_lessonTypeId",
                table: "lessons",
                column: "lessonTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_lessons_lessonType_lessonTypeId",
                table: "lessons",
                column: "lessonTypeId",
                principalTable: "lessonType",
                principalColumn: "lessonTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_lessons_lessonType_lessonTypeId",
                table: "lessons");

            migrationBuilder.DropTable(
                name: "lessonType");

            migrationBuilder.DropIndex(
                name: "IX_lessons_lessonTypeId",
                table: "lessons");

            migrationBuilder.DropColumn(
                name: "lessonTypeId",
                table: "lessons");

            migrationBuilder.AddColumn<string>(
                name: "teacherRole",
                table: "teachers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "studentRole",
                table: "students",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "7d414aa5-dac9-4289-a97c-d75fa349c6a1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "9688b048-a770-428d-8ded-8fe3832c6bd4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "6a339c76-eb44-4075-992f-589bf019d192");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c67e3ef8-0221-4014-bbed-dc7c2b7ab0be", "AQAAAAEAACcQAAAAEKxshtzEr289ADehRAwHIkxPauK8xiW8oJAIO/Mb/q8Gs5Fo17Tdmq92yVoGeRpzxw==", "0c2d5eb7-f8fc-46ef-9d4b-3000935dc0fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7cf4fac-7e9f-4941-8cc2-821e5af4b8f0", "AQAAAAEAACcQAAAAEIEonkLvk2jzH+FxOBZgCoNuG5+OIUohbbhoPAtz5ZWlk3nwJlCVkZwruayhAsXk9Q==", "c85b1428-6368-4fab-9e91-85fac4516970" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5648858f-152b-4f58-93fd-0b264badd054", "AQAAAAEAACcQAAAAEDtpKsoT27lNe3iwAU6v8M9lhJmQnyQrnu5KK84bdg8igi5YmOzZHOeEQXanRuofqQ==", "81290a24-0120-4460-ae24-c9cba9cc28ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1d54701-f391-49f2-a1cc-cdfcce3a7e4f", "AQAAAAEAACcQAAAAEFX3PpaPaboQm0R5/GjQx9EuNslQHG9XgAR7zguUBK17T+ObO+57loWUC8Yiy6jLdw==", "81cb020f-2822-48b4-baf0-494a1f9be741" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed35400a-19eb-4eac-bf9d-d0db2c106fef", "AQAAAAEAACcQAAAAEJUOJ7pF4Myl6j5paxU1bn9CiJR0nIhTutUy9sNkZ/VBN7sfNAQzBdmXLFHpJWpqrg==", "4883175e-1a62-4af3-af85-add31254f9ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a22c93d3-990c-4601-a8f7-839fe3d400ed", "AQAAAAEAACcQAAAAEE7U6vbyDFv5ls8vqn/N2pk1L30/XG+WLjbJMB15uLXhgtjwc5odCpdWDhyahz/dTA==", "562706ee-5680-473d-8da2-db9b8e5afdd9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd1d55cd-8618-4c66-b8d0-d5ca2f72ea07", "AQAAAAEAACcQAAAAEHbYy2S//an0ZoWTzI6D5hCm2+s9s8A9DGMbOauPH3z01jzVoxL0KVMmywAmN6WCQQ==", "4eba1e38-0f77-40d0-96b3-b4d40c259376" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b28f18e0-3cb5-4c81-9d5f-bb94441c4cce", "AQAAAAEAACcQAAAAEMEr7lUUL7ob2lUTzqnGSXH+7PFkbH93A90zlwE9IYFxT5ivChw5zTelNODLyOo49g==", "1a4e3bef-250d-4919-941e-35f922b474bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b10f8031-02d2-41b3-9727-b68225a1b495", "AQAAAAEAACcQAAAAEPrcO3W0RXrUlUkO8bUGvdx3e/h4VWDZD3Y6678uXIIWBW0KNEL8EcfWCFbXADhW8g==", "7bd9146c-9ec3-4396-bcf7-b0eaf01c3ba3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a696f8bf-fde6-42d5-83ab-5b647dafb6a7", "AQAAAAEAACcQAAAAEG1mx/leuWoH1Bcog6trYP+ioZvw0UNxm4tAHdo0YCbhOXfYNlU6pSGJIq7kIF0big==", "80e7320e-b6d5-45ad-8702-ddaa9c1210e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75be18eb-e605-4719-953f-a17e9753f78f", "AQAAAAEAACcQAAAAELw7DB5H/CBJHg15KSSCZpej76L4Y7UijrhAk8UmCWX63ClnB8baWKpsLoW6UZRLOg==", "97ae4a9e-17c3-4f1d-b72c-21840e63957a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19a8c810-08c8-4a0a-99f5-2ef5e997280a", "AQAAAAEAACcQAAAAEL85+csghmXReWHQ4Xj/MsqIyFWofDhB1QdlZxBYmhernOIlQkrO4oJi6hG0FZtkQA==", "59f877c2-d813-436d-9104-046766c4115a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7ef2cbe-500f-43fc-a855-0694c710fa5f", "AQAAAAEAACcQAAAAEG3BybzoPCiwPl8Tf6+B2Klnzlr26qpyDuMsxHa+Ss6QR4WxXDjbTe69H2pUJWR9mQ==", "70708257-b4b9-4a68-af00-cd0d3656b38b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01acf754-dc01-4a5d-a32f-88b093c7b740", "AQAAAAEAACcQAAAAEA+BUNujKF7qXiXOgbEmFrcEwMbSnpawbwoPOzq8DOP4o9+iWCD6asGa/6NDZLGYHQ==", "831b67ae-f1c3-4739-a21a-aec1fdaa9c79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8740971f-b96d-4e23-af4d-dcefd0656b5a", "AQAAAAEAACcQAAAAEJL26eY19hFnmYL0JpxKYw/Evn01UfOEfLq2+pV00YYiwncqEFKUWe1uYFlHyZPn1Q==", "d744b728-c008-4fc7-b75f-373c83df4689" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36a71c1c-7824-4281-80e4-4ef122847ca9", "AQAAAAEAACcQAAAAEFDgPOrwOUUIVQtT8isPHdUaUK15wysRfUP34P3b7FST7os3gmCPURkGX+6eioc8RA==", "c9dccd57-f269-4fba-94f0-0784d079815d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6bcf4ee-00aa-4dac-a05c-1fecbf0a4f1a", "AQAAAAEAACcQAAAAEIkIyEVAUTqYJ0/wh4JNQtjd+eAP7pyNyTw4h5NnsNGhk1vc7CYbBeW82dfsp1tLjw==", "19ad13fa-b0a3-4e82-a192-1ac7ae5fc466" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07470af9-7290-4ebf-9880-6866c31862a4", "AQAAAAEAACcQAAAAEAlcdNL5l29da2PCABe+yijC51uAeWB4cmZCkzocv2N30xJZeZ0TYDHZ/mXFqUu13Q==", "f12dcd5d-e91a-4ddc-b02a-477755850616" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "280e5abb-5a2d-46db-a58b-af2b081cab3e", "AQAAAAEAACcQAAAAEJOTiHSB+sp2YgNL+CHxz/RSZo9a0chsxaBpB/GLD/T+ZIxq5u2DEhRKEoVGkLv+VA==", "1020b9ad-a41d-4e25-9bf2-f05a7c273437" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61916daa-96b9-4af8-b486-58d79721209d", "AQAAAAEAACcQAAAAEDIMZTwCbPoBNuPgIzA60xt9zBB97rx6puAn8CaFzfgk4gTL+CYA/ctySimu6GXtWQ==", "fd6860c1-1ef0-4236-ae48-596834e080cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d01f9825-ba79-44d2-9774-58c99623a2f1", "AQAAAAEAACcQAAAAELyZSGIYpXf46KnQ7nAVKUCZacet0b8f1ODMY7bJlf9rW9hkb+tFu0pRnFRV7FiJ4Q==", "fd68866f-9aa0-4e03-9f68-1ae4a148e4d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f8ef1c2-64ce-4ee9-8f45-15875b9f034f", "AQAAAAEAACcQAAAAEC0L5cgbG72TyUl3ecklJm50LHtkvOX8AV4CmiRPkSpliKQ2SbyAm0soZeonxOJjTw==", "51d865d9-d1e8-439a-8c16-207781b4d3ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2650a5a-1493-4052-996e-1f9215455e91", "AQAAAAEAACcQAAAAEBU4KZJFdORkVxcAg9AboKluStfAmtmpmgouCgDotIehW7AJ1vATzDQcF6U02ou+aw==", "c171bb02-230e-4276-987e-0f76acefe4a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9335b60-541b-4814-8f73-5547b1faba68", "AQAAAAEAACcQAAAAEAa14jXW4CrwB2aF7GJAFE0fkbqcpgqp78jac8GVf6ayPzw3obZhRzSqr7mG4UsWAw==", "e7d82396-5db9-4c26-8283-e1f90e1d9bee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc0abdc5-fe44-4108-a051-6bf760d10084", "AQAAAAEAACcQAAAAEAbtIB0KfEXYg9Fh0nYxLzV92hYecccT6tucWv0j9ioi4e84XYtVc2VuRFPZELVwjw==", "6b01fd8a-604b-4777-9c57-d83fe39f5995" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66654a18-63d4-42fa-ae2d-320973f951e3", "AQAAAAEAACcQAAAAEKfnS57/pgKL0j3htqJIiKQQb9xbjvRcbrOI5u9CCJcWThuGSJASMcgWipegMQyWhQ==", "ddbfa1bf-a0e3-46cd-80a9-163a3d6e17f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d80abdf-bef7-4bc2-a5c5-a19590423973", "AQAAAAEAACcQAAAAEFKDJsNLQEAXPhHIxlM7ZRYwE1mfMRduadgaCoVCJs6OFQ8ARScPSOQ+Gy84gsJwUw==", "0e8f2bd1-9b1b-4dc2-b8a4-c047a1ac6d69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f583f53f-e0f2-4160-89e2-8538faf9cbc9", "AQAAAAEAACcQAAAAEALr4sE0G33bOh3tYSsLdYdX7Ow24Tnxg0bF7d0PLY1Af0OVdXKJ9hXmyKh3x+kHaQ==", "2e00545d-bf9b-49d5-889b-de20ecc81c5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfec322b-5bd7-4cd3-9fc3-a818725a081d", "AQAAAAEAACcQAAAAEHYF2Yxg6/qTsOpB5UxgHNmsFo4s5yYP00cZAAQvpZzohToCEaDfHOxKWRpcD2HIbQ==", "fedea50b-2694-44e8-97de-e3af4a976908" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34d08df8-2a26-4ac5-9f53-76428d697c95", "AQAAAAEAACcQAAAAELVD2dbIPrmb09679M6tMXR6jnl3wVdhvW5LqJUqGRRH0ZP1lbMgTIhznZcmXdYIGA==", "6ab12e4d-32b4-4f82-bcca-2c45aaf582b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0867d5d0-cd96-457d-975b-5d8098eee53f", "AQAAAAEAACcQAAAAEENIMCd3MFTKDCCxc09xj8E3mR/G0s5oqi2dO5V0QAtgffgMivSmAJDiutD0VlVR+g==", "b6c226a5-74c5-4071-9e44-78171f31b61f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "439a88a5-ebc5-485c-a797-6f641afcda81", "AQAAAAEAACcQAAAAEJqyh9YtJWdfOzzpx14F4WO0bHPsVB5L8yiNk1Xq7RoU2KV0yIJLYgOp5A7thhGP9g==", "b887ce99-2065-4ec0-b0c4-8b16810eb253" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5072d095-da9a-488b-b6fa-21b67da63686", "AQAAAAEAACcQAAAAECVrHDmBMYHASJ7lkfhRL1ob871C7KTbQQt+2N6Dy9p/2nPoKLTln7TNnY9pLkowvg==", "6733d4a7-0184-4619-af08-f32367c9c3e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c483eb3f-ae2e-4b83-af77-dc0a35285385", "AQAAAAEAACcQAAAAEGg84VmYVrGghwO1vua/BEljMXieaIOxXpp1dugXHYX/9pVHI3BMfAh1XEl2QvDd/A==", "0efe2d34-13ec-4893-8381-f02171389b29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4f0cec1-753c-4893-b2a9-301b518af7d2", "AQAAAAEAACcQAAAAEO6IvcsPUo+czq9wRX0M3L13fZZ/PIiEOj/RXpo+XHa3HaGzxvT5tkET0sXhLuUu2g==", "a2e318cd-dec6-42d0-aeaa-479e7bb0be12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f664e97-ab6b-40ca-a75f-ea3e0993b468", "AQAAAAEAACcQAAAAEC9HsErR6PKlTL1J+JihLYTjxcxg4RwzOVgjVJBQejeWjgbETSzQKpWOZRo1teuZPA==", "e1f69750-60ff-4661-8390-bc8141899a4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f988af2d-6573-48b2-8374-cc0d3cf63330", "AQAAAAEAACcQAAAAEDFsTi6kTBHxCw6i871KFyaVpctOULP8ynjaTkkqJNxGNkVvgMFM/nFpU3agZYq4WQ==", "3d23c635-d432-49be-ae32-f609e28e3e84" });

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 1,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 2,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 3,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 4,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 5,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 6,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 7,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 8,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 9,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 10,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 11,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 12,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 13,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 14,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 15,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 16,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 17,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 18,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 19,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 20,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 21,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 22,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 23,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 24,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 25,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 26,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 27,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 28,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 29,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "studentId",
                keyValue: 30,
                column: "studentRole",
                value: "student");

            migrationBuilder.UpdateData(
                table: "teachers",
                keyColumn: "teacherId",
                keyValue: 1,
                column: "teacherRole",
                value: "teacher");

            migrationBuilder.UpdateData(
                table: "teachers",
                keyColumn: "teacherId",
                keyValue: 2,
                column: "teacherRole",
                value: "teacher");

            migrationBuilder.UpdateData(
                table: "teachers",
                keyColumn: "teacherId",
                keyValue: 3,
                column: "teacherRole",
                value: "teacher");

            migrationBuilder.UpdateData(
                table: "teachers",
                keyColumn: "teacherId",
                keyValue: 4,
                column: "teacherRole",
                value: "teacher");

            migrationBuilder.UpdateData(
                table: "teachers",
                keyColumn: "teacherId",
                keyValue: 5,
                column: "teacherRole",
                value: "teacher");

            migrationBuilder.UpdateData(
                table: "teachers",
                keyColumn: "teacherId",
                keyValue: 6,
                column: "teacherRole",
                value: "teacher");

            migrationBuilder.CreateIndex(
                name: "IX_teachers_teacherRole",
                table: "teachers",
                column: "teacherRole");

            migrationBuilder.CreateIndex(
                name: "IX_students_studentRole",
                table: "students",
                column: "studentRole");

            migrationBuilder.AddForeignKey(
                name: "FK_students_AspNetRoles_studentRole",
                table: "students",
                column: "studentRole",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_teachers_AspNetRoles_teacherRole",
                table: "teachers",
                column: "teacherRole",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
