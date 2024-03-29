﻿using Escalouve.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escalouve.Infra.Data.EntitiesConfiguration
{
    public class EscaladoConfiguration : IEntityTypeConfiguration<Escalado>
    {
        public void Configure(EntityTypeBuilder<Escalado> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .Property(e => e.IntegranteId)
                .IsRequired();
            builder
                .Property(e => e.InstrumentoId)
                .IsRequired();
            builder
                .Property(e => e.EscalaId)
                .IsRequired();
        }
    }
}
