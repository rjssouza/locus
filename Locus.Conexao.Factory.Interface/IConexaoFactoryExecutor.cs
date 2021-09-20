using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Conexao.Factory.Interface
{
    public interface IConexaoFactoryExecutor : IDisposable
    {
        IDbTransaction ObterTransacao();
        IDbConnection ObterConexao();
    }
}
