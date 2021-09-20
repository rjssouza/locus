using Locus.Comando.Interface.Especialidade;
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
    public class EspecialidadeRepositorio : BaseRepositorio<Especialidade>, IEspecialidadeRepositorio
    {
        private readonly IDeletarEspecialidade _deletarEspecialidade;
        private readonly IEditarEspecialidade _editarEspecialidade;
        private readonly IInserirEspecialidade _inserirEspecialidade;

        public EspecialidadeRepositorio(IDeletarEspecialidade deletarEspecialidade,
                                        IEditarEspecialidade editarEspecialidade,
                                        IInserirEspecialidade inserirEspecialidade,
                                        IListarTodos<Especialidade> listarTodos)
            : base(listarTodos)
        {
            this._deletarEspecialidade = deletarEspecialidade;
            this._editarEspecialidade = editarEspecialidade;
            this._inserirEspecialidade = inserirEspecialidade;
        }

        public override BaseDto Editar(Especialidade entidade)
        {
            return this._editarEspecialidade.Executar(entidade);
        }

        public override BaseDto Deletar(Especialidade entidade)
        {
            return this._deletarEspecialidade.Executar(entidade);
        }

        public override BaseDto Inserir(Especialidade entidade)
        {
            return this._inserirEspecialidade.Executar(entidade);
        }
    }
}
