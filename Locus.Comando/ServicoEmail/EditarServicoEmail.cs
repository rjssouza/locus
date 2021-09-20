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
    public class EditarServicoEmail : BaseComando<Locus.Repositorio.Entidade.ServicoEmail>, IEditarServicoEmail
    {
        public EditarServicoEmail(IConexaoFactoryExecutor conexao) : base(conexao)
        {
        }

        public override BaseDto Executar(Repositorio.Entidade.ServicoEmail entidade)
        {
            return this.Update(entidade);
        }
    }
}
