using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class newnewnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "155d524d-f292-49b2-82a8-d40c3d108817");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "28c536db-dd5c-44e9-83eb-b84b70547f3e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "8c4a4f8b-3bd5-48eb-85f3-a5703d6ee836");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "0e77cb09-d70c-42eb-ab10-876e60185cfe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac1345a0-7eff-4a19-9a15-7ce3cd31aae0", "AQAAAAEAACcQAAAAEB9ZigCxORyRIuW3tAR9RTxaZJH7ajpXJoD12l4MbYEAH2ebcUZpkE2KRPlQLkhS0g==", "7ecd1f0a-eccd-4c7d-8383-b63d8fbbf4af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3b6eb20-21c7-408a-b941-da1c68bf8630", "AQAAAAEAACcQAAAAEHiF/ljnyxzYl10lkYfGs+w+4nWQtXbQJYB1teCJQTypPN9CICCNA9vNFY28mPNzMQ==", "6a960c75-9584-4515-b492-64dd72afe15c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9ce97d7-ccdb-404d-819e-8118e7fc8d23", "AQAAAAEAACcQAAAAENI6DWehOQfF7gyu7wKP65mA5clz9ygWZTP4AfUV2s9gR3han2aIHUL3hKxEUR/7jg==", "6d667c3a-64a2-4a3a-b46b-3c9dee04cde9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15ab1611-c4df-4585-a1e4-125c2d833cb3", "AQAAAAEAACcQAAAAEIA+HAW9Oo3C7KDldy4WAJfY/kNBOXJ9lX9L06icCMlmzngeqUmMd5n0QsY0VuL2Xg==", "7a0919b4-e96d-432f-bb1f-1e61fb1e7539" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09d24f6b-be94-4f0f-890b-ef2147e345d9", "AQAAAAEAACcQAAAAEP3yhfquJUOQZ48QNDtIehLcNMGRa5A275DOpxVBfzvqmEF7fj4grB2EMsN5aki9qA==", "6686d2b1-1077-4944-afc8-c2259dbf0838" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab6fef67-1979-40f0-a6ea-1e6c3ea412cf", "AQAAAAEAACcQAAAAEIagbY3R3DI3r5wGMdRVq5tHy2zkdqfEyzTLgU4iTYyN2N8MQu3HsZVdZK/cOvjdXg==", "05f8db23-c98b-43ea-94ca-a19388c4026a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3ab2794-4209-40fe-bed3-512c66f0dfa5", "AQAAAAEAACcQAAAAEONsGQnpQSXvk4kqHVs40Fs+RAA3Uu/Wc2FDNnxGz9XbX9JCQ1e2QwhSXKZJb0xx+g==", "ec212dfc-dffc-4e12-8999-3145e924c7b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53c0c9ee-b486-490c-a5c5-abdf105e0ecd", "AQAAAAEAACcQAAAAEMp5fvWGNt1ea9jcsq4gK/dqpWa5fhXN+3lZH+yqJ3KmDzwKvJJT+8aqEmNVHtQKpA==", "fe7de071-cf11-4bc9-b6d1-347f4d4b01b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f288b4e3-1f74-40a4-b803-6dbeab4b8439", "AQAAAAEAACcQAAAAEP8b/T4VEFF4TQRw3nHlrMd7QwSGmxFyl0wbLWGPPBsGM1ej9Lap862sldu7Qyd3ug==", "9fadf2c8-7302-46f2-a2c0-baafe4b4de0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e7ef2c3-1e8c-40a8-a744-0fd4f976ad13", "AQAAAAEAACcQAAAAEBnEiT7NaRD41uHtBqGK9O5Om8nIeiIrREL40E/nAHgLn4lH2LRgZNJcNcj/luApag==", "c76c02a9-bce5-477e-820c-56915530e912" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c924766-51f2-4b5d-90da-f125f7c0fb15", "AQAAAAEAACcQAAAAEDl2Ykr1Rhj4lIPtSkexj4Letw1MKIy50grWGqL4yELZLdGgGA5lTJqZXCQXvIpFCA==", "476ea309-5316-4e23-abee-ba40a72d0d56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3e204b6-3202-41c9-800d-62d1778093be", "AQAAAAEAACcQAAAAEEaeQiyr7kRJy91v4t82deqdTn3pF78sPb4m3C8mxNe4cIUe9vkPfWsPcZAZhVtWZQ==", "29bfca0a-8d83-40c7-8246-5c701cf86070" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24aa3399-b1a3-4954-9ede-f64f30bec792", "AQAAAAEAACcQAAAAEFSVWV3SwTxyOAvafiidFZhXgH0yt/Z2+aVoYJvlQkc59xzEY/20Unx52Zv/CguvNQ==", "6b6230c3-0f1b-4bd5-b157-d452b63c1206" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86038543-a745-448d-99c3-578b5bb10660", "AQAAAAEAACcQAAAAEPzeNB7NaB4aYJg/84lzuJ8n1visdLZyfmXDWtt8AXGTJa+FwMRtdUEgU64HUyyEfA==", "b24d9f12-51b9-41f1-9c39-84ad44f9245c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b248cdb-137a-493e-a001-a379e809f342", "AQAAAAEAACcQAAAAEDKiQNETfNpz8rOdbEsFEvo2qgFICrIeXJLvQshoV+/RAL4RcE1GVKluslD2u1hgyg==", "cea1c35c-0be5-439e-9a4b-9d00f5b3fa9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1337bcfc-19f1-41dd-8e50-1de3f45c3c42", "AQAAAAEAACcQAAAAEMt9YShbt1LJ8oCyklwVJv9x7zgohKh2mYxrU/bdjyXbV+/PFnlEODITMJEoUQVuLQ==", "a8fbdf69-90a3-4848-82a1-be90ddef1c60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4dc84c8e-71e9-4af3-8a78-b189cd791e18", "AQAAAAEAACcQAAAAELHlJT8KOfN1CAdzlE7gMqa/bkhU2bOhBG7Aeeax6f8HcmwJj/9Wm46T2qt7XBZdew==", "97e218dd-37c9-4a44-a5ca-b7ae527fecf2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f0eefbe-6c6a-4a78-86c5-e464d4e4e657", "AQAAAAEAACcQAAAAEN10vJ5jKLHcg9ZwNp8GQTYK/O1X1IesYtbqScb7bMkJPfvkZQVS8KrZFwh60tc3hw==", "3392ef52-db0f-489e-87c2-171a1164194d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28b65ed8-67b9-4cd2-97ae-12bbd39beaf1", "AQAAAAEAACcQAAAAEBfERdWczeyCORLs4GmsroUCnCTLX54a4x0KAl7kILm9+95kB1nRaSVUoDotbJJyRQ==", "229b28b8-9021-4c27-b8b0-df7fda918c41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19f16473-c073-4ad2-955f-8a10489bcf18", "AQAAAAEAACcQAAAAEEkNmLzSSdRLnaRbBn+aZMER4f5mZFCfYU1Nj82vGGfF+ff2bS84hIB2+C/FT40CMA==", "a5cb2297-4df9-41ec-9e1b-872108c47c61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd0daccc-91bf-4db5-b239-2cdc3ee452c0", "AQAAAAEAACcQAAAAEAKQwX5VoZfeNzWOqLW7S/CR58LnqTrlTeGPWcndu5Oq9R79wrRoSmQMvtRclbdwFQ==", "f794789f-6770-4630-bb51-64ed872d412a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6121cd4-e058-4527-b98a-5e5dd0351d03", "AQAAAAEAACcQAAAAEHbN3nwQfccIflQRBaf896jP2CncmRL5oQhq9M24MzRkM4WTGAX2Fas4mySlSnazFA==", "8dfa247d-d0e5-4b32-b14d-51aa294f77ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4501837f-2686-4c28-b2c2-5a23e1bd2f3f", "AQAAAAEAACcQAAAAECFVQh2qDxTqRhEPdACkWyRnv2EMQs3Mogrfa4w77c8H+jqzfNoMXqBpdg6Rg+uKBQ==", "8df24166-9f2f-4e4d-aaf3-0f39bc653c38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ff3524c-297c-411a-8232-f4ef95ee603c", "AQAAAAEAACcQAAAAEF7bwBmA5+DlYlmw1Eoc3ZkXGDh2mppq/lXv6xO/kqIpW7+nZv1rPcoKNB6RM3i17g==", "cba543c3-3c4d-46f1-af9f-d2ec20e2b354" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f109d79-752a-4443-ac27-822cdd1c09a9", "AQAAAAEAACcQAAAAEE0kCuGq9L+eWG+ZEgAsnRnnKnnXrx2uTzgRBxfItOFomIKoQydItS2+m4l/pVehfg==", "1a79ad02-530f-4c95-8e6b-37829a367b27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "064f8a35-49c1-48ff-bf40-70dd3a53fc8a", "AQAAAAEAACcQAAAAEIzMANU3jUSbbKvFRbyHLUmAx8fVnPWfnTo/1EwDJhYQSUAxH8lxpx6C7ooZVcVdhQ==", "2a350783-8e07-40b2-b057-b91209a9316e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba7b6596-07fa-497d-b4ed-3eb6dea15bf7", "AQAAAAEAACcQAAAAEOISYEQQ8e8Zksf/qaQTThUZ/ekKzw/tT7mDybeUBQrGwpaJIBJPd5YocGnaYmjetA==", "8828040a-b46b-4f54-a292-7e77f30ec8c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f466882-28f7-4e0a-b43b-a6ebbc34136f", "AQAAAAEAACcQAAAAEAQ7meGrPeQ2o/ad/7IckKc4DFCtI/ywAxqTDlAlDtoOAPMxqIbB3a7wTyzbGVINzQ==", "2210ac20-45c0-469c-8aa5-da50e99bfd1a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5328a66-b078-4037-9376-09c8f6437799", "AQAAAAEAACcQAAAAEN1AB2Zc/d0uyRzFby1MbWp7L56mjUw/j5JTBUElaRC6APSSmjutv9QNLBsPs3tznQ==", "7a0c8f31-2f29-45c9-afe3-4b506df75c71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc178835-839e-41ab-b959-67dca7741133", "AQAAAAEAACcQAAAAEPrL+7z+N6VFilwhFmOX+jE7FKErwQ60srntMXXRnS7vigJmUvPMQwWiNE9KeXcpmA==", "a8f65929-6de3-4fce-b479-23d3bbf83b27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40cf8ed1-3ee5-485a-9dc3-756273e73d13", "AQAAAAEAACcQAAAAEHRtJ4wHxxrebPAc7owysGEPa0gnDtkgPjR/tTIVKeaESiyL+RKsultjczyfspK3Bw==", "4ef5d9fc-07e2-4cb1-a863-7125a9ddc997" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd7d82de-1cb3-4404-8594-75fd961c7270", "AQAAAAEAACcQAAAAEE+Xm7osVuQ1M0PCAh2ERM3GFR/WWbrM9Yru63FUjlc0H8f4GkNI2SD6FwxBJT7BMA==", "91ca2c00-329d-43f7-ba64-68bd01165570" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db000cc1-adb7-4b32-9588-26c7b2c12c14", "AQAAAAEAACcQAAAAEHGxRk8w+iW7PxchU/LeWJz8nWXu0S/9SlJlPgE5OM/Kn74Q+yLQeDweXRPTbYjMmw==", "650862a7-5742-4344-b44a-b63795a267df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffb9d031-9dd2-4823-b6fd-382794eff8bd", "AQAAAAEAACcQAAAAENLG0APlggGwDx2oYO1Sz4S5bFa4mJUUMiuELmB/f/o5ulEEmjyPNWAKSYE6WuZVSA==", "877e026c-7304-4ed0-969d-ec30251d450f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca8b86b5-495d-4793-a078-9cf9c0712fdb", "AQAAAAEAACcQAAAAEA+RZzUT7jc5y4qxqkrZBdiWtA/qe1ZjjTxxX8XHQ4aDWRG1EdIUrK0HwssIXJYBtQ==", "6e88d2b1-385f-40dd-8de5-55d34037ccb8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6713753c-8473-4e9f-be39-4262095fb642", "AQAAAAEAACcQAAAAEEbuZhKhNGUwiCWVWI3QTpyMRvCbKh47l6WuSMxGR8zMAGJ267JTj2TUfCQIo3DcBw==", "362b3f18-5747-44e3-b087-a2896c6a50e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90026994-e61b-4d63-80c0-1fc80c7b91c9", "AQAAAAEAACcQAAAAEORn/lutFNxHY2NbTpkUQjneaXji6h774dkJT+/+T1SG75HnVFUeGTNLHiSb2mpdxg==", "ad592a9f-eec9-420c-aa31-57a3fe4f8db2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61e819cc-1dbc-43a7-be3c-22b12d3089cb", "AQAAAAEAACcQAAAAEBAlOCFNA7hgDagLFr1DvYsk6eDuaedIRwpGkgD11zIDQgqOXp+atBsWlTLdikMnCg==", "8df758b1-8604-4f8b-91ce-7e10a318c4e3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
