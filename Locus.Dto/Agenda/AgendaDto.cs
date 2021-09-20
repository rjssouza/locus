using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Dto.Agenda
{
    public class AgendaDto : BaseDto
    {
        public int CodigoEspecialidade { get; set; }
        public int CodigoProfissional { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public char Status { get; set; }
    }
}
