using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FrutasJABBA.Migrations
{
    /// <inheritdoc />
    public partial class quintaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdEstado",
                table: "EstadosFrutas",
                newName: "IDEstado");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IDEstado",
                table: "EstadosFrutas",
                newName: "IdEstado");
        }
    }
}
