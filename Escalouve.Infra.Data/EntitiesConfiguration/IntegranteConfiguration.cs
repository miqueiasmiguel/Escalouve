using Escalouve.Domain.Entities;
using Escalouve.Domain.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escalouve.Infra.Data.EntitiesConfiguration
{
    public class IntegranteConfiguration : IEntityTypeConfiguration<Integrante>
    {
        public void Configure(EntityTypeBuilder<Integrante> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .Property(e => e.Nome)
                .HasMaxLength(Constantes.TamanhoMaximo100)
                .IsRequired();
            builder
                .Property(e => e.Ativo)
                .IsRequired();

            builder
                .HasMany(e => e.Instrumentos)
                .WithMany(e => e.Integrantes)
                .UsingEntity<IntegranteInstrumento>();
        }
    }
}
