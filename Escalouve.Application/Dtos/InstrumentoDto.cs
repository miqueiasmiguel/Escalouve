using Escalouve.Domain.Shared;
using System.ComponentModel.DataAnnotations;

namespace Escalouve.Application.Dtos
{
    public class InstrumentoDto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
    }
}
