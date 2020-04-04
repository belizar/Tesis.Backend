using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tesis.Models
{
    public abstract class EntidadBase
    {
        public int ID { get; set; }
        public bool Baja { get; set; }
    }
}