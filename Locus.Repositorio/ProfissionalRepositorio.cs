using Locus.Comando.Interface.Profissional;
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
    public class ProfissionalRepositorio : BaseRepositorio<Profissional>, IProfissionalRepositorio
    {
        private readonly IDeletarProfissional _deletarProfissional;
        private readonly IEditarProfissional _editarProfissional;
        private readonly IInserirProfissional _inserirProfissional;

        public ProfissionalRepositorio(IDeletarProfissional deletarProfissional,
                                       IEditarProfissional editarProfissional,
                                       IInserirProfissional inserirProfissional,
                                       IListarTodos<Profissional> listarTodos)
            : base(listarTodos)
        {
            this._deletarProfissional = deletarProfissional;
            this._editarProfissional = editarProfissional;
            this._inserirProfissional = inserirProfissional;
        }

        public override BaseDto Editar(Profissional entidade)
        {
            return this._editarProfissional.Executar(entidade);
        }

        public override BaseDto Deletar(Profissional entidade)
        {
            return this._deletarProfissional.Executar(entidade);
        }

        public override BaseDto Inserir(Profissional entidade)
        {
            return this._inserirProfissional.Executar(entidade);
        }
    }
}
