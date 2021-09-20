using Locus.Comando.Interface.Usuario;
using Locus.Consulta.Interface.Compartilhado;
using Locus.Consulta.Interface.Usuario;
using Locus.Dto;
using Locus.Dto.Usuario;
using Locus.Repositorio.Entidade;
using Locus.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Repositorio
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        private readonly IBuscaPorCredencial _buscaPorCredencial;
        private readonly IDeletarUsuario _deletarUsuario;
        private readonly IEditarUsuario _editarUsuario;
        private readonly IInserirUsuario _inserirUsuario;

        public UsuarioRepositorio(IBuscaPorCredencial buscaPorCredencial,
                                  IDeletarUsuario deletarUsuario,
                                  IEditarUsuario editarUsuario,
                                  IInserirUsuario inserirUsuario,
                                  IListarTodos<Usuario> listarTodos)
            : base(listarTodos)
        {
            this._buscaPorCredencial = buscaPorCredencial;
            this._deletarUsuario = deletarUsuario;
            this._editarUsuario = editarUsuario;
            this._inserirUsuario = inserirUsuario;
        }

        public override BaseDto Editar(Usuario entidade)
        {
            return this._editarUsuario.Executar(entidade);
        }

        public override BaseDto Deletar(Usuario entidade)
        {
            return this._deletarUsuario.Executar(entidade);
        }

        public override BaseDto Inserir(Usuario entidade)
        {
            return this._inserirUsuario.Executar(entidade);
        }

        public UsuarioDto ObterUsuarioPorCredencial(Credencial credencial)
        {
            return this._buscaPorCredencial.ExecutarConsulta(credencial);
        }
    }
}
