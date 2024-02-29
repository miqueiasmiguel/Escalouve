using AutoMapper;
using Escalouve.Application.Dtos;
using Escalouve.Domain.Entities;

namespace Escalouve.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<IntegranteDto, Integrante>()
                .ForMember(e => e.Ativo, opt => opt.MapFrom(dto => dto.Ativo ?? true));

            CreateMap<Integrante, IntegranteDto>();

            CreateMap<InstrumentoDto, Instrumento>();
            CreateMap<Instrumento, InstrumentoDto>();

            CreateMap<EscalaDto, Escala>();
            CreateMap<Escala, EscalaDto>();
        }
    }
}
