using AutoMapper;
using Escalouve.Application.Dtos;
using Escalouve.Application.Interfaces;
using Escalouve.Domain.Entities;
using Escalouve.Domain.Interfaces;

namespace Escalouve.Application.Services
{
    public class IntegranteService : IIntegranteService
    {
        private readonly IIntegranteRepository _integranteRepository;
        private readonly IMapper _mapper;

        public IntegranteService(IIntegranteRepository integranteRepository, IMapper mapper)
        {
            _integranteRepository = integranteRepository;
            _mapper = mapper;
        }

        public async Task<IntegranteDto> CreateAsync(IntegranteDto dto)
        {
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
