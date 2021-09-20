using Locus.Comando.Interface.PerfilUsuario;
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
    public class PerfilUsuarioRepositorio : BaseRepositorio<PerfilUsuario>, IPerfilUsuarioRepositorio
    {
        private readonly IDeletarPerfilUsuario _deletarPerfilUsuario;
        private readonly IEditarPerfilUsuario _editarPerfilUsuario;
        private readonly IInserirPerfilUsuario _inserirPerfilUsuario;

        public PerfilUsuarioRepositorio(IDeletarPerfilUsuario deletarPerfilUsuario,
                                        IEditarPerfilUsuario editarPerfilUsuario,
                                        IInserirPerfilUsuario inserirPerfilUsuario,
                                        IListarTodos<PerfilUsuario> listarTodos)
            : base(listarTodos)
        {
            this._deletarPerfilUsuario = deletarPerfilUsuario;
            this._editarPerfilUsuario = editarPerfilUsuario;
            this._inserirPerfilUsuario = inserirPerfilUsuario;
        }

        public override BaseDto Editar(PerfilUsuario entidade)
        {
            return this._editarPerfilUsuario.Executar(entidade);
        }

        public override BaseDto Deletar(PerfilUsuario entidade)
        {
            return this._deletarPerfilUsuario.Executar(entidade);
        }

        public override BaseDto Inserir(PerfilUsuario entidade)
        {
            return this._inserirPerfilUsuario.Executar(entidade);
        }
    }
}
