using Locus.Comando.Interface.Agenda;
using Locus.Conexao.Factory.Interface;
using Locus.Dto;
using Locus.Dto.Agenda;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Comando.Agenda
{
    public class InserirAgenda : BaseComando<Repositorio.Entidade.Agenda>, IInserirAgenda
    {
        public InserirAgenda(IConexaoFactoryExecutor conexao) : base(conexao)
        {
        }

        public override BaseDto Executar(Repositorio.Entidade.Agenda entidade)
        {
            return this.Insert(entidade);
        }
    }
}
