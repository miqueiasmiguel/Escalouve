using Escalouve.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escalouve.Infra.Data.EntitiesConfiguration
{
    public class IntegranteInstrumentoConfiguration : IEntityTypeConfiguration<IntegranteInstrumento>
    {
        public void Configure(EntityTypeBuilder<IntegranteInstrumento> builder)
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
                .Property(e => e.Nivel)
                .IsRequired();
        }
    }
}
