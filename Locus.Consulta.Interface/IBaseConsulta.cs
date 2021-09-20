using Locus.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Consulta.Interface
{
    public interface IBaseConsulta<TDtoEntrada, TDtoSaida>
        where TDtoEntrada : BaseDto
    {
        TDtoSaida ExecutarConsulta(TDtoEntrada entrada);
    }
}
