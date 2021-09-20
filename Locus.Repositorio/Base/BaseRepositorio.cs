using Dapper;
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
    public abstract class BaseRepositorio<TEntidade>: IBaseRepositorio<TEntidade>
        where TEntidade : BaseEntidade
    {
        protected readonly IListarTodos<TEntidade> _listarTodos;

        public BaseRepositorio(IListarTodos<TEntidade> listarTodos)
        {
            this._listarTodos = listarTodos;
        }

        public abstract BaseDto Editar(TEntidade entidade);

        public abstract BaseDto Deletar(TEntidade entidade);

        public abstract BaseDto Inserir(TEntidade entidade);

        public virtual IEnumerable<TEntidade> ListarTodos()
        {
            return this._listarTodos.ExecutarConsulta(new BaseDto()
            {
                Sucesso = true
            });
        }
    }
}
