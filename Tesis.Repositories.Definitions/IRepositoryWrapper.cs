using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using Tesis.Repositories.Definition.Repositories;

namespace Tesis.Repositories.Definition
{
    public interface IRepositoryWrapper
    {
        ITrabajoRepository Trabajos { get; }
        IClienteRepository Clientes { get; }
        IEstadoDeCreditoRepository EstadosDeCredito { get; }
        ITelefonoRepository Telefonos { get; }
        ITiposDeMovimientoRepository TiposDeMovimiento { get; }
        IMovimientosRepository Movimientos { get; }
        ICreditoRepository Creditos { get; }
        IParametrosRepository Parametros { get; }
        ICuotasRepository Cuotas { get; }
        Task SaveAsync();

        Task<IDbContextTransaction> BeginTransaction();

        Task Commit();
    }
}
