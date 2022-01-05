using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DQMA.Data.Migrations
{
    public partial class InitialCreateStatement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachments_Masters_MasterId",
                table: "Attachments");

            migrationBuilder.DropTable(
                name: "FormValues");

            migrationBuilder.DropTable(
                name: "Masters");

            migrationBuilder.DropTable(
                name: "Validations");

            migrationBuilder.DropTable(
                name: "FormControls");

            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropIndex(
                name: "IX_Attachments_MasterId",
                table: "Attachments");

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

            migrationBuilder.DropColumn(
                name: "MasterId",
                table: "Attachments");

            migrationBuilder.AddColumn<string>(
                name: "AttachmentUrl",
                table: "Attachments",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatementId",
                table: "Attachments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CrimeTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrimeTypeName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrimeTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OfficerRanks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RankName = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficerRanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parishes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParishName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parishes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rejections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatementId = table.Column<int>(nullable: false),
                    Comments = table.Column<string>(maxLength: 255, nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 450, nullable: true),
                    Modified = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rejections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 50, nullable: true),
                    Phone = table.Column<string>(maxLength: 25, nullable: true),
                    Email = table.Column<string>(maxLength: 25, nullable: true),
                    CrimeTypeId = table.Column<int>(nullable: false),
                    IncidentDate = table.Column<DateTime>(nullable: false),
                    ParishId = table.Column<int>(nullable: false),
                    CountryId = table.Column<int>(nullable: false),
                    PropertyDescription = table.Column<string>(maxLength: 150, nullable: true),
                    TotalEstimate = table.Column<double>(nullable: false),
                    TotalAmountStolen = table.Column<double>(nullable: false),
                    SuspectName = table.Column<string>(maxLength: 50, nullable: true),
                    SuspectAddress = table.Column<string>(maxLength: 50, nullable: true),
                    SuspectParishId = table.Column<int>(nullable: false),
                    SuspectCountryId = table.Column<int>(nullable: false),
                    SuspectDescription = table.Column<string>(maxLength: 150, nullable: true),
                    IsVictim = table.Column<bool>(nullable: false),
                    OfficerName = table.Column<string>(nullable: true),
                    OfficerRankId = table.Column<int>(nullable: false),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 450, nullable: true),
                    Modified = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Statements_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Statements_CrimeTypes_CrimeTypeId",
                        column: x => x.CrimeTypeId,
                        principalTable: "CrimeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Statements_OfficerRanks_OfficerRankId",
                        column: x => x.OfficerRankId,
                        principalTable: "OfficerRanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Statements_Parishes_ParishId",
                        column: x => x.ParishId,
                        principalTable: "Parishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_StatementId",
                table: "Attachments",
                column: "StatementId");

            migrationBuilder.CreateIndex(
                name: "IX_Statements_CountryId",
                table: "Statements",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Statements_CrimeTypeId",
                table: "Statements",
                column: "CrimeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Statements_OfficerRankId",
                table: "Statements",
                column: "OfficerRankId");

            migrationBuilder.CreateIndex(
                name: "IX_Statements_ParishId",
                table: "Statements",
                column: "ParishId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachments_Statements_StatementId",
                table: "Attachments",
                column: "StatementId",
                principalTable: "Statements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachments_Statements_StatementId",
                table: "Attachments");

            migrationBuilder.DropTable(
                name: "Rejections");

            migrationBuilder.DropTable(
                name: "Statements");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "CrimeTypes");

            migrationBuilder.DropTable(
                name: "OfficerRanks");

            migrationBuilder.DropTable(
                name: "Parishes");

            migrationBuilder.DropIndex(
                name: "IX_Attachments_StatementId",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "AttachmentUrl",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "StatementId",
                table: "Attachments");

            migrationBuilder.AddColumn<int>(
                name: "MasterId",
                table: "Attachments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comments = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    FormName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormControls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comments = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DataType = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FieldName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    ListValues = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comments = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormControlId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comments = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FormControlId = table.Column<int>(type: "int", nullable: false),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    Rule = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ValidationName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
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

            migrationBuilder.AddForeignKey(
                name: "FK_Attachments_Masters_MasterId",
                table: "Attachments",
                column: "MasterId",
                principalTable: "Masters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
