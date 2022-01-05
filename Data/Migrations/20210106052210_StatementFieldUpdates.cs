using Microsoft.EntityFrameworkCore.Migrations;

namespace DQMA.Data.Migrations
{
    public partial class StatementFieldUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Statements_CrimeTypes_CrimeTypeId",
                table: "Statements");

            migrationBuilder.DropTable(
                name: "CrimeTypes");

            migrationBuilder.DropIndex(
                name: "IX_Statements_CrimeTypeId",
                table: "Statements");

            migrationBuilder.DropColumn(
                name: "CrimeTypeId",
                table: "Statements");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Statements");

            migrationBuilder.DropColumn(
                name: "IsVictim",
                table: "Statements");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Statements");

            migrationBuilder.AddColumn<int>(
                name: "CategoryTypeId",
                table: "Statements",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Statements",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MotiveId",
                table: "Statements",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OffenseTypeId",
                table: "Statements",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CategoryTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Motives",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MotiveName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OffenseType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OffenseName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OffenseType", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "723bf2f1-dd8c-46e1-88db-48d3feb8fca2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "4c12baa8-e714-4b01-933e-72be5be28bad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "f4bb1e45-e3d6-4fbd-b7f3-cc2d2d30dad0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d2ac3db-7f4f-4a48-8ba2-29a406f79db1", "AQAAAAEAACcQAAAAELU6ZnNRFi+aZvC5iiggT3ZZZWZSn6rRbGksGyaSKvaINEaQEavQw/9nl+DERHkVQA==", "132e95b9-1631-4802-ba52-9f72523e942f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48546c4d-5c92-4bb2-9319-82ab1545dd65", "AQAAAAEAACcQAAAAEGTdLMSkWvyeCoRcCjh4iuGtlS5f0A91nHis80zTxEu5u4Prp0hatmDGsJN8tLmdyw==", "8a984988-2396-4ec4-9c98-ede3f60d6a1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9c786b0-3eda-41d4-9162-920fbe647194", "AQAAAAEAACcQAAAAEHNsXPTiV4NTE7Va5tSZYGmUzaCqQalGvWZ2+a5W2H8endbMjKo4pEynn+6V5oNJxA==", "865df7ca-dae8-4ddf-804f-d2b9d45ddbbd" });

            migrationBuilder.CreateIndex(
                name: "IX_Statements_CategoryTypeId",
                table: "Statements",
                column: "CategoryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Statements_MotiveId",
                table: "Statements",
                column: "MotiveId");

            migrationBuilder.CreateIndex(
                name: "IX_Statements_OffenseTypeId",
                table: "Statements",
                column: "OffenseTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Statements_CategoryTypes_CategoryTypeId",
                table: "Statements",
                column: "CategoryTypeId",
                principalTable: "CategoryTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Statements_Motives_MotiveId",
                table: "Statements",
                column: "MotiveId",
                principalTable: "Motives",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Statements_OffenseType_OffenseTypeId",
                table: "Statements",
                column: "OffenseTypeId",
                principalTable: "OffenseType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Statements_CategoryTypes_CategoryTypeId",
                table: "Statements");

            migrationBuilder.DropForeignKey(
                name: "FK_Statements_Motives_MotiveId",
                table: "Statements");

            migrationBuilder.DropForeignKey(
                name: "FK_Statements_OffenseType_OffenseTypeId",
                table: "Statements");

            migrationBuilder.DropTable(
                name: "CategoryTypes");

            migrationBuilder.DropTable(
                name: "Motives");

            migrationBuilder.DropTable(
                name: "OffenseType");

            migrationBuilder.DropIndex(
                name: "IX_Statements_CategoryTypeId",
                table: "Statements");

            migrationBuilder.DropIndex(
                name: "IX_Statements_MotiveId",
                table: "Statements");

            migrationBuilder.DropIndex(
                name: "IX_Statements_OffenseTypeId",
                table: "Statements");

            migrationBuilder.DropColumn(
                name: "CategoryTypeId",
                table: "Statements");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Statements");

            migrationBuilder.DropColumn(
                name: "MotiveId",
                table: "Statements");

            migrationBuilder.DropColumn(
                name: "OffenseTypeId",
                table: "Statements");

            migrationBuilder.AddColumn<int>(
                name: "CrimeTypeId",
                table: "Statements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Statements",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsVictim",
                table: "Statements",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Statements",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CrimeTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrimeTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrimeTypes", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Statements_CrimeTypeId",
                table: "Statements",
                column: "CrimeTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Statements_CrimeTypes_CrimeTypeId",
                table: "Statements",
                column: "CrimeTypeId",
                principalTable: "CrimeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
