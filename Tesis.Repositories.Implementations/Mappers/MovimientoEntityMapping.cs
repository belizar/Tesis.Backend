using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tesis.Models.Dominio.Movimientos;

namespace Tesis.Repositories.Implementation.Mappers
{
    public class MovimientoEntityMapping : IEntityTypeConfiguration<Movimiento>
    {
        public void Configure(EntityTypeBuilder<Movimiento> entity)
        {
            entity.MapBase();
            entity.HasOne(x => x.Tipo);
            entity.Property(x => x.Concepto);
            entity.Property(x => x.Monto);
            entity.Property(x => x.Saldo);
        }
    }
}
