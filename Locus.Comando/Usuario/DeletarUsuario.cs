using Locus.Comando.Interface.Usuario;
using Locus.Conexao.Factory.Interface;
using Locus.Dto;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Comando.Usuario
{
    public class DeletarUsuario : BaseComando<Locus.Repositorio.Entidade.Usuario>, IDeletarUsuario
    {
        public DeletarUsuario(IConexaoFactoryExecutor conexao) : base(conexao)
        {
        }

        public override BaseDto Executar(Repositorio.Entidade.Usuario entidade)
        {
            return this.Delete(entidade);
        }
    }
}
