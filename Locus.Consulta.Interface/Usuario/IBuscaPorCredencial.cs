using Locus.Dto;
using Locus.Dto.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Consulta.Interface.Usuario
{
    public interface IBuscaPorCredencial : IBaseConsulta<Credencial, UsuarioDto>
    {
    }
}
