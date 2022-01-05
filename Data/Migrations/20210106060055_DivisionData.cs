using Microsoft.EntityFrameworkCore.Migrations;

namespace DQMA.Data.Migrations
{
    public partial class DivisionData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DivisionId",
                table: "Statements",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Divisions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DivisionName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d7f79ef0-4726-45d0-ae41-c438105f4bb2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "cd2de4ab-211d-4e77-9b3d-03415c4e8e50");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "d484c51b-9c2e-4d7b-837a-140450aa6657");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "957e5bd8-f1c1-4a42-9383-5a21e63b15f4", "AQAAAAEAACcQAAAAEIfCYIQX1d0ntfEgfiUTZVS+CaoY7zoKy7QPLKM2X2fIIHcwhgiLnymR9Ywy8KJIEA==", "b62d3dad-a6b8-4a8f-806f-5398059854ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cfb97e3-f303-4dc8-bf0a-59cc3a0f1318", "AQAAAAEAACcQAAAAELE9eVHyRo8jtCBFKaaMv42f4JIdw02cb6XCX0BtkMUcnbQhfV5MzYbe2pl4gw8BHA==", "72944644-1294-4c89-ab90-27ad4a3b1817" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cefb7b1f-1113-4d3d-ad48-14285ae1b640", "AQAAAAEAACcQAAAAEG7MT2xjAnuE/GRmf9gukOQP7W0jBKELumJ+j6KgbSrJ4YBPTG4aONZHTVaHgdSFiw==", "e69db329-c0b0-48cb-befc-ba96aff74f3c" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "DivisionName" },
                values: new object[,]
                {
                    { 19, "Westmoreland" },
                    { 18, "Trelawny" },
                    { 17, "St. Thomas" },
                    { 16, "St. Mary" },
                    { 15, "St. James" },
                    { 14, "St. Elizabeth" },
                    { 13, "St. Catherine South" },
                    { 11, "St. Ann" },
                    { 10, "St. Andrew South" },
                    { 9, "St. Andrew North" },
                    { 8, "St. Andrew Central" },
                    { 7, "Portland" },
                    { 6, "Manchester" },
                    { 5, "Kingston Western" },
                    { 4, "Kingston Eastern" },
                    { 3, "Kingston Central" },
                    { 2, "Hanover" },
                    { 12, "St. Catherine North" },
                    { 1, "Clarendon" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Statements_DivisionId",
                table: "Statements",
                column: "DivisionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Statements_Divisions_DivisionId",
                table: "Statements",
                column: "DivisionId",
                principalTable: "Divisions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Statements_Divisions_DivisionId",
                table: "Statements");

            migrationBuilder.DropTable(
                name: "Divisions");

            migrationBuilder.DropIndex(
                name: "IX_Statements_DivisionId",
                table: "Statements");

            migrationBuilder.DropColumn(
                name: "DivisionId",
                table: "Statements");

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
        }
    }
}
