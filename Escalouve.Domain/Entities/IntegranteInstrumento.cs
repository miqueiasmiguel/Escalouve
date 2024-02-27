using Escalouve.Domain.Enums;
using Escalouve.Domain.Validation;

namespace Escalouve.Domain.Entities;

public sealed class IntegranteInstrumento
{
    public int Id { get; set; }
    public int IntegranteId { get; set; }
    public int InstrumentoId { get; set; }
    public NivelEnum Nivel { get; set; }

    public Integrante Integrante { get; set; }
    public Instrumento Instrumento { get; set; }
}