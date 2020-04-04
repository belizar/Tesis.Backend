using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tesis.Models.Dominio.Credito;

namespace Tesis.Repositories.Implementation.Mappers
{
    public class ParametrosEntityMapping : IEntityTypeConfiguration<Parametros>
    {
        public void Configure(EntityTypeBuilder<Parametros> entity)
        {
            entity.MapBase();
            entity.Property(x => x.Fecha);
            entity.Property(x => x.TasaMora);
            entity.Property(x => x.TEM);
        }
    }
}
