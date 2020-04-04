using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tesis.Models.Dominio.Movimientos;

namespace Tesis.Repositories.Definition.Repositories
{
    public interface IMovimientosRepository : IRepositoryBase<Movimiento>
    {
        Task<Movimiento> GetLast();
    }
}
