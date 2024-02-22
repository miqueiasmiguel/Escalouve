using Escalouve.Domain.Validation;

namespace Escalouve.Domain.Entities;

public sealed class Escalado
{
    public int Id { get; private set; }
    public Integrante Integrante { get; private set; }
    public Instrumento Instrumento { get; private set; }

    public Escalado(Integrante integrante, Instrumento instrumento)
    {
        Validate(integrante, instrumento);
    }

    public void Update(Integrante integrante, Instrumento instrumento)
    {
        Validate(integrante, instrumento);
    }

    private void Validate(Integrante integrante, Instrumento instrumento)
    {
        DomainExceptionValidation.When(!integrante.Ativo, "Integrante inválido. O integrante está inativo.");

        DomainExceptionValidation.When(!integrante.Instrumentos.Any(i => i.Id == instrumento.Id), "Instrumento inválido. O instrumento não está cadastrado para o integrante.");

        Integrante = integrante;
        Instrumento = instrumento;
    }
}
