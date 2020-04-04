using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tesis.Models.Dominio.Credito
{
    public class ReciboDeCuota
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public DateTime FechaDePago { get; set; }

        [ForeignKey("Cuota_ID")]
        public Cuota Cuota { get; set; }
        public int Cuota_ID { get; set; }
    }
}