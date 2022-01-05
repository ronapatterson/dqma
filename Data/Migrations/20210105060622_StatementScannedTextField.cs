using Microsoft.EntityFrameworkCore.Migrations;

namespace DQMA.Data.Migrations
{
    public partial class StatementScannedTextField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ScannedText",
                table: "Statements",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "4da675da-fc0f-4405-bccb-5ea7e9a0a0e9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "a4da9775-338e-4c54-9690-534401966e1b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "9cf6a968-41d5-4819-b92e-665d0d0f0b61");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74236dbf-3c78-43cf-a825-72bea7949b8d", "AQAAAAEAACcQAAAAEHDC3YDm9DqfbIC6mJMPIjhEkHlA8AwGqZqIhqY2N9q98t5mqjQbCWrJ/YeYwW76RA==", "b9710528-a518-43f5-af93-4175d757999f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1c36178-2042-408d-a51d-5e545ecd13c8", "AQAAAAEAACcQAAAAEEUiRNbXw4vh3MkIbk4DhdxJ9bdKOq8TZwHzqZhiC/E9MOFfCnQm8RO2ld59Z278dQ==", "06db8414-1e5d-433b-96c6-121c81aeea3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a6fed5a-f82f-4110-aff9-0d04711e13a8", "AQAAAAEAACcQAAAAEHfMZA6M+YrIIb6kqflV2k86g7WNyJz6+bQ51W8QLch3ByinQj2bft2Bl3c/Fq+sgg==", "29ebef69-d4d9-4b3e-bafb-2724ba2f0143" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ScannedText",
                table: "Statements");

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
        }
    }
}
