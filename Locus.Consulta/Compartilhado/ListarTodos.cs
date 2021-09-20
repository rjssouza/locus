using Locus.Conexao.Factory.Interface;
using Locus.Consulta.Interface.Compartilhado;
using Locus.Dto;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Consulta.Compartilhado
{
    public class ListarTodos<TEntidade> : BaseConsulta<BaseDto, IEnumerable<TEntidade>>, IListarTodos<TEntidade>
        where TEntidade : BaseEntidade
    {
        public ListarTodos(IConexaoFactoryExecutor conexao) : base(conexao)
        {
        }

        public override IEnumerable<TEntidade> ExecutarConsulta(BaseDto entrada)
        {
            return this.LerTodos<TEntidade>();
        }
    }
}
