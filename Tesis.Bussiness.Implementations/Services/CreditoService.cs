using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesis.Bussiness.Definition;
using Tesis.Models.Dominio.Credito;
using Tesis.Repositories.Definition;

namespace Tesis.Bussiness.Implementation.Services
{
    public class CreditoService : ICreditoService
    {
        private readonly IRepositoryWrapper wrapper;
        private readonly IMovimientosService movimientosService;

        public CreditoService(IRepositoryWrapper wrapper, IMovimientosService movimientosService)
        {
            this.wrapper = wrapper;
            this.movimientosService = movimientosService;
        }

        public async Task Save(Credito credito)
        {
            using(var transaction = await this.wrapper.BeginTransaction())
            {
                await this.wrapper.Creditos.Create(credito);
                //await this.wrapper.Cuotas.CreateMany(credito.Cuotas.ToList().Select(c => { c.Credito_ID = credito.ID; return c; }));
                await this.movimientosService.Debe(credito.MontoSolicitado, $"Crédito Otorgado Nº {credito.ID}");
                await this.movimientosService.Debe(credito.GastosAdministrativos, $"Gastos Administrativos por crédito otorgado Nº {credito.ID}");
                await this.wrapper.SaveAsync();
                transaction.Commit();
            }
        }

    }
}
