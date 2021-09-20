using Locus.Comando.Interface.PerfilUsuario;
using Locus.Conexao.Factory.Interface;
using Locus.Dto;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Comando.PerfilUsuario
{
    public class EditarPerfilUsuario : BaseComando<Locus.Repositorio.Entidade.PerfilUsuario>, IEditarPerfilUsuario
    {
        public EditarPerfilUsuario(IConexaoFactoryExecutor conexao) : base(conexao)
        {
        }

        public override BaseDto Executar(Repositorio.Entidade.PerfilUsuario entidade)
        {
            return this.Update(entidade);
        }
    }
}
