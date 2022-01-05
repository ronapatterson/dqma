using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DQMA.Data.Migrations
{
    public partial class ParishStatementNullFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "TotalEstimate",
                table: "Statements",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "TotalAmountStolen",
                table: "Statements",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "SuspectParishId",
                table: "Statements",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SuspectCountryId",
                table: "Statements",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedAt",
                table: "Statements",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "TotalEstimate",
                table: "Statements",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalAmountStolen",
                table: "Statements",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SuspectParishId",
                table: "Statements",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SuspectCountryId",
                table: "Statements",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedAt",
                table: "Statements",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "bbaacd9b-87ca-4398-9016-dc61a4acbbce");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "4b278b9b-5bb9-4fa7-81a1-dd5e5ef6a4c4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "5387f721-e9c7-41cf-ba13-0f79260360ed");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea76add9-07aa-448b-a80c-0a20b1f6e713", "AQAAAAEAACcQAAAAEHA6ngiyvdA38OhfeU2TbNYza5Zw9NjDO07hlt9qNMMMgCTTxT5v5BmlVBJdO3ddpg==", "17e813af-8674-4e37-af94-d68c6d31cf0f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca8e9cf4-96fd-49d0-972f-446d8cd2d2cd", "AQAAAAEAACcQAAAAEP15mp4ilHUnHk1wJX2TX5NJsWFsV5se7mbl6jSFFbNvSDxG/F2Y1Jr4x2pUsI3mmw==", "b47cbe20-e549-4820-97c0-97f720ccef2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9326b143-1d9c-4f7a-bdf4-e64a089993de", "AQAAAAEAACcQAAAAEAOjH7MpAdWpYt47Htm9uypVV9qQc+Rt8Day8mG6i2EtQYEf3Pph9oalCGGY4P+jsA==", "d48d05bf-8fd3-47d5-8f0c-693bc4204edc" });
        }
    }
}
