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
    public class DeletarServicoEmail : BaseComando<Locus.Repositorio.Entidade.ServicoEmail>, IDeletarServicoEmail
    {
        public DeletarServicoEmail(IConexaoFactoryExecutor conexao) : base(conexao)
        {
        }

        public override BaseDto Executar(Repositorio.Entidade.ServicoEmail entidade)
        {
            return this.Delete(entidade);
        }
    }
}
