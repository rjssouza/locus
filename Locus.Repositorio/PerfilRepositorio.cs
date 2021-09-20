using Locus.Comando.Interface.Perfil;
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
    public class PerfilRepositorio : BaseRepositorio<Perfil>, IPerfilRepositorio
    {
        private readonly IDeletarPerfil _deletarPerfil;
        private readonly IInserirPerfil _inserirPerfil;
        private readonly IEditarPerfil _editarPerfil;

        public PerfilRepositorio(IDeletarPerfil deletarPerfil,
                                 IInserirPerfil inserirPerfil,
                                 IEditarPerfil editarPerfil,
                                 IListarTodos<Perfil> listarTodos)
            : base(listarTodos)
        {
            this._deletarPerfil = deletarPerfil;
            this._editarPerfil = editarPerfil;
            this._inserirPerfil = inserirPerfil;
        }

        public override BaseDto Editar(Perfil entidade)
        {
            return this._editarPerfil.Executar(entidade);
        }

        public override BaseDto Deletar(Perfil entidade)
        {
            return this._deletarPerfil.Executar(entidade);
        }

        public override BaseDto Inserir(Perfil entidade)
        {
            return this._inserirPerfil.Executar(entidade);
        }
    }
}
