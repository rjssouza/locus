using Dapper;
using Locus.Comando.Interface;
using Locus.Conexao.Factory.Interface;
using Locus.Dto;
using Locus.Repositorio.Entidade;

namespace Locus.Comando
{
    public abstract class BaseComando<TEntidade> : IBaseComando<TEntidade>
        where TEntidade : BaseEntidade
    {
        protected readonly IConexaoFactoryExecutor _conexao;

        public BaseComando(IConexaoFactoryExecutor conexao)
        {
            this._conexao = conexao;
        }

        protected BaseDto Insert(TEntidade entidade)
        {
            var transaction = _conexao.ObterTransacao();
            var id = transaction.Connection.Insert<long>(entidade, transaction);
            return new BaseDto()
            {
                Codigo = id,
                Sucesso = true
            };
        }

        protected BaseDto Update(TEntidade entidade)
        {
            var transaction = _conexao.ObterTransacao();
            var resultado = transaction.Connection.Update(entidade, transaction) > 0;
            return new BaseDto()
            {
                Codigo = entidade.Codigo,
                Sucesso = resultado
            };
        }

        protected BaseDto Delete(TEntidade entidade)
        {
            var transaction = _conexao.ObterTransacao();
            var resultado = transaction.Connection.Delete<TEntidade>(entidade, transaction) > 0;
            return new BaseDto()
            {
                Codigo = entidade.Codigo,
                Sucesso = resultado
            };
        }

        public abstract BaseDto Executar(TEntidade entidade);
    }
}
