using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace maximo_P2_A2.Entities
{
    public class CobroDetalles
    {
        [Key]
        public int CobroDetalleId { get; set; }
        public double MontoVenta { get; set; }
        public double Cobrado{ get; set; }
        [ForeignKey("VentaId")]
        public int VentaId { set; get; }
        public int CobroId { set; get; }
    }
}