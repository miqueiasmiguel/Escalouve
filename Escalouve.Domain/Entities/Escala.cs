using Escalouve.Domain.Validation;

namespace Escalouve.Domain.Entities;

public sealed class Escala
{
    public int Id { get; private set; }
    public DateTime Data { get; private set; }
    public IDictionary<Instrumento, int> Layout { get; private set; }
    public List<Escalado> Escalados { get; set; }

    public Escala(DateTime data, IDictionary<Instrumento, int> layout)
    {
        Validar(data, layout);
    }

    public void Update(DateTime data, IDictionary<Instrumento, int> layout)
    {
        Validar(data, layout);
    }

    private void Validar(DateTime data, IDictionary<Instrumento, int> layout)
    {
        DomainExceptionValidation.When(layout.Count < 1, "Layout Inválido. O layout está vazio.");

        Data = data;
        Layout = layout;
    }
}
