using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Text;
using Tesis.Models.Dominio.Cliente;

namespace Tesis.Repositories.Implementation.Mappers
{
    public class ClienteEntityMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> entity)
        {
            entity.ToTable("Clientes");
            entity.HasKey(x => x.ID);

            entity.Property(x => x.CUIL);
            entity.Property(x => x.FechaDeNacimiento);
            entity.Property(x => x.Apellido);
            entity.Property(x => x.Nombre);
            entity.Property(x => x.Email);

            entity.HasMany(x => x.Telefonos)
                  .WithOne(x => x.Cliente)
                  .HasForeignKey(x => x.ClienteID);

            entity.HasMany(x => x.Trabajos)
                  .WithOne(x => x.Cliente)
                  .HasForeignKey(x => x.ClienteID);

            entity.OwnsOne(x => x.DomicilioPersonal, dom => {
                dom.Property(x => x.Barrio)
                      .HasColumnName("Barrio");

                dom.Property(x => x.Calle)
                      .HasColumnName("Calle");

                dom.Property(x => x.Depto)
                      .HasColumnName("Depto")
                      .IsRequired(false);

                dom.Property(x => x.Localidad)
                      .HasColumnName("Localidad");

                dom.Property(x => x.Lote)
                      .HasColumnName("Lote")
                      .IsRequired(false);

                dom.Property(x => x.Manzana)
                      .HasColumnName("Manzana")
                      .IsRequired(false);

                dom.Property(x => x.Numero)
                      .HasColumnName("Numero")
                      .IsRequired(false);

                dom.Property(x => x.Piso)
                      .HasColumnName("Piso")
                      .IsRequired(false);
            });
        }
    }
}
