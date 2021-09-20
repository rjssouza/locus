using Locus.Dto;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Consulta.Interface.Compartilhado
{
    public interface IListarTodos<TEntidade> : IBaseConsulta<BaseDto, IEnumerable<TEntidade>>
        where TEntidade : BaseEntidade
    {                    

    }
}
