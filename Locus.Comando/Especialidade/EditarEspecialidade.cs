using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Locus.Comando.Interface.Especialidade;
using Locus.Conexao.Factory.Interface;
using Locus.Dto;
using Locus.Repositorio.Entidade;

namespace Locus.Comando.Especialidade
{
    public class EditarEspecialidade : BaseComando<Locus.Repositorio.Entidade.Especialidade>, IEditarEspecialidade
    {
        public EditarEspecialidade(IConexaoFactoryExecutor conexao) 
            : base(conexao)
        {
        }

        public override BaseDto Executar(Repositorio.Entidade.Especialidade entidade)
        {
            return this.Update(entidade);
        }
    }
}
