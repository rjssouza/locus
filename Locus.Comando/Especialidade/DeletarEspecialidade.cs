using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Locus.Comando.Interface.Especialidade;
using Locus.Conexao.Factory.Interface;
using Locus.Dto;

namespace Locus.Comando.Especialidade
{
    public class DeletarEspecialidade : BaseComando<Locus.Repositorio.Entidade.Especialidade>, IDeletarEspecialidade
    {
        public DeletarEspecialidade(IConexaoFactoryExecutor conexao) 
            : base(conexao)
        {
        }

        public override BaseDto Executar(Repositorio.Entidade.Especialidade entidade)
        {
            return this.Delete(entidade);
        }
    }
}
