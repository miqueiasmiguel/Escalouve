using Escalouve.Domain.Constantes;
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
        Validar(nome);

        Ativo = true;
    }

    public void AlternarStatus()
    {
        Ativo = !Ativo;
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
