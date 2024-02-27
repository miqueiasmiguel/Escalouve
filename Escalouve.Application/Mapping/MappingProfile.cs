using AutoMapper;
using Escalouve.Application.Dtos;
using Escalouve.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escalouve.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<IntegranteDto, Integrante>();
            CreateMap<Integrante, IntegranteDto>();

            CreateMap<InstrumentoDto, Instrumento>();
            CreateMap<Instrumento, InstrumentoDto>();

            CreateMap<EscalaDto, Escala>();
            CreateMap<Escala, EscalaDto>();
        }
    }
}
