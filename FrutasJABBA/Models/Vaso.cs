using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrutasJABBA.Models
{
    public class Vaso
    {
        [Key]
        public int IDVaso { get; set; }
        [Required]
        public int IDTamano { get; set; }
        [ForeignKey(nameof(IDTamano))]
        public TamanoVaso TamanoVaso { get; set; }
        [Required]
        public int IDPedido { get; set; }
        [ForeignKey(nameof(IDPedido))]
        public Pedido Pedido { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal CostoProduccion { get; set; }
    }
}
