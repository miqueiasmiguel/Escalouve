using System.ComponentModel.DataAnnotations;

namespace Escalouve.Application.Dtos
{
    public class IntegranteDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "'Nome é obrigatório'")]
        [MinLength(3, ErrorMessage = "")]
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}
