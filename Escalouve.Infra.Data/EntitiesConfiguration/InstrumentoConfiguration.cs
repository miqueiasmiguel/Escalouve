using Escalouve.Domain.Constantes;
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
    public class InstrumentoConfiguration : IEntityTypeConfiguration<Instrumento>
    {
        public void Configure(EntityTypeBuilder<Instrumento> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .Property(e => e.Nome)
                .HasMaxLength(Validacao.TamanhoMaximo100)
                .IsRequired();
        }
    }
}
