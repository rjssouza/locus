using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Dto.Perfil
{
    public class PerfilUsuarioDto : BaseDto
    {
        public int CodigoUsuario { get; set; }
        public int CodigoPerfil { get; set; }
    }
}
