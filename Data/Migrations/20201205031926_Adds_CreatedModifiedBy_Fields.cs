using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DQMA.Data.Migrations
{
    public partial class Adds_CreatedModifiedBy_Fields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "FormValues");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "FormValues");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "FormValues");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "FormValues");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Masters",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Masters",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "Masters",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Masters",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Forms",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Forms",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "Forms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Forms",
                maxLength: 450,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "Masters");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Masters");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "Masters");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Masters");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Forms");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "FormValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "FormValues",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "FormValues",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "FormValues",
                type: "int",
                nullable: true);
        }
    }
}
