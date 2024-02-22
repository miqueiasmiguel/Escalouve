using Escalouve.Domain.Enums;
using Escalouve.Domain.Validation;

namespace Escalouve.Domain.Entities;

public sealed class IntegranteInstrumento
{
    public int IntegranteId { get; set; }
    public int InstrumentoId { get; set; }
    public NivelEnum Nivel { get; set; }
}