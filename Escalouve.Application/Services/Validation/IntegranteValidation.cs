using Escalouve.Application.Dtos;
using Escalouve.Application.Services.Validation.Interfaces;
using Escalouve.Domain.Interfaces;
using Escalouve.Domain.Shared.Exceptions;

namespace Escalouve.Application.Services.Validation
{
    public class IntegranteValidation : IIntegranteValidation
    {
        private readonly IInstrumentoRepository _instrumentoRepository;

        public IntegranteValidation(IInstrumentoRepository instrumentoRepository)
        {
            _instrumentoRepository = instrumentoRepository;
        }

        public void Validar(IntegranteDto integranteDto)
        {
            ValidarInstrumentos(integranteDto);
        }

        private async void ValidarInstrumentos(IntegranteDto integranteDto)
        {
            ArgumentNullException.ThrowIfNull(integranteDto.Instrumentos);

            foreach (var instrumentoDto in integranteDto.Instrumentos)
            {
                ServiceValidationException.When(!await _instrumentoRepository.Existe(instrumentoDto.Id),
                    $"Instrumento com o Id {instrumentoDto.Id} não encontrado.");
            }
        }
    }
}
