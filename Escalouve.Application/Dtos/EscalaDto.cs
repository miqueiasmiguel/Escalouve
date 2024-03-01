using System.ComponentModel.DataAnnotations;

namespace Escalouve.Application.Dtos
{
    public class EscalaDto
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public IDictionary<int, int> Layout { get; set; }
    }
}
