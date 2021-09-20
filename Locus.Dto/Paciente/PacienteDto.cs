﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Dto.Paciente
{
    public class PacienteDto : BaseDto
    {
        public int Matricula { get; set; }
        public string Cpf { get; set; }
        public string RG { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Nome { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
