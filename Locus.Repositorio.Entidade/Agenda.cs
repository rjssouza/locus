using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Repositorio.Entidade
{
    public class Agenda : BaseEntidade
    {
        public int CodigoEspecialidade { get; set; }
        public int CodigoProfissional { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public char Status { get; set; }
    }
}
