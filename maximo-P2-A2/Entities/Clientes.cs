using System.ComponentModel.DataAnnotations;

namespace maximo_P2_A2.Entities
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombres { get; set; }
    }
}