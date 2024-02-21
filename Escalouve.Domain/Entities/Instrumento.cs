namespace Escalouve.Domain.Entities;

public sealed class Instrumento
{
    public int Id { get; private set; }
    public string Nome { get; private set; }

    public Instrumento(string nome)
    {
        Nome = nome;
    }
}
