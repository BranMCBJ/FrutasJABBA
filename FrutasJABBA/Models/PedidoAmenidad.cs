using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrutasJABBA.Models
{
    public class PedidoAmenidad
    {
        [Key]
        public int IDPedidoAmenidad { get; set; }
        [Required]        
        public int IDPedido { get; set; }
        [ForeignKey(nameof(IDPedido))]
        public Pedido Pedido { get; set; }
        [Required]        
        public int IDAmenidad { get; set; }
        [ForeignKey(nameof(IDAmenidad))]
        public Amenidad Amenidad { get; set; }
        [Required]
        public int Cantidad { get; set; }
    }
}
