using Escalouve.Domain.Entities;
using Escalouve.Domain.Shared;
using Escalouve.Domain.Validation;

namespace Escalouve.Domain.Testes
{
    public class IntegranteTeste
    {
        [Fact]
        public void DeveInstanciarObjetoIntegrante()
        {
            var integrante = new Integrante("Integrante Teste");
        }

        [Fact]
        public void DeveLancarExcecaoNomeCurtoAoInstanciarIntegrante()
        {
            var e = Assert.Throws<DomainExceptionValidation>(() =>
            {
                var integrante = new Integrante("Ab");
            });

            Assert.Equal($"Campo \"Nome\" inválido. O campo \"Nome\" não pode conter menos de {Constantes.TamanhoMinimo3} caracteres.", e.Message);
        }

        [Fact]
        public void DeveLancarExcecaoNomeLongoAoInstanciarIntegrante()
        {
            var e = Assert.Throws<DomainExceptionValidation>(() =>
            {
                var integrante = new Integrante("12345678901234567890123456789012345678901234567890" +
                                                "12345678901234567890123456789012345678901234567890" +
                                                "12345678901234567890123456789012345678901234567890" +
                                                "12345678901234567890123456789012345678901234567890" +
                                                "12345678901234567890123456789012345678901234567890" +
                                                "12345678901234567890123456789012345678901234567890");
            });

            Assert.Equal($"Campo \"Nome\" inválido. O campo \"Nome\" não pode conter mais de {Constantes.TamanhoMaximo100} caracteres.", e.Message);
        }

        [Fact]
        public void DeveLancarExcecaoNomeVazioAoInstanciarIntegrante()
        {
            var e = Assert.Throws<DomainExceptionValidation>(() =>
            {
                var integrante = new Integrante("");
            });

            Assert.Equal($"Campo \"Nome\" inválido. O campo \"Nome\" não pode conter menos de {Constantes.TamanhoMinimo3} caracteres.", e.Message);
        }
    }
}
