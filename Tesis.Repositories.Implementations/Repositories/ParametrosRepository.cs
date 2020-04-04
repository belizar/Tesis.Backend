using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesis.Models.Dominio.Credito;
using Tesis.Repositories.Definition;
using Tesis.Repositories.Definition.Repositories;
using Tesis.Repositories.Implementations;

namespace Tesis.Repositories.Implementation.Repositories
{
    public class ParametrosRepository : RepositoryBase<Parametros>, IParametrosRepository
    {
        private readonly AlimaDataContext context;

        public ParametrosRepository(AlimaDataContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<Parametros> GetActive()
        {
            var all = await FindAll();

            return all.FirstOrDefault();
        }

        public async Task KillAll()
        {
           var parames = await this.context.Parametros.ToListAsyncSafe();
            this.context.Parametros.UpdateRange(parames.Select(param => { param.Baja = true; return param; }));
        }
    }
}
