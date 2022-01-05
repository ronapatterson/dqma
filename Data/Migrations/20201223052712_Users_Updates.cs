using Microsoft.EntityFrameworkCore.Migrations;

namespace DQMA.Data.Migrations
{
    public partial class Users_Updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "bbaacd9b-87ca-4398-9016-dc61a4acbbce", "Admin", "ADMIN" },
                    { "2", "4b278b9b-5bb9-4fa7-81a1-dd5e5ef6a4c4", "Data Steward", "DATA STEWARD" },
                    { "3", "5387f721-e9c7-41cf-ba13-0f79260360ed", "Form Developer", "FORM DEVELOPER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "ea76add9-07aa-448b-a80c-0a20b1f6e713", null, false, false, null, null, "ADMIN@JCF.COM", "AQAAAAEAACcQAAAAEHA6ngiyvdA38OhfeU2TbNYza5Zw9NjDO07hlt9qNMMMgCTTxT5v5BmlVBJdO3ddpg==", null, false, "17e813af-8674-4e37-af94-d68c6d31cf0f", false, "admin@jcf.com" },
                    { "2", 0, "ca8e9cf4-96fd-49d0-972f-446d8cd2d2cd", null, false, false, null, null, "STEWARD@JCF.COM", "AQAAAAEAACcQAAAAEP15mp4ilHUnHk1wJX2TX5NJsWFsV5se7mbl6jSFFbNvSDxG/F2Y1Jr4x2pUsI3mmw==", null, false, "b47cbe20-e549-4820-97c0-97f720ccef2b", false, "steward@jcf.com" },
                    { "3", 0, "9326b143-1d9c-4f7a-bdf4-e64a089993de", null, false, false, null, null, "DEVELOPER@JCF.COM", "AQAAAAEAACcQAAAAEAOjH7MpAdWpYt47Htm9uypVV9qQc+Rt8Day8mG6i2EtQYEf3Pph9oalCGGY4P+jsA==", null, false, "d48d05bf-8fd3-47d5-8f0c-693bc4204edc", false, "developer@jcf.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "1", "1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "2", "2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "3", "3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");
        }
    }
}
