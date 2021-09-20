using Locus.Comando.Interface.SessaoEspecialidade;
using Locus.Conexao.Factory.Interface;
using Locus.Dto;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Comando.SessaoEspecialidade
{
    public class EditarSessaoEspecialidade : BaseComando<Locus.Repositorio.Entidade.SessaoEspecialidade>, IEditarSessaoEspecialidade
    {
        public EditarSessaoEspecialidade(IConexaoFactoryExecutor conexao) : base(conexao)
        {
        }

        public override BaseDto Executar(Repositorio.Entidade.SessaoEspecialidade entidade)
        {
            return this.Update(entidade);
        }
    }
}
