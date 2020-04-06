using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tesis.Entities;
using Tesis.Models.Dominio.Cliente;
using Tesis.Repositories.Definition.Repositories;
using Tesis.Repositories.Implementations;

namespace Tesis.Repositories.Implementation.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        private AlimaDataContext context;

        public ClienteRepository(AlimaDataContext context) : base(context)
        {
            this.context = context;
        }

        //TODO: Implement getBy logic 
        public Task<IEnumerable<Cliente>> GetBy(string firstname, string lastname, long cuil)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Page<Cliente>> GetPage(int take, int skip)
        {

            return await GetPage(this.context.Clientes, take, skip);
        }

        public override IQueryable<Cliente> CustomFindAll(DbSet<Cliente> set)
        {
            return set.Include(x => x.Trabajos)
                      .Include(x => x.Telefonos)
                      .AsQueryable();
        }
    }
}