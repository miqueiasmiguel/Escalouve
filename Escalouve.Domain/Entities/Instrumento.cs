using Escalouve.Domain.Constantes;
using Escalouve.Domain.Validation;

namespace Escalouve.Domain.Entities;

public sealed class Instrumento
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public List<Integrante> Integrantes { get; set; }
    public List<IntegranteInstrumento> IntegrantesInstrumentos { get; set; }

    public Instrumento(string nome)
    {
        Validar(nome);
    }

    private void Validar(string nome)
    {
        DomainExceptionValidation.When(nome.Length > Validacao.TamanhoMaximo100,
            $"Nome inválido. O nome não pode ter mais que {Validacao.TamanhoMaximo100} caracteres.");
        DomainExceptionValidation.When(nome.Length < Validacao.TamanhoMinimo3,
            $"Nome inválido. O nome não pode ter menos que {Validacao.TamanhoMinimo3} caracteres.");

        Nome = nome;
    }
}
