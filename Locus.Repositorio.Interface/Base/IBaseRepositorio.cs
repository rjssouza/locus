using Locus.Dto;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Repositorio.Interface
{
    public interface IBaseRepositorio<TEntidade>
        where TEntidade : BaseEntidade
    {
        BaseDto Inserir(TEntidade entidade);
        BaseDto Editar(TEntidade entidade);
        BaseDto Deletar(TEntidade entidade);
        IEnumerable<TEntidade> ListarTodos();
    }
}
