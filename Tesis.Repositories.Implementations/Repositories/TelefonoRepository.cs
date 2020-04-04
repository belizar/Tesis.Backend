using Tesis.Models.Dominio.Cliente;
using Tesis.Repositories.Definition.Repositories;
using Tesis.Repositories.Implementations;

namespace Tesis.Repositories.Implementation.Repositories
{
    public class TelefonoRepository : RepositoryBase<Telefono>, ITelefonoRepository
    {
        private AlimaDataContext context;

        public TelefonoRepository(AlimaDataContext context) : base(context)
        {
            this.context = context;
        }
    }
}