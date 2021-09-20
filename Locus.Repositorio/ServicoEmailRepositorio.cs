using Locus.Comando.Interface.ServicoEmail;
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
    public class ServicoEmailRepositorio : BaseRepositorio<ServicoEmail>, IServicoEmailRepositorio
    {
        private readonly IDeletarServicoEmail _deletarServicoEmail;
        private readonly IEditarServicoEmail _editarServicoEmail;
        private readonly IInserirServicoEmail _inserirServicoEmail;

        public ServicoEmailRepositorio(IDeletarServicoEmail deletarServicoEmail,
                                       IEditarServicoEmail editarServicoEmail,
                                       IInserirServicoEmail inserirServicoEmail,
                                       IListarTodos<ServicoEmail> listarTodos)
            : base(listarTodos)
        {
            this._deletarServicoEmail = deletarServicoEmail;
            this._editarServicoEmail = editarServicoEmail;
            this._inserirServicoEmail = inserirServicoEmail;
        }

        public override BaseDto Editar(ServicoEmail entidade)
        {
            return this._editarServicoEmail.Executar(entidade);
        }

        public override BaseDto Deletar(ServicoEmail entidade)
        {
            return this._deletarServicoEmail.Executar(entidade);
        }

        public override BaseDto Inserir(ServicoEmail entidade)
        {
            return this._inserirServicoEmail.Executar(entidade);
        }
    }
}
