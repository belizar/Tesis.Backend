using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tesis.Models.Dominio.Movimientos
{
    public class TiposDeMovimiento : EntidadBase
    {
        public enum EId
        {
            Debe = 1,
            Haber = 2
        }

        public string Nombre { get; set; }
    }
}