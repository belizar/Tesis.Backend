using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Tesis.Models.Dominio.Cliente;
using Tesis.Models.Dominio.Credito;
using Tesis.Models.Dominio.Movimientos;
using Tesis.Repositories.Definition;
using Tesis.Repositories.Implementation.Mappers;

namespace Tesis.Repositories.Implementations
{
    public class AlimaDataContext : DbContext
    {
        public AlimaDataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Trabajo> Trabajos { get; set; }
        public DbSet<Parametros> Parametros { get; set; }
        public DbSet<Movimiento> Movimientos { get; set; }
        public DbSet<TiposDeMovimiento> TiposDeMovimientos { get; set; }
        public DbSet<EstadoDeCredito> EstadosDeCredito { get; set; }
        public DbSet<Credito> Creditos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ClienteEntityMapping());
            modelBuilder.ApplyConfiguration(new CreditoEntityMapping());
            modelBuilder.ApplyConfiguration(new CuotaEntityMapping());
            modelBuilder.ApplyConfiguration(new TrabajosEntityMapping());
            modelBuilder.ApplyConfiguration(new TelefonosEntityMapping());
            modelBuilder.ApplyConfiguration(new ParametrosEntityMapping());
            modelBuilder.ApplyConfiguration(new MovimientoEntityMapping());
            modelBuilder.ApplyConfiguration(new TipoDeMovimientoMapping());
            modelBuilder.ApplyConfiguration(new EstadoDeCreditoEntityMapping());
        }
        
    }
}
