using System;
using System.Collections.Generic;
using System.Text;
using Tesis.Models.Dominio.Credito;

namespace Tesis.Repositories.Definition.Repositories
{
    public interface IEstadoDeCreditoRepository : IRepositoryBase<EstadoDeCredito>, IPaginatedRepository<EstadoDeCredito, int>
    {
    }
}
