using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Tesis.Models.Dominio.Movimientos;
using Tesis.Repositories.Definition.Repositories;
using Tesis.Repositories.Implementations;

namespace Tesis.Repositories.Implementation.Repositories
{
    public class MovimientoRepository : RepositoryBase<Movimiento>, IMovimientosRepository
    {
        private AlimaDataContext context;

        public MovimientoRepository(AlimaDataContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<Movimiento> GetLast()
        =>  await  Task.FromResult(this.context
                       .Movimientos
                       .OrderByDescending(x => x.ID)
                       .FirstOrDefault());
    }
}