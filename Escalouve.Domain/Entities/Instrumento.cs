using Escalouve.Domain.Constantes;
using Escalouve.Domain.Validation;

namespace Escalouve.Domain.Entities;

public sealed class Instrumento
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public List<Integrante> Integrantes { get; set; }

    public Instrumento(string nome)
    {
        Validar(nome);
    }

    private void Validar(string nome)
    {
        DomainExceptionValidation.When(nome.Length > Validacao.TAMANHO_MAXIMO_100,
            $"Nome inválido. O nome não pode ter mais que {Validacao.TAMANHO_MAXIMO_100} caracteres.");
        DomainExceptionValidation.When(nome.Length < Validacao.TAMANHO_MINIMO_3,
            $"Nome inválido. O nome não pode ter menos que {Validacao.TAMANHO_MINIMO_3} caracteres.");

        Nome = nome;
    }
}
