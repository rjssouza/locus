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
    public class DeletarValorHora : BaseComando<Locus.Repositorio.Entidade.ValorHora>, IDeletarValorHora
    {
        public DeletarValorHora(IConexaoFactoryExecutor conexao) : base(conexao)
        {
        }

        public override BaseDto Executar(Repositorio.Entidade.ValorHora entidade)
        {
            return this.Delete(entidade);
        }
    }
}
