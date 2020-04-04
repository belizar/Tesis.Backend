using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tesis.Models.Dominio.Cliente;

namespace Tesis.Repositories.Implementation.Mappers
{
    public class TelefonosEntityMapping : IEntityTypeConfiguration<Telefono>
    {
        public void Configure(EntityTypeBuilder<Telefono> builder)
        {
            builder.ToTable("Telefonos");
            builder.MapBase();
            builder.Property(x => x.Descripcion);
            builder.HasOne(x => x.Cliente);
        }
    }
}
