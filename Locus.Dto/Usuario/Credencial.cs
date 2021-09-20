using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Dto.Usuario
{
    public class Credencial : BaseDto
    {
        public string Username { get; set; }
        public string Senha { get; set; }
    }
}
