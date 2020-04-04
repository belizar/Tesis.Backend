using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tesis.Bussiness.Definition;
using Tesis.Models.Dominio.Movimientos;
using Tesis.Repositories.Definition;
using Tesis.Repositories.Definition.Repositories;
using Tesis.Repositories.Implementation.Repositories;

namespace Tesis.Bussiness.Implementation.Services
{
    public class MovimientosService : IMovimientosService
    {
        private readonly IRepositoryWrapper wrapper;

        public MovimientosService(IRepositoryWrapper wrapper)
        {
            this.wrapper = wrapper;
        }



        public async Task Debe(decimal cantidad, string description)
        {
                var lastMov = this.wrapper.Movimientos.GetLast();
                var movimiento = new Movimiento
                {
                    Concepto = description,
                    Monto = cantidad,
                    Saldo = cantidad,
                    TipoId = (int) TiposDeMovimiento.EId.Debe
                };

            movimiento.Saldo = await lastMov != null ? (await lastMov).Saldo - cantidad : cantidad * -1;

            await this.wrapper.Movimientos.Create(movimiento);
        }

        public async Task Haber(decimal cantidad, string description)
        {
                var lastMov = this.wrapper.Movimientos.GetLast();
                var movimiento = new Movimiento
                {
                    Concepto = description,
                    Monto = cantidad,
                    Saldo = cantidad,
                    TipoId = (int)TiposDeMovimiento.EId.Debe
                };

                movimiento.Saldo = await lastMov != null ? (await lastMov).Saldo + cantidad : cantidad;
                await this.wrapper.Movimientos.Create(movimiento);
        }
    }
}
