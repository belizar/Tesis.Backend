using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tesis.Models.Dominio.Credito
{
    public class Parametros : EntidadBase
    {
        public decimal TasaMora { get; set; }
        public decimal TEM { get; set; }
        public DateTime Fecha { get; set; }
    }
}