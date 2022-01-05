using Microsoft.EntityFrameworkCore.Migrations;

namespace DQMA.Data.Migrations
{
    public partial class StatementRequiredFieldsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Statements_OfficerRanks_OfficerRankId",
                table: "Statements");

            migrationBuilder.AlterColumn<int>(
                name: "OfficerRankId",
                table: "Statements",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Statements",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Statements",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Statements",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c9203c30-fd6b-46ba-a946-464c545c9d54");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "372a9b02-a115-4fbe-9cc6-7d68e1609419");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "de147f09-a031-4b2d-9658-2287bc906bf1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "050b5805-ac27-491b-8bc2-c69f6868b4b1", "AQAAAAEAACcQAAAAEIM9u+qWJrMck3dFrJ5qcpVmAHxSteJQXyGIcwZ4xPtS8LQAiZZAocx8pSMY3XqWVg==", "86d75838-22ac-446d-8436-931ee128b499" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c29c1869-bd56-4415-aae7-7761bbb722d2", "AQAAAAEAACcQAAAAEGzyvj2kgDrLgybI72FbihVCl3m83cfKGqVtScE+UJgTJfrh+NWCjdJOlQi44W5gZQ==", "73b49f69-d1c1-4f41-998b-582b06c4277c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc75e756-b7d4-4a9c-8de4-d1981eb3ab8c", "AQAAAAEAACcQAAAAEIGngXfwormUntEjseMNIPnQNqBsb5WsJX3svg9Y5yij+RuY+GMkt7FysLYkNPXejg==", "a86d5f61-ca94-407c-975e-39ae2c0740bc" });

            migrationBuilder.AddForeignKey(
                name: "FK_Statements_OfficerRanks_OfficerRankId",
                table: "Statements",
                column: "OfficerRankId",
                principalTable: "OfficerRanks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Statements_OfficerRanks_OfficerRankId",
                table: "Statements");

            migrationBuilder.AlterColumn<int>(
                name: "OfficerRankId",
                table: "Statements",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Statements",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Statements",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Statements",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "18da21d8-ed48-4b68-b01c-0c3433f61224");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "65f37438-ef0f-4ae7-b902-5d252c137d72");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "22cd75c7-045d-4af1-b97d-359339186d86");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc1e9497-c697-4d73-a9c5-a2f4b131db7c", "AQAAAAEAACcQAAAAEDvjaT27/3IkJWaLbmNDoSDHLCX6QJsuL0VMmIPs/bhy6REOIxvWTGcE59EOJN3w4w==", "802b8237-1d4e-405b-8ea3-225e015a57a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1414df4e-3861-4801-a55a-a0f119fa5281", "AQAAAAEAACcQAAAAEPnwtZJjVlFSqvJOIS6z1A0JoDq9f4rejYP3vdDhOJXAS4NZkfLcCdQUsz0D0+Blpg==", "c499c095-2192-4eee-beb5-3db091bf6e0d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75ac5e6e-9d5b-4590-8220-4a7e18e95837", "AQAAAAEAACcQAAAAEO4hyAJcbywb9y0oQ9Ebct8lTBcZSKGsIZFbrI8tx3DtFf/cMk/KMPgpZs1ellnRjA==", "06bd8b0f-80d4-40f2-a95d-03198bbf954f" });

            migrationBuilder.AddForeignKey(
                name: "FK_Statements_OfficerRanks_OfficerRankId",
                table: "Statements",
                column: "OfficerRankId",
                principalTable: "OfficerRanks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
