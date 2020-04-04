using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tesis.Models.Dominio.Cliente;

namespace Tesis.Repositories.Definition.Repositories
{
    public interface IClienteRepository : IRepositoryBase<Cliente>, IPaginatedRepository<Cliente, int>
    {
        Task<IEnumerable<Cliente>> GetBy(string firstname, string lastname, long cuil);
    }
}
