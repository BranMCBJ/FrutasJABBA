using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrutasJABBA.Models
{
    public class Fruta
    {
        public Fruta(int iDFruta, int iDEstado, EstadoFruta estado, bool variable, string nombre, string emoji, decimal precioG, decimal pesoActual, decimal pesoRequerido, decimal fDU)
        {
            IDFruta = iDFruta;
            IDEstado = iDEstado;
            Estado = estado;
            Variable = variable;
            Nombre = nombre;
            Emoji = emoji;
            PrecioG = precioG;
            PesoActual = pesoActual;
            PesoRequerido = pesoRequerido;
            FDU = fDU;
        }

        public Fruta() { }

        [Key]
        public int IDFruta { get; set; }
        [Required]
        public int IDEstado { get; set; }
        [ForeignKey(nameof(IDEstado))]
        public EstadoFruta Estado { get; set; }
        public bool Variable { get; set; } = false;
        [StringLength(50)]
        public string Nombre { get; set; }
        [StringLength(5)]
        public string? Emoji { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal PrecioG { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal PesoActual { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal PesoRequerido { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal FDU { get; set; }
    }
}
