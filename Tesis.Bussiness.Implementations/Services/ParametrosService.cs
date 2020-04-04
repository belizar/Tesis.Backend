using System;
using System.Threading.Tasks;
using Tesis.Bussiness.Definition;
using Tesis.Models.Dominio.Credito;
using Tesis.Repositories.Definition;

namespace Tesis.Bussiness.Implementation.Services
{
    public class ParametrosService : IParametrosService
    {
        private readonly IRepositoryWrapper wrapper;

        public ParametrosService(IRepositoryWrapper wrapper)
        {
            this.wrapper = wrapper;
        }
        public async Task Save(Parametros entity)
        {
            using(var tran = await this.wrapper.BeginTransaction())
            {
                entity.Fecha = new DateTime();
                await this.wrapper.Parametros.KillAll();
                await this.wrapper.Parametros.Create(entity);
                await this.wrapper.SaveAsync();
                tran.Commit();
            }
        }
    }
}
