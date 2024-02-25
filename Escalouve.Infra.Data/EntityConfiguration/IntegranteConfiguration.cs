using Escalouve.Domain.Constantes;
using Escalouve.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escalouve.Infra.Data.EntityConfiguration
{
    public class IntegranteConfiguration : IEntityTypeConfiguration<Integrante>
    {
        public void Configure(EntityTypeBuilder<Integrante> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .Property(e => e.Nome)
                .HasMaxLength(Validacao.TAMANHO_MAXIMO_100)
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
