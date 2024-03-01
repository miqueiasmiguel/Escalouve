using Escalouve.Domain.Entities;

namespace Escalouve.Domain.Interfaces;

public interface IInstrumentoRepository : IRepository<Instrumento>
{
    Task<bool> Existe(int id);
}
