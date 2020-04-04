using System.Linq;
using System.Threading.Tasks;
using Tesis.Entities;
using Tesis.Models.Dominio.Credito;
using Tesis.Repositories.Definition.Repositories;
using Tesis.Repositories.Implementations;

namespace Tesis.Repositories.Implementation.Repositories
{
    public class EstadoDeCreditoRepository : RepositoryBase<EstadoDeCredito>, IEstadoDeCreditoRepository
    {
        private AlimaDataContext context;

        public EstadoDeCreditoRepository(AlimaDataContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<Page<EstadoDeCredito>> GetPage(int limit, int cursor)
        {
            var page = new Page<EstadoDeCredito>();

            var query = this.context
                             .EstadosDeCredito
                             .OrderBy(x => x.Nombre)
                             //.WhereIsNotNull(() => cursor > 0, x => x.ID >= cursor)
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