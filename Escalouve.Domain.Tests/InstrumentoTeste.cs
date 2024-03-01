using Escalouve.Domain.Entities;
using Escalouve.Domain.Shared;
using Escalouve.Domain.Shared.Exceptions;

namespace Escalouve.Domain.Tests
{
    public class InstrumentoTeste
    {
        [Fact]
        public void DeveInstanciarObjetoInstrumento()
        {
            var instrumento = new Instrumento("Violão");
        }

        [Fact]
        public void DeveLancarExcecaoNomeCurtoAoInstanciarInstrumento()
        {
            var e = Assert.Throws<DomainValidationException>(() =>
            {
                var instrumento = new Instrumento("Ab");
            });

            Assert.Equal($"Campo \"Nome\" inválido. O campo \"Nome\" não pode conter menos de {Constantes.TamanhoMinimo3} caracteres.", e.Message);
        }

        [Fact]
        public void DeveLancarExcecaoNomeLongoAoInstanciarInstrumento()
        {
            var e = Assert.Throws<DomainValidationException>(() =>
            {
                var instrumento = new Instrumento("12345678901234567890123456789012345678901234567890" +
                                             "12345678901234567890123456789012345678901234567890" +
                                             "12345678901234567890123456789012345678901234567890" +
                                             "12345678901234567890123456789012345678901234567890" +
                                             "12345678901234567890123456789012345678901234567890" +
                                             "12345678901234567890123456789012345678901234567890");
            });

            Assert.Equal($"Campo \"Nome\" inválido. O campo \"Nome\" não pode conter mais de {Constantes.TamanhoMaximo100} caracteres.", e.Message);
        }

        [Fact]
        public void DeveLancarExcecaoNomeVazioAoInstanciarInstrumento()
        {
            var e = Assert.Throws<DomainValidationException>(() =>
            {
                var instrumento = new Instrumento("");
            });

            Assert.Equal($"Campo \"Nome\" inválido. O campo \"Nome\" não pode conter menos de {Constantes.TamanhoMinimo3} caracteres.", e.Message);
        }
    }
}
