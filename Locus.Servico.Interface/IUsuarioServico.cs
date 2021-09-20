using Locus.Dto;
using Locus.Dto.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Servico.Interface
{
    public interface IUsuarioServico : IBaseServico
    {
        UsuarioDto ObterUsuarioLogado(Credencial credencial);

        BaseDto CadastrarUsuario(UsuarioDto usuarioDto);
    }
}
