using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tesis.Models.Dominio.Credito;

namespace Tesis.Repositories.Implementation.Mappers
{
    public class CreditoEntityMapping : IEntityTypeConfiguration<Credito>
    {
        public void Configure(EntityTypeBuilder<Credito> entity)
        {
            entity.MapBase();

            entity.HasOne(x => x.Propietario);
            entity.HasOne(x => x.Garante);
            entity.HasOne(x => x.EstadoActual);
            entity.HasOne(x => x.Parametro);

            entity.Property(x => x.MontoSolicitado);
            entity.Property(x => x.SituacionCrediticia);
            entity.Property(x => x.GastosAdministrativos);
            entity.Property(x => x.FechaAlta);

            entity.HasMany(x => x.Cuotas)
                  .WithOne(x => x.Credito)
                  .HasForeignKey(x => x.Credito_ID);


        }


    }
}
