using Locus.Comando.Interface.Profissional;
using Locus.Conexao.Factory.Interface;
using Locus.Dto;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Comando.Profissional
{
    public class InserirProfissional : BaseComando<Locus.Repositorio.Entidade.Profissional>, IInserirProfissional
    {
        public InserirProfissional(IConexaoFactoryExecutor conexao) : base(conexao)
        {
        }

        public override BaseDto Executar(Repositorio.Entidade.Profissional entidade)
        {
            return this.Insert(entidade);
        }
    }
}
