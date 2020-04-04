using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tesis.Models.Dominio.Credito
{
    public class EstadoDeCredito : EntidadBase
    {
        public enum eId
        {
            PendienteDeAprobar = 1,
            ListoParaAprobar = 2,
            Aprobado = 3,
            Otorgado = 4,
            Cancelado = 5,
            Rechazado = 6,
            Anulado = 7
        }


        public string Nombre { get; set; }


        //public static EstadoDeCredito PendienteDeAprobar() => ObtenerEstado(eId.PendienteDeAprobar);
        //public static EstadoDeCredito ListoParaAprobar() => ObtenerEstado(eId.ListoParaAprobar);
        //public static EstadoDeCredito Aprobado() => ObtenerEstado(eId.Aprobado);
        //public static EstadoDeCredito Otorgado() => ObtenerEstado(eId.Otorgado);
        //public static EstadoDeCredito Cancelado() => ObtenerEstado(eId.Cancelado);
        //public static EstadoDeCredito Rechazado() => ObtenerEstado(eId.Rechazado);
        //public static EstadoDeCredito Anulado() => ObtenerEstado(eId.Anulado);

        //private static EstadoDeCredito ObtenerEstado(eId id)
        //{
        //    var repo = Injector.GetService<IDbContext>().GetRepository<EstadoDeCredito>();
        //    return repo.First(x => x.ID == (int)id);
        //}
    }
}