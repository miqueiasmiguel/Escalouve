namespace Escalouve.Domain.Entities;

public sealed class Integrante
{
    public int Id { get; set; }
    public string Nome { get; private set; }
    public List<Instrumento> Instrumentos { get; set; }

    public Integrante(string nome)
    {
        Nome = nome;
    }
}
