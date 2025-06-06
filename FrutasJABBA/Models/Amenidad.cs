using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrutasJABBA.Models
{
    public class Amenidad
    {
        [Key]
        public int IDAmenidad { get; set; }
        public int StockActual { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal PrecioUnidad { get; set; }
        [StringLength(100)]
        public string Nombre { get; set; }
    }
}
