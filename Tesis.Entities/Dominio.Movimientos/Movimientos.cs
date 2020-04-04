using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tesis.Models.Dominio.Movimientos
{
    public class Movimiento : EntidadBase
    {
        public int ID { get; set; }

        public DateTime Fecha { get; set; }

        public TiposDeMovimiento Tipo { get; set; }
        public int TipoId { get; set; }

        public string Concepto { get; set; }
        public decimal Monto { get; set; }
        public decimal Saldo { get; set; }
    }
}