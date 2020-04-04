using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tesis.Models.Dominio.Credito
{
    public class Credito : EntidadBase
    {
        public Cliente.Cliente Propietario { get; set; }
        public Cliente.Cliente Garante { get; set; }
        public virtual IList<GaranteEnCredito> Garantes { get; set; }
        public virtual IList<Cuota> Cuotas { get; set; }
        public Parametros Parametro { get; set; }
        public EstadoDeCredito EstadoActual { get; set; }
        public decimal GastosAdministrativos { get; set; }
        public DateTime FechaAlta { get; set; }
        public int EstadoDeCreditoID { get; set; }
        public int PropietarioID { get; set; }
        public int GaranteID { get; set; }
        public int ParametroID { get; set; }
        public int? SituacionCrediticia { get; set; }
        public decimal MontoSolicitado { get; set; }
        public int NroCredito { get; set; }
        
        //public int? CreditoRelacionadoID { get; set; }
        //[ForeignKey("CreditoRelacionadoID")]
        //public Credito CreditoRelacionado { get; set; }

    }
}