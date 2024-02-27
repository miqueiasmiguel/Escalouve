using Escalouve.Domain.Validation;

namespace Escalouve.Domain.Entities;

public sealed class Integrante
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public bool Ativo { get; private set; }
    public ICollection<Instrumento> Instrumentos { get; set; }
    public ICollection<IntegranteInstrumento> IntegrantesInstrumentos { get; set; }

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
        DomainExceptionValidation.When(nome.Length > Constantes.TamanhoMaximo100,
            $"Nome inválido. O nome não pode ter mais que {Constantes.TamanhoMaximo100} caracteres.");
        DomainExceptionValidation.When(nome.Length < Constantes.TamanhoMinimo3,
            $"Nome inválido. O nome não pode ter menos que {Constantes.TamanhoMinimo3} caracteres.");

        Nome = nome;
    }
}
