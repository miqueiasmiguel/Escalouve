using Escalouve.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escalouve.Infra.Data.EntitiesConfiguration
{
    public class EscalaConfiguration : IEntityTypeConfiguration<Escala>
    {
        public void Configure(EntityTypeBuilder<Escala> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .Property(e => e.Data)
                .IsRequired();
            builder
                .Property(e => e.Layout)
                .IsRequired();

            builder
                .HasMany(e => e.Escalados)
                .WithOne(e => e.Escala);
        }
    }
}
