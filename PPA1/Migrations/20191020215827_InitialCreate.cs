using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PPA1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BMILogs",
                columns: table => new
                {
                    timestamp = table.Column<DateTime>(nullable: false),
                    heightFeet = table.Column<double>(nullable: false),
                    heightInches = table.Column<double>(nullable: false),
                    weight = table.Column<double>(nullable: false),
                    result = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BMILogs", x => x.timestamp);
                });

            migrationBuilder.CreateTable(
                name: "DistanceLogs",
                columns: table => new
                {
                    timestamp = table.Column<DateTime>(nullable: false),
                    x1 = table.Column<double>(nullable: false),
                    y1 = table.Column<double>(nullable: false),
                    x2 = table.Column<double>(nullable: false),
                    y2 = table.Column<double>(nullable: false),
                    result = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistanceLogs", x => x.timestamp);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BMILogs");

            migrationBuilder.DropTable(
                name: "DistanceLogs");
        }
    }
}
