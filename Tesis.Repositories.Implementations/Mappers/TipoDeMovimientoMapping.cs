using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tesis.Models.Dominio.Movimientos;

namespace Tesis.Repositories.Implementation.Mappers
{
    public class TipoDeMovimientoMapping : IEntityTypeConfiguration<TiposDeMovimiento>
    {
        public void Configure(EntityTypeBuilder<TiposDeMovimiento> entity)
        {
            entity.ToTable("TiposDeMovimiento");
            entity.MapBase();
            entity.Property(x => x.Nombre);
            entity.HasData(Enum.GetValues(typeof(TiposDeMovimiento.EId))
                               .Cast<TiposDeMovimiento.EId>()
                               .Select(x => new TiposDeMovimiento() { ID = (int)x, Nombre = x.ToString().Spacify() }));
        }
    }
}
