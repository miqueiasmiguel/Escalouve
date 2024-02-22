using Escalouve.Domain.Validation;

namespace Escalouve.Domain.Entities;

public sealed class Escalado
{
    public int Id { get; private set; }
    public int IntegranteId { get; private set; }
    public int InstrumentoId { get; private set; }
    public Integrante Integrante { get; set; }
    public Instrumento Instrumento { get; set; }

    public Escalado(int integranteId, int instrumentoId)
    {
        Validate(integranteId, instrumentoId);
    }

    private void Validate(int integranteId, int instrumentoId)
    {
        DomainExceptionValidation.When(integranteId <= 0, "IntegranteId inválido. O id do integrante não pode ser menor ou igual a zero.");

        DomainExceptionValidation.When(instrumentoId <= 0, "InstrumentoId inválido. O id do instrumento não pode ser menor ou igual a zero.");

        IntegranteId = integranteId;
        InstrumentoId = instrumentoId;
    }
}
