using Escalouve.Domain.Shared;
using Escalouve.Domain.Shared.Exceptions;
using Mensagens = Escalouve.Domain.Shared.Mensagens;

namespace Escalouve.Domain.Entities;

public sealed class Escalado
{
    public int Id { get; private set; }
    public int IntegranteId { get; private set; }
    public int InstrumentoId { get; private set; }
    public int EscalaId { get; private set; }
    public Integrante Integrante { get; set; }
    public Instrumento Instrumento { get; set; }
    public Escala Escala { get; set; }

    public Escalado(int integranteId, int instrumentoId, int escalaId)
    {
        Validar(integranteId, instrumentoId, escalaId);
    }

    private void Validar(int integranteId, int instrumentoId, int escalaId)
    {
        DomainValidationException.When(integranteId < Constantes.Quantidade1,
                    string.Concat(string.Format(Mensagens.Validacao.MensagemCampoInvalido, nameof(IntegranteId)),
                                  Constantes.EspacoEmBranco,
                                  string.Format(Mensagens.Validacao.MensagemCampoInteiroMinimo, nameof(IntegranteId), Constantes.Quantidade1)));

        DomainValidationException.When(instrumentoId < Constantes.Quantidade1,
            string.Concat(string.Format(Mensagens.Validacao.MensagemCampoInvalido, nameof(InstrumentoId)),
                          Constantes.EspacoEmBranco,
                          string.Format(Mensagens.Validacao.MensagemCampoInteiroMinimo, nameof(InstrumentoId), Constantes.Quantidade1)));

        DomainValidationException.When(escalaId < Constantes.Quantidade1,
            string.Concat(string.Format(Mensagens.Validacao.MensagemCampoInvalido, nameof(EscalaId)),
                          Constantes.EspacoEmBranco,
                          string.Format(Mensagens.Validacao.MensagemCampoInteiroMinimo, nameof(EscalaId), Constantes.Quantidade1)));

        IntegranteId = integranteId;
        InstrumentoId = instrumentoId;
        EscalaId = escalaId;
    }
}
