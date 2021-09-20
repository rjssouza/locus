using Locus.Conexao.Factory.Interface;
using Locus.Dto.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Locus.Repositorio.Entidade;
using Locus.Dto;
using Locus.Comando.Interface.Agenda;

namespace Locus.Comando.Agenda
{
    public class DeletarAgenda : BaseComando<Repositorio.Entidade.Agenda>, IDeletarAgenda
    {
        public DeletarAgenda(IConexaoFactoryExecutor conexao) 
            : base(conexao)
        {
        }

        public override BaseDto Executar(Repositorio.Entidade.Agenda entidade)
        {
            return this.Delete(entidade);
        }
    }
}
