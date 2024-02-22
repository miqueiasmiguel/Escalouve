using Escalouve.Domain.Validation;

namespace Escalouve.Domain.Entities;

public sealed class Instrumento
{
    public int Id { get; private set; }
    public string Nome { get; private set; }

    public Instrumento(string nome)
    {
        Validate(nome);
    }

    private void Validate(string nome)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome inválido. O nome não pode ser nulo.");
        DomainExceptionValidation.When(nome.Length > 250, "Nome inválido. O nome não pode ter mais que 250 caracteres.");
        DomainExceptionValidation.When(nome.Length < 3, "Nome inválido. O nome não pode ter menos que 3 caracteres.");

        Nome = nome;
    }
}
