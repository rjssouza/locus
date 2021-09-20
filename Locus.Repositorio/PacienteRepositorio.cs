using Locus.Comando.Interface.Paciente;
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
    public class PacienteRepositorio : BaseRepositorio<Paciente>, IPacienteRepositorio
    {
        private readonly IDeletarPaciente _deletarPaciente;
        private readonly IInserirPaciente _inserirPaciente;
        private readonly IEditarPaciente _editarPaciente;

        public PacienteRepositorio(IDeletarPaciente deletarPaciente,
                                   IInserirPaciente inserirPaciente,
                                   IEditarPaciente editarPaciente,
                                   IListarTodos<Paciente> listarTodos)
            : base(listarTodos)
        {
            this._deletarPaciente = deletarPaciente;
            this._inserirPaciente = inserirPaciente;
            this._editarPaciente = editarPaciente;
        }

        public override BaseDto Editar(Paciente entidade)
        {
            return this._editarPaciente.Executar(entidade);
        }

        public override BaseDto Deletar(Paciente entidade)
        {
            return this._deletarPaciente.Executar(entidade);
        }

        public override BaseDto Inserir(Paciente entidade)
        {
            return this._inserirPaciente.Executar(entidade);
        }
    }
}
