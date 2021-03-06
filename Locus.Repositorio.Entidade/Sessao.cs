using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Repositorio.Entidade
{
    public class Sessao : BaseEntidade
    {
        public int MatriculaPaciente { get; set; }
        public DateTime DataMarcacao { get; set; }
        public DateTime DataInicioConsulta { get; set; }
        public DateTime DataFimConsulta { get; set; }
        public char Status { get; set; }
        public string Observação { get; set; }
    }
}
