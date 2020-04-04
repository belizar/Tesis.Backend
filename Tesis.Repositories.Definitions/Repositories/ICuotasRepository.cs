using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tesis.Models.Dominio.Credito;

namespace Tesis.Repositories.Definition.Repositories
{
    public interface ICuotasRepository : IRepositoryBase<Cuota>
    {
        Task CreateMany(IEnumerable<Cuota> cuotas);
    }
}
