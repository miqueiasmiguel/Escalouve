using Escalouve.Domain.Shared;
using System.ComponentModel.DataAnnotations;

namespace Escalouve.Application.Dtos
{
    public class IntegranteDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool? Ativo { get; set; }
        public List<InstrumentoDto>? Instrumentos { get; set; }
    }
}
