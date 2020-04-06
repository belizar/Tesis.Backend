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

        public async Task<Page<Credito>> GetPage(int take, int skip)
        {
            return await GetPage(this.context.Creditos, take, skip);
        }
    }
}