using Locus.Comando.Interface.PerfilUsuario;
using Locus.Comando.Interface.Usuario;
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
    public class InserirPerfilUsuario : BaseComando<Locus.Repositorio.Entidade.PerfilUsuario>, IInserirPerfilUsuario
    {
        public InserirPerfilUsuario(IConexaoFactoryExecutor conexao) : base(conexao)
        {
        }

        public override BaseDto Executar(Repositorio.Entidade.PerfilUsuario entidade)
        {
            return this.Insert(entidade);
        }
    }
}
