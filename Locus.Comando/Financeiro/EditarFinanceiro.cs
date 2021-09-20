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
    public class EditarFinanceiro : BaseComando<Locus.Repositorio.Entidade.Financeiro>, IEditarFinanceiro
    {
        public EditarFinanceiro(IConexaoFactoryExecutor conexao) : base(conexao)
        {
        }

        public override BaseDto Executar(Repositorio.Entidade.Financeiro entidade)
        {
            return this.Update(entidade);
        }
    }
}
