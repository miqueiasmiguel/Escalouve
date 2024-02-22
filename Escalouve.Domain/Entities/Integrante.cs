using Escalouve.Domain.Validation;

namespace Escalouve.Domain.Entities;

public sealed class Integrante
{
    public int Id { get; set; }
    public string Nome { get; private set; }
    public bool Ativo { get; private set; }
    public List<Instrumento> Instrumentos { get; set; }

    public Integrante(string nome)
    {
        Validate(nome);

        Ativo = true;
    }

    public void AlternarStatus()
    {
        Ativo = !Ativo;
    }

    private void Validate(string nome)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome inválido. O nome não pode ser nulo.");
        DomainExceptionValidation.When(nome.Length > 250, "Nome inválido. O nome não pode ter mais que 250 caracteres.");
        DomainExceptionValidation.When(nome.Length < 3, "Nome inválido. O nome não pode ter menos que 3 caracteres.");

        Nome = nome;
    }
}
