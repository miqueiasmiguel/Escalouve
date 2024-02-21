namespace Escalouve.Domain.Entities;

public class Escala
{
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public required List<Escalado> Escalados { get; set; }
    public required IDictionary<Instrumento, int> Layout { get; set; }
}
