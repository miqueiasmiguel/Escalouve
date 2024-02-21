namespace Escalouve.Domain.Entities;

public sealed class Escalado
{
    public int Id { get; private set; }
    public Integrante Integrante { get; private set; }
    public Instrumento Instrumento { get; private set; }

    public Escalado(Integrante integrante, Instrumento instrumento)
    {
        Integrante = integrante;
        Instrumento = instrumento;
    }
}
