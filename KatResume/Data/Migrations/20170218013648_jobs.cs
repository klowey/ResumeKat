using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Resume.Data.Migrations
{
    public partial class jobs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobDate",
                table: "Jobs");

            migrationBuilder.AddColumn<DateTime>(
                name: "JobDateFrom",
                table: "Jobs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "JobDateTo",
                table: "Jobs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobDateFrom",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "JobDateTo",
                table: "Jobs");

            migrationBuilder.AddColumn<DateTime>(
                name: "JobDate",
                table: "Jobs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
