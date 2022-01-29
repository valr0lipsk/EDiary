using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class defaultSubgr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "bad86e4f-8caf-4f10-b7de-2d6d07472da0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "612baca1-e7b7-42d0-95fb-20ddf837a579");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "91855fe3-763e-4795-82fa-3360df75188c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "3e843062-4531-4fcf-bafa-1e8a076e59e1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "164f0090-c24e-4621-b3d6-1cd6894193b8", "AQAAAAEAACcQAAAAEEbxbszgtYNrA5D+pMMTnVO7RWtDEoFfpvX2IpmIv79Lyl+2UriGlN6lhT16XRAW3g==", "d90d3db0-b1c1-4854-adaf-f4f61ba6617e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6926aec7-f3c7-42f6-916d-22e38c3aece0", "AQAAAAEAACcQAAAAEOXgGhuo9mCj0fyRSQ7iazklTD7pkJamAxTTCc6PsHal+33M7wzAkYRIUo4EspA8SA==", "09073a0b-7ac2-411d-a519-c7fff91a1e56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "697f9c76-5116-49f3-b595-8672614e6c9b", "AQAAAAEAACcQAAAAEDDt9TRzmb/rNqN9KSjTKCNkQYUzFQQf24bnXv9XfE87xEXZyd8wECZ5lJgEWOEZsA==", "e27ed644-b82a-4c13-be0f-896b6b9c369a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eaa5273c-a923-42c8-af62-030e45e35249", "AQAAAAEAACcQAAAAEEmvzOFOrqXnW5eK2grlN8UxFjmTumiXzTJ4F4vdUi5NUTesLlMUswm+nVKf80QGuA==", "1c497133-0d93-425a-b988-c10b1d6bb5e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14182fbf-cc4c-42e7-85e8-744bf8f3accc", "AQAAAAEAACcQAAAAELTSxUIut+JnFzBzxYVkVnpZoeRF7aAY1IpXGl9GXPv+6Ay0R7igG7h1nUk9NaGu9g==", "ab4f10b5-f47a-4dd8-a594-e3ea445f5307" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "151ebdb7-0648-475e-a7d7-c8229f836fe6", "AQAAAAEAACcQAAAAEBlTW4kq9jVXdeeqN8ZSq6Uuc1Sn0hi1H7ZWww0JAi5N/uWqoZOG9MOxQgH4Ipixpg==", "736e7974-9cb7-4f29-ae9e-485ebd0d0053" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e06cb06-895a-430e-83bf-91ad89663f84", "AQAAAAEAACcQAAAAEC+vzInb8BQDZy1BJNWh9JdLsrqU88cdyFhu23tol1ImTkxwvrP2NVZ50K3mSXW5/A==", "1e63d147-a0b8-43da-ad2c-5ccd67af05c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb75b42a-adc4-497d-a99f-b3b52f2ce6b2", "AQAAAAEAACcQAAAAEHm2mZtHjEuZqUY2HXkqZyECzXGg8KTsLkjmVF8ALeHTHm3kzhybGd4dnoK0gqqomg==", "851a1173-330f-478b-bcc6-8e6239026690" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b17edcfc-c435-45ed-bb8f-f82c4c17614f", "AQAAAAEAACcQAAAAEEx6BFJq7O24et9MEnYv+IHGYmtJKxUXZe3gj4UGYxTs1zJNtiaJuUsttoCO9l+7zw==", "33ec944d-9e7d-40de-a650-1ef1593d0fab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b7df67d-4def-4f98-82ea-97d2c846b3d2", "AQAAAAEAACcQAAAAEBr/2o/5XSO4p/6jQylkDqtkRNSROkPFNeihf4RYIsvtDMmADJO9bHNNNZ1ZPsDP5g==", "f2eef3da-8767-4079-bd5d-789cef2cf84d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0697a8a5-e76f-4347-a0a7-90df44975b5a", "AQAAAAEAACcQAAAAEAsSFodznTmg/Ol7igU8cq4kVh90dJbIRH0j3Xy1T5wGbtVi2oiry+r0yrhrhKWOiw==", "6ce1b0de-7ae6-4b52-945a-935d3ef87371" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2801976c-da0a-476d-9760-b6906e8960b3", "AQAAAAEAACcQAAAAEInBy9P0vvXgsf6aX81dsasHWqhDndjsJ4jE0sItIVgiCCDb6RKOy7dW/4jmlqrWng==", "21fbc69f-c2a2-46bf-aac7-5d30c601cc38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64b3a3d5-e515-4c72-a46b-cd8970254431", "AQAAAAEAACcQAAAAEOlINZH7pKRLo2VGW979crGJGcOM2q5J+MzuRfNJaoQp5FYLRn/1UbTnQXfVgkXxYA==", "051a9878-33f7-4195-afd1-dd04dec82366" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43b439e6-e82a-42e4-bec6-fa5d242f9c89", "AQAAAAEAACcQAAAAECdIQ8gX5UMSn5J3UK1od0IP2RHzISlbj2MZ3JVDrGBYo2l0EzIguDbKyAy/TD3PHA==", "a6f60989-d159-424b-bc72-4bc7915a0348" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1e04ead-3636-4425-9119-9e48035d71e9", "AQAAAAEAACcQAAAAELrML28GVPDsgk/t+Z/ChiWSPv34r9vOudbGfTXzoqB0XiPVjMzK6FJZewhgUd/E3A==", "7baa4d66-aa0f-4a40-a42f-109ec2964bef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f278b76e-faff-4520-9097-c116d105aeff", "AQAAAAEAACcQAAAAEDoJ/sBi6S5wBgtIioR4cG3U4t5Y50hJ7+aMz25j7ylTKVElgMO+hbD5B/dXu/DQhQ==", "c48f3b51-0fd5-418a-baea-953090b5c612" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff1a061e-3c45-4522-b89d-84d15fbe4867", "AQAAAAEAACcQAAAAEE65dm6W+9cgThGBh6+BpBhnYZsEKpec6bDY23z2XAvJw2W5JetYsDSQIZp76EE6zg==", "69f712b7-32b6-4bf1-8760-46de001b5203" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "152d1a0b-4c04-4150-a019-517573009862", "AQAAAAEAACcQAAAAEAhMuhYkubyBcOQuJUKuhLTylk8yf/6TPZmqdZHLckT/MSB3PQ/Q+RGVPOZ6Jkyy9g==", "fd8deb9b-58eb-4e2b-ae43-eae604eda739" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97ec90fa-d8b6-40eb-ba26-8b9ff86a16c2", "AQAAAAEAACcQAAAAEJY7Kekr/tB8BKZ121MCBV1BQAM5UxkqWBaDQfT6islCupQSio0NNtX8uS+qAZWKPQ==", "81ec5983-984f-4bd0-b5e0-9786ce6514dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f7d6153-9b5e-486f-afd1-1c009011e319", "AQAAAAEAACcQAAAAEDRrwfLsO583RMtGhaPB5Q2UctsOxJophMCWd4UrSs4WSN6dS6zkq3hk48LnDrV3zw==", "8468f799-091b-4b9c-9754-e5d61d3c7d24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09876c77-d63c-453f-8e62-4090bfc3382c", "AQAAAAEAACcQAAAAEHjwayr8v7Ulmu1FgMlhBAy0LQhLeEztkD9hg+xrMxW80WE7fJsaFUe9VYZi6mlmrQ==", "aa883eeb-b5a3-4868-b6c1-9f224d880aae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e42ac7db-316c-4a4a-8676-8562545a8a56", "AQAAAAEAACcQAAAAECmMN2ZRUERFyugFnbnZz4Nj4oJ4Zu/CkcFdZ2zMu1pZeCwvqsCdE5aLlctN8m8g8w==", "3064907c-3587-4e43-a6dc-7aa17441eab0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc029142-cc9a-41b9-bc61-41c469554407", "AQAAAAEAACcQAAAAEIioZkMRXBtp37JI1HdAubEKdR4zE1alF4Tv1SEabMu73hmwLNkygwptUQRCHurmQg==", "352d6fe7-39f7-4d83-80c0-f56b7ee671d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "473bc0c9-a6be-4752-b501-1b5420799fe1", "AQAAAAEAACcQAAAAEECKFAeiQ+miYL1N9c7X/OyaHuniRtlnOCszNpTeev4rXnBSs49Q0/55VEbrePrNCQ==", "48cbbc17-5392-4857-9e12-51698caf6fa6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0e6cf4a-3bf6-41d9-bd3d-187a0aa19aed", "AQAAAAEAACcQAAAAEJzaoFHBVZN8YDGOUXKN/WaBdLW+eYQ5e5PGHtD5OO9RTpKReVWB/nGJI2sa2WxBDg==", "b81dbcae-51cf-47e5-ba60-07e8c1a09340" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c6696d5-def9-4085-b365-4708729d7459", "AQAAAAEAACcQAAAAEKdPooWcEwiNBFEDgZN2LYuxkVNAlHgbuWe2Xv1IfemDNxJkJe+Lik3jqPDQ4DvCyA==", "8f719ce1-3a9e-483e-90e9-be63379d298f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5166f7fa-6ec1-48e2-a545-75b60ec2fead", "AQAAAAEAACcQAAAAEGWxgao36EjnxXHGd9epy+pWlf5iZeFpO27SQmoDhduhHSEmyZuxN7rMGuyGeKXjMg==", "a1e8b4fc-243f-444d-821c-7fe43264a7e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15872973-8ea4-4c17-ba65-d7fae8707632", "AQAAAAEAACcQAAAAEN+UrLKfrNPYibRM3QcWpWWiViF/h7tes09U3emfG7qck6/QmWIEo2we+IobyUHPWA==", "3f49bc82-635a-45ac-bee7-7f138867ddc5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a590a4ea-b9ef-46c6-b192-4be56eccc05f", "AQAAAAEAACcQAAAAEEVewnzsKtY6rF/KZqp0YPrUvuX/W1qrv/RPfw9yF7MZYV3GM1pSX21FLuOUOGX9+Q==", "8448ee0b-1a78-40e1-a6a0-fc1d9520ef45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1add9744-709a-4dc6-be52-68444b3bd0e9", "AQAAAAEAACcQAAAAEKtyvlfqXinAcZ5lBodrr3WUyus1QrT33ixM1Jn8+lymzAHxrsEkjzQeHnM6XpZDag==", "a81bf693-3339-438b-a631-0a6f1860c7b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6de23617-9619-4ad0-8c5a-587d9ca48573", "AQAAAAEAACcQAAAAEBSsNdYEBvED1In6SSCyUJvkwrudA0bWXhhG1SZnt+c6j1wxOomdiJESjslxyV+TrQ==", "492333cf-fd98-4790-a748-02fe2ccbcc60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a43fd6a-11df-47f7-b7b2-43fa638b3454", "AQAAAAEAACcQAAAAELN0QkbOtiSK2fFYg6UovWYFlaqwlxUT4I/QIIwlv2Qc7bdm24NBwHcCmFDXxzkmLg==", "b40388e3-d010-4fd5-97a9-b4973a6dfa54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6dcbe97-0ad4-49e3-9c88-076552f154a0", "AQAAAAEAACcQAAAAEMWpo0gjcGQ/dFelqBH6WJJWtNekF7n/gYikG/hRG8vSTzcU67e3OLNhkBiPzcxaiw==", "8c2caf08-3d5a-4af9-b785-900789415ec1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b65019fb-85d4-4ae8-8c8a-02fd2bf45b11", "AQAAAAEAACcQAAAAEHwgwY2u2cYAH5JPC4T8AjJKOGBBijxoJAG+w7k1fsrEU344rCQwYRVMArlNykRFpg==", "fedb41da-fcdd-499b-95e0-8e02229ef1e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d477c6c-7a9c-4786-a8e3-b9ad3e1b9d8b", "AQAAAAEAACcQAAAAEGfUAz/ayevwhhn7m+KiUwDy4mcamX3abszFEuAIFpk6sQAEuQYjUALfBFtPery1Cw==", "3a43dfb5-8272-4387-8e3a-a47719f5df5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d662c080-b777-4110-989b-9b7de08e0338", "AQAAAAEAACcQAAAAEOOP3P/W+Qz732Q7ZHTMhHXrN0KrsguQWXwOoy13V/YnbvCfQwoEE8paPeMsSHEeWA==", "9242c6cf-74d3-4e8f-9aa5-5837c45cb395" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a5bbd70-79fe-4e5d-8a55-a60528274724", "AQAAAAEAACcQAAAAELfCK9CmlKCTKGSBTNxpToQHxSp3jNVLk7DBq+9nwNx/16KJXfmdW6TfxZiAlbYmxw==", "53ce187b-bd62-4c62-979d-8a4e97fec26e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44efe463-7411-4ef4-ab8f-d339cd1a1732", "AQAAAAEAACcQAAAAEMj2uG47JWpO9KTUkvDpJU4Cb0rJVQH9bLPihvRYKxxoTi7X9YtvM+eqyqYL/dfzGg==", "61abab92-172c-47b5-866c-44b681d83a32" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
