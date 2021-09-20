using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Dto.Sessao
{
    public class SessaoEspecialidadeDto : BaseDto
    {
        public int CodigoSessao { get; set; }
        public int CodigoEspecialidade { get; set; }
        public int CodigoUsuario { get; set; }
        public int CodigoValorHora { get; set; }
    }
}
