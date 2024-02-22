using Escalouve.Domain.Enums;

namespace Escalouve.Domain.Entities;

public sealed class IntegranteInstrumento
{
    public int IntegranteId { get; set; }
    public int InstrumentoId { get; set; }
    public NivelEnum Nivel { get; private set; }

    public IntegranteInstrumento(NivelEnum nivel)
    {
        Nivel = nivel;
    }

    public void Update(NivelEnum nivel)
    {
        Nivel = nivel;
    }
}