using Escalouve.Application.Dtos;

namespace Escalouve.Application.Interfaces
{
    public interface IIntegranteService : IService<IntegranteDto>
    {
        Task AlternarStatusAsync(int id);
    }
}
