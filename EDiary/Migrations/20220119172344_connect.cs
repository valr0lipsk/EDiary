using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class connect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "04379e8f-9e05-4f1d-bdd1-27e0af96e708");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "fb8c1055-71a2-49b1-b083-6083a02d9d68");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "4e8ee4cb-6e94-4bbd-a431-8ac4cd89c328");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "6092a27e-9124-4277-ac3f-50805b36a064");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f25b0ec-6399-4b38-9c06-1725b9df2738", "AQAAAAEAACcQAAAAEBaPgwE8jtODTN0JMyzxoOMjd3xkCg7KQrWK+cL9MgDc8Lr5XdUjYQOMNVOXHnnh3g==", "6fe26b66-c75c-4ca2-bf1f-d3a5aa5ad1d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c44689ee-2820-4279-a9cb-98232fda0f00", "AQAAAAEAACcQAAAAEDFFXmMFsxZPAEF1O0mCswK+xqeHv2WsknNIm9PNHEJjzhe+d8atNoX0d42lT8XS5Q==", "d51161a0-b930-489f-b262-e48c41ef3b7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8b56ea9-75ad-46d8-8d83-f82a0e97db49", "AQAAAAEAACcQAAAAEADp5o2wv9gY6OLUS00BrHjDVkaIaeigL6CYMLIU6iVRX2ONUKQnxtSW7b+n6If/SQ==", "01216ba7-f911-4fa0-9c3d-97d78c2a40c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bafc881-249b-46eb-83b8-8e911cae0e6c", "AQAAAAEAACcQAAAAEDfZmQaQPCCqJMwxhW+us3+tn8rksfE1mbXuyT0N4oNKAnzVI1/M8lcHWZhkAXdUYA==", "db5bf509-a34e-4fb2-9dba-880e366effb8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78cd6461-59ec-402a-b53c-48ee01a3058b", "AQAAAAEAACcQAAAAECg/v57Fd9H5UEtVUGOGw5g4THXJykKMDj3X2xONgYRCYozkefrVRpkG8voQCjtf6Q==", "a53663cc-ec3c-49b9-ace3-83583c3e9810" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0b5b591-8989-49ae-9098-2f801620a25b", "AQAAAAEAACcQAAAAEM2RpUSK/3Mok4VMQ4Ey08NT4KuNFt/0/LIA+Pyrp0zvocC7iILPxkPtCYMTYpo+Hw==", "472072d5-611e-4345-9e6d-082e2dacb525" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2effe7c8-5c08-4c39-a6e7-0b8bfb59a20a", "AQAAAAEAACcQAAAAEDiG7fAk4Ncf5vgG0ExyHFzOn5SZvHeetpS54Vi4rZ4m2ISN+0h5Ve56yZJXdJDt9Q==", "d06f5325-6d8b-4727-afa0-4128dd166efd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "502c03da-3d11-4772-aab1-4b2d152acc6c", "AQAAAAEAACcQAAAAEHtJYZwvHEsvp4v+7mymOwXk9Se4eMRqA2ASmaGs6qmbncqHtisEz1GRHcdSjMIKXQ==", "1b6626ce-adc7-4a93-b5e5-5a64d14c72e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "339256fb-783f-47a6-a288-f6399298b0c1", "AQAAAAEAACcQAAAAEIygqPy74D5L+KbkaPg72vEUdH5k91ly0mrv4DK/n+e/XuaHeEMhyglhHIrlIP1hLQ==", "cc100229-4d3b-4f64-b7d7-ae95b8cd49a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b359bbf-4bdc-4acb-b2be-452cadd27add", "AQAAAAEAACcQAAAAEIHWLRcKfPADL4tmI3VsPFaiGcDLE6DAXofdEyGoqo8AQnbfcYdl6pWv2f07PC5ukg==", "d10c72d8-d5d2-499e-8b75-9827333ffedc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee56a950-3033-4d10-8786-73c9507f1585", "AQAAAAEAACcQAAAAEJS7PfZh+CAGSSUMote9A++KeFuL4+VgPrrGA6EK58OTtxSnGDQGoUTqy3Br6OVnYw==", "4f388c5c-4f11-45cf-bd72-553bb7797250" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a55e7582-54a5-4809-9b91-1b85d291a3d3", "AQAAAAEAACcQAAAAEGhdKfLB1KxV3hV2mMzm30DdOci9E3IIciMcDQiAdPKNXy3DtbG9/rhO8YDj/1JN5g==", "2f7632ee-6a61-4392-9daf-bccc8144d413" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee362d8e-6dff-4d53-9048-c04d23d3b239", "AQAAAAEAACcQAAAAEJBnKWQWucdbphN6LILgRC0S/7wRGvYzDGeMdmDizH9VsnfsxqScHuHgXl0USM/pyg==", "ac703b21-6527-4c83-8b7d-db6389ec4635" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "091fa954-f5f1-4693-8aa0-fcff97b7b1d3", "AQAAAAEAACcQAAAAEFKoxZEQbj1s4IeMh4gV+jl5+qSWjNyHptNZrYTn4LcLCHaqtw+Tnu74i5RS42bK3g==", "58b23431-a86a-4100-bf43-48439b5064ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8d2e68e-4c4e-445d-9e12-cba93dc84d9d", "AQAAAAEAACcQAAAAEG7sYqDqHwytKcyO5arEnurzUuLJM1my7TpLNv9Nt+SnD3u/oDLnZLaqyFaFR7uR7Q==", "a10bd8ab-9587-4046-81cf-c51ff9aec357" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b87eda11-7a40-473c-aa12-7a631c999c9c", "AQAAAAEAACcQAAAAEJ4ejTLD8Jw3R9319AgHyp8GmGdschp4glA/hdThtR875jmkWSFYdjONuGa+rEmeQg==", "f6f680b4-7594-4bbc-826c-49cffbc7cb3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d01a97d8-62aa-4028-a58c-7dbfced14d04", "AQAAAAEAACcQAAAAEOemz9bpnwSPrGQZIDP2RZ78my1v15bONlPQVS9urGQr15yp4nSfHJQS5P3BWdxC6w==", "825f98f1-4dd3-4ffd-a0c0-88df11b05bf7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dba9d4c6-d5ea-4e3b-82f2-0c7125523179", "AQAAAAEAACcQAAAAEPWGUifRR2eoZAvW2C61J58YvKf/Br0P15sfXSVsA4KaZiTaFYakrZIbdpiO3aeW3g==", "044cf6a2-3f08-4ccb-8784-fe628468717a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7d68059-959c-4261-8a29-e6d1c3d7eb21", "AQAAAAEAACcQAAAAELZ8WQkxk8+aT1hJkIGrTfjfh0r3zoYfyGtLIi1aqI3bwKExbBTw7PBgAZUO9GBTmA==", "7ce093ef-1b04-4bae-a86a-0d2a70a624e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2400c70c-bff5-4014-be29-bff8f511b8ce", "AQAAAAEAACcQAAAAEKAX9gzjWXH2P35RPVNPd9xisKIFGeEqaZuMdI2j85PJKG1yTSonrtMSsJPZ2lp9UA==", "8517ff1c-a84b-4848-8c78-40d923575fc6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46af8c05-97b2-40aa-923f-ad9f3fb263d9", "AQAAAAEAACcQAAAAEMojqXAH6RdqjcgL8vHJdSUg/3+vJfAmyvZ/szzVSJCq7J1Qzz/8128uF5SvnbrWUQ==", "faf6877e-293d-42b8-a690-a96108206761" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91e597e3-8c32-48f1-9516-1005faee8998", "AQAAAAEAACcQAAAAEMB9YwR638zpz//OfiC69/pbT5/khZZT7JCDAMZB8LBkqgMH9mbv/YpSc2f3LgMLDQ==", "c18632db-eacc-4473-aa91-39afc45871df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c92c387-231f-40a2-951c-0a3cad5117a1", "AQAAAAEAACcQAAAAECJ0cxmedfHbVCvrty6lOYMncteHvAdUvXn18DVyhh5nGKAEfM7BLRZlo3NkH3g2Ig==", "ff2fc4fb-9ee3-470c-b462-3a13a688c84b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6b571cd-d9b5-468c-96e1-14c1d711a8ba", "AQAAAAEAACcQAAAAEJLvghhAqVuiVpby5Hk5iDPghlwASg+EDlMldFynrhiE0Ofr7mhj4fKm6PRn5mVlIQ==", "815191e2-34b6-460b-9e5b-3d372dc4eb78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "306722d6-7e80-4e06-b3e7-d4dd929ac287", "AQAAAAEAACcQAAAAEGEWA1Jxkqyb6wE6YJ0JeB65DYlz5yAi/c+GgYfElxvrKUVuTBkVXUz1krcw5/vOfQ==", "85080fc3-6338-4dff-ac91-df1703be1fec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0266be4-f042-4068-8d03-3d7db17c6d2c", "AQAAAAEAACcQAAAAEDNftLQcqGl+SlTY471gYiqpKytPRiepZWWRxh8p1P14MQmJIU2eOwmoa+23V5TU6A==", "aa608bdb-0a31-4d8f-8a71-ef0c6191e12e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23b10754-3b0a-4214-9c8a-d88a939c1176", "AQAAAAEAACcQAAAAEHGND1tvPMQtoWtJ+zN6WBms5FApoVqxJ3u2FlzuxanvTEfRCMZiRwyGfPAv/Yy3Rw==", "a06c46a6-8524-4299-b499-a89d3b7d9e3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16fb9e86-d4b0-4eaa-89d6-10cfcbaaad84", "AQAAAAEAACcQAAAAELJXE/CxmEumiVzJZWVgxeuuFmIystORcMAJOfC9MmoAJvEyDgd8+iPsGZo+WarHLQ==", "788a88d6-5855-4c76-8f67-8dfc5be5ec10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30f9171c-0554-444d-b24c-346358c727e4", "AQAAAAEAACcQAAAAEPKbf8qHltVgdeBdWhF6mGJ9KgJ3dKQTRgEHAYh1+VBp1+q0asp+A5GjHqUnDVNSrQ==", "6dbb9b6c-1c33-41d1-87f6-f2d9f2af0ce1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a322241-70d0-4024-8205-70b9e465ca5d", "AQAAAAEAACcQAAAAEOqZ0F6rXlI8Bzusyc9e6Kinm+PB2Pz/HJiM7xvMChNqJMTvimZLXm4n8SukpBqyWw==", "58c97e5a-5e30-486a-a703-e31a51ffff67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e0f3307-236f-4a64-bf7e-2719bc3714f2", "AQAAAAEAACcQAAAAEGmKqYRGIHstXErnBErM9JLhZkhLYVu8duiiHmkLurdP4B2k86azHVHGsn0u8BmOSg==", "c54b8423-4eae-40de-a2ae-eb21d05434b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd2fd92f-661f-4230-afc2-95ea32daf108", "AQAAAAEAACcQAAAAEHr9XVSaUvNn8jiya6ccn4g7KJ6wTlkzMdH7dH18NMj4gn0f2+w2ZDqsxTVhMgmOLQ==", "8d323ab5-bd34-48a7-8112-132d4477a58d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "516152ec-0a9c-4f4d-8d6d-3296374e37b6", "AQAAAAEAACcQAAAAELk5UUykYuLCfvwSvciHti86WKtPI9BgVRR6T8jnZoFntHtv17G1mjKy5/Es9E6g5g==", "08d36aaf-01e1-4801-9024-d567ab418a74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0f9e4d1-39e8-484b-a76d-3a45121e0556", "AQAAAAEAACcQAAAAEETjUrsoEze32HiwMVitw+9fwY5a1mWHjba6OJXJ3ZYS7PtXQ1OoTZQ48rg9wf4OWw==", "b6df4570-1a70-46d9-8d6a-3070369058df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0e65a15-50db-4864-a72f-61c3b989e5ca", "AQAAAAEAACcQAAAAEErEmhLMaCo1oUxMB5QAh0oZBZY98hR8PXQBXBVr6klrZJXCxvxAUfWNqNBX3SnuFQ==", "d344d366-c159-41f5-8bcf-727a60da9261" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8608caec-2d45-4800-9b05-4312830d9169", "AQAAAAEAACcQAAAAELQLGlm5vK0ef3rbTY81ibdgAGPIuVg+CjFdnOOVgzYv6ExrjvXaioIJI7cifpVjFA==", "79b96e68-84c9-4a40-9d7b-94fd268a7a07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f18dcad4-2194-45ba-a7a3-e9eadbca3f65", "AQAAAAEAACcQAAAAEEgBMlvDgzxeuHwDkKmN383V+tun9rGVVeZvRF3esKmveQVaeKstAnLEdtwtAdMsUw==", "5cde6364-facd-4b12-8976-2cb27c3aa83c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "12a45541-eef6-4401-8391-62afaebffe8b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "8248250e-4265-4a09-bc67-8a3b561b8748");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "3f57e549-1f9e-418e-81e4-f9725f2d11b8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "a183e990-82cc-48e7-8976-3bf49be9cf61");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "589adec6-6872-4628-9229-1b25593c1262", "AQAAAAEAACcQAAAAEPaApNcgrSKUpNyrKYqfps2mkTwX8bgxy/eJUdcd4ynqg+cORsV/DTU2LyM87EFFWA==", "da035d0b-f946-467e-9ade-c3573f165646" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "717a6b91-c2df-43d6-a315-88e650963cb9", "AQAAAAEAACcQAAAAEPZf5Wa8wFo1i8EoSzF1ew8Ezdri9MGs8gqufsUn31JlrtcbLn1UWwIvPxXy6jB3dw==", "b3ac9a98-8e4b-4e13-a689-130eb33c6fc9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de922344-2f25-4a7b-b9bf-2509edc1540a", "AQAAAAEAACcQAAAAEHXUw9h7KyvLoLERliAogYzpzyrg6x2rmb6GhFVKy1Xh+8S7eq0RnVrLO7fy1utPUQ==", "0ffc360e-dcc6-4a7d-8851-c208a2d7c51a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f24ceaa1-03fe-4174-898d-e0337b36d1d8", "AQAAAAEAACcQAAAAECxnQ4LC23iqsMrruKb4I2/Imxy/R1IrlzbbliwcsScslze9v3XpS0VX2O9H6Jwr+g==", "92aaf351-c3f2-42f2-b425-9a6fc9d3c9db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33c9cf49-60e3-4a80-89ec-013882234e9f", "AQAAAAEAACcQAAAAEBz+wL6f6WR0mRLuwwIJg36+qxDj692zwLRMHTZnE4DF/QpX546Y2S2/vKlmJSiLug==", "bc3c91a6-2bc3-4a6a-a3db-5a2dff30cdfc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3037cf63-bad5-4cdb-83a1-93733b25001c", "AQAAAAEAACcQAAAAEBdZaLDIvAP6FAjWP0qAh3ZG0trBhpjvJ5zBLYcr+Bp6FvCugtgSG1x2+/OMcaRQRA==", "f1f0fd67-c723-4cc7-be40-3ec333375ac9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f66f2412-c801-4083-9400-07e5def16d08", "AQAAAAEAACcQAAAAEIgiNkme8WztG+Av0DwEeUcHUGTXeCsAWPKhpU+F0q/HOMkP5M/+MVjsN5scvhcT4Q==", "cc601848-c60c-4d81-bb9f-04babfc2d68b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ce6ec23-21c7-4769-8935-69fb3a08ff22", "AQAAAAEAACcQAAAAEN1uWi6Yl3oHbxNU6uVDKDC+wXGi3XHKDefDc8lI36gaNL6tvf4XhPuYu2PpPS/5Qg==", "b819e6f1-9983-488b-96d5-4233de54a76d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cb46eba-eb42-47ee-a37f-9419cc8e7fdf", "AQAAAAEAACcQAAAAEGKJICS3wtTjvCU+SR97gs0Hizj0heE8q8gyhtLgOZlqciu+saXuOLVoCMs5atP8dg==", "ce1dc1b1-eadb-4f7b-83b7-87e631d980fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "659bc699-2f77-4d4e-94d5-33392599a92c", "AQAAAAEAACcQAAAAEIyG2l4CSt59tmeJoeLWCMGsALTrfZDPrrl1TtNfH7MAgKZV+8+y1FfCGq8FaXegvA==", "3b817650-29f1-4abb-b79d-dab14adbeaf2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc15e7e8-020a-435a-bef3-f48d9b4b3961", "AQAAAAEAACcQAAAAEDQiHHwrZaOEM4uPoxYm/YWaknqCUtWT1ShTFUZw90BhfTNplPSkbVzbUkPjhXbl0Q==", "c15d4399-ac13-4ffa-a8c3-36801f31439e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8ffd8dc-76d4-455e-b6a5-2f1373f09587", "AQAAAAEAACcQAAAAELrkvg8VpjhlB6SiuVWfwYDQ9KL14TyneAlkWrKh+kyq0cP4ildQA1n8hSXgwN4tKg==", "5cea6f35-d3e8-41d0-b998-b5146dc4e40c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fa9c3be-c9d4-466b-abff-8b320cf61e8d", "AQAAAAEAACcQAAAAEKnZRGXNgTb2VE/WPELZCTVtHsgQLMzfY3UmKiM1gruJUnOCi8EYOUodr9KShHelfQ==", "08c06c70-ce64-4365-a830-837e8a063849" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "761d6581-8898-4276-81be-b7a6f8148a68", "AQAAAAEAACcQAAAAEIvG4rCkTglEePj2BOihU2OBJJmpxoGTIAVpsZ7VHrRNRo81Mvjwy2jeaOImOlZYaQ==", "0d6c84b5-d828-488e-85df-58eff5db2964" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a7aec0e-eb53-4514-9b8f-ea2aeedfc120", "AQAAAAEAACcQAAAAELSXA56nFDUMjsSZu62G9DyEgoS6ywjedQ+gwldQkWPl5aXT4zrsSG6/NVMa+4bSpg==", "0e295531-fcee-4a4e-a41d-8b395b5aa41f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e05aa22-9293-4a2b-9f26-2a7b42e2e9d2", "AQAAAAEAACcQAAAAEHoXdrv6RWTQev7R5uHQWhjmpJ03R249u0YoQs7cEWJhEah33guXbhlSMSVXodYAqQ==", "07954258-c06e-42e6-98ce-2201511ed067" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80dc29a8-edbc-493d-b7cd-53bc54e7ad62", "AQAAAAEAACcQAAAAEInUicbHT7p7U10YuqwSDDALanyTiz4nYz3nBC9/ksUo7+dgujIvXC8dp8oRQwsK0Q==", "f1b9bcc1-228b-4732-bba4-35c8d7a75611" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "daf51b66-b839-4f7e-b1cf-b4265c983875", "AQAAAAEAACcQAAAAEOw0UVGCnUr0gc+THVUQr+myKOHI6iAaVjiivVz/4RaJYW9av0hBj4A8YQEmvXPKlA==", "423c4331-58c1-4156-917c-4cfbc9b34c08" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52927efb-7883-4565-bf70-b383a72f8700", "AQAAAAEAACcQAAAAEEd6b3OVByHOv948xMO5Qby7KgwRjmYuIOuq8K2ZiFSU7oenmbMbF1YLbPgR6ANrFg==", "f0c82725-122d-4b44-a08e-470061afe078" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "054bc72b-fa99-4b40-b1ad-d8d58d2964ea", "AQAAAAEAACcQAAAAEBgYAFLdrZkMBVFAwg0ooBO2cM3hi2y6SIhn8mgWUXMh1JvUlpwQ674pGJu75uSIjQ==", "cb8da753-cc37-4e38-824a-5247883a4c06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8a3db6c-35e6-4d77-9a57-56748c80c5e8", "AQAAAAEAACcQAAAAEPL1oc5BtTBGtmRDx6jmdxoIC7IXopyy0LQ70Zo9ynuEM67zphIqMs4DiZQ/J3EOIw==", "c579f0ae-5ae0-4915-b8ac-baae69c5bd33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b28f1576-d6a0-455d-9d59-0a644aae0a41", "AQAAAAEAACcQAAAAEDfCthQ5bebdu4rLzNcIfJKKkmzHnfExXT/0AhHxL0QHNojg19XmOJfW5KSGQHL34A==", "faadeb10-85a9-4d1a-8a1d-181b1bd51737" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0350ab83-cf1e-48a3-8784-92eec8810a4a", "AQAAAAEAACcQAAAAEJ3gePVAIQTF1dn1lhYdusl4AKmhH6xS2cTQuraPXqVXIWI3/uSqegYcEoEaQUJXvw==", "dff76111-74f1-428e-88d8-51de46c2826d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32e654bf-93a1-4f98-ba24-91e4c368d053", "AQAAAAEAACcQAAAAEOVkTCN54HTxenD42EoEy+Aodx28VpbtAd2Qp3jt2Zm11sNkpCvB3+GdkD2CSOBVeg==", "71d9e8af-8146-4e18-9c31-98cf2d8ebc12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2320ed68-902e-4f01-be89-dfb3676fcba9", "AQAAAAEAACcQAAAAEJTYrjgnsN3rqwYaWr/LM2h6mjt/WXd+h65IcRu/wDtDBypxB2e9ficgw+apl6j2fQ==", "e247e898-b352-444b-a1f2-40f676bcc728" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4518da15-9cb0-4456-aed3-f53951768e19", "AQAAAAEAACcQAAAAEGaqokTTkQpiahtpPICv9uYClpUsPZwUAF3H1z37c5MIrC7YEVStVzvYSEQz28Cvpg==", "54916f33-8e4d-41b3-a34f-9e27575eb8c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "421d477e-99aa-4b3b-8ef6-2e98c8fb3c2c", "AQAAAAEAACcQAAAAEFn2aJOipRCAZNzz/p0n+c9szk5jfR6OUJjP59w3L/PZl04CaAGCyvc67n9KJa7HBQ==", "2df88571-cad7-47bb-b7d7-be41144964bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37952295-d4e1-43b8-8474-9b65eabfde10", "AQAAAAEAACcQAAAAEBSqCPp4CYUYDG80N3i9tmoIaJu9A6udV9yI1bRoAlrbdmuwv96eHJPJRcVHNe3Q2A==", "444addf3-d273-44dd-b81b-e9bcf6afd593" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf731469-069c-430f-8b72-a047f29f904e", "AQAAAAEAACcQAAAAEBest+XWUSshAD/AH1BiIzY1out8ZiYfw0Ude/pF7WGYMQqM/28HJfnEzjOoHRGI7Q==", "50337efb-46c7-4237-8767-687c11fe4646" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22e790c2-4a8a-41c6-b79a-c5c20521deb7", "AQAAAAEAACcQAAAAEB+mWUZGUdCzYV5yhkw9SeEm23aGFfkhxqlntTmqS4we8ZrHfF0oRiQSaWa80w0FxA==", "275643b5-499b-4968-947a-eaf40356ea4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48c5c82b-7acd-48ed-b850-ec7a68c76191", "AQAAAAEAACcQAAAAEHMc9Jl0yIbWgyCdV5KDH9gKExFvqFCfp7lmHwPdG9qA1aOI2nvNkgJfte2FQ3+xBA==", "68e5ad53-f015-4406-94fb-9f7772e73893" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe195296-85c6-4361-ac5d-ab0baa461cbe", "AQAAAAEAACcQAAAAEE2w+7EPr2GLWmox0BJuQZ1TDBnruJmnItwUUk3DrKQAqNumA7wR9PrTPLrAUH5qLQ==", "b1752a9e-9809-428c-945a-36007b1d6ac5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfee2f43-8829-414f-8d60-f4f9b62f626d", "AQAAAAEAACcQAAAAEAJ3+QZO0BxkoOW/cTmR7uKuJND9EHDfyDGQzWSOqVYi1y1mkcB0zcJAkrDetGLLpw==", "be884c5d-026b-49fb-9e84-91f7fe6a0b5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "157588a5-d1e0-4001-98a4-984f41816d82", "AQAAAAEAACcQAAAAEPsHLQFILA3dyOTCO8ZHeXIhBhd/RIEBHyKVI2WKdnA3i5pT4BglBcm42JjEgPE6Fg==", "66b7bd0a-d09e-44e1-b567-3e9ac8ddffb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d09bc00-a584-4bb2-b1ba-c2dc8264a994", "AQAAAAEAACcQAAAAEMLHe6CjWCBWtVptKlbxpEB8nQF9RVFtgCenqdLu0RCDupeTPtVaOqoqppakgn59eA==", "ed07fea6-3bfc-4732-86d2-5fa1dcb8cb45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f4bbdf3-3d84-460c-bdb6-4254de79d410", "AQAAAAEAACcQAAAAEJc8mLIaa+1Bh+9vYWGgJqCkHGzhvnlZuj53//68XANPaArcXdhZMw/rJC7EYTZyRw==", "d8a0d316-5c12-4180-ac41-154dee78083d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac7101f9-ba0a-4c8f-b89e-85fdae4413d1", "AQAAAAEAACcQAAAAEJAsGMmlaDnxnjJ1pOi9lnILwwUz0d0Oz9LPoKj1Tx1oTT5i0Jlk8SvTkdU7znPNAg==", "3c1dc325-38b9-4b11-a25b-e0cf186a4de8" });
        }
    }
}
