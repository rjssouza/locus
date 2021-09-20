using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Dto.Profissional
{
    public class ProfissionalDto : BaseDto
    {
        public int CodigoUsuario { get; set; }
        public int CodigoEspecialidade { get; set; }
        public int CodigoValorHora { get; set; }
        public bool Status { get; set; }
    }
}
