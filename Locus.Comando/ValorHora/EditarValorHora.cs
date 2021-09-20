using Locus.Comando.Interface.ValorHora;
using Locus.Conexao.Factory.Interface;
using Locus.Dto;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Comando.ValorHora
{
    public class EditarValorHora : BaseComando<Locus.Repositorio.Entidade.ValorHora>, IEditarValorHora
    {
        public EditarValorHora(IConexaoFactoryExecutor conexao) : base(conexao)
        {
        }

        public override BaseDto Executar(Repositorio.Entidade.ValorHora entidade)
        {
            return this.Update(entidade);
        }
    }
}
