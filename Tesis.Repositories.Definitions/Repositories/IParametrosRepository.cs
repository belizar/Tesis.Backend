using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tesis.Models.Dominio.Credito;

namespace Tesis.Repositories.Definition.Repositories
{
    public interface IParametrosRepository : IRepositoryBase<Parametros>
    {
        Task KillAll();

        Task<Parametros> GetActive();
    }
}
