using Escalouve.Application.Interfaces;
using Escalouve.Application.Mapping;
using Escalouve.Application.Services;
using Escalouve.Domain.Interfaces;
using Escalouve.Infra.Data.Context;
using Escalouve.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Escalouve.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"), b =>
                b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddAutoMapper(typeof(MappingProfile));

            services.AddScoped<IIntegranteRepository, IntegranteRepository>();
            services.AddScoped<IInstrumentoRepository, InstrumentoRepository>();
            services.AddScoped<IEscaladoRepository, EscaladoRepository>();
            services.AddScoped<IEscalaRepository, EscalaRepository>();

            services.AddScoped<IIntegranteService, IntegranteService>();
            services.AddScoped<IInstrumentoService, InstrumentoService>();
            services.AddScoped<IEscalaService, EscalaService>();

            return services;
        }
    }
}
