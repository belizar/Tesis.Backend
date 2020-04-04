using System.Linq;
using System.Threading.Tasks;
using Tesis.Entities;
using Tesis.Models.Dominio.Credito;
using Tesis.Repositories.Definition.Repositories;
using Tesis.Repositories.Implementations;

namespace Tesis.Repositories.Implementation.Repositories
{
    public class CreditoRepository : RepositoryBase<Credito>, ICreditoRepository
    {
        private AlimaDataContext context;

        public CreditoRepository(AlimaDataContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<Page<Credito>> GetPage(int limit, int cursor)
        {
            var page = new Page<Credito>();

            var query = this.context
                             .Creditos
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
    }
}