using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace maximo_P2_A2.Entities
{
    public class Cobros
    {
        [Key]
        public int CobroId { get; set; }
        public DateTime Fecha { get; set; }
        public double MontoCobrado { get; set; }
        public string Observaciones { get; set; }
        [ForeignKey("ClienteId")]
        public int ClienteId { set; get; }
        public Clientes clientes { get; set; }
        [ForeignKey("CobroId")]
        public  virtual List<CobroDetalles> detalle { get; set; }
    }
}