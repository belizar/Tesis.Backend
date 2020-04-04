using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tesis.Models.Dominio.Cliente;

namespace Tesis.Bussiness.Definition
{
    public interface IClienteService
    {
        Task Save(Cliente cliente);

        Task Update(Cliente cliente);

        Task Delete(string id);
    }
}
