using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escalouve.Application.Dtos
{
    public class EscalaDto
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public IDictionary<int, int> Layout { get; set; }
    }
}
