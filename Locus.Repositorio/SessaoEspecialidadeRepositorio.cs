using Locus.Comando.Interface.SessaoEspecialidade;
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
    public class SessaoEspecialidadeRepositorio : BaseRepositorio<SessaoEspecialidade>, ISessaoEspecialidadeRepositorio
    {
        private readonly IDeletarSessaoEspecialidade _deletarSessaoEspecialidade;
        private readonly IEditarSessaoEspecialidade _editarSessaoEspecialidade;
        private readonly IInserirSessaoEspecialidade _inserirSessaoEspecialidade;

        public SessaoEspecialidadeRepositorio(IDeletarSessaoEspecialidade deletarSessaoEspecialidade,
                                              IEditarSessaoEspecialidade editarSessaoEspecialidade,
                                              IInserirSessaoEspecialidade inserirSessaoEspecialidade,
                                              IListarTodos<SessaoEspecialidade> listarTodos)
            : base(listarTodos)
        {
            this._deletarSessaoEspecialidade = deletarSessaoEspecialidade;
            this._editarSessaoEspecialidade = editarSessaoEspecialidade;
            this._inserirSessaoEspecialidade = inserirSessaoEspecialidade;
        }

        public override BaseDto Editar(SessaoEspecialidade entidade)
        {
            return this._editarSessaoEspecialidade.Executar(entidade);
        }

        public override BaseDto Deletar(SessaoEspecialidade entidade)
        {
            return this._deletarSessaoEspecialidade.Executar(entidade);
        }

        public override BaseDto Inserir(SessaoEspecialidade entidade)
        {
            return this._inserirSessaoEspecialidade.Executar(entidade);
        }
    }
}
