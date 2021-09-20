using AutoMapper;
using Dapper;
using Locus.Conexao.Factory.Interface;
using Locus.Consulta.Interface.Usuario;
using Locus.Dto;
using Locus.Dto.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Consulta.Usuario
{
    public class BuscaPorCredencial : BaseConsulta<Credencial, UsuarioDto>, IBuscaPorCredencial
    {
        private const string CONSULTA_CPF = @"SELECT codigo
      ,cpf
      ,rg
      ,nome
      ,email
      ,ativo
      ,dataCadastro
      ,username
      ,senha
  FROM Usuario
  WHERE (username = @username and senha = @senha) or codigo = @codigo";

        public BuscaPorCredencial(IConexaoFactoryExecutor conexao) 
            : base(conexao)
        {
        }

        public override UsuarioDto ExecutarConsulta(Credencial entrada)
        {
            var param = new DynamicParameters();
            param.Add("username", entrada.Username);
            param.Add("senha", entrada.Senha);
            param.Add("codigo", entrada.Codigo);
            var usuario = LerUnico<Locus.Repositorio.Entidade.Usuario>(CONSULTA_CPF, param);
            return Mapper.Map<UsuarioDto>(usuario);
        }
    }
}
