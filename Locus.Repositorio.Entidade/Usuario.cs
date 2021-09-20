using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Repositorio.Entidade
{
    public class Usuario : BaseEntidade
    {
        public string Cpf { get; set; }
        public string RG { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Int16 Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }
    }
}
