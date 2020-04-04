using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tesis.Models.Dominio.Credito;

namespace Tesis.API.GraphQL.Types
{
    public class PageEstadoDeCreditoType : PageType<EstadoDeCredito, EstadoDeCreditoType>
    {
        public PageEstadoDeCreditoType() : base()
        {
            Name = "PageEstadoDeCredito";
        }
    }
}
