using Escalouve.Domain.Shared;
using Escalouve.Domain.Validation;
using Mensagens = Escalouve.Domain.Shared.Mensagens;

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
            string.Concat(string.Format(Mensagens.Validacao.MensagemCampoInvalido, nameof(Nome)),
                          Constantes.EspacoEmBranco,
                          string.Format(Mensagens.Validacao.MensagemCampoTamanhoMaximo, nameof(Nome), Constantes.TamanhoMaximo100)));

        DomainExceptionValidation.When(nome.Length < Constantes.TamanhoMinimo3,
            string.Concat(string.Format(Mensagens.Validacao.MensagemCampoInvalido, nameof(Nome)),
                          Constantes.EspacoEmBranco,
                          string.Format(Mensagens.Validacao.MensagemCampoTamanhoMinimo, nameof(Nome), Constantes.TamanhoMinimo3)));

        Nome = nome;
    }
}
