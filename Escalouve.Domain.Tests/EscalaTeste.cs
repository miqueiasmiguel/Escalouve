using Escalouve.Domain.Entities;
using Escalouve.Domain.Validation;

namespace Escalouve.Domain.Tests
{
    public class EscalaTeste
    {
        [Fact]
        public void DeveInstanciarObjetoEscala()
        {
            var layout = new Dictionary<int, int>();

            layout.Add(1, 1);

            var escala = new Escala(DateTime.Today, layout);
        }

        [Fact]
        public void DeveLancarExcecaoLayoutVazioAoInstanciarEscala()
        {
            var e = Assert.Throws<DomainExceptionValidation>(() =>
            {
                var escala = new Escala(DateTime.Today, new Dictionary<int, int>());
            });

            Assert.Equal("Layout Inválido. O layout está vazio.", e.Message);
        }
    }
}