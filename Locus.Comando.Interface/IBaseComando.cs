using Locus.Dto;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Comando.Interface
{
    public interface IBaseComando<TEntidade>
        where TEntidade : BaseEntidade
    {
        BaseDto Executar(TEntidade entrada);
    }
}
