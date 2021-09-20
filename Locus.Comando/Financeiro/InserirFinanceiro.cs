using Locus.Comando.Interface.Financeiro;
using Locus.Conexao.Factory.Interface;
using Locus.Dto;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Comando.Financeiro
{
    public class InserirFinanceiro : BaseComando<Locus.Repositorio.Entidade.Financeiro>, IInserirFinanceiro
    {
        public InserirFinanceiro(IConexaoFactoryExecutor conexao) : base(conexao)
        {
        }

        public override BaseDto Executar(Repositorio.Entidade.Financeiro entidade)
        {
            return this.Insert(entidade);
        }
    }
}
