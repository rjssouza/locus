using Locus.Comando.Interface.Agenda;
using Locus.Conexao.Factory.Interface;
using Locus.Dto;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Comando.Agenda
{
    public class EditarAgenda : BaseComando<Repositorio.Entidade.Agenda>, IEditarAgenda
    {
        public EditarAgenda(IConexaoFactoryExecutor conexao) : base(conexao)
        {
        }

        public override BaseDto Executar(Repositorio.Entidade.Agenda entidade)
        {
            return this.Update(entidade);
        }
    }
}
