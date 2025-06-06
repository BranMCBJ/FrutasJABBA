using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrutasJABBA.Models
{
    public class StockFruta
    {
        [Key]
        public int IDStock { get; set; }
        [Required]
        public int IDFruta { get; set; }
        [ForeignKey(nameof(IDFruta))]
        public Fruta Fruta { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Precio { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal PesoTotal { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal PesoUtilizable { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal FDU { get; set; }
    }
}
