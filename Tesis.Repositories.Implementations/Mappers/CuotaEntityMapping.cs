using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tesis.Models.Dominio.Credito;

namespace Tesis.Repositories.Implementation.Mappers
{
    public class CuotaEntityMapping : IEntityTypeConfiguration<Cuota>
    {
        public void Configure(EntityTypeBuilder<Cuota> entity)
        {
            entity.ToTable("Cuotas");
            entity.MapBase();


            entity.Property(x => x.DiasDeMora);
            entity.Property(x => x.FechaDePago);
            entity.Property(x => x.Interes).IsRequired();
            entity.Property(x => x.Numero).IsRequired();
            entity.Property(x => x.Pagada).HasDefaultValue(false);
            entity.Property(x => x.Vencimiento).IsRequired();
        }
    }
}
