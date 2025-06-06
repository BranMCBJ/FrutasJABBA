using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrutasJABBA.Models
{
    public class StockVaso
    {
        [Key]
        public int IDStock { get; set; }
        [Required]
        public int IDTamano { get; set; }
        [ForeignKey(nameof(IDTamano))]
        public TamanoVaso TamanoVaso { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal PrecioUnitario { get; set; }
        public int CantidadActual { get; set; }
        public int CantidadRequerida { get; set; }
    }
}
