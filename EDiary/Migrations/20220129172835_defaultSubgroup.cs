using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class defaultSubgroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "studentSubgroup",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "studentSubgroup",
                table: "students",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

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
    }
}
