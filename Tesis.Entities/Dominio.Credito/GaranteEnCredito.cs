using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tesis.Models.Dominio.Credito
{
    public class GaranteEnCredito : EntidadBase
    {

        public int GaranteID { get; set; }
        [ForeignKey("GaranteID")]
        public virtual Dominio.Cliente.Cliente Cliente { get; set; }

        public int? CreditoID { get; set; }

        [ForeignKey("CreditoID")]
        public virtual Credito Credito { get; set; }
    }
}