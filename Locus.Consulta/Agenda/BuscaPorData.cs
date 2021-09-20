using Locus.Conexao.Factory.Interface;
using Locus.Dto.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Locus.Consulta.Interface.Agenda;

namespace Locus.Consulta.Agenda
{
    public class BuscaPorData : BaseConsulta<FiltroAgendaDataDto, IEnumerable<AgendaDto>>, IBuscaPorData
    {
        private const string BUSCA_DATA = @"SELECT * FROM AGENDA AGE WHERE @DATA BETWEEN AGE.DATAINICIO AND AGE.DATAFIM";

        public BuscaPorData(IConexaoFactoryExecutor conexao) : base(conexao)
        {
        }

        public override IEnumerable<AgendaDto> ExecutarConsulta(FiltroAgendaDataDto entrada)
        {
            var param = new DynamicParameters();
            param.Add("DATA", entrada.DataAgenda);
            return Ler<AgendaDto>(BUSCA_DATA, param);
        }
    }
}
