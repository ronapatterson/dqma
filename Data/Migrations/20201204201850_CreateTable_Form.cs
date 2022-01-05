using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DQMA.Data.Migrations
{
    public partial class CreateTable_Form : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormName = table.Column<string>(maxLength: 50, nullable: false),
                    Comments = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormControls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FieldName = table.Column<string>(maxLength: 50, nullable: false),
                    DataType = table.Column<string>(maxLength: 25, nullable: false),
                    ListValues = table.Column<string>(maxLength: 150, nullable: true),
                    Comments = table.Column<string>(maxLength: 255, nullable: true),
                    FormId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormControls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormControls_Forms_FormId",
                        column: x => x.FormId,
                        principalTable: "Forms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Masters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormId = table.Column<int>(nullable: false),
                    IsApproved = table.Column<bool>(nullable: false),
                    Comments = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Masters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Masters_Forms_FormId",
                        column: x => x.FormId,
                        principalTable: "Forms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormValues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormControlId = table.Column<int>(nullable: false),
                    Value = table.Column<string>(maxLength: 255, nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormValues_FormControls_FormControlId",
                        column: x => x.FormControlId,
                        principalTable: "FormControls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Validations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValidationName = table.Column<string>(maxLength: 50, nullable: false),
                    Rule = table.Column<string>(maxLength: 50, nullable: true),
                    IsRequired = table.Column<bool>(nullable: false),
                    Comments = table.Column<string>(maxLength: 255, nullable: true),
                    FormControlId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Validations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Validations_FormControls_FormControlId",
                        column: x => x.FormControlId,
                        principalTable: "FormControls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attachments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttachmentName = table.Column<string>(maxLength: 50, nullable: false),
                    Comments = table.Column<string>(maxLength: 255, nullable: true),
                    MasterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attachments_Masters_MasterId",
                        column: x => x.MasterId,
                        principalTable: "Masters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_MasterId",
                table: "Attachments",
                column: "MasterId");

            migrationBuilder.CreateIndex(
                name: "IX_FormControls_FormId",
                table: "FormControls",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_FormValues_FormControlId",
                table: "FormValues",
                column: "FormControlId");

            migrationBuilder.CreateIndex(
                name: "IX_Masters_FormId",
                table: "Masters",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_Validations_FormControlId",
                table: "Validations",
                column: "FormControlId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attachments");

            migrationBuilder.DropTable(
                name: "FormValues");

            migrationBuilder.DropTable(
                name: "Validations");

            migrationBuilder.DropTable(
                name: "Masters");

            migrationBuilder.DropTable(
                name: "FormControls");

            migrationBuilder.DropTable(
                name: "Forms");
        }
    }
}
