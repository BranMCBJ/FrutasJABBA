using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FrutasJABBA.Migrations
{
    /// <inheritdoc />
    public partial class primeraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Amenidades",
                columns: table => new
                {
                    IDAmenidad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StockActual = table.Column<int>(type: "int", nullable: false),
                    PrecioUnidad = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenidades", x => x.IDAmenidad);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IDCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido1 = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido2 = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(600)", maxLength: 600, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Pedidos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IDCliente);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EstadoFruta",
                columns: table => new
                {
                    IdEstado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Estado = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoFruta", x => x.IdEstado);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EstadosPedido",
                columns: table => new
                {
                    IDEstado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Estado = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosPedido", x => x.IDEstado);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TamanosVasos",
                columns: table => new
                {
                    IDTamano = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tamano = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TamanosVasos", x => x.IDTamano);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Frutas",
                columns: table => new
                {
                    IDFruta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IDEstado = table.Column<int>(type: "int", nullable: false),
                    Variable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Emoji = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrecioG = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    PesoActual = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    PesoRequerido = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    PromedioPerdida = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frutas", x => x.IDFruta);
                    table.ForeignKey(
                        name: "FK_Frutas_EstadoFruta_IDEstado",
                        column: x => x.IDEstado,
                        principalTable: "EstadoFruta",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    IDPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IDCliente = table.Column<int>(type: "int", nullable: false),
                    IDEstado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaEntrega = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CostoProduccion = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    PrecioVenta = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.IDPedido);
                    table.ForeignKey(
                        name: "FK_Pedidos_Clientes_IDCliente",
                        column: x => x.IDCliente,
                        principalTable: "Clientes",
                        principalColumn: "IDCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_EstadosPedido_IDEstado",
                        column: x => x.IDEstado,
                        principalTable: "EstadosPedido",
                        principalColumn: "IDEstado",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PaquetesVasos",
                columns: table => new
                {
                    IDPaquete = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IDTamano = table.Column<int>(type: "int", nullable: false),
                    PrecioPaquete = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaquetesVasos", x => x.IDPaquete);
                    table.ForeignKey(
                        name: "FK_PaquetesVasos_TamanosVasos_IDTamano",
                        column: x => x.IDTamano,
                        principalTable: "TamanosVasos",
                        principalColumn: "IDTamano",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StocksVasos",
                columns: table => new
                {
                    IDStock = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IDTamano = table.Column<int>(type: "int", nullable: false),
                    PrecioUnitario = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    CantidadActual = table.Column<int>(type: "int", nullable: false),
                    CantidadRequerida = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StocksVasos", x => x.IDStock);
                    table.ForeignKey(
                        name: "FK_StocksVasos_TamanosVasos_IDTamano",
                        column: x => x.IDTamano,
                        principalTable: "TamanosVasos",
                        principalColumn: "IDTamano",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pesos",
                columns: table => new
                {
                    IDPseo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IDTamano = table.Column<int>(type: "int", nullable: false),
                    IDFruta = table.Column<int>(type: "int", nullable: false),
                    PesoLeno = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    PorcionMax = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pesos", x => x.IDPseo);
                    table.ForeignKey(
                        name: "FK_Pesos_Frutas_IDFruta",
                        column: x => x.IDFruta,
                        principalTable: "Frutas",
                        principalColumn: "IDFruta",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pesos_TamanosVasos_IDTamano",
                        column: x => x.IDTamano,
                        principalTable: "TamanosVasos",
                        principalColumn: "IDTamano",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StocksFrutas",
                columns: table => new
                {
                    IDStock = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IDFruta = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    PesoTotal = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    PesoUtilizable = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    FDU = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StocksFrutas", x => x.IDStock);
                    table.ForeignKey(
                        name: "FK_StocksFrutas_Frutas_IDFruta",
                        column: x => x.IDFruta,
                        principalTable: "Frutas",
                        principalColumn: "IDFruta",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PedidosAmenidades",
                columns: table => new
                {
                    IDPedidoAmenidad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IDPedido = table.Column<int>(type: "int", nullable: false),
                    IDAmenidad = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidosAmenidades", x => x.IDPedidoAmenidad);
                    table.ForeignKey(
                        name: "FK_PedidosAmenidades_Amenidades_IDAmenidad",
                        column: x => x.IDAmenidad,
                        principalTable: "Amenidades",
                        principalColumn: "IDAmenidad",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidosAmenidades_Pedidos_IDPedido",
                        column: x => x.IDPedido,
                        principalTable: "Pedidos",
                        principalColumn: "IDPedido",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Vasos",
                columns: table => new
                {
                    IDVaso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IDTamano = table.Column<int>(type: "int", nullable: false),
                    IDPedido = table.Column<int>(type: "int", nullable: false),
                    CostoProduccion = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vasos", x => x.IDVaso);
                    table.ForeignKey(
                        name: "FK_Vasos_Pedidos_IDPedido",
                        column: x => x.IDPedido,
                        principalTable: "Pedidos",
                        principalColumn: "IDPedido",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vasos_TamanosVasos_IDTamano",
                        column: x => x.IDTamano,
                        principalTable: "TamanosVasos",
                        principalColumn: "IDTamano",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "VasosFrutas",
                columns: table => new
                {
                    IDVasoFruta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IDVaso = table.Column<int>(type: "int", nullable: false),
                    IDFruta = table.Column<int>(type: "int", nullable: false),
                    Gramaje = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VasosFrutas", x => x.IDVasoFruta);
                    table.ForeignKey(
                        name: "FK_VasosFrutas_Frutas_IDFruta",
                        column: x => x.IDFruta,
                        principalTable: "Frutas",
                        principalColumn: "IDFruta",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VasosFrutas_Vasos_IDVaso",
                        column: x => x.IDVaso,
                        principalTable: "Vasos",
                        principalColumn: "IDVaso",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Frutas_IDEstado",
                table: "Frutas",
                column: "IDEstado");

            migrationBuilder.CreateIndex(
                name: "IX_PaquetesVasos_IDTamano",
                table: "PaquetesVasos",
                column: "IDTamano");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_IDCliente",
                table: "Pedidos",
                column: "IDCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_IDEstado",
                table: "Pedidos",
                column: "IDEstado");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosAmenidades_IDAmenidad",
                table: "PedidosAmenidades",
                column: "IDAmenidad");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosAmenidades_IDPedido",
                table: "PedidosAmenidades",
                column: "IDPedido");

            migrationBuilder.CreateIndex(
                name: "IX_Pesos_IDFruta",
                table: "Pesos",
                column: "IDFruta");

            migrationBuilder.CreateIndex(
                name: "IX_Pesos_IDTamano",
                table: "Pesos",
                column: "IDTamano");

            migrationBuilder.CreateIndex(
                name: "IX_StocksFrutas_IDFruta",
                table: "StocksFrutas",
                column: "IDFruta");

            migrationBuilder.CreateIndex(
                name: "IX_StocksVasos_IDTamano",
                table: "StocksVasos",
                column: "IDTamano");

            migrationBuilder.CreateIndex(
                name: "IX_Vasos_IDPedido",
                table: "Vasos",
                column: "IDPedido");

            migrationBuilder.CreateIndex(
                name: "IX_Vasos_IDTamano",
                table: "Vasos",
                column: "IDTamano");

            migrationBuilder.CreateIndex(
                name: "IX_VasosFrutas_IDFruta",
                table: "VasosFrutas",
                column: "IDFruta");

            migrationBuilder.CreateIndex(
                name: "IX_VasosFrutas_IDVaso",
                table: "VasosFrutas",
                column: "IDVaso");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaquetesVasos");

            migrationBuilder.DropTable(
                name: "PedidosAmenidades");

            migrationBuilder.DropTable(
                name: "Pesos");

            migrationBuilder.DropTable(
                name: "StocksFrutas");

            migrationBuilder.DropTable(
                name: "StocksVasos");

            migrationBuilder.DropTable(
                name: "VasosFrutas");

            migrationBuilder.DropTable(
                name: "Amenidades");

            migrationBuilder.DropTable(
                name: "Frutas");

            migrationBuilder.DropTable(
                name: "Vasos");

            migrationBuilder.DropTable(
                name: "EstadoFruta");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "TamanosVasos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "EstadosPedido");
        }
    }
}
