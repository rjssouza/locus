using Dapper;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Locus.Repositorio.Interface.Comando
{
    public interface IRepositorioComando<TEntidade>
        where TEntidade : BaseEntidade
    {
        TEntidade ExecutarComando(string comando, DynamicParameters parameters = null);
        TEntidade ExecutarComandoTransacao(string comando, TransactionScope transactionScope, DynamicParameters parameters = null);

    }
}
