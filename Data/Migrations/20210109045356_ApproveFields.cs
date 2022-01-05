using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DQMA.Data.Migrations
{
    public partial class ApproveFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ApprovedDate",
                table: "Statements",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Statements",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "a37e9009-1386-4e1e-ae09-4587fa7feba6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "1968d7e1-acbd-4f4d-b871-16aa77ac6a69");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "dc817924-7b50-4af7-977d-051f0d85f7bb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93a82392-77c7-4fd9-aeb5-b79cda441c1b", "AQAAAAEAACcQAAAAEDP94typZdoJX9spU3XpSLtdav21bCUoD7niCwLedlfvSN+gQVRhiv0rPX7zfstpbQ==", "d22a57c9-22bc-4d09-9857-12f6f41ec684" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82551c96-5b1c-40f0-8cf0-df8ea098c913", "AQAAAAEAACcQAAAAEBxVKTNBBzcv06JCaFCrCB6Roh+JUOBsapm/kAQdAwMHQsO0Dg07JMy7+NA+qizHYw==", "e3fd4aa9-93bc-4bac-85e6-8a3f2dd2f477" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25092255-5c77-40b3-be6a-85ca07870845", "AQAAAAEAACcQAAAAEKVBiUL01XVEXt4iesKN/PBK6Y597C36mm0bu5rLWUUtSJybNCM+qKWl1QtAf44ROg==", "7ee83757-bd44-4e2b-b221-23d9f720667d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApprovedDate",
                table: "Statements");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Statements");

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
        }
    }
}
