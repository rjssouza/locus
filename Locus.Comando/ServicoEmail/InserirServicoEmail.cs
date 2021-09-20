using Locus.Comando.Interface.ServicoEmail;
using Locus.Conexao.Factory.Interface;
using Locus.Dto;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Comando.ServicoEmail
{
    public class InserirServicoEmail : BaseComando<Locus.Repositorio.Entidade.ServicoEmail>, IInserirServicoEmail
    {
        public InserirServicoEmail(IConexaoFactoryExecutor conexao) : base(conexao)
        {
        }

        public override BaseDto Executar(Repositorio.Entidade.ServicoEmail entidade)
        {
            return this.Insert(entidade);
        }
    }
}
