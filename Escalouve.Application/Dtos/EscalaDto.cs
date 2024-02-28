using System.ComponentModel.DataAnnotations;

namespace Escalouve.Application.Dtos
{
    public class EscalaDto
    {
        public int Id { get; set; }

        [Required()]
        public DateTime Data { get; set; }

        [Required()]
        public IDictionary<int, int> Layout { get; set; }
    }
}
