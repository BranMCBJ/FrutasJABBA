using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrutasJABBA.Models
{
    public class Pedido
    {
        [Key]
        public int IDPedido { get; set; }
        [Required]        
        public int IDCliente { get; set; }
        [ForeignKey(nameof(IDCliente))]
        public Cliente Cliente { get; set; }
        [Required]        
        public int IDEstado { get; set; }
        [ForeignKey(nameof(IDEstado))]
        public EstadoPedido EstadoPedido { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaEntrega { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal CostoProduccion { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal PrecioVenta { get; set; }
    }
}
