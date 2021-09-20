using System;
using Locus.Servico.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Locus.Testes.Repositorio
{
    [TestClass]
    public class AgendaTest : BaseTestes
    {
        private IAgendaServico Servico
        {
            get
            {
                return _container.Resolve<IAgendaServico>();
            }
        }

        [TestMethod]
        public void TesteInsercaoAgenda()
        {
            var retorno = Servico.InserirAgenda(new Dto.Agenda.AgendaDto()
            {
                CodigoEspecialidade = 1,
                CodigoProfissional = 1,
                DataFim = DateTime.Now,
                DataInicio = DateTime.Now,
                Status = 'S'
            });

            Assert.IsTrue(TesteBuscaAgendaCodigo(retorno.Codigo));
        }

        private bool TesteBuscaAgendaCodigo(long codigo)
        {
            var resultado = Servico.BuscarAgendaPorCodigo(new Dto.BaseDto()
            {
                Codigo = codigo
            });
            return resultado != null;
        }
    }
}
