using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FrutasJABBA.Migrations
{
    /// <inheritdoc />
    public partial class addmigrationcuartaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Frutas_EstadoFruta_IDEstado",
                table: "Frutas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_EstadosPedido_IDEstado",
                table: "Pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstadosPedido",
                table: "EstadosPedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstadoFruta",
                table: "EstadoFruta");

            migrationBuilder.RenameTable(
                name: "EstadosPedido",
                newName: "EstadosPedidos");

            migrationBuilder.RenameTable(
                name: "EstadoFruta",
                newName: "EstadosFrutas");

            migrationBuilder.AlterColumn<string>(
                name: "Emoji",
                table: "Frutas",
                type: "varchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(5)",
                oldMaxLength: 5)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstadosPedidos",
                table: "EstadosPedidos",
                column: "IDEstado");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstadosFrutas",
                table: "EstadosFrutas",
                column: "IdEstado");

            migrationBuilder.AddForeignKey(
                name: "FK_Frutas_EstadosFrutas_IDEstado",
                table: "Frutas",
                column: "IDEstado",
                principalTable: "EstadosFrutas",
                principalColumn: "IdEstado",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_EstadosPedidos_IDEstado",
                table: "Pedidos",
                column: "IDEstado",
                principalTable: "EstadosPedidos",
                principalColumn: "IDEstado",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Frutas_EstadosFrutas_IDEstado",
                table: "Frutas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_EstadosPedidos_IDEstado",
                table: "Pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstadosPedidos",
                table: "EstadosPedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstadosFrutas",
                table: "EstadosFrutas");

            migrationBuilder.RenameTable(
                name: "EstadosPedidos",
                newName: "EstadosPedido");

            migrationBuilder.RenameTable(
                name: "EstadosFrutas",
                newName: "EstadoFruta");

            migrationBuilder.UpdateData(
                table: "Frutas",
                keyColumn: "Emoji",
                keyValue: null,
                column: "Emoji",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Emoji",
                table: "Frutas",
                type: "varchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(5)",
                oldMaxLength: 5,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstadosPedido",
                table: "EstadosPedido",
                column: "IDEstado");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstadoFruta",
                table: "EstadoFruta",
                column: "IdEstado");

            migrationBuilder.AddForeignKey(
                name: "FK_Frutas_EstadoFruta_IDEstado",
                table: "Frutas",
                column: "IDEstado",
                principalTable: "EstadoFruta",
                principalColumn: "IdEstado",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_EstadosPedido_IDEstado",
                table: "Pedidos",
                column: "IDEstado",
                principalTable: "EstadosPedido",
                principalColumn: "IDEstado",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
