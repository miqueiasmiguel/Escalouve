using Escalouve.Domain.Constantes;
using Escalouve.Domain.Entities;
using Escalouve.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var e = Assert.Throws<DomainExceptionValidation>(() =>
            {
                var instrumento = new Instrumento("Ab");
            });

            Assert.Equal($"Nome inválido. O nome não pode ter menos que {Validacao.TamanhoMinimo3} caracteres.", e.Message);
        }

        [Fact]
        public void DeveLancarExcecaoNomeLongoAoInstanciarInstrumento()
        {
            var e = Assert.Throws<DomainExceptionValidation>(() =>
            {
                var instrumento = new Instrumento("12345678901234567890123456789012345678901234567890" +
                                             "12345678901234567890123456789012345678901234567890" +
                                             "12345678901234567890123456789012345678901234567890" +
                                             "12345678901234567890123456789012345678901234567890" +
                                             "12345678901234567890123456789012345678901234567890" +
                                             "12345678901234567890123456789012345678901234567890");
            });

            Assert.Equal($"Nome inválido. O nome não pode ter mais que {Validacao.TamanhoMaximo100} caracteres.", e.Message);
        }

        [Fact]
        public void DeveLancarExcecaoNomeVazioAoInstanciarInstrumento()
        {
            var e = Assert.Throws<DomainExceptionValidation>(() =>
            {
                var instrumento = new Instrumento("");
            });

            Assert.Equal($"Nome inválido. O nome não pode ter menos que {Validacao.TamanhoMinimo3} caracteres.", e.Message);
        }
    }
}
