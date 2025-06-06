using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrutasJABBA.Models
{
    public class TamanoVaso
    {
        [Key]
        public int IDTamano { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Tamano { get; set; }
    }
}
