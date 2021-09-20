using Locus.Conexao.Factory.Interface;
using Locus.Conexao.ServicoInterface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Conexao.Factory
{
    public class ConexaoFactory : IConexaoFactory, IConexaoFactoryExecutor, IDisposable
    {
        private readonly string _connString;
        private IDbConnection conexao;
        private IDbTransaction transacao;

        private IDbConnection Conexao
        {
            get
            {
                if (conexao != null)
                {
                    switch (conexao.State)
                    {
                        case ConnectionState.Broken:
                            conexao.Open();
                            return conexao;
                        case ConnectionState.Closed:
                            conexao.Open();
                            return conexao;
                        default:
                            return conexao;
                    }
                }
                conexao = new SqlConnection(_connString);
                return Conexao;
            }
        }
        internal bool ExisteTransacao
        {
            get 
            {
                return (transacao != null && transacao.Connection != null && transacao.Connection.State == ConnectionState.Open);
            }
        }

        public ConexaoFactory(string connString)
        {
            this._connString = connString;
        }

        public void AbrirTransacao()
        {
            if (!ExisteTransacao)
            {
                transacao = Conexao.BeginTransaction();
            }
        }

        public void Commit()
        {
            if (ExisteTransacao)
                transacao.Commit();
        }

        public void Rollback()
        {
            if (ExisteTransacao)
                transacao.Rollback();
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public IDbTransaction ObterTransacao()
        {
            AbrirTransacao();
            return transacao;
        }

        protected virtual void Dispose(bool dispose)
        {
            if (dispose)
            {
                Commit();
                if(this.conexao != null)
                {
                    this.conexao.Dispose();
                    this.conexao = null;
                }
            }
            GC.SuppressFinalize(this);
        }

        public IDbConnection ObterConexao()
        {
            var transaction = ObterTransacao();
            return transacao.Connection;
        }
    }
}
