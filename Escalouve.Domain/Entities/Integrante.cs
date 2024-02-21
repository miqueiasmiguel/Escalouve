namespace Escalouve.Domain.Entities;

public class Integrante
{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public required List<Instrumento> Instrumentos { get; set; }
}
