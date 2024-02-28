using Escalouve.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

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
                .HasConversion(
                    e => JsonConvert.SerializeObject(e),
                    e => JsonConvert.DeserializeObject<Dictionary<int, int>>(e))
                .IsRequired();

            builder
                .HasMany(e => e.Escalados)
                .WithOne(e => e.Escala)
                .HasForeignKey(e => e.EscalaId);
        }
    }
}
