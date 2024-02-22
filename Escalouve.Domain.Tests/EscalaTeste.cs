using Escalouve.Domain.Entities;
using Escalouve.Domain.Validation;

namespace Escalouve.Domain.Tests
{
    public class EscalaTeste
    {
        [Fact]
        public void DeveInstanciarObjetoEscala()
        {
            var layout = new Dictionary<Instrumento, int>();
            var instrumento = new Instrumento("Viol�o");

            layout.Add(instrumento, 1);

            var escala = new Escala(DateTime.Today, layout);
        }

        [Fact]
        public void DeveLancarExcecaoLayoutVazioAoInstanciarEscala()
        {
            var e = Assert.Throws<DomainExceptionValidation>(() =>
            {
                var escala = new Escala(DateTime.Today, new Dictionary<Instrumento, int>());
            });

            Assert.Equal("Layout Inv�lido. O layout est� vazio.", e.Message);
        }
    }
}