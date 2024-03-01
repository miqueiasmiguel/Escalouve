using Escalouve.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Escalouve.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Integrante> Integrantes { get; set; }
        public DbSet<Instrumento> Instrumentos { get; set; }
        public DbSet<IntegranteInstrumento> IntegrantesInstrumentos { get; set; }
        public DbSet<Escala> Escalas { get; set; }
        public DbSet<Escalado> Escalados { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
