using Escalouve.Domain.Entities;
using Escalouve.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Assert.Equal("Nome inválido. O nome não pode ter menos que 3 caracteres.", e.Message);
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

            Assert.Equal("Nome inválido. O nome não pode ter mais que 250 caracteres.", e.Message);
        }

        [Fact]
        public void DeveLancarExcecaoNomeVazioAoInstanciarIntegrante()
        {
            var e = Assert.Throws<DomainExceptionValidation>(() =>
            {
                var integrante = new Integrante("");
            });

            Assert.Equal("Nome inválido. O nome não pode ter menos que 3 caracteres.", e.Message);
        }
    }
}
