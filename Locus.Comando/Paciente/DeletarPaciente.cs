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
    public class DeletarPaciente : BaseComando<Locus.Repositorio.Entidade.Paciente>, IDeletarPaciente
    {
        public DeletarPaciente(IConexaoFactoryExecutor conexao) : base(conexao)
        {
        }

        public override BaseDto Executar(Repositorio.Entidade.Paciente entidade)
        {
            return this.Delete(entidade);
        }
    }
}
