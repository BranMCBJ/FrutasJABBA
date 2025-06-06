using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrutasJABBA.Models
{
    public class PaqueteVaso
    {
        [Key]
        public int IDPaquete { get; set; }
        [Required]        
        public int IDTamano { get; set; }
        [ForeignKey(nameof(IDTamano))]
        public TamanoVaso TamanoVaso { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal PrecioPaquete { get; set; }
        public int Cantidad{ get; set; }
    }
}
