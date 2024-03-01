using AutoMapper;
using Escalouve.Application.Dtos;
using Escalouve.Application.Interfaces;
using Escalouve.Application.Services.Validation.Interfaces;
using Escalouve.Domain.Entities;
using Escalouve.Domain.Interfaces;

namespace Escalouve.Application.Services
{
    public class IntegranteService : IIntegranteService
    {
        private readonly IIntegranteRepository _integranteRepository;
        private readonly IInstrumentoRepository _instrumentoRepository;
        private readonly IIntegranteInstrumentoRepository _integranteInstrumentoRepository;
        private readonly IIntegranteValidation _integranteValidation;
        private readonly IMapper _mapper;

        public IntegranteService(IIntegranteRepository integranteRepository, IMapper mapper, IInstrumentoRepository instrumentoRepository, IIntegranteInstrumentoRepository integranteInstrumentoRepository, IIntegranteValidation integranteValidation)
        {
            _integranteRepository = integranteRepository;
            _mapper = mapper;
            _instrumentoRepository = instrumentoRepository;
            _integranteInstrumentoRepository = integranteInstrumentoRepository;
            _integranteValidation = integranteValidation;
        }

        public async Task<IntegranteDto> CreateAsync(IntegranteDto dto)
        {
            _integranteValidation.Validar(dto);

            var integrante = _mapper.Map<Integrante>(dto);

            integrante = await _integranteRepository.CreateAsync(integrante);

            return _mapper.Map<IntegranteDto>(integrante);
        }

        public async Task DeleteAsync(int? id)
        {
            var integrante = await _integranteRepository.GetByIdAsync(id);

            await _integranteRepository.DeleteAsync(integrante);
        }

        public async Task<IEnumerable<IntegranteDto>> GetAllAsync()
        {
            var integrantes = await _integranteRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<IntegranteDto>>(integrantes);
        }

        public async Task<IntegranteDto?> GetByIdAsync(int? id)
        {
            var integrante = await _integranteRepository.GetByIdAsync(id);

            return _mapper.Map<IntegranteDto>(integrante);
        }

        public async Task<IntegranteDto> UpdateAsync(IntegranteDto dto)
        {
            var integrante = _mapper.Map<Integrante>(dto);

            integrante = await _integranteRepository.UpdateAsync(integrante);

            return _mapper.Map<IntegranteDto>(integrante);
        }

        public async Task AlternarStatusAsync(int id)
        {
            var integrante = await _integranteRepository.GetByIdAsync(id);

            integrante.AlternarStatus();

            await _integranteRepository.UpdateAsync(integrante);
        }
    }
}
