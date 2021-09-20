﻿using Locus.Comando.Interface.Sessao;
using Locus.Conexao.Factory.Interface;
using Locus.Dto;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Comando.Sessao
{
    public class DeletarSessao : BaseComando<Locus.Repositorio.Entidade.Sessao>, IDeletarSessao
    {
        public DeletarSessao(IConexaoFactoryExecutor conexao) : base(conexao)
        {
        }

        public override BaseDto Executar(Repositorio.Entidade.Sessao entidade)
        {
            return this.Delete(entidade);
        }
    }
}
