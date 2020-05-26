using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tesis.Models.Dominio.Cliente;

namespace Tesis.Repositories.Implementation.Mappers
{
    public class TrabajosEntityMapping : IEntityTypeConfiguration<Trabajo>
    {
        public void Configure(EntityTypeBuilder<Trabajo> entity)
        {
            entity.ToTable("Trabajos");
            entity.MapBase();

            entity.Property(x => x.LugarDeTrabajo);
            entity.Property(x => x.Sueldo);
            entity.Property(x => x.Cargo);
            entity.Property(x => x.FechaDeIngreso);
            entity.Property(x => x.FechaDeEgreso);
            entity.Property(x => x.TelefonoLaboral);

            entity.OwnsOne(x => x.DomicilioLaboral, dom => {
                dom.Property(x => x.Barrio)
                      .HasColumnName("Barrio")
                      .IsRequired(false);

                dom.Property(x => x.Calle)
                      .HasColumnName("Calle")
                      .IsRequired(false);

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
