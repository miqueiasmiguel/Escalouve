﻿using Escalouve.Domain.Entities;
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

            Assert.Equal($"Nome inválido. O nome não pode ter menos que {Constantes.TamanhoMinimo3} caracteres.", e.Message);
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

            Assert.Equal($"Nome inválido. O nome não pode ter mais que {Constantes.TamanhoMaximo100} caracteres.", e.Message);
        }

        [Fact]
        public void DeveLancarExcecaoNomeVazioAoInstanciarIntegrante()
        {
            var e = Assert.Throws<DomainExceptionValidation>(() =>
            {
                var integrante = new Integrante("");
            });

            Assert.Equal($"Nome inválido. O nome não pode ter menos que {Constantes.TamanhoMinimo3} caracteres.", e.Message);
        }
    }
}
