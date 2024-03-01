using Escalouve.Domain.Shared;
using Escalouve.Domain.Shared.Exceptions;
using Mensagens = Escalouve.Domain.Shared.Mensagens;

namespace Escalouve.Domain.Entities;

public sealed class Escala
{
    public int Id { get; private set; }
    public DateTime Data { get; private set; }
    public IDictionary<int, int> Layout { get; private set; }
    public ICollection<Escalado> Escalados { get; set; }

    public Escala(DateTime data, IDictionary<int, int> layout)
    {
        Validar(data, layout);
    }

    private void Validar(DateTime data, IDictionary<int, int> layout)
    {
        DomainValidationException.When(!layout.Any(),
            string.Concat(string.Format(Mensagens.Validacao.MensagemCampoInvalido, nameof(Layout)),
                          Constantes.EspacoEmBranco,
                          string.Format(Mensagens.Validacao.MensagemCampoVazio, nameof(Layout))));

        Data = data;
        Layout = layout;
    }
}
