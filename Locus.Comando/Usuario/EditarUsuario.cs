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
    public class EditarUsuario : BaseComando<Locus.Repositorio.Entidade.Usuario>, IEditarUsuario
    {
        public EditarUsuario(IConexaoFactoryExecutor conexao) : base(conexao)
        {
        }

        public override BaseDto Executar(Repositorio.Entidade.Usuario entidade)
        {
            return this.Update(entidade);
        }
    }
}
