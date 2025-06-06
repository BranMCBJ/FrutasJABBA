using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrutasJABBA.Models
{
    public class VasoFruta
    {
        [Key]
        public int IDVasoFruta { get; set; }
        [Required]
        public int IDVaso { get; set; }
        [ForeignKey(nameof(IDVaso))]
        public Vaso Vaso { get; set; }
        [Required]
        public int IDFruta { get; set; }
        [ForeignKey(nameof(IDFruta))]
        public Fruta Fruta { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Gramaje { get; set; }
    }
}
