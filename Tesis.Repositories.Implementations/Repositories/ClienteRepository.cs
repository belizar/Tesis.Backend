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

        public async Task<Page<Cliente>> GetPage(int limit, int cursor)
        {

            var page = new Page<Cliente>();

            var query = this.context
                             .Clientes
                             .OrderBy(x => x.ID)
                             .WhereIsNotNull(() => cursor > 0, x => x.ID >= cursor)
                             .Take(limit + 1);


            page.Data = await query.ToListAsyncSafe();

            if (page.Data.Count() == (limit + 1))
            {
                page.PreviousId = cursor;
                page.NextId = page.Data.Last().ID;
                page.Data = page.Data.Where(x => x.ID != page.NextId);
                page.HasNextPage = true;
            }
            
            return await Task.FromResult(page);
        }

        public override IQueryable<Cliente> CustomFindAll(DbSet<Cliente> set)
        {
            return set.Include(x => x.Trabajos)
                      .Include(x => x.Telefonos)
                      .AsQueryable();
        }
    }
}