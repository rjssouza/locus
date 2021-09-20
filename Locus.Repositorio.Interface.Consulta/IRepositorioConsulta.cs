using Dapper;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Repositorio.Interface.Consulta
{
    public interface IRepositorioConsulta<TEntidade>
        where TEntidade : BaseEntidade
    {
        TEntidade LerUnico(string query, DynamicParameters parameters = null);
        IEnumerable<TEntidade> Ler(string query, DynamicParameters parameters = null);
        IEnumerable<TDto> Ler<TDto>(string query, DynamicParameters parameters = null);
        IEnumerable<TDto> LerPaginado<TDto>(string query, DynamicParameters parameters = null);
    }
}
