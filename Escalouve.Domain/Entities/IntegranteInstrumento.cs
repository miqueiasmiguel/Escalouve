using Escalouve.Domain.Enums;
using Escalouve.Domain.Shared;
using Escalouve.Domain.Shared.Exceptions;
using Mensagens = Escalouve.Domain.Shared.Mensagens;

namespace Escalouve.Domain.Entities;

public sealed class IntegranteInstrumento
{
    public int Id { get; set; }
    public int IntegranteId { get; set; }
    public int InstrumentoId { get; set; }
    public NivelEnum Nivel { get; set; }
    public Integrante Integrante { get; set; }
    public Instrumento Instrumento { get; set; }

    public IntegranteInstrumento(int integranteId, int instrumentoId, NivelEnum nivel)
    {
        Validar(integranteId, instrumentoId);

        Nivel = nivel;
    }

    private void Validar(int integranteId, int instrumentoId)
    {
        DomainValidationException.When(integranteId < Constantes.Quantidade1,
                            string.Concat(string.Format(Mensagens.Validacao.MensagemCampoInvalido, nameof(IntegranteId)),
                                          Constantes.EspacoEmBranco,
                                          string.Format(Mensagens.Validacao.MensagemCampoInteiroMinimo, nameof(IntegranteId), Constantes.Quantidade1)));

        DomainValidationException.When(instrumentoId < Constantes.Quantidade1,
            string.Concat(string.Format(Mensagens.Validacao.MensagemCampoInvalido, nameof(InstrumentoId)),
                          Constantes.EspacoEmBranco,
                          string.Format(Mensagens.Validacao.MensagemCampoInteiroMinimo, nameof(InstrumentoId), Constantes.Quantidade1)));

        IntegranteId = integranteId;
        InstrumentoId = instrumentoId;
    }
}