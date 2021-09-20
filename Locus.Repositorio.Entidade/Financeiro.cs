using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Repositorio.Entidade
{
    public class Financeiro : BaseEntidade
    {
        public int CodigoSessao { get; set; }
        public int CodigoEspecialidade { get; set; }
        public string Tipo { get; set; }
        public Decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public string RefCpf { get; set; }
        public string RefRG { get; set; }
        public string RefExpedido { get; set; }
        public string RefNacionalidade { get; set; }
        public string RefProfissao { get; set; }
        public string RefEstadoCivil { get; set; }
        public string Observacao { get; set; }
        public char Status { get; set; }
        public int CodigoUsuario { get; set; }
    }
}
