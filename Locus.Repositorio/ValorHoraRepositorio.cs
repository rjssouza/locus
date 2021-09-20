using Locus.Comando.Interface.ValorHora;
using Locus.Consulta.Interface.Compartilhado;
using Locus.Dto;
using Locus.Repositorio.Entidade;
using Locus.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Repositorio
{
    public class ValorHoraRepositorio : BaseRepositorio<ValorHora>, IValorHoraRepositorio
    {
        private readonly IDeletarValorHora _deletarValorHora;
        private readonly IEditarValorHora _editarValorHora;
        private readonly IInserirValorHora _inserirValorHora;

        public ValorHoraRepositorio(IDeletarValorHora deletarValorHora,
                                    IEditarValorHora editarValorHora,
                                    IInserirValorHora inserirValorHora,
                                    IListarTodos<ValorHora> listarTodos)
            : base(listarTodos)
        {
            this._deletarValorHora = deletarValorHora;
            this._editarValorHora = editarValorHora;
            this._inserirValorHora = inserirValorHora;
        }

        public override BaseDto Editar(ValorHora entidade)
        {
            return this._editarValorHora.Executar(entidade);
        }

        public override BaseDto Deletar(ValorHora entidade)
        {
            return this._deletarValorHora.Executar(entidade);
        }

        public override BaseDto Inserir(ValorHora entidade)
        {
            return this._inserirValorHora.Executar(entidade);
        }
    }
}
