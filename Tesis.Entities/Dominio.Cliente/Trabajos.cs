using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Tesis.Models.Dominio.Cliente;

namespace Tesis.Models.Dominio.Cliente
{
    public class Trabajo : EntidadBase
    {

        
        public string LugarDeTrabajo { get; set; }
        public long? CUIT { get; set; }
        public decimal Sueldo { get; set; }
        public string Cargo { get; set; }
        public DateTime FechaDeIngreso { get; set; }
        public virtual Domicilio DomicilioLaboral { get; set; }
        public long TelefonoLaboral { get; set; }

        public Cliente Cliente { get; set; }
        public int ClienteID { get; set; }
    }
}