using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Conexao.ServicoInterface
{
    public interface IConexaoFactory : IDisposable
    {
        void AbrirTransacao();
        void Commit();
        void Rollback();
    }
}
