using System.ComponentModel.DataAnnotations;

namespace FrutasJABBA.Models
{
    public class Cliente
    {
        [Key]
        public int IDCliente { get; set; }
        [StringLength(60)]
        public string Nombre { get; set; }
        [StringLength(60)]
        public string Apellido1 { get; set; }
        [StringLength(60)]
        public string Apellido2 { get; set; }
        [StringLength(20)]
        public string Telefono { get; set; }
        [StringLength(600)]
        public string Direccion { get; set; }
        public int Pedidos { get; set; } = 0;
    }
}
