using Tesis.Models.Dominio.Movimientos;
using Tesis.Repositories.Definition.Repositories;
using Tesis.Repositories.Implementations;

namespace Tesis.Repositories.Implementation.Repositories
{
    public class TiposDeMovimientoRepository : RepositoryBase<TiposDeMovimiento>, ITiposDeMovimientoRepository
    {
        private AlimaDataContext context;

        public TiposDeMovimientoRepository(AlimaDataContext context) : base(context)
        {
            this.context = context;
        }
    }
}