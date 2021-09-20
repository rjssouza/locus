using Locus.Comando.Interface.Financeiro;
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
    public class FinanceiroRepositorio : BaseRepositorio<Financeiro>, IFinanceiroRepositorio
    {
        private readonly IDeletarFinanceiro _deletarFinanceiro;
        private readonly IEditarFinanceiro _editarFinanceiro;
        private readonly IInserirFinanceiro _inserirFinanceiro;

        public FinanceiroRepositorio(IDeletarFinanceiro deletarFinanceiro,
                                     IEditarFinanceiro editarFinanceiro,
                                     IInserirFinanceiro inserirFinanceiro,
                                     IListarTodos<Financeiro> listarTodos)
            : base(listarTodos)
        {
            this._deletarFinanceiro = deletarFinanceiro;
            this._editarFinanceiro = editarFinanceiro;
            this._inserirFinanceiro = inserirFinanceiro;
        }

        public override BaseDto Editar(Financeiro entidade)
        {
            return this._editarFinanceiro.Executar(entidade);
        }

        public override BaseDto Deletar(Financeiro entidade)
        {
            return this._deletarFinanceiro.Executar(entidade);
        }

        public override BaseDto Inserir(Financeiro entidade)
        {
            return this._inserirFinanceiro.Executar(entidade);
        }
    }
}
