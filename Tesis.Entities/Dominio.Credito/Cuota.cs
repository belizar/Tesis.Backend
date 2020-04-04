using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tesis.Models.Dominio.Credito
{
    public class Cuota : EntidadBase
    {

        public int Numero { get; set; }

        public decimal Monto { get; set; }

        public decimal MontoPorMora { get; set; }

        public decimal Interes { get; set; }

        public DateTime Vencimiento { get; set; }

        [DefaultValue(null)]
        public DateTime? FechaDePago { get; set; }

        [DefaultValue(false)]
        public bool Pagada { get; set; }

        [ForeignKey("Credito_ID")]
        public Credito Credito { get; set; }
        public int Credito_ID { get; set; }

        public int DiasDeMora { get; set; }
    }
}