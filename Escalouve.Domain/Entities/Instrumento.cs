using Escalouve.Domain.Validation;

namespace Escalouve.Domain.Entities;

public sealed class Instrumento
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public ICollection<Integrante> Integrantes { get; set; }
    public ICollection<IntegranteInstrumento> IntegrantesInstrumentos { get; set; }

    public Instrumento(string nome)
    {
        Validar(nome);
    }

    private void Validar(string nome)
    {
        DomainExceptionValidation.When(nome.Length > Constantes.TamanhoMaximo100,
            $"Nome inválido. O nome não pode ter mais que {Constantes.TamanhoMaximo100} caracteres.");
        DomainExceptionValidation.When(nome.Length < Constantes.TamanhoMinimo3,
            $"Nome inválido. O nome não pode ter menos que {Constantes.TamanhoMinimo3} caracteres.");

        Nome = nome;
    }
}
