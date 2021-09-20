using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Locus.Conexao.ServicoInterface;
using Locus.Dto;
using Locus.Dto.Usuario;
using Locus.Provider.Interface;
using Locus.Repositorio.Entidade;
using Locus.Repositorio.Interface;
using Locus.Servico.Interface;
using Locus.Servico.Regras.Usuario;

namespace Locus.Servico
{
    public class UsuarioServico : BaseServico, IUsuarioServico
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioServico(IConexaoFactory conexaoFactory, IUsuarioRepositorio usuarioRepositorio, IProvedorUsuario provedorUsuario)
            : base(conexaoFactory, provedorUsuario)
        {
            this._usuarioRepositorio = usuarioRepositorio;
        }

        public UsuarioDto ObterUsuarioLogado(Credencial credencial)
        {
            var usuarioDto = this._usuarioRepositorio.ObterUsuarioPorCredencial(credencial);
            usuarioDto.ValidarUsuario();
            return usuarioDto;
        }

        public BaseDto CadastrarUsuario(UsuarioDto usuarioDto)
        {
            var entidade = Mapper.Map<Usuario>(usuarioDto);
            return this._usuarioRepositorio.Inserir(entidade);
        }
    }
}
