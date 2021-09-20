using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Dto
{
    public class UsuarioDto : BaseDto
    {
        public string Cpf { get; set; }
        public string RG { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Boolean Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }
    }
}
