using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tesis.Models.Dominio.Cliente
{
    public class Telefono : EntidadBase
    {

        
        public long Numero { get; set; }
        public string Descripcion { get; set; }

        public int ClienteID { get; set; }

        public Cliente Cliente { get; set; }
    }
}