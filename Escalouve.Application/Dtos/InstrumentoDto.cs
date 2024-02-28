using Escalouve.Domain.Shared;
using System.ComponentModel.DataAnnotations;

namespace Escalouve.Application.Dtos
{
    public class InstrumentoDto
    {
        public int Id { get; set; }

        [Required()]
        [MinLength(Constantes.TamanhoMinimo3)]
        [MaxLength(Constantes.TamanhoMaximo100)]
        public string Nome { get; set; }
    }
}
