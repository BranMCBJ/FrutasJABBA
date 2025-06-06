using Microsoft.EntityFrameworkCore;

namespace FrutasJABBA.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FrutasJABBA.Models.Amenidad> Amenidades { get; set; }
        public DbSet<FrutasJABBA.Models.Cliente> Clientes { get; set; }
        public DbSet<FrutasJABBA.Models.EstadoPedido> EstadosPedidos { get; set; }
        public DbSet<FrutasJABBA.Models.Fruta> Frutas { get; set; }
        public DbSet<FrutasJABBA.Models.PaqueteVaso> PaquetesVasos { get; set; }
        public DbSet<FrutasJABBA.Models.Pedido> Pedidos { get; set; }
        public DbSet<FrutasJABBA.Models.PedidoAmenidad> PedidosAmenidades { get; set; }
        public DbSet<FrutasJABBA.Models.Peso> Pesos { get; set; }
        public DbSet<FrutasJABBA.Models.StockFruta> StocksFrutas { get; set; }
        public DbSet<FrutasJABBA.Models.StockVaso> StocksVasos { get; set; }
        public DbSet<FrutasJABBA.Models.TamanoVaso> TamanosVasos { get; set; }
        public DbSet<FrutasJABBA.Models.Vaso> Vasos { get; set; }
        public DbSet<FrutasJABBA.Models.VasoFruta> VasosFrutas { get; set; }
        public DbSet<FrutasJABBA.Models.EstadoFruta> EstadosFrutas { get; set; }
    }
}
