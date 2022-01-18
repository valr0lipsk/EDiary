using Microsoft.EntityFrameworkCore.Migrations;

namespace EDiary.Migrations
{
    public partial class removeAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "dc24268a-627a-4174-9fe4-4d431732bbeb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "8cd531a8-4dbb-492f-a07a-9c33171f6065");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "b127466e-e520-4f20-92dc-12cf719b3f8d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "3a62f436-ae83-48c6-a561-9aab6efe2a87");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "467742f4-eaf8-4a63-83df-2d4585f643bd", "AQAAAAEAACcQAAAAEGPrBD0H6ZvMfLfRYSAKaDnNkiLHeEFeotnQPYdeg8r2lNtmmpU9Gi1S156iV91LNA==", "146f327a-de0d-4ace-baaf-633f6c82ec1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d49df96e-af5e-46f9-b3ce-e9100a04999d", "AQAAAAEAACcQAAAAEBjB6jJEFC5yHwrOxXps2khnXNJnrAXknn5SoTprZmFbuhp3Ybe9Za2GmoIOEaQU1Q==", "bb78a0ae-62da-4287-a62b-6ea0e25ea458" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a56dc14b-23df-409b-95e7-84088aa0c18a", "AQAAAAEAACcQAAAAEFBviHFuKw2zoZjIGEGiqkIjQ7LpUc3hewEUtA6GR6d990NgmC39MQ9nPt48KuEdpw==", "f98ae045-9162-460b-bafd-2292b3b4464c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "921fa8f9-f184-4976-ba8a-b1ef169f57d5", "AQAAAAEAACcQAAAAENn2a4SAMxTDS5Ru1CkzohA2/7y7GyZR7JpBG9rdaOX/n/DDQlNG6GXuq9253bDNVw==", "c491d5fa-5326-4ef1-8e5a-db03ee10af37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53bbda11-de9d-44cd-8663-29ddd224f0f8", "AQAAAAEAACcQAAAAEJi6fbRs+K6rGPl93oIWrSh8kD3VcG/XCpiAqNwJC0CKc/mOP7JiPB3a4LnsNh/Y3Q==", "295c32ee-c551-40d9-a96b-fae651edb8d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f552830-ae66-41d6-aacf-08da54bb5690", "AQAAAAEAACcQAAAAEJfox93ac6TobCHcCI82jOlkjNE+A+z5QrvyWOJJuK5xvHIHdUaa4shY5mm0hGvQzA==", "4c3e7fa7-30e2-419b-a58e-5a00db2717f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac49be7e-6639-468b-a0b3-f00710066397", "AQAAAAEAACcQAAAAEGNFTc609m9pONSRjJz40FX1FhfbLNaTPYRLVtDn0vueaz1WnF7RabBk/cv+zafKkQ==", "7d47b8cc-38c5-4546-adcd-ea473c2fac4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f40ea69b-0bf8-4c40-9e30-3e224052fd35", "AQAAAAEAACcQAAAAEMAZjXn1SQ7BwJF8hiw4LeyNoHY45PGBpHkl/svieQEu6yt+9IRWn8ySWFCd5mCDNQ==", "34c84afb-ea03-47f3-8a6a-b0f8f0ee7283" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb73e2bb-f5bb-41e9-be10-fe184e435b78", "AQAAAAEAACcQAAAAECcon0+4x4TxSnnOsG7mnV8A3ocZxcdun2Dwn2cyhnHIQ5z8qqvOV4bNFAyztnqPVQ==", "14d2e371-2dd7-4f61-a08a-17093d90fab6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94f0b837-c6c1-4b9b-9fde-b1caa5fadd10", "AQAAAAEAACcQAAAAEJwANywrfKWRqNoRMnPoDdFAsQ8EOyMw9g9XARpgutkQH2HHtWy4EtOliJh+PeJX2g==", "99900d38-3852-4898-88b5-dff5881588c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e29f03ba-b13a-43cb-8ed4-9c572845ef31", "AQAAAAEAACcQAAAAEM6OycJ6oQ17NwLQDkksGbs35mqugGAn0iTBIAah01uN/tPTaAdFxX4uQK3uOcwV9g==", "17315b5d-c1b8-4450-ac09-fc547887cbe7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7366406e-423a-437c-ac92-7046d30ba490", "AQAAAAEAACcQAAAAEFS+e2MpJqVTyhH2YZeGXL/d1tGUPIW2vM3m0JQ9IF7eWfc5DTh2+sDs4z0xr5V2Xw==", "b01ca4c0-52a3-41e4-9cb6-8e4280b50cf2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58de0420-c49a-4b43-a785-1af979523545", "AQAAAAEAACcQAAAAEC7/9M7PgCgV4Y5Cw93glEuskoMOgvaj/vEE46/psGo9HUDy2j5/tshz6MOGTO2Z5w==", "7f81efae-ca00-4b6c-9ec6-2669498bc7c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15ea3a68-aa84-4cd2-898e-6af84a0af07b", "AQAAAAEAACcQAAAAECepAwW0drAwKAN08GswYhOukHsIJY7qUMpdcga1/I2doVTjKD+yoq/HI48NGIzLdw==", "f801f91e-0531-455e-8e64-5f6b401decdd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6288aa92-7741-4132-9deb-fc9c3cd3c8a0", "AQAAAAEAACcQAAAAEB86xlQ2VyGznpeGTDOmzkSwhDn7fZJHo6u4lDFCU5Qa0pWmaIeDzCPfVQB1egt8KQ==", "0b893c47-227c-4236-94d1-30c1b4cc6510" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "309dfdfa-4914-476f-926c-e8529c038e80", "AQAAAAEAACcQAAAAECFMWgEvETsqRaDuS+yXa678PA7XrhfG/05fWRI0dXGzvTRvlbWqerxYOwNiIDxhvw==", "7eaf0c63-8434-42b7-a35b-96e48826d486" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73a9b9f7-89fd-48a3-a08d-30cf1c71ebc8", "AQAAAAEAACcQAAAAEEtiN/SpAEiRo8JfYo2Fgi6YBcGaZiGdlAnYUQVTi1JX8z7R6xe6dk85Qs0TqnPs6g==", "dd6942fc-3560-427c-abbc-fe1cb1728778" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2133acb1-14d7-430a-9d03-30675d779056", "AQAAAAEAACcQAAAAECCXEOz5qBYFVVTEqTuDLax/i6EaQgOAfsVmXZ9gzvZi+IO9l50gcae+HofT2epLuA==", "75d7c086-4f0a-41c9-9f69-e2b5fee65b53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec36fbf3-dccc-4882-ae5a-3df2d533e151", "AQAAAAEAACcQAAAAEIIeWo9Eix334PYK8/0pcpahZhXLMZC/16QDGEhNXX32BZRHjppt1YOVTbGk6kKXgQ==", "1bff38d7-6c3b-4cde-8389-0a4af31dc6a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9cba8fc-a723-4c78-a5ee-3ad93fd4cd99", "AQAAAAEAACcQAAAAEOZrz9sm2vn+FtsOcF9Mc+f991v3BdYrONQs7EklqLxbvMOfNGpc5xsj+IBoGNByNA==", "e22542d1-6e78-44c0-83d8-76546d28edb6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02b8a4ab-2109-409a-afcb-fdd2a7789a1f", "AQAAAAEAACcQAAAAEJdfy6Iafc7mf/UtCmpkJuAPwlt5ek5jtv64VNAN5c0OljGFzACpV9Ix/mgP05ggSA==", "08c15f59-19e4-460e-a83b-bb47024db26c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c389e39-aabd-4cc5-b1dd-b3a7b68fd7d6", "AQAAAAEAACcQAAAAEF3OymexBDEuBqJLHaBbsqt2A9l6ij/Fb8QgzZllgfvBGqUc5cFpadeyCnb9GFm7sg==", "3e2c34c9-93e6-439e-8641-3b6de1ac8ac4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1889d36f-bca4-4d4d-a329-2e3f4c2a2d4f", "AQAAAAEAACcQAAAAEK2Q4SMllnJDr9BUSta2vplMZSB/HGmD77OjNsjqBlH905+jR3gQFMCQCRo8GfuTJQ==", "c71a86ec-5673-438c-ac0c-8db470816409" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7161173a-fa4b-4dac-9da3-c33838b46895", "AQAAAAEAACcQAAAAELRFZ0ZIv8wFuG37rSGtmQGckqPr7TJTpBRMqiAKGz1S1Zf9IgZyskZpTA8ETT0ALQ==", "cbb9927f-5ea6-454d-9f7d-2a0cf255af1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eebde0ba-aa68-488c-a375-8875676c66a3", "AQAAAAEAACcQAAAAEKgec1RbsxDDVP5sOwDghDjolFbYLVMaFhxKIwSDbJva3DjSm9m9S2THrYwPBA5a0g==", "ef7f76c9-813d-4b96-a495-969079577727" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bca0882f-fa47-4329-9e50-0aba8920e731", "AQAAAAEAACcQAAAAEEDjvxj0MU8FBxKARJtxaiVm9Fv+lxfhwW2QLZVXBpgM7lixWXiDQl+zbw32WlSnqg==", "9701200c-f176-41bc-8a0f-4105f847bfad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83783be9-df5b-448e-b580-3ad1308975ed", "AQAAAAEAACcQAAAAEDhTjNCGQm7wp4ImUP4nRVgvfFq1Re4MI2/FyUYQDS2QCiUCNfmOlpnc9L1O63UWpg==", "663f8a95-0835-4b7a-8abc-cf2fef455dff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ff91e95-471b-4832-807a-1d28f7a9477c", "AQAAAAEAACcQAAAAEKmhNBNenBejUVLMbqkb2ckAEWNxUEPEY/vLrdjfbyEEcg2FfQ7+0zkAzfM06smTjQ==", "3dccde10-7409-44a7-a77d-f88bd06020e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "590cfdc7-5a57-4266-b337-af0f44cc26c1", "AQAAAAEAACcQAAAAEAGE3xCW5j6PbbGFbiDmkjzpFM73DtNgAIZsM3R3EZbEJUbQoKjN53Sto3Q8aZe+Yw==", "040355fa-630f-4104-ad52-54562fb4070a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a1f6683-977c-4cc5-9472-e61b95043f16", "AQAAAAEAACcQAAAAEN1wTbM2hWDHitke33qSTcfohWr8J7ZM29RL7K21cyztXIBXol6ApjCrxhSZhp20Eg==", "4116139a-6cca-4cc5-ba37-61051e5b0a41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1174317-f6bf-453e-970c-7b1bcfc7aa17", "AQAAAAEAACcQAAAAEOpAmXZ/r05UjLKki2hgFepzDPkIUgv44koh5PdHEx3AIN9ANdnaiXQqvK2rOCf3yw==", "af768f35-b200-4b89-8074-43e89c94adc3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "915f30c0-4ec1-4e74-a283-6ad797f84643", "AQAAAAEAACcQAAAAEP8Bkxtk27GoCCP/oaz5o/BELCab3iNpZem2eARcE49irN8/DdHb9aNFn/I6lwqwUw==", "00c16e7b-c06d-4b64-83df-e3daef0b7c09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4147f637-5024-4965-b5e4-4a5a4e5785f7", "AQAAAAEAACcQAAAAEM222CP9ccsB8omTzIWiTKsFSmfLoZuEMafOUrFb7FZ/lQClN4Hc/8E6CXeNeWw+Tg==", "5a86da4f-8b4b-4d1f-a528-1649037bdcde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba51c4ca-ca97-4f08-a7ce-6fc382e31fe6", "AQAAAAEAACcQAAAAEAuAdqFfu31Tu0eyP+VkQrY+9AVnIfofYdR4sWymTKSKERAy5BXzVqBWzTblICFeFw==", "0ae82b97-a375-4e56-8801-766d10c50828" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df486a2a-2330-4496-b670-39d5885b25df", "AQAAAAEAACcQAAAAEEO3vBTYKNWpwcteAtzZxG/31bCYfCDrPMSID61ADoEFniwmqy0o/N3lIgg+PE7NEA==", "52b2bee8-37b5-4228-8dd6-776181cc7689" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d51066c8-b1b3-4d5e-a709-64b3299d7ec6", "AQAAAAEAACcQAAAAEAHhBF2zsjaBKrU/Ra7KDVMBfUujGigCl/+F0DkS1IUW+2pOY/Z8mV4iJFznW1JGlg==", "b1595c44-7037-4495-a15d-e0b539692233" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c27f075-a788-48cf-af71-0cbf37b7e508", "AQAAAAEAACcQAAAAEOHwtiabCcLc8eaRG/X3HQoGtPkHFeKa34DcHXuA780MCRO3YotT7TDY3qtIBx6UDA==", "2360c58c-aab6-48f1-93a6-9c73afc26004" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    adminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adminRole = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    adminUser = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.adminId);
                    table.ForeignKey(
                        name: "FK_admins_AspNetRoles_adminRole",
                        column: x => x.adminRole,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_admins_AspNetUsers_adminUser",
                        column: x => x.adminUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "9fbae94a-e40b-4a50-a4da-6da08307a4c7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "headman",
                column: "ConcurrencyStamp",
                value: "161300ec-93cb-4724-bfda-90dc5d9cf5ac");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student",
                column: "ConcurrencyStamp",
                value: "ba16866a-5390-4188-b53c-6674b2263a8f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher",
                column: "ConcurrencyStamp",
                value: "d02de12d-f16e-444d-a886-692c4354f421");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a18c6042-992e-4736-a6f1-62716f718cc6", "AQAAAAEAACcQAAAAEN6YgnLJRJIweZxoGPqe2fsP7QOcykPDVj06k7s3IhFOyy5eMlGIw7Nuew3Pmo5A5g==", "36afb35b-2ae6-4c8f-9ce4-f8c5d79f5368" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e369e18c-ec9c-42b4-bb48-21a2d1e66d9a", "AQAAAAEAACcQAAAAEOkfgA2EkujtvxdZc4sDoJWuvO1Kh8YP4Ve3oUWywmSCa7u0a7sSydhwKhBL2sz/4g==", "babe750f-7337-44bf-b108-223846c5315c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7204853-2177-43aa-9be5-8b644d79c5ce", "AQAAAAEAACcQAAAAED0gFaEGcRJzE46P1xYgQVdOfa5Msp7bL1fPQKSxIWkA4ncyZ038l/mDxXap03lt2A==", "ea2b951e-51c9-4ba9-9a3d-ba1c424e97f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e45fab17-65da-4f4b-981d-13c7acf2457b", "AQAAAAEAACcQAAAAEFsxRpg0aod77gWuzD9m7Q/t9xtd8GX2wR4nivyh9C11Hb8TEiUgo2f5/aiHk1wiiQ==", "4728a384-824e-469b-96fe-3a7ee74d719d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0439e78-351b-4bce-ab52-86d02449a766", "AQAAAAEAACcQAAAAEB1xAe4NtIO2ljv2KqM++VyiYAbGbtMDwRwcpOJSRyna7SuPvcvrhO8Ngiz3H3ftlw==", "b809644f-8ac3-4ef3-b445-d2dc3d0be054" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f95299ac-bd9f-47e6-b5d2-c76e5342fa32", "AQAAAAEAACcQAAAAECK4fXy8TDSmpaC+QhPBi5T9PgF+vczee0IoMNdzWh8bVENufZvRIGFw0cwxHiphgA==", "5d2e4fb8-d2bf-4051-8d89-df46254fbf23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ee4e285-48b4-41c5-9497-e3a2b5222a14", "AQAAAAEAACcQAAAAEEDLYub2ns/QsN9v9jp33zkjgv/ETIX6ue71sQeEcs0lty6d3hFxjdF9+0r9JVV8Qw==", "c196fc7d-d601-407b-8d15-03916fc2332f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "537c4f08-26c4-4835-8cbd-fdd6db47c6ca", "AQAAAAEAACcQAAAAEK1p4aHnfTYu/jM5Retd8oLq+BBBlHMqb18XHWRdwClXEYEEYw7MXgsuCp39OKKlaA==", "47db71d1-1762-4a3a-9bac-b8a578cc3fc2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd58911a-25b2-4deb-b574-63232c490f89", "AQAAAAEAACcQAAAAEKdl9RwGwWrg0h5Bx+cYgcul7+FoLGYw/m2FRPUWkSpY7E5rhpWzsIGxs3Ls1ap60Q==", "773ed746-e023-4e41-ae6f-55be9f1e193a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b481ab31-2aff-4c9f-8b93-5d62f899319a", "AQAAAAEAACcQAAAAEKuF9o3argvqZ/WO/JcFl8eBz4sGZPIv832onz3I1xer/oQkIxOB9tmNUs6NwJ5lmQ==", "1ffea079-3c9a-4e7e-bffc-cac8887f6514" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10597a1e-877f-491c-9857-103aff9e6f57", "AQAAAAEAACcQAAAAEML3DU0TpHB+KYSZRYOCfhDo2w8SR3MiFaQuG4Ll2fKdCgFMT+70BdVKifcil4Awuw==", "9e8c5541-bc16-4f7c-9c2d-ec4875ec56bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2cbb98b-ed53-4bd8-b7b3-2459f0fdebe0", "AQAAAAEAACcQAAAAEAsXQFrG2gTcVIDQc+9KBSQAzAOFu/QoP6rK5Baro9+DXm5eh6KCCFPaVtz/IiAL6g==", "0bf8704a-da90-43d5-88f8-35dae56bc917" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3877d4a0-62f4-4a99-ae86-5fd079abef68", "AQAAAAEAACcQAAAAENQDDrwXGi1REnG2OacOseiJ6QSEAsoHk5PirB52g/K5Zhis6y87yzodxoshmSr9mw==", "72af1a45-3c8c-4fb5-b3c0-17728d808e0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b90c301f-02c1-4ff0-bca6-45d255863ecf", "AQAAAAEAACcQAAAAEJQZlcvnpFNIfMIWwsOAcBdj8KzpxcUMmha46iBGLNYPsx648uo17S7BFznMP7rOLQ==", "5a604c4a-c00e-4041-a585-be425551a710" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10c4333c-ff39-4ab4-ad16-6f9a1a6357a6", "AQAAAAEAACcQAAAAEOxSJQjAROC+MSZmfDkRUuKE4ZnFvlCsrjDu3FmAtSDYdoNK45MoW0yA5uobtrRitA==", "4bab554b-efaa-4b51-83e1-90c27aa030c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78ed7859-4f07-4cc3-958a-e058db18ab59", "AQAAAAEAACcQAAAAEPtf/zJj7C0x9j9OeeYiZgq0FY0TZMm4YIsOYsG+SQv/HOrRtAihnyDclCKjeI+oLA==", "68ae9412-a242-4a4b-9cf4-51db98e82215" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f53bef7a-31d9-4487-9f5a-86b029459b42", "AQAAAAEAACcQAAAAEIArz4KtI5+F3YwWeJf3x9YxppSNoiiRli7gpcVOiutS7uxnyyCdkc16fdBKzfuncA==", "016a8a49-2026-48be-9f4b-9d17e612a597" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2d5095b-e35b-4e99-b924-db8d8cdbed07", "AQAAAAEAACcQAAAAEPof2eqBUVKbMICzcChU0cymVr2qZqAxEqAPhvQeIYWZd0tetlE2DeYJhXZGM+em7w==", "633b257e-b5f5-4b50-8dbf-43c317e39341" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b983d2ee-2df5-405b-960e-0fb068ed2eb4", "AQAAAAEAACcQAAAAEGQWt2ytb7hXZJIhTODt6a2o6VHskSAhYEX5kYBV37iIBHlpimZS/Rb5ShuGz7pikQ==", "2cb31c7b-d847-4c2a-ad4e-79ac636e2f75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c821133-44f9-4c0c-8aa6-a60fa02dff77", "AQAAAAEAACcQAAAAELcWwwmSMrETSvUQaf2XrO3lPF1y29q2/7YIlTaWOMnhOBe1SehvSdqiNmFucp1B+g==", "8288296a-c899-472d-810b-28f6e27ef952" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91589d5b-1e13-4ed6-9b94-5f93826cc8d4", "AQAAAAEAACcQAAAAEOj6NwU6gbRKQhfS+8KCDZAhZHdbfkrt+JxXsU58Pgocv8KfTEuusI1wiK9dXf4XVA==", "ddfe20bb-a7a6-48d1-83f1-60bc4bb1ae80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57c9369a-3f18-4d6a-8770-7b0c1db0619f", "AQAAAAEAACcQAAAAEIF45wi0OLY3pXgDr5lTi7QxXQo2LtxqPyb9kcobsZCW+G9eG7ufsG4eSzpO6kLkiQ==", "f023db7a-5965-4bc6-9691-fa7e4e416563" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8860d8d5-6460-46de-80dd-ac614d2ae5ee", "AQAAAAEAACcQAAAAENs7ZXB/T8VFXROdv/tRDy7FJBT5m9Yc//yK1ak1KDXNQr/V671YzcvZl8W8fo4qAg==", "1d4f0dda-cfd0-47e6-b9cd-6038550f68ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cea2295e-ca5d-47c8-8c7d-147ddcfe166c", "AQAAAAEAACcQAAAAENRLj8dY0fn8Q+298dvJ1ZnCr9vV4B/5pNySkscN+Fad8SdIoI8MxwkW2EqPzhXvfQ==", "37212a14-35b6-4115-ba55-ea8a98ba4d06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48ae3877-6435-4be1-9c6b-2bf27cab89c8", "AQAAAAEAACcQAAAAEMoum5hnvcADTK9FM0ml6YmtZqLCKwYORR+Q9+jr8DlAu5TTuuIYSsEkFeqxTQcXuA==", "ecc3a8c0-d3b6-4172-acea-248e0ffc0c8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "052fa503-640a-4a01-abc8-4b1dc94149e2", "AQAAAAEAACcQAAAAEKF8SZf1uMGGGNkYFeS3qBI6VHIoofDI6N/q2pC6Odb9NnuGPMmnWpOT+Ynb6UAZYg==", "b84d702f-47ea-4bf9-ab9f-6f39c6f133d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39a51285-61ef-4634-b46d-088e8d2ad239", "AQAAAAEAACcQAAAAEGIe1Ird3et3ChS424OMdfL95VQr+t/N/VxLB5RGyYS8B9gw4NRfbBgNuAJe0zeLIg==", "3e5efe5f-498c-40f2-841b-89a40ecb1e0a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4229a599-9e4c-44f0-843d-69df4c82debd", "AQAAAAEAACcQAAAAELMrbXppdjbW/14HwawPcW0lvT10HXaTZx/4PDAfTkvuJhw+ALjKhgggBnZEuiLDFw==", "029496c4-b72e-4e9d-820b-8228d7eff048" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2af530c3-ad89-48df-a6c8-36275fe3d37d", "AQAAAAEAACcQAAAAEMLt3kSGIR8kx29dex4niEv5tH2ZzWu41vLJUfeZI5NgzkunNgenZGzk0srodJIOfg==", "ed44e948-063f-4e2a-b51f-33d7bc020dbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c42fca08-f3f1-4b1d-86de-01d30bf1b660", "AQAAAAEAACcQAAAAENPBdH+pi0Lbh6gBTdQDv3OxHKek5I7uFo8NAzS38+oun2sGESykHTZpYjXpnWrB8g==", "502df237-1351-412b-a37d-4f9d40d06a58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f2262c4-1fe7-440b-9dd0-ec6e86a00265", "AQAAAAEAACcQAAAAELQuvayhUAUKiah7uPK45Fhl3RV+d9tqdUD8jG4B4U1KbbZNsyAetJAjeNcbZqCV2g==", "fa2ef31b-75e4-4c7b-b5b2-c8070fc4508f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e9ece7a-5090-4afa-a6aa-cbb0e75becad", "AQAAAAEAACcQAAAAEOw+NKX1/0OAp++g+uLqC4d0nn5hEw2qo/Empz9wLSR30GGziLrDnkTi3maCpBIKMw==", "5594efd1-302a-40d0-8990-41fea173d567" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22a0ded5-ce5a-4ef7-9eff-1e531ecc8d48", "AQAAAAEAACcQAAAAEJQ2jXt1B1rNbAcIgeFMs1ncE99t440vVtPZ82XN322q7H14C+flsPUgPOsnJokucg==", "e8c1fb73-3d0e-41a1-ae52-207364fdbb9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "436c4fd7-416d-40ed-a26d-bfe97c9d8673", "AQAAAAEAACcQAAAAENWB/y6ptAL1ryGPJVMjnaFumbGQMhW/T8C5M1c+ak49cEta6S/K2KHQVVQhn/YogQ==", "98db2ee6-83fe-4fa3-9191-5557d6b552c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9721d14-8d85-4118-88ed-79f315a006b7", "AQAAAAEAACcQAAAAEFb7cPgGGzZGEzCWwseTHOp0KRdm4MXDUc7GqESFEg8jRWcYGs/2hK/hMyL3ib448A==", "95f01e98-d6bc-45fb-891d-574c4ebc08ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4df8e9c-6800-4038-9c36-2ce5b38eade9", "AQAAAAEAACcQAAAAEEHv1gKEPW4H7RIdxAeXVUBZFuwwMSX43as0f3yH3zHQT35MDIFSkKdZQI6aUQ2NOA==", "86c03fe6-b575-40a0-9bc5-e554c17bd4f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "276794b9-1a0c-4668-aaba-d30e5f2cb78c", "AQAAAAEAACcQAAAAEJIXHZFG4gPsMem+vnTHFJOVJZbvtO5qfd2U8nrO5Oe5inmR/I9PSUejrTrKrmOdZg==", "177084d9-9fe0-4bd4-9984-c0c9e40d762f" });

            migrationBuilder.InsertData(
                table: "admins",
                columns: new[] { "adminId", "adminRole", "adminUser" },
                values: new object[] { 1, "admin", "4" });

            migrationBuilder.CreateIndex(
                name: "IX_admins_adminRole",
                table: "admins",
                column: "adminRole");

            migrationBuilder.CreateIndex(
                name: "IX_admins_adminUser",
                table: "admins",
                column: "adminUser");
        }
    }
}
