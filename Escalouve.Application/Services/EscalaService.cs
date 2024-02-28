using AutoMapper;
using Escalouve.Application.Dtos;
using Escalouve.Application.Interfaces;
using Escalouve.Domain.Entities;
using Escalouve.Domain.Interfaces;

namespace Escalouve.Application.Services
{
    public class EscalaService : IEscalaService
    {
        private readonly IEscalaRepository _escalaRepository;
        private readonly IMapper _mapper;

        public EscalaService(IEscalaRepository escalaRepository, IMapper mapper)
        {
            _escalaRepository = escalaRepository;
            _mapper = mapper;
        }

        public async Task<EscalaDto> CreateAsync(EscalaDto dto)
        {
            var escala = _mapper.Map<Escala>(dto);

            escala = await _escalaRepository.CreateAsync(escala);

            return _mapper.Map<EscalaDto>(escala);
        }

        public async Task DeleteAsync(int? id)
        {
            var escala = await _escalaRepository.GetByIdAsync(id);

            await _escalaRepository.DeleteAsync(escala);
        }

        public async Task<IEnumerable<EscalaDto>> GetAllAsync()
        {
            var escalas = await _escalaRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<EscalaDto>>(escalas);
        }

        public async Task<EscalaDto?> GetByIdAsync(int? id)
        {
            var escala = await _escalaRepository.GetByIdAsync(id);

            return _mapper.Map<EscalaDto>(escala);
        }

        public async Task<EscalaDto> UpdateAsync(EscalaDto dto)
        {
            var escala = _mapper.Map<Escala>(dto);

            escala = await _escalaRepository.UpdateAsync(escala);

            return _mapper.Map<EscalaDto>(escala);
        }
    }
}
