﻿using Locus.Comando.Interface.Perfil;
using Locus.Conexao.Factory.Interface;
using Locus.Dto;
using Locus.Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Comando.Perfil
{
    public class InserirPerfil : BaseComando<Locus.Repositorio.Entidade.Perfil>, IInserirPerfil
    {
        public InserirPerfil(IConexaoFactoryExecutor conexao) : base(conexao)
        {
        }

        public override BaseDto Executar(Repositorio.Entidade.Perfil entidade)
        {
            return this.Insert(entidade);
        }
    }
}
