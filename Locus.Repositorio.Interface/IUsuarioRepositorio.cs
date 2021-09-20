using Locus.Dto;
using Locus.Dto.Usuario;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Repositorio.Interface
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        UsuarioDto ObterUsuarioPorCredencial(Credencial credencial);
    }
}
