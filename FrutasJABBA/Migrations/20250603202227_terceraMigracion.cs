using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FrutasJABBA.Migrations
{
    /// <inheritdoc />
    public partial class terceraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PromedioPerdida",
                table: "Frutas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PromedioPerdida",
                table: "Frutas",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
