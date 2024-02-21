using Escalouve.Domain.Enums;

namespace Escalouve.Domain.Entities;

public class IntegranteInstrumento
{
    public int IntegranteId { get; set; }
    public int InstrumentoId { get; set; }
    public NivelEnum Nivel { get; set; }
}
