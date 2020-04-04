using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Tesis.Bussiness.Definition;
using Tesis.Models.Dominio.Cliente;
using Tesis.Repositories.Definition;

namespace Tesis.Bussiness.Implementation.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IRepositoryWrapper wrapper;

        public ClienteService(IRepositoryWrapper wrapper)
        {
            this.wrapper = wrapper;
        }

        public async Task Delete(string id)
        {
            using(var tran = await this.wrapper.BeginTransaction())
            {
               var cliente = await this.wrapper.Clientes.Delete(int.Parse(id));
               await cliente.Trabajos
                            .AsQueryable()
                            .ForEachAsync((t => this.wrapper.Trabajos.Delete(t.ID)));

               await cliente.Telefonos
                            .AsQueryable()
                            .ForEachAsync((t => this.wrapper.Telefonos.Delete(t.ID)));

                await cliente.Trabajos
                            .AsQueryable()
                            .ForEachAsync((t => this.wrapper.Trabajos.Delete(t.ID)));
                await this.wrapper.SaveAsync();
            }
        }

        public async Task Save(Cliente cliente)
        {
            using(var tran = await this.wrapper.BeginTransaction())
            {
                await this.wrapper.Clientes.Create(cliente);
                await this.wrapper.SaveAsync();
                tran.Commit();
            }
        }

        public async Task Update(Cliente cliente)
        {
            using (var tran = await this.wrapper.BeginTransaction())
            {
                await this.wrapper.Clientes.Update(cliente);
                await this.wrapper.SaveAsync();
                tran.Commit();
            }
        }
    }
}
