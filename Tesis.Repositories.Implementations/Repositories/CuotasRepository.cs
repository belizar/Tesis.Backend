using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tesis.Models.Dominio.Credito;
using Tesis.Repositories.Definition.Repositories;
using Tesis.Repositories.Implementations;

namespace Tesis.Repositories.Implementation.Repositories
{
    public class CuotasRepository : RepositoryBase<Cuota>, ICuotasRepository
    {
        private readonly AlimaDataContext context;

        public CuotasRepository(AlimaDataContext context) : base(context)
        {
            this.context = context;
        }

        public async Task CreateMany(List<Cuota> cuotas)
        {
            await this.context.AddRangeAsync(cuotas);
        }

        public Task CreateMany(IEnumerable<Cuota> cuotas)
        {
            throw new NotImplementedException();
        }
    }
}
