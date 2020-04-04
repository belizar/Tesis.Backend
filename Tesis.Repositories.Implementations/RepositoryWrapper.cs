using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Threading.Tasks;
using Tesis.Repositories.Definition;
using Tesis.Repositories.Definition.Repositories;
using Tesis.Repositories.Implementation.Repositories;
using Tesis.Repositories.Implementations;

namespace Tesis.Repositories.Implementation
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly AlimaDataContext context;
        private ITrabajoRepository _trabajoRepository;
        private IClienteRepository _clienteRepository;
        private IEstadoDeCreditoRepository _estadoDeCreditoRepository;
        private ITelefonoRepository _telefonoRepository;
        private ITiposDeMovimientoRepository _tipoDeMovimientoRepository;
        private IMovimientosRepository _movimientoRepository;
        private ICreditoRepository _creditoRepository;
        private IParametrosRepository _parametrosRepository;
        private ICuotasRepository _cuotasRepository;

        public RepositoryWrapper(AlimaDataContext context)
        {
            this.context = context;
        }

        public ITrabajoRepository Trabajos {
            get
            {
                if (_trabajoRepository == null)
                {
                    _trabajoRepository = new TrabajoRepository(context);
                }

                return _trabajoRepository;
            }
        }

        public IClienteRepository Clientes
        {
            get
            {
                if (_clienteRepository == null)
                {
                    _clienteRepository = new ClienteRepository(context);
                }

                return _clienteRepository;
            }
        }
        public IEstadoDeCreditoRepository EstadosDeCredito
        {
            get
            {
                if (_estadoDeCreditoRepository == null)
                {
                    _estadoDeCreditoRepository = new EstadoDeCreditoRepository(context);
                }

                return _estadoDeCreditoRepository;
            }
        }
        public ITelefonoRepository Telefonos
        {
            get
            {
                if (_telefonoRepository == null)
                {
                    _telefonoRepository = new TelefonoRepository(context);
                }

                return _telefonoRepository;
            }
        }
        public ITiposDeMovimientoRepository TiposDeMovimiento
        {
            get
            {
                if (_tipoDeMovimientoRepository == null)
                {
                    _tipoDeMovimientoRepository = new TiposDeMovimientoRepository(context);
                }

                return _tipoDeMovimientoRepository;
            }
        }
        public IMovimientosRepository Movimientos
        {
            get
            {
                if (_movimientoRepository == null)
                {
                    _movimientoRepository = new MovimientoRepository(context);
                }

                return _movimientoRepository;
            }
        }

        public ICreditoRepository Creditos
        {
            get
            {
                if (_creditoRepository == null)
                {
                    _creditoRepository = new CreditoRepository(context);
                }

                return _creditoRepository;
            }
        }

        public IParametrosRepository Parametros
        {
            get
            {
                if (_parametrosRepository == null)
                {
                    _parametrosRepository = new ParametrosRepository(context);
                }

                return _parametrosRepository;
            }
        }

        public ICuotasRepository Cuotas
        {
            get
            {
                if (_cuotasRepository == null)
                {
                    _cuotasRepository = new CuotasRepository(context);
                }

                return _cuotasRepository;
            }
        }

        public async Task<IDbContextTransaction> BeginTransaction()
        {
            return await this.context.Database.BeginTransactionAsync();
        }

        public Task Commit()
        {
            throw new NotImplementedException();
        }

        public async Task SaveAsync()
        {
            await this.context.SaveChangesAsync();
        }
    }
}
