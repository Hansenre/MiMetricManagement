using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiQualityPMO.Migrations
{
    public partial class Btp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Btp",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Factory = table.Column<string>(nullable: false),
                    FiscalYear = table.Column<string>(nullable: false),
                    Quarter = table.Column<string>(nullable: false),
                    WholeSalePrice = table.Column<double>(nullable: false),
                    WeightedCost = table.Column<double>(nullable: false),
                    MiRate = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Btp", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Btp");
        }
    }
}
