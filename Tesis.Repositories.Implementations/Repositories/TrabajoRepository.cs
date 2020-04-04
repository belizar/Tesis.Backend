using Tesis.Models.Dominio.Cliente;
using Tesis.Repositories.Definition.Repositories;
using Tesis.Repositories.Implementations;

namespace Tesis.Repositories.Implementation.Repositories
{
    public class TrabajoRepository : RepositoryBase<Trabajo>, ITrabajoRepository
    {
        private AlimaDataContext context;

        public TrabajoRepository(AlimaDataContext context) : base(context)
        {
            this.context = context;
        }
    }
}