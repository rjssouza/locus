using Locus.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Servico.Interface
{
    public interface IBaseServico
    {
        void Commit();
        void Rollback();
    }
}
