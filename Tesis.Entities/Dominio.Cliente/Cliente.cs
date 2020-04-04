using System;
using System.Collections.Generic;

namespace Tesis.Models.Dominio.Cliente
{
    
    public class Cliente : EntidadBase
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long CUIL { get; set; }
        public string Email { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public virtual IList<Trabajo> Trabajos { get; set; }
        public virtual IList<Telefono> Telefonos { get; set; }
        public virtual Domicilio DomicilioPersonal { get; set; }
        public int NroCliente { get; set; }
        public string NombreCompleto => $"{Apellido}, {Nombre}";
    }
}