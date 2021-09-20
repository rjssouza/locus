using Dapper;
using Locus.Conexao.Factory.Interface;
using Locus.Consulta.Interface;
using Locus.Dto;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Consulta
{
    public abstract class BaseConsulta<TDtoEntrada, TDtoSaida> : IBaseConsulta<TDtoEntrada, TDtoSaida>
        where TDtoEntrada : BaseDto
    {
        protected readonly IConexaoFactoryExecutor _conexao;

        public BaseConsulta(IConexaoFactoryExecutor conexao)
        {
            this._conexao = conexao;
        }

        public abstract TDtoSaida ExecutarConsulta(TDtoEntrada entrada);

        protected IEnumerable<T> LerTodos<T>()
        {
            return this._conexao.ObterConexao().GetList<T>();
        }

        protected IEnumerable<T> Ler<T>(string sql, object param = null)
        {
            return this._conexao.ObterConexao().Query<T>(sql, param, this._conexao.ObterTransacao());
        }

        protected T LerUnico<T>(string sql, object param = null)
        {
            return this._conexao.ObterConexao().QueryFirst<T>(sql, param, this._conexao.ObterTransacao());
        }
    }
}
