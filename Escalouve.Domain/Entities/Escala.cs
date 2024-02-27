using Escalouve.Domain.Validation;

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

    public void Update(DateTime data, IDictionary<int, int> layout)
    {
        Validar(data, layout);
    }

    private void Validar(DateTime data, IDictionary<int, int> layout)
    {
        DomainExceptionValidation.When(layout.Count < 1, "Layout Inválido. O layout está vazio.");

        Data = data;
        Layout = layout;
    }
}
