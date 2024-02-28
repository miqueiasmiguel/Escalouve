using Escalouve.Domain;
using Escalouve.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escalouve.Infra.Data.EntitiesConfiguration
{
    public class InstrumentoConfiguration : IEntityTypeConfiguration<Instrumento>
    {
        public void Configure(EntityTypeBuilder<Instrumento> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .Property(e => e.Nome)
                .HasMaxLength(Constantes.TamanhoMaximo100)
                .IsRequired();
        }
    }
}
