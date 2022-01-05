using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DQMA.Data.Migrations
{
    public partial class StatusFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApprovedDate",
                table: "Statements");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Statements");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Statements",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StatusDate",
                table: "Statements",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "9779942f-0545-4356-8098-663784ee6b82");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "b6e7d2d2-79cd-44ed-82ba-224f54bb50b6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "96441cfb-1c57-4abc-b479-cb27be67c194");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "416d53b4-5f53-40bc-98f5-71bc67ddd376", "AQAAAAEAACcQAAAAEPQEwDOFTPppUhNZUVxEv2vo/W5VhdfByWexWS5puXvnNcVGgKgBArdwnnxngFSAGQ==", "6b0ed40e-82f3-420d-bf29-3b3d6e2fe87a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ec98109-d1fd-420f-8a6d-7ff02be8b9ec", "AQAAAAEAACcQAAAAEJnzjqn469ksS0oAzRRdt/ZZTv+e0I4KE7CnTbyZl2sNE/YrXyBKR83jKD27rUBygw==", "bd459ae4-1efb-4cd4-8aec-6aca61facf4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71975c14-ac73-4ec0-a1d2-06c168fba3d0", "AQAAAAEAACcQAAAAELSY/QgatNXLzA7n63psV6BULLdlH/AO156qUTgxTx0rwqahECrWmlMqjBAEFvt+LQ==", "5fc9d6cb-7aa5-4826-9157-df75eaece46c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Statements");

            migrationBuilder.DropColumn(
                name: "StatusDate",
                table: "Statements");

            migrationBuilder.AddColumn<DateTime>(
                name: "ApprovedDate",
                table: "Statements",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Statements",
                type: "bit",
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
    }
}
