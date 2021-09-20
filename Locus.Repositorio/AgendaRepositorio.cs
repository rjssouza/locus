using Locus.Comando.Interface.Agenda;
using Locus.Consulta.Interface.Agenda;
using Locus.Consulta.Interface.Compartilhado;
using Locus.Dto;
using Locus.Dto.Agenda;
using Locus.Repositorio.Entidade;
using Locus.Repositorio.Interface;
using System.Collections.Generic;

namespace Locus.Repositorio
{
    public class AgendaRepositorio : BaseRepositorio<Agenda>, IAgendaRepositorio
    {
        private readonly IBuscaPorData _buscaPorData;
        private readonly IBuscaPorCodigo _buscaPorCodigo;
        private readonly IInserirAgenda _inserirAgenda;
        private readonly IEditarAgenda _editarAgenda;
        private readonly IDeletarAgenda _deletarAgenda;

        public AgendaRepositorio(IBuscaPorData buscaPorData,
                                 IBuscaPorCodigo buscaPorCodigo,
                                 IInserirAgenda inserirAgenda,
                                 IEditarAgenda editarAgenda,
                                 IDeletarAgenda deletarAgenda,
                                 IListarTodos<Agenda> listarTodos)
            : base(listarTodos)
        {
            this._buscaPorCodigo = buscaPorCodigo;
            this._inserirAgenda = inserirAgenda;
            this._editarAgenda = editarAgenda;
            this._deletarAgenda = deletarAgenda;
            this._buscaPorData = buscaPorData;
        }

        public IEnumerable<AgendaDto> BuscarPorData(FiltroAgendaDataDto filtroAgendaDataDto)
        {
            return this._buscaPorData.ExecutarConsulta(filtroAgendaDataDto);
        }

        public AgendaDto BuscarAgendaPorCodigo(BaseDto baseDto)
        {
            return this._buscaPorCodigo.ExecutarConsulta(baseDto);
        }

        public override BaseDto Editar(Agenda entidade)
        {
            return this._editarAgenda.Executar(entidade);
        }

        public override BaseDto Deletar(Agenda entidade)
        {
            return this._deletarAgenda.Executar(entidade);
        }

        public override BaseDto Inserir(Agenda entidade)
        {
            return this._inserirAgenda.Executar(entidade);
        }
    }
}



