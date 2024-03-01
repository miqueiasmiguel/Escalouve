using Escalouve.Domain.Entities;
using Escalouve.Domain.Shared.Exceptions;

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
            var e = Assert.Throws<DomainValidationException>(() =>
            {
                var escala = new Escala(DateTime.Today, new Dictionary<int, int>());
            });

            Assert.Equal("Campo \"Layout\" inválido. O campo \"Layout\" está vazio.", e.Message);
        }
    }
}