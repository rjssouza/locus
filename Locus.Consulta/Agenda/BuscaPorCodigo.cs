using Dapper;
using Locus.Conexao.Factory.Interface;
using Locus.Consulta.Interface.Agenda;
using Locus.Dto;
using Locus.Dto.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Consulta.Agenda
{
    public class BuscaPorCodigo : BaseConsulta<BaseDto, AgendaDto>, IBuscaPorCodigo
    {
        private const string BUSCA_CODIGO = @"SELECT * FROM AGENDA AGE WHERE AGE.CODIGO = @CODIGO";

        public BuscaPorCodigo(IConexaoFactoryExecutor conexao) : base(conexao)
        {
        }

        public override AgendaDto ExecutarConsulta(BaseDto entrada)
        {
            var param = new DynamicParameters();
            param.Add("CODIGO", entrada.Codigo);
            return LerUnico<AgendaDto>(BUSCA_CODIGO, param);
        }
    }
}
