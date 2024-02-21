using Escalouve.Domain.Enums;

namespace Escalouve.Domain.Entities;

public sealed class IntegranteInstrumento
{
    public int IntegranteId { get; private set; }
    public int InstrumentoId { get; private set; }
    public NivelEnum Nivel { get; private set; }
}
