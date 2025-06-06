using System.ComponentModel.DataAnnotations;

namespace FrutasJABBA.Models
{
    public class EstadoFruta
    {
        [Key]
        public int IDEstado { get; set; }
        [StringLength(60)]
        public string Estado { get; set; }
    }
}
