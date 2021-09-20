using Locus.Comando.Interface.Sessao;
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
    public class SessaoRepositorio : BaseRepositorio<Sessao>, ISessaoRepositorio
    {
        private readonly IDeletarSessao _deletarSessao;
        private readonly IEditarSessao _editarSessao;
        private readonly IInserirSessao _inserirSessao;

        public SessaoRepositorio(IDeletarSessao deletarSessao,
                                 IEditarSessao editarSessao,
                                 IInserirSessao inserirSessao,
                                 IListarTodos<Sessao> listarTodos)
            : base(listarTodos)
        {
            this._deletarSessao = deletarSessao;
            this._editarSessao = editarSessao;
            this._inserirSessao = inserirSessao;
        }

        public override BaseDto Editar(Sessao entidade)
        {
            return this._editarSessao.Executar(entidade);
        }

        public override BaseDto Deletar(Sessao entidade)
        {
            return this._deletarSessao.Executar(entidade);
        }

        public override BaseDto Inserir(Sessao entidade)
        {
            return this._inserirSessao.Executar(entidade);
        }
    }
}
