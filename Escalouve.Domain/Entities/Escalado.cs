using Escalouve.Domain.Validation;

namespace Escalouve.Domain.Entities;

public sealed class Escalado
{
    public int Id { get; private set; }
    public int IntegranteId { get; private set; }
    public int InstrumentoId { get; private set; }
    public int EscalaId { get; set; }
    public Integrante Integrante { get; set; }
    public Instrumento Instrumento { get; set; }
    public Escala Escala { get; set; }
}
