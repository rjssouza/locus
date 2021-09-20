using Locus.Dto;
using Locus.Dto.Excecao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Servico.Regras.Usuario
{
    public static class UsuarioExt
    {
        public static void ValidarUsuario(this UsuarioDto usuarioDto)
        {
            if(!usuarioDto.Ativo)
            {
                throw new ExcecaoValidacao(new KeyValuePair<string, string>("Usuario Ativo", "Usuario não esta ativo"));
            }
        }
    }
}
