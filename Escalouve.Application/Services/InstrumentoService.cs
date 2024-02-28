using AutoMapper;
using Escalouve.Application.Dtos;
using Escalouve.Application.Interfaces;
using Escalouve.Domain.Entities;
using Escalouve.Domain.Interfaces;

namespace Escalouve.Application.Services
{
    public class InstrumentoService : IInstrumentoService
    {
        private readonly IInstrumentoRepository _instrumentoRepository;
        private readonly IMapper _mapper;

        public InstrumentoService(IInstrumentoRepository instrumentoRepository, IMapper mapper)
        {
            _instrumentoRepository = instrumentoRepository;
            _mapper = mapper;
        }

        public async Task<InstrumentoDto> CreateAsync(InstrumentoDto dto)
        {
            var instrumento = _mapper.Map<Instrumento>(dto);

            instrumento = await _instrumentoRepository.CreateAsync(instrumento);

            return _mapper.Map<InstrumentoDto>(instrumento);
        }

        public async Task DeleteAsync(int? id)
        {
            var instrumento = await _instrumentoRepository.GetByIdAsync(id);

            await _instrumentoRepository.DeleteAsync(instrumento);
        }

        public async Task<IEnumerable<InstrumentoDto>> GetAllAsync()
        {
            var instrumentos = await _instrumentoRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<InstrumentoDto>>(instrumentos);
        }

        public async Task<InstrumentoDto?> GetByIdAsync(int? id)
        {
            var instrumento = await _instrumentoRepository.GetByIdAsync(id);

            return _mapper.Map<InstrumentoDto>(instrumento);
        }

        public async Task<InstrumentoDto> UpdateAsync(InstrumentoDto dto)
        {
            var instrumento = _mapper.Map<Instrumento>(dto);

            instrumento = await _instrumentoRepository.UpdateAsync(instrumento);

            return _mapper.Map<InstrumentoDto>(instrumento);
        }
    }
}
