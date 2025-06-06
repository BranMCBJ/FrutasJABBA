using System.ComponentModel.DataAnnotations;

namespace FrutasJABBA.Models
{
    public class Dia
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Fecha { get; set; }        
    }
}
