using Microsoft.EntityFrameworkCore.Migrations;

namespace DQMA.Data.Migrations
{
    public partial class ParishStatement_Updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Statements",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Parishes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Statements");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Parishes");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "c5a0f1e0-22c4-4274-ac07-3f8f02713442", "Admin", "ADMIN" },
                    { "2", "20c40fe3-a639-4053-9411-e29dde7f50b3", "Data Steward", "DATA STEWARD" },
                    { "3", "d5d18e45-e121-4871-b552-5655dde51cd1", "Form Developer", "FORM DEVELOPER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "fc5b13a1-6d42-45ed-833d-b4321b1433ab", null, false, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEN6WWtFr2JHAveRRZMb7UmgaCh1nAK9lg6UYl7XKrd9Uo5WmvD/Fv5P8A+BVo4KaRQ==", null, false, "cdfb9172-4ac0-4c8b-a281-fc809d1fc623", false, "admin@jcf.com" },
                    { "2", 0, "52b98b92-baa0-4937-a18b-0fd696a19065", null, false, false, null, null, "DATA STEWARD", "AQAAAAEAACcQAAAAEBbF4DpB+2iiXNuF2fLh0Ut6RWYy3gb+eY+340TrHCrC1mvWFQyyQBJLbUGOPjqnXQ==", null, false, "e5b426de-d368-47fd-9b7b-e2d297036ee8", false, "steward@jcf.com" },
                    { "3", 0, "e274ee17-c752-414e-bdc4-87822dde83d0", null, false, false, null, null, "FORM DEVELOPER", "AQAAAAEAACcQAAAAEIixiZtkE4nxfycfiRvXi2t6xFjXxLtrGbehPZPZLkASigIb8SJyKEcvHwo+RL2FLg==", null, false, "34c6f500-3944-4a0e-bdf3-db1a26fcc67d", false, "developer@jcf.com" }
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
    }
}
