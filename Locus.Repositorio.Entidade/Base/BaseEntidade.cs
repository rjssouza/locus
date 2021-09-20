using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Repositorio.Entidade
{
    public class BaseEntidade
    {
        [Key]
        [Column("codigo")]
        public virtual long Codigo { get; set; }
    }
}
