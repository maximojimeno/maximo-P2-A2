using System.ComponentModel.DataAnnotations;

namespace maximo_P2_A2.Entities
{
    public class CobrosDetalle
    {
        [Key]
        public int CobroDetalleId { get; set; }
        public int CobroId { get; set; }
        public int VentaId { get; set; }
        public decimal Monto { get; set; }
    }
}