namespace Escalouve.Domain.Entities;

public sealed class Escala
{
    public int Id { get; private set; }
    public DateTime Data { get; private set; }
    public List<Escalado> Escalados { get; set; }
    public IDictionary<Instrumento, int> Layout { get; set; }
}
