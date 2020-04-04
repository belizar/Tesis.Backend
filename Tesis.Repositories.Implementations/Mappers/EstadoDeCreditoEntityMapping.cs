using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tesis.Models.Dominio.Credito;

namespace Tesis.Repositories.Implementation.Mappers
{
    public class EstadoDeCreditoEntityMapping : IEntityTypeConfiguration<EstadoDeCredito>
    {
        public void Configure(EntityTypeBuilder<EstadoDeCredito> entity)
        {
            entity.ToTable("EstadoDeCredito");
            entity.MapBase();
            entity.HasData(Enum.GetValues(typeof(EstadoDeCredito.eId))
                             .Cast<EstadoDeCredito.eId>()
                             .Select(x => new EstadoDeCredito() { ID = (int)x, Nombre = x.ToString().Spacify() }));
        }
    }
}
