using Locus.Comando.Interface.Paciente;
using Locus.Conexao.Factory.Interface;
using Locus.Dto;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Comando.Paciente
{
    public class InserirPaciente : BaseComando<Locus.Repositorio.Entidade.Paciente>, IInserirPaciente
    {
        public InserirPaciente(IConexaoFactoryExecutor conexao) : base(conexao)
        {
        }

        public override BaseDto Executar(Repositorio.Entidade.Paciente entidade)
        {
            return this.Insert(entidade);
        }
    }
}
