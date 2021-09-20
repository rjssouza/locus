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
    public class InserirUsuario : BaseComando<Locus.Repositorio.Entidade.Usuario>, IInserirUsuario
    {
        public InserirUsuario(IConexaoFactoryExecutor conexao) : base(conexao)
        {
        }

        public override BaseDto Executar(Repositorio.Entidade.Usuario entidade)
        {
            return this.Insert(entidade);
        }
    }
}
