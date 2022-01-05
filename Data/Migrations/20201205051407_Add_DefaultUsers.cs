using Microsoft.EntityFrameworkCore.Migrations;

namespace DQMA.Data.Migrations
{
    public partial class Add_DefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "2a9f104d-34eb-4037-8499-0d1554afdaa4", "Admin", "ADMIN" },
                    { "2", "94333c17-3467-4fbb-9d6c-3743e12c2541", "Data Steward", "DATA STEWARD" },
                    { "3", "1ee4239d-46fb-4b68-9531-f3bf816987c4", "Form Developer", "FORM DEVELOPER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "7513fb44-631e-48f2-b41f-bc2afef1f86d", null, false, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEL4PPiM+cbzUFQbY7CMa4rOap8Qcv8JnAKpYQVai1pxypg/3wFzXjEYTGOL1Y7AM4w==", null, false, "8a308c3d-ace2-4978-a888-27ac14902a95", false, "admin@jcf.com" },
                    { "2", 0, "4e677a81-f74b-4082-8c4e-e51c1d6faec2", null, false, false, null, null, "DATA STEWARD", "AQAAAAEAACcQAAAAEIGCVvfLuBLM3hUs+ST44kW0N/89c7sWu5VpwxiAsQHfXrBsRtx2t/+V74o+5djBcA==", null, false, "7e60ad25-f775-4d6e-9a80-0629f0ce0015", false, "steward@jcf.com" },
                    { "3", 0, "6fbc1d18-cb79-4242-828b-3fae04f3ec2b", null, false, false, null, null, "FORM DEVELOPER", "AQAAAAEAACcQAAAAEPklKgPVFQLIatkIYY0p8JaX5TEqd/PJKpwJhEwEYq+HY17G8tmV9gb8Ow+Pd2TwDA==", null, false, "79ff3a02-2b9f-45fc-8848-ef8b97b28cea", false, "developer@jcf.com" }
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
