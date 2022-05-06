using Microsoft.EntityFrameworkCore.Migrations;

namespace MiQualityPMO.Migrations
{
    public partial class CopqBtp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PorRate",
                table: "Copq");

            migrationBuilder.DropColumn(
                name: "WeightedCost",
                table: "Btp");

            migrationBuilder.DropColumn(
                name: "WholeSalePrice",
                table: "Btp");

            migrationBuilder.AddColumn<double>(
                name: "WeightedCost",
                table: "Copq",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "WholeSalePrice",
                table: "Copq",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PorRate",
                table: "Btp",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WeightedCost",
                table: "Copq");

            migrationBuilder.DropColumn(
                name: "WholeSalePrice",
                table: "Copq");

            migrationBuilder.DropColumn(
                name: "PorRate",
                table: "Btp");

            migrationBuilder.AddColumn<double>(
                name: "PorRate",
                table: "Copq",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "WeightedCost",
                table: "Btp",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "WholeSalePrice",
                table: "Btp",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
