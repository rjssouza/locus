using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Repositorio.Entidade
{
    public class SessaoEspecialidade : BaseEntidade
    {
        public int CodigoSessao { get; set; }
        public int CodigoEspecialidade { get; set; }
        public int CodigoUsuario { get; set; }
        public int CodigoValorHora { get; set; }
    }
}
