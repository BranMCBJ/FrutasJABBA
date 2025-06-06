using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrutasJABBA.Models
{
    public class Peso
    {
        [Key]
        public int IDPseo { get; set; }
        [Required]        
        public int IDTamano { get; set; }
        [ForeignKey(nameof(IDTamano))]
        public TamanoVaso TamanoVaso { get; set; }
        [Required]        
        public int IDFruta { get; set; }
        [ForeignKey(nameof(IDFruta))]
        public Fruta Fruta { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal PesoLeno { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal PorcionMax { get; set; }
    }
}
