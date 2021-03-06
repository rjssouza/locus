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
    public class DeletarSessaoEspecialidade : BaseComando<Locus.Repositorio.Entidade.SessaoEspecialidade>, IDeletarSessaoEspecialidade
    {
        public DeletarSessaoEspecialidade(IConexaoFactoryExecutor conexao) : base(conexao)
        {
        }

        public override BaseDto Executar(Repositorio.Entidade.SessaoEspecialidade entidade)
        {
            return this.Delete(entidade);
        }
    }
}
