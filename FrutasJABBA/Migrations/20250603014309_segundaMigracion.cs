using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FrutasJABBA.Migrations
{
    /// <inheritdoc />
    public partial class segundaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "FDU",
                table: "Frutas",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FDU",
                table: "Frutas");
        }
    }
}
