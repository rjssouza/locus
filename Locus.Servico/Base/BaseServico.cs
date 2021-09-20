using Locus.Conexao.ServicoInterface;
using Locus.Dto;
using Locus.Provider.Interface;
using Locus.Repositorio.Entidade;
using Locus.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Servico
{
    public class BaseServico : IBaseServico
    {
        private readonly IConexaoFactory _conexaoFactory;
        protected readonly IProvedorUsuario _provedorUsuario;

        public BaseServico(IConexaoFactory conexaoFactory, IProvedorUsuario provedorUsuario)
        {
            this._conexaoFactory = conexaoFactory;
            this._provedorUsuario = provedorUsuario;
        }

        protected void AbrirTransacao()
        {
            this._conexaoFactory.AbrirTransacao();
        }

        public void Commit()
        {
            this._conexaoFactory.Commit();
        }

        public void Rollback()
        {
            this._conexaoFactory.Dispose();
        }
    }
}
