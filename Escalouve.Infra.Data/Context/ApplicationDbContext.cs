using Escalouve.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escalouve.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Integrante> Integrantes { get; set; }
        public DbSet<Integrante> Instrumento { get; set; }
        public DbSet<Escala> Escala { get; set; }

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
